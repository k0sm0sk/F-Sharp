

let qplus (a,b) (c,d) =
	((a*d + b*c) , (b*d))

let minus (a,b) (c,d) = 
	((a*d - b*c) , (b*d))

let qmult (a,b) (c,d) = 
	((a*c) , (b*d))

let qdiv (a,b) (c,d) =
	((a*d) , (b*c))

let toString (a: int, b:int) = 
	string a + "/" + string b

// illustration
printfn "1/2 + 1/3 = %s" (toString (qplus (1,2) (1,3)))