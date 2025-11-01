using BYT3_Calculator;

var add = new Calculator(10, 20, "+");
Console.WriteLine($"The result is {add.Calculate()}");

var sub = new Calculator(100, 3434, "-");
Console.WriteLine($"The result is {sub.Calculate()}");

var mul = new Calculator(123, 123123, "*");
Console.WriteLine($"The result is {mul.Calculate()}");

var div = new Calculator(123, 32332, "/");
Console.WriteLine($"The result is {div.Calculate()}");