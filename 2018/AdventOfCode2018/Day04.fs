namespace AdventOfCode2018

open System
open System.Text.RegularExpressions
open System.Globalization


module Day04 =
  type GuardAction =
    BeginShift of string
    | FallAsleep
    | WakeUp

  type GuardLog = {
    action: GuardAction
    dateTime: DateTime;
  }

  let guardLogPattern = "\[(.*)\] (.*)"

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

  let badGuardStats guardLog =
    ()