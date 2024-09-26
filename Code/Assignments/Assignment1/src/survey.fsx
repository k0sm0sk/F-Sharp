let survey = 
    [
        // 0(ID), 1, 2, 3, 4, 5
        ("UUID1", 4, 4, 3, 3, 1)
        ("UUID2", 2, 3, 1, 4, 3)
        ("UUID3", 1, 1, 2, 1, 4)
        ("UUID4", 2, 1, 4, 3, 2)
        ("UUID5", 1, 4, 3, 4, 2)
        ("UUID6", 4, 2, 2, 1, 3)
        ("UUID7", 1, 3, 2, 1, 4)
        ("UUID8", 2, 4, 3, 2, 1)
        ("UUID9", 3, 3, 1, 2, 4)
    ]



printfn "\nThe complete survey is: \n%A\n\n---------------------------" survey


let answerSorter = 
    survey 
    |> List.filter (fun (_, _, answer2, _, _, _) -> answer2 = 1)
    |> List.map (fun (uuid, _, _, _, _, _) -> uuid)


printfn "\nThe students that answered question 2 with 1 as their answer \nare: %A, which totals to: %A students\n" answerSorter answerSorter.Length


let percentageAnswers = 
    survey
    |> List.groupBy (fun (_, _, answer2, _, _, _) -> answer2)

let rec percentageSorter n =
    match n with
    | _ when n >= percentageAnswers.Length -> exit 0 // ? handles out of bounds n-value and terminates program.
    | _ when n < 0 -> percentageSorter(0) // ? ensures minimum input will be 0 (as the first index is 0)
    | _ -> 
    printfn "Percentage of students who answered %A, is %A %%" (fst percentageAnswers[n]) (float (snd percentageAnswers[n]).Length/float survey.Length*100.0) 
    percentageSorter (n+1)


printfn "%A" (percentageSorter 0)

