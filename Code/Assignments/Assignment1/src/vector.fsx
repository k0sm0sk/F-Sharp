
let vectorLength (a:float, b:float) = 
    sqrt(a**2 + b**2)

printfn "The length of the given vector is (%.3f) \n" (vectorLength (1, 1))

let vectorAdd (a:float, b:float) (c:float, d:float) = 
    (a + c), (d + b)

printfn "The two vectors added results in %A" (vectorAdd (10.0, 5.0) (-2.0, 8.0))