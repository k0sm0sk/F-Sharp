open System

let hello() =
    printf "Enter your name: "

    let name = Console.ReadLine()

    printfn "Hello %s" name

    exit 0 //exit's the console (and program) and returns exit code 0. Can be any number. All that is past the hello function will not be run

hello()

// following will not be run, since exit is present in the function and terminates ongoing program in console.

printfn "test"

Console.ReadKey() |> ignore // closes console if key is pressed


//? data types in print:
// %s = runs something, in the form of a string (e.g. it can run a function, which is given in a string format)
// %i = int version
// %f = float version
// %A = uppercase version
// %O = object version
// %[number]s = adds padding, e.g. printfn "%-5s %5s" "1" "2" -> 1     2 (or something like this)
// %*s = dynamic padding, e.g. printfn "%*s" 10 "Test" -> [start of line]          test (or something like this)

// I know there is a version for tuples but don't know what it is.