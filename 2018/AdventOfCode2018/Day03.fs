namespace AdventOfCode2018
open System.Text.RegularExpressions

module Day03 =
  type Rect = {
    id: string;
    width: int;
    height: int;
    topLeft: int * int;
    bottomRight: int * int;
  }

  let claimPattern = "#([0-9]{1,4}) @ ([0-9]+),([0-9]+): ([0-9]+)x([0-9]+)"

  let rectOfClaim claim =
    let matcher = Regex.Match(claim, claimPattern)
  
    let height = int <| matcher.Groups.Item(5).Value
    let width = int <| matcher.Groups.Item(4).Value
    let topLeft = (int <| matcher.Groups.Item(2).Value, int <| matcher.Groups.Item(3).Value)
    let bottomRight = (fst topLeft + width, snd topLeft + height)

    {
      id = matcher.Groups.Item(1).Value
      topLeft = topLeft
      bottomRight = bottomRight
      height = height
      width = width
    }

  let overlapArea rects = 
    let grid = Array2D.create 1000 1000 0
    let mutable area = 0
    let mutable noCoverage = Some(Seq.head rects)

    let applyRectToGrid rect =
      let { topLeft=topLeft; width=width; height=height } =rect
      let (x, y) = topLeft

      for i in y .. y + height - 1 do
        for j in x .. x + width - 1 do
          let value = Array2D.get grid j i
          Array2D.set grid j i (value + 1)

    let noOverlap rect =
      let { topLeft=topLeft; width=width; height=height } = rect
      let (x, y) = topLeft
      let mutable area = 0
      
      for i in y .. y + height - 1 do
        for j in x .. x + width - 1 do
          area <- area + Array2D.get grid j i
      
      area = width * height

    let computeAreaCovered cell =
      if cell > 1
      then area <- area + 1; 
  
    Seq.iter applyRectToGrid rects
    Array2D.iter computeAreaCovered grid
    
    (area, Seq.find noOverlap rects)

  let overlaps a b =
    false