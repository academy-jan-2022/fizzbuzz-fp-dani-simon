module FizzBuzz

let convert input =
    match input with 
    | 15 -> "FizzBuzz"
    | 5 -> "Buzz"
    | input when input % 3 = 0 -> "Fizz"
    | _ -> $"{input}"
