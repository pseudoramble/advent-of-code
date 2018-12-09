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

  let partOne = (Guard.sleepiestGuard guards, Guard.sleepiestGuard guards |> fst |> Guard.sleepiestMinute)

  partOne

// dayOne ()
// dayTwo ()
// dayThree ()
dayFour ()