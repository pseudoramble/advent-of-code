namespace AdventOfCode2018

module Day01 =
  let cycle (values: seq<int>) =
    Seq.initInfinite (fun _ -> values) |> Seq.concat

  let frequency (values: seq<int>) =
    Seq.sum values

  let repeat (values: seq<int>) =
    let mutable foundCycles = Set.empty
    let mutable acc = 0

    let results = 
      values 
      |> cycle
      |> Seq.skipWhile (fun value -> 
          acc <- acc + value
          match Set.contains acc foundCycles with
          | true -> false
          | false -> 
            foundCycles <- Set.add acc foundCycles;
            true;
        )

    printfn "%A" results
    acc