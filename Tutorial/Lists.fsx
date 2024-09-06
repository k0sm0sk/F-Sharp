open System
printfn ""

let doFuncs() =
    let randomList = [1;2;3]

    let randomListDouble = List.map (fun x -> x * 2) randomList

    printfn "Regular List: %A\nDoubled list: %A" randomList randomListDouble

    printfn "Length of list: %i" randomList.Length

    [1;2;3;4;5;6;7;8;9;10]
    |> List.filter (fun v -> (v % 2) = 0)
    |> List.map (fun x -> x * 2)
    |> printfn "\nModulus list doubled: %A"
doFuncs()

printfn ""