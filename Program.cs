int ModResult(int numberY, int divider){
    return numberY % divider;
}

int DivResult(int numberY, int divider){
    return numberY / divider;
}

int GetNumber(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberX = GetNumber("Please insert a 5-digit number: ");
int first = DivResult(numberX, 10000);
int second= ModResult(DivResult(numberX, 1000), 10);
int forth = DivResult(ModResult(numberX, 100), 10);
int fifth = ModResult(numberX, 10);
if (first == fifth & second == forth){
   Console.WriteLine($"{numberX} is a palindrome!");
}
else {
   Console.WriteLine($"{numberX} is not a palindrome!");
}