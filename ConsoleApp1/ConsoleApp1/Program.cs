using System.Xml;
using Base;
Game step = new Game();
step.Output();
namespace Base
{ 
    class Game { 
        public void Output() { 
for (int y = 0; y <=30; y+=10)
{
	for (int x = 0; x < 30; x++)
	{
		Console.SetCursorPosition(x, y);
		Console.Write("-");
	}
}
for (int x = 0; x <= 30; x += 10)
{
    for (int y = 0; y < 30; y++)
    {
        Console.SetCursorPosition(x, y);
        Console.Write("-");
    }
}
int num = 0;
int x0;
int y0;
int step = -1;
            for (int i = 0; i < 9; i++)
            {
                Console.SetCursorPosition(0, 31);
                num = int.Parse(Console.ReadLine());
                x0 = ((num - 1) % 3) * 10 + 1;
                y0 = ((num - 1) / 3) * 10 + 1;
                if (step == 1)
                {
                    for (int x = x0; x < x0 + 8; x++)
                    {
                        for (int y = y0; y < y0 + 8; y++)
                        {
                            if (x == x0 || x == x0 + 7 || y == y0 || y == y0 + 7)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write("^");
                            }
                        }
                    }
                }
                if (step == -1)
                {
                    for (int x = x0; x < x0 + 8; x++)
                    {
                        for (int y = y0; y < y0 + 8; y++)
                        {
                            if (x - y == x0 - y0 || x + y == y0 + x0 + 7)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write("^");
                            }
                        }
                    }
                }
                step *= -1;
            }
}
}
}