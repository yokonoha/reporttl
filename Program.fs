[<EntryPoint>]
let main argv =
    let len=argv.[0].Length
    if argv.Length=1 then printfn "[Report text length]The length of the text is %d" len
    else printfn "Error: Please enclose your text in \"\". Or do not send multiple arguments."
    0
    //ただ単にF#に触りたかったので製作しました!(by横葉)