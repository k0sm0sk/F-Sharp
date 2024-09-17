// let rec spaces n =
//     if n <= 0 then 
//         printfn "n is now: %i" n
//         exit 0
//     else 
//         printfn "Current n: %i" n
//         "" + spaces (n-1)

// printfn "%A" (spaces 6)
    

(*
We need to "Kill" the program in order to not overload the memory 
and get a runtime error, so we make an exitcode, set to a random number.
This ensures we don't get
"n is now 0"
"n is now 0"
"n is now 0"
"n is now 0"
"n is now 0"

And in the end runtime error.


*)

let rec diamondSpaces n =
    if n <= 0 then 
        ""
    else 
        " " + diamondSpaces (n-1)

let rec stars n =
    if n <= 0 then 
        "" 
    else 
        "* " + stars (n - 1)

let rec diamondTop l n = 
    // let n = l

    if l > 0 then
        diamondTop (l - 1) n
        printfn "%s" (diamondSpaces (n - l) + stars l)
        
        
let rec diamondBottom l n = 
    // let n = l

    if l > 0 then
        diamondBottom (l - 1) n
        printfn "%s" (diamondSpaces (l) + stars (n - 1))

// Call the function
// diamondTop 5 5
// diamondBottom 5 5

let mutable testx = 10
let testy = 25
let testplus testx testy = testx + testy
testx <- 25

(*

5
4
3
2
1
    *
   * *
  * * *
 * * * *
* * * * *
 * * * *
  * * *
   * *
    *

*)




