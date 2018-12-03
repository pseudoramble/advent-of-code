namespace AdventOfCode2018

type LoggingBuilder(?title: string) =
  let log p = printfn "%A" p
  let actualTitle = defaultArg title "" 

  do if actualTitle <> "" then printfn "%s" actualTitle;

  member this.Bind(x, f) = 
    log x
    f x

  member this.Return(x) = 
      x