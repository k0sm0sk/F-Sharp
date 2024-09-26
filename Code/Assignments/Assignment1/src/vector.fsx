
let vectorLength (a:float, b:float) = 
    sqrt(a**2 + b**2)

printfn "\nThe length of vector 1 is (%.3f) \nThe length of vector 2 is (%.3f)\n" (vectorLength (1, 1)) (vectorLength (2, 4))

let vectorAdd (a:float, b:float) (c:float, d:float) = 
    (a + c), (d + b)

printfn "Vector 1 & 2 added results in %A \nVector 3 & 4 added results in %A" (vectorAdd (10.0, 5.0) (-2.0, 8.0)) (vectorAdd(6.0, 8.0) (13.0,20.0))

let vectorScale (a: float, b:float) (scaleValue:float) =
    (a * scaleValue), (b * scaleValue)

printfn "The scale product of the two vectors given, is %A \n" (vectorScale(2.0, 3.0) (2.0))