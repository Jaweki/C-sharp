//NAMED AND DEFAULT PARAMETERS
void PrintWithPrefix(string theStr, string Prefix = " "){
    Console.WriteLine($"{Prefix}{theStr}");
}

PrintWithPrefix(Prefix : "%", theStr : "Hello There");