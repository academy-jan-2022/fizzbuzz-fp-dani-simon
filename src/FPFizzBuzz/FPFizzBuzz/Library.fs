module FizzBuzz

let convert number =
    if 3 = number then "Fizz" else
        if 5 = number then "Buzz"
        else $"{number}"
