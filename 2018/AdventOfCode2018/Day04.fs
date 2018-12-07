namespace AdventOfCode2018

open System
open System.Text.RegularExpressions
open System.Globalization

module Guard = 
  type GuardAction =
    BeginShift of string
    | FallAsleep
    | WakeUp

  type GuardLog = {
    action: GuardAction
    dateTime: DateTime;
  }

  type Guard = {
    id: string;
    logs: GuardLog list
  }
  
  let addAction action guard =
    {
      Guard.id=guard.id
      logs=List.rev (action :: List.rev guard.logs)
    }

  let sleepiestMinute guard =
    let timeline = Array.zeroCreate 60
    Seq.toList guard.logs
    |> List.chunkBySize 2
    |> Seq.iter (fun [a; b] ->
      let minuteRange = [a.dateTime.Minute .. b.dateTime.Minute]
      printfn "%A" minuteRange
      Seq.iter (fun minute -> 
        Array.set timeline minute ((Array.get timeline minute) + 1)
      ) minuteRange
    )
    Array.indexed timeline |> Array.maxBy snd

  let sleepiestGuard guards =
    Seq.map (fun guard ->
      let sleepyMinutes =
        Seq.toList guard.logs
        |> List.chunkBySize 2
        |> Seq.sumBy (fun [a; b] ->
          b.dateTime.Minute - a.dateTime.Minute
        )
      (guard, sleepyMinutes)
    ) guards
    |> Seq.maxBy snd
    
module Day04 =
  open Guard

  let guardLogPattern = "\[(.*)\] (.*)"
  let guardPattern = "Guard #([0-9]+)"

  let guardOfGuardLog log = 
    let matcher = Regex.Match(log, guardPattern)
    {
      id=matcher.Groups.Item(1).Value
      logs=[]
    }  

  let guardsOfGuardLogs logs =
    Seq.fold (fun (guards, currentGuard) guardLog ->
      match guardLog.action with
      | FallAsleep | WakeUp -> 
        let updatedGuard = Guard.addAction guardLog (Option.get currentGuard)
        (Map.add updatedGuard.id updatedGuard guards, Some updatedGuard)
      | BeginShift(entry) as bs -> 
        let guard = guardOfGuardLog entry
        match Map.containsKey guard.id guards with
        | true -> (guards, Some <| Map.find guard.id guards)
        | false -> (Map.add guard.id guard guards, Some guard)
    ) (Map.empty, None) logs
    |> fst
    |> Map.toSeq
    |> Seq.map snd

  let parseGuardLog log =
    let matcher = Regex.Match(log, guardLogPattern)
    let dateTime = DateTime.Parse(matcher.Groups.Item(1).Value)
    let action = 
      match (matcher.Groups.Item(2).Value) with
      "falls asleep" -> GuardAction.FallAsleep
      | "wakes up" -> GuardAction.WakeUp
      | msg -> GuardAction.BeginShift(msg)

    {
      action=action
      dateTime=dateTime;
    }