let students = 
    [ 
        ("John", 0)
        ("Alice", 2)
        ("Bob", 4)
        ("Charlie", 2)
        ("David", 1)
        ("Eve", 4)
        ("Frank", 3)
        ("George", 2)
        ("Hannah", 1)
        ("Isaac", 3)
        ("Julia", 2)
        ("Kevin", 0)
        ("Lily", 4)
        ("Michael", 2)
        ("Nina", 1)
        ("Oliver", 3)
        ("Penelope", 2)
        ("Quincy", 4)
        ("Rachel", 1)
        ("Samuel", 0)
        ("Tessa", 0)
        ("Uma", 2)
        ("Victor", 4)
        ("Wendy", 1)
        ("Xavier", 3)
        ("Yvonne", 2)
        ("Zoe", 4)
    ]
    

// let myTuple (students)
// printfn "Anden værdi er: %d" (snd myTuple)
printfn "\n\n%A\n\n" (List.length students)

// ? index = index in students list
let sortedStudents =
    students |> List.groupBy (fun n -> (snd n))
    

    // let grouped = List.groupBy (fun (a, score) -> score = 1) students
    
    // sortedStudents (index+1)


printfn"%A" (sortedStudents)



// let sorted_students =
//     students |> List.groupBy (fun n -> (snd n))

// printfn "%A" sorted_students


// printfn"%A" students[n]
// let sorted_students =
//     match (students snd)
//     | 
    

