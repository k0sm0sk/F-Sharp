type cm = int

// let volume (length: cm) (height: cm) (width: cm) =
//     length*height*width

// printfn "The volume is %d" (volume 10 20 15)

// type qnum = int * int

// let qplus (x: qnum) (y: qnum) =
//     let (a, b) = x
//     let (c, d) = y
//     ((a*d) + (b*c)), (b*d)


// let t = qplus (1,2) (-1,2)

// printfn "1/2 + (-1/2) = %d/%d" (fst t) (snd t)


// let qmult (x: qnum) (y: qnum) =
//     let (a,b) = x
//     let (c,d) = y
//     ((a*c) , (b*d))

// let b = qmult (4,5) (10,3)

// printfn "4/5 * 10/3 = %d/%d" (fst b) (snd b)

let interestRate (deposit: int): float = 
    if (deposit < 1) then 0
    elif (deposit < 10000) then 0.02
    elif (deposit < 50000) then 0.03
    else 0.04

let percent = (interestRate 10) * 100.0

printfn "Interest rate is: %.2f (%.2f%%)" (interestRate 10) percent


let rec compoundInterestRate (x: int) (n: int) : float =
    let interestRate = 0.2
    printfn "x: %d, n: %d" x n
    if (n <= 0) then (float x)
    else
        let lastYearDeposit = compoundInterestRate x (n-1)
        lastYearDeposit + interestRate * lastYearDeposit


printfn "%A" (compoundInterestRate 10 5)
