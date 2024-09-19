let l =[0..100]

let rec binary x currentList =
    let middleIndex = List.length currentList / 2
    match x with
    | _ when x <= 0 -> 
        printfn "Stopping recursion. Final list: %A" currentList 
        exit 0 //? Return exitcode 0, when x <= 0
    | _ when x < middleIndex -> 
        let newList = List.take middleIndex currentList
        printfn "x: %d, middleIndex: %d, newList: %A" x middleIndex newList
        binary x newList
    | _ -> 
        printfn "x is either higher then %A, which is half the original list" currentList[middleIndex]
        "Empty"

printfn "Resulting list: %A" (binary 90 l)


(* 
? Assume a list is sorted. Binary search begins by comparing an element in the 
? middle of the list with the target value. If the target value matches the element, 
? its position in the list is returned. If the target value is less than the element, 
? the search continues in the lower half of the list. If the target value is greater 
? than the element, the search continues in the upper half of the list. 
? By doing this, the algorithm eliminates the half in which the target value cannot 
? lie in each iteration.

*)