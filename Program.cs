Console.WriteLine("Hello, jesienne kasztanowce!");
bool working = true;
while (working)
{
    Console.WriteLine("0 - Start");
    Console.WriteLine("1 - Summing");
    Console.WriteLine("2 - Quit");

    if (int.TryParse(Console.ReadLine(), out int req))
    {
        switch (req)
        {
            case 0:
                Console.WriteLine("Starting...");
                break;
            case 1:
                Console.WriteLine("Special activity");
                Console.WriteLine("Write a number");
                if (int.TryParse(Console.ReadLine(), out int x))
                    Console.WriteLine($"{x} + {x} = {x + x}");
                Console.WriteLine("End of special activity");
                break;
            case 2:
                working=false;
                Console.WriteLine("Goodbye! See you soon");
                break;
        }
    }
}
return 0;
