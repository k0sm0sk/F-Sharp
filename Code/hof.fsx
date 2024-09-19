let l = [1;2;3;4]
printfn "Old List: %A \nNew List: %A" l (l |> List.map(fun n -> n+1))


let lModified = 
    l |> List.map(fun n -> n*2)

printfn "Newer list: %A" lModified


// Creating a new list by adding 1 to each element
let newList = l |> List.map (fun n -> n + 1)
printfn "New List: %A; " newList

// Print each element of the new list
printfn "Elements in the New List:"
newList |> List.iter (fun n -> printfn "%d" n)



printfn "Even numbers in original list: %A" (l |> List.filter (fun n -> (n % 2) = 0)) //=0 is even, =1 is uneven, everything else returns empty list.
printfn "Uneven numbers in original list: %A" (l |> List.filter (fun n -> (n % 2) = 1)) //=0 is even, =1 is uneven, everything else returns empty list.



printfn "%A" (l |> List.map(fun n -> float n))




let listTest = [0.0..10.0] //? List.average requires floats in list

printfn "Average of %A, is: %A" listTest (listTest |> List.average) 

//?Prints value nr. 3 in linst (0 -> 1 -> 2, which is iteration 3)
printfn "%A" listTest[2]

printfn "\n"

let l2 = [1..100]
printfn "Sperated even and uneven: %A" (l2 |> List.groupBy (fun n -> (n % 2)))
printfn "Seperated <50 & >50: %A" (l2 |> (List.groupBy (fun n -> n < 50)))


printfn "\n\nFib:\n"


let rec fib currentX lastX = //define a current x and last x so we can multiply the two
    printfn "current x is: %i" currentX
    match currentX with
    | 0 -> fib 1 0
    | _ when currentX < 1000 -> fib (currentX + lastX) currentX
    | _ -> exit 0

printfn "%A" (fib 0 0)