open System
printfn ""
let doFuncs() =

    // let getSum (x :int, y: int) : int = x + y
    
    // printf "5 + 7 = %i" (getSum(5,7))

    let rec factorial x =
        printfn "Current value of x is: %i" x
        if x < 1 then 1
        else x * factorial (x-1)

    printfn "\nFactorial of 10: %i" (factorial(10))

doFuncs()

