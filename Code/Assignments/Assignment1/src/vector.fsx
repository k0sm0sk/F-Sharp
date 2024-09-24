
let vectorLength (a:float, b:float) = 
    sqrt(a**2 + b**2)

printfn "\nThe length of the given vector is (%.3f) \n" (vectorLength (1, 1))

let vectorAdd (a:float, b:float) (c:float, d:float) = 
    (a + c), (d + b)

printfn "The two vectors added results in %A \n" (vectorAdd (10.0, 5.0) (-2.0, 8.0))

let vectorScale (a: float, b:float) (scaleValue:float) =
    (a * scaleValue), (b * scaleValue)

printfn "The scale product of the two vectors given, is %A \n" (vectorScale(2.0, 3.0) (2.0))