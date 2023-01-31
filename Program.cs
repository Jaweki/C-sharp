string inputStr = " ";
Console.WriteLine("Do while () loop");
do{
    inputStr = Console.ReadLine();
    if (inputStr == "exit")
    {
        break;
    }
    Console.WriteLine("You entered: {0}",inputStr);
}while (inputStr != "exit");