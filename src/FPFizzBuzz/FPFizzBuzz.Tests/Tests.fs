module Tests

open Xunit

[<Theory>]
[<InlineData("1", 1)>]
[<InlineData("2", 2)>]
let ``convert input to string`` (expected: string, input: int) =
    let result = FizzBuzz.convert input
    Assert.Equal(expected, result)
    
    
[<Theory>]
[<InlineData("Fizz", 3)>]
let ``convert input to fizz`` (expected: string, input: int) =
    let result = FizzBuzz.convert input
    Assert.Equal(expected, result)
    
    
[<Theory>]
[<InlineData("Buzz", 5)>]
let ``convert input to buzz`` (expected: string, input: int) =
    let result = FizzBuzz.convert input
    Assert.Equal(expected, result)
    
