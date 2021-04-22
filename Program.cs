using System;

namespace PhFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Philippine Flag @ Nestor P. Gerona Jr.";
            Console.SetWindowSize(200,70);
            
            PrintFlag();
            // sun is 17 pixels
            // star is 10 pixels
        }
        static void PrintFlag()
        {
            for (int i = 0; i < 62; i++)
            {
                for (int w = 0; w < 1; w++)
                {
                    Console.WriteLine();
                }
                for (int w = 0; w < 2; w++)
                {
                    
                        Console.Write("W");
                }

                for (int w = 0; w < i*3 ; w++)
                {
                    if(i < 4)
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i == 6 || i == 7 || i == 12 || i == 13 || i == 48 || i == 49 || i == 54 || i == 55)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i == 6 || i == 7 || i == 12 || i == 13 
                        || i == 48 || i == 49 
                        || i == 54 || i == 55 
                        || i == 8 || i == 11
                        || i == 50 || i == 53)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i == 9 || i == 7 || i == 12 || i == 10
                        || i == 51 || i == 49
                        || i == 54 || i == 52
                        || i == 8 || i == 11 
                        || i == 50 || i == 53)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 4 && i < 12)
                        || (i > 46 && i < 54)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }

                for (int w = 0; w < 1; w++)
                {
                    if ((i > 3 && i < 12)
                        || (i > 45 && i < 54)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 4 && i < 12)
                        || (i > 46 && i < 54)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 6 && i < 13)
                        || (i > 48 && i < 55)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 5 && i < 9)
                        || (i > 10 && i < 14)
                        || (i > 52 && i < 56)
                        || (i > 47 && i < 51)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 5 && i < 8)
                        || (i > 11 && i < 14)
                        || (i > 53 && i < 56)
                        || (i > 47 && i < 50)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i == 29)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 21 && i < 25)
                        || (i > 27 && i < 31)
                        || (i > 33 && i < 37)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 21 && i < 26)
                        || (i > 27 && i < 31)
                        || (i > 32 && i < 37)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 4 || i > 55)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 21 && i < 27)
                        || (i > 27 && i < 31)
                        || (i > 31 && i < 37)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 5 || i > 54)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 22 && i < 36))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 5 || i > 54)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 23 && i < 35))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 5 || i > 54)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 24 && i < 34))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 6 || i > 53)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 21 && i < 37))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 6 || i > 53)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 20 && i < 38))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 6 || i > 53)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 21 && i < 37))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 7 || i > 52)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 24 && i < 34))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 7 || i > 52)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 23 && i < 35))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 7 || i > 52)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 22 && i < 36))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 8 || i > 51)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 21 && i < 27)
                        || (i > 27 && i < 31)
                        || (i > 31 && i < 37)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 8 || i > 51)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 21 && i < 26)
                        || (i > 27 && i < 31)
                        || (i > 32 && i < 37)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 8 || i > 51)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 21 && i < 25)
                        || (i > 27 && i < 31)
                        || (i > 33 && i < 37)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 9 || i > 50)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i == 29)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 9 || i > 50)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 9 || i > 50)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 10 || i > 49)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 10 || i > 49)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 10 || i > 49)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 11 || i > 48)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 11 || i > 48)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 11 || i > 48)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 12 || i > 47)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 12 || i > 47)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 12 || i > 47)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 13 || i > 46)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 13 || i > 46)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 13 || i > 46)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 14 || i > 45)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 14 || i > 45)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 14 || i > 45)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 15 || i > 44)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 15 || i > 44)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 15 || i > 44)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 16 || i > 43)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 16 || i > 43)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 16 || i > 43)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 17 || i > 42)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 17 || i > 42)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if (i < 17 || i > 42)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }

                for (int w = 0; w < 1; w++)
                {
                    if ((i > 24 && i < 27)
                        || (i > 30 && i < 33))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 18 || i > 41)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 24 && i < 28)
                        || (i > 29 && i < 33))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 18 || i > 41)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 25 && i < 32))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 18 || i > 41)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 23 && i < 31))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 19 || i > 40)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 22 && i < 31))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 19 || i > 40)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 23 && i < 31))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 19 || i > 40)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 25 && i < 32))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 20 || i > 39)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {
                    if ((i > 24 && i <28)
                        || (i > 29 && i < 33))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 20 || i > 39)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 1; w++)
                {

                    if ((i > 24 && i < 27)
                        || (i > 30 && i < 33))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < 20 || i > 39)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }

                for (int w = 60; w < i*3; w++)
                {
                    if (i > 20 && i < 30)
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 117; w > i * 3; w--)
                {
                    if (i > 29 && i < 39)
                    {
                        Console.Write("W");
                    }
                }

                for (int w = 180; w > i*3; w--)
                {
                    if (i > 55)
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 0; w < 3; w++)
                {
                    if (i < 56 && i > 29)
                    {
                        Console.Write("W");
                    }
                }

                for (int w = 0; w < 3; w++)
                {
                    if (i < 61 && i > 30)
                    {
                        Console.Write("W");
                    }
                }
                for (int w = 183; w > i * 3; w--)
                {
                    if (i < 31)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("B");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                for (int w = 0; w < i * 3; w++)
                {
                    if (i > 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("R");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }






            }
        }
    }
}
