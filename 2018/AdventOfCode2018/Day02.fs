namespace AdventOfCode2018

module Day02 = 
  let simpleChecksum ids =
    let findDupes currId =
      let groups = 
        Seq.groupBy id currId
        |> Seq.map (snd >> Seq.length)
        |> Seq.filter (fun len -> len > 1 && len < 4)
        |> Seq.distinct
        |> Seq.sort
      
      groups

    let countDupes (twosies, threesies) id =
      let dupes = findDupes id |> List.ofSeq
      
      match dupes with
      | [_; _] -> (twosies + 1, threesies + 1)
      | [x] when x = 3 -> (twosies, threesies + 1)
      | [x] when x = 2 -> (twosies + 1, threesies)
      | _ -> (twosies, threesies)
    
    Seq.fold countDupes (0, 0) ids
    |> fun (twosies, threesies) -> twosies * threesies

  let similar (ids: seq<string>) =
    let closeBy (a, b) =
      let results = 
        Seq.zip a b
        |> Seq.map (fun (x, y) -> int x - int y)
        |> Seq.filter (fun x -> x <> 0)

      Seq.length results = 1

    ids
    |> Seq.sort
    |> Seq.pairwise
    |> Seq.find closeBy