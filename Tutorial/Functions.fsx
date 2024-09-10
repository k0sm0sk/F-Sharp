open System
printfn ""
// let doFuncs() =
//     printfn "---------\nDo Funcs section:"
//     // let getSum (x :int, y: int) : int = x + y
    
//     // printf "5 + 7 = %i" (getSum(5,7))

//     let rec factorial x =
//         printfn "Current value of x is: %i" x
//         if x < 1 then 1
//         else x * factorial (x-1)

//     printfn "\nFactorial of 10: %i" (factorial(10))

// doFuncs()



// let calculusFunc() =
//     printfn "---------\n\nCalculus Func section\n"
//     let multiply x  = x * 2
//     let add y       = y + 5

//     let addMultiply = add >> multiply
//     let multiplyAdd = add << multiply // can also be multiply >> add

//     printfn "Number is 10, multiply is x*2, add is y+5"
//     printfn "\nMultiply: %i" (multiply 10)
//     printfn "Add: %i" (add 10)
//     printfn "Add and then multiply: %i" (addMultiply 10)
//     printfn "Multiply and then add: %i" (multiplyAdd 10)

// calculusFunc()


// let dataTypesFunc() = 
//     printfn "---------\n\nData Types Func section\n"
//     let number = 2
//     printfn "Num is: %i" (number)
//     printfn  "Type: %A" (number.GetType()) // we use %A because we "don't" know the datatype, and then use gettype to find out

//     printfn "Float version: %.2f" (float number) // %.2f = float with 2 decimals. (float number) changes the number var from int to float
//     printfn "Integar version: %i" (int 2.9) // %.2f = float with 2 decimals. (float number) changes the number var from int to float

// dataTypesFunc()


let f (x:float) (y:char):bool =
    false
printfn "%A" f



printfn ""