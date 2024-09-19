open System
printfn ""

let bindStuff() =
    let mutable test1 = 1
    printfn "test1 before: %i" test1
    test1 <- 2
    printfn "Test1 after: %i" test1

    // Different way of changing
    let test2 = ref 10
    printfn "test2 Before: %i" test2.Value
    test2.Value <- 50
    printfn "test2 After: %i" test2.Value



bindStuff()

// Console.ReadKey() |> ignore
printfn ""