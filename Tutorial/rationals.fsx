

let qplus (a,b) (c,d) = ((a*d + b*c) , (b*d))

let qplus2nd (a, b) (c, d) (e, f) = qplus (qplus (a, b) (c, d)) (e, f)

let qminus (a,b) (c,d) = ((a*d - b*c) , (b*d))

let qmult (a,b) (c,d) = ((a*c) , (b*d))

let qdiv (a,b) (c,d) = ((a*d) , (b*c))

let toString (a: int, b: int) = string a + "/" + string b

let qminus2nd (a, b) (c, d) (e, f) = qminus (a, b) (qmult (c, d) (e, f))

// illustration
printfn "1/2 + 1/3 = %s" (toString (qplus (1,2) (1,3)))
printfn "2/3 - 3/2 = %s" (toString (qminus (2,3) (3,2)))
printfn "1/4 + 3/4 + 1/2 = %s" (toString(qplus2nd (1,4) (3,4) (1,2)))
printfn "1/4 + 3/4 + 1/2 = %s" (toString(qminus2nd(3,4) (3,2) (1,2)))


