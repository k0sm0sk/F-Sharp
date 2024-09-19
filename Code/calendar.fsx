let monthInput x =
    match x with
    | 1 | 3 | 5 | 7 | 8 | 10 | 12 -> "31"
    | 4 | 6 | 9 | 11 -> "30"
    | 2 -> "28"
    | _ when x > 12 -> "Error, input is more than 12"
    | _ when x < 0 -> "Error, input is less than 0"
    | _ -> "Type error"


printfn "%i: %s" 13 (monthInput 13)


(*
The program should take input of month in an integar. 
It should then match the x value (input of month) with
different months, and return the amount of days as output.
It should also be able to catch when x is more than 12, and is less than zero, as well
as if x is not the type integar

*)