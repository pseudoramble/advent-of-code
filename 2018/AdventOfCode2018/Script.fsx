#load "Day01.fs"
#load "Day02.fs"
#load "Day03.fs"
#load "Day04.fs"
#load "Logger.fs"

open System.IO
open AdventOfCode2018
// open AdventOfCode2018.Day01
// open AdventOfCode2018.Day02
// open AdventOfCode2018.Day03
open AdventOfCode2018.Day04

let dayFour () =
  let logger = new LoggingBuilder("Day Four\n--------------")
  let inputs = 
    Seq.map parseGuardLog <| File.ReadAllLines "./2018/AdventOfCode2018/inputs/day-04"
    |> Seq.sortBy (fun log -> log.dateTime)
  let guards = guardsOfGuardLogs inputs

  let sleepiestGuard = Guard.sleepiestGuard guards
  let sleepySchedules = 
    Guard.sleepySchedules guards
    |> Seq.map (fun (id, schedule) -> (id, Seq.maxBy snd schedule))
  let maxMinuteSlept = Seq.maxBy (fun (_, minute) -> snd minute) sleepySchedules

  let partOne = (sleepiestGuard, sleepiestGuard |> fst |> Guard.sleepiestMinute)
  let partTwo = Seq.filter (fun (_, minute) -> minute = snd maxMinuteSlept) sleepySchedules

  (partOne, partTwo)

// dayOne ()
// dayTwo ()
// dayThree ()
dayFour () 