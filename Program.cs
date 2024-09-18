using System;

Console.WriteLine("Press Arrow key to start the game and other key to exit the game");

int x = 0;
int y = 0;

Random random = new Random();
int foodX = random.Next(0, Console.WindowWidth -3);
int foodY = random.Next(0, Console.WindowHeight -3);

ConsoleKeyInfo keyInfo;
Console.CursorVisible = false;

do {
    Console.Clear();

    Console.SetCursorPosition(foodX, foodY);
    Console.Write("@");

    Console.SetCursorPosition(x, y);
    Console.Write("^-^");

    keyInfo = Console.ReadKey();

    if(keyInfo.Key != ConsoleKey.LeftArrow && keyInfo.Key != ConsoleKey.DownArrow && keyInfo.Key != ConsoleKey.UpArrow && keyInfo.Key != ConsoleKey.RightArrow) {
        break;
    }

    switch(keyInfo.Key) {
        case ConsoleKey.UpArrow: if (y > 0) y--;
                            break;
        case ConsoleKey.LeftArrow: if (x > 0) x--;
                            break;
        case ConsoleKey.RightArrow: if (x < Console.WindowWidth-3) x++;
                            break;
        case ConsoleKey.DownArrow: if (y < Console.WindowHeight-3) y++;
                            break;
    }
    if(foodX == x && foodY == y) {
        Console.Clear();
        Console.SetCursorPosition(x, y);
        Console.Write("X-X");
        foodX = random.Next(0, Console.WindowWidth-3);
        foodY = random.Next(0, Console.WindowHeight-3);
        Thread.Sleep(100);
    }
    Thread.Sleep(10);
} while( true );