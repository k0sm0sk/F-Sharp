let rec gcd x y =
    match y with
    | 0 -> x
    | _ -> gcd y (x % y)

printfn "%i %% %i = %i" 10 5 (gcd 10 5)