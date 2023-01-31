float milesToKm(float miles){
    float result = miles*1.6f;
    return result;
}

void PrintWithPrefix(string theStr){
    Console.WriteLine($"::>{theStr}");
}
//Console.WriteLine($"The result is {milesToKm(52.0f)}");
PrintWithPrefix("Test string");
