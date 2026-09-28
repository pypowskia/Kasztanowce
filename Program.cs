Console.WriteLine("Hello, kasztanowce!");
Console.WriteLine("0 - Start");
Console.WriteLine("1 - Special");
Console.WriteLine("2 - Quit");

if(int.TryParse(Console.ReadLine(), out int req))
{
    switch(req)
    {
        case 0: Console.WriteLine("Starting...");
            break;
        case 1: Console.WriteLine("Nothing special to do");
            break;
        case 2: return 0;
    }
}
return 0;
