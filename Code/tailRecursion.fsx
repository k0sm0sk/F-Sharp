let rec print_list (l: 'a list) : unit =
    match l with 
    | [] -> ()
    | head::tail -> printfn "Head: %A" head; print_list tail; printfn "List: %A" l 


print_list [("0");("1");("2");("3");("4")]