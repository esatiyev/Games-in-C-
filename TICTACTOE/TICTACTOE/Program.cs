using System;

namespace MyApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            while (true)
            {
                int number, player = 1;
                
                int n = 1;              // gedis sayi 9 olanda oyun bitir
                char FOF = '1', SOF = '2', TOF = '3';
                char FOS = '4', SOS = '5', TOS = '6';
                char FOT = '7', SOT = '8', TOT = '9';
                Console.WriteLine("Game Info: \n Player 1: X \n Player 2: O \n");
                GetFirstField();


                while (true)
                {
                    number = GetNumber(player);

                    while (!CheckNumber(number, player, FOF, SOF, TOF, FOS, SOS, TOS, FOT, SOT, TOT))
                        number = GetNumber(player);
//#endregion


                    if (player == 1)
                    {
                        if (number == 1) FOF = 'X';
                        else if (number == 2) SOF = 'X';
                        else if (number == 3) TOF = 'X';
                        else if (number == 4) FOS = 'X';
                        else if (number == 5) SOS = 'X';
                        else if (number == 6) TOS = 'X';
                        else if (number == 7) FOT = 'X';
                        else if (number == 8) SOT = 'X';
                        else TOT = 'X';
                    }
                    else
                    {
                        if (number == 1) FOF = 'O';
                        else if (number == 2) SOF = 'O';
                        else if (number == 3) TOF = 'O';
                        else if (number == 4) FOS = 'O';
                        else if (number == 5) SOS = 'O';
                        else if (number == 6) TOS = 'O';
                        else if (number == 7) FOT = 'O';
                        else if (number == 8) SOT = 'O';
                        else TOT = 'O';
                    }


                    GetNewField(number, player, FOF, SOF, TOF, FOS, SOS, TOS, FOT, SOT, TOT);



                    if (WhoIsWin(number, player, FOF, SOF, TOF, FOS, SOS, TOS, FOT, SOT, TOT) == 1)
                    {
                        Console.WriteLine("Player 1 win!!!");
                        break;
                    }

                    else if (WhoIsWin(number, player, FOF, SOF, TOF, FOS, SOS, TOS, FOT, SOT, TOT) == 2)
                    {
                        Console.WriteLine("Player 2 has won!!!");
                        break;
                    }

                    else if (n == 9) Console.WriteLine("!!!   Noone has won   !!!");


                    if (player == 1) player = 2;
                    else player = 1;


                    n++;
                }


                Console.WriteLine("\nPlease press any key to reset the game");

                Console.Read();

                Console.Clear();   // console sifirlanir
         
            }
            
        }





        static void GetFirstField()
        {
            char FOF = '1', SOF = '2', TOF = '3';
            char FOS = '4', SOS = '5', TOS = '6';
            char FOT = '7', SOT = '8', TOT = '9';

            Console.WriteLine(" {0} | {1} | {2} ", FOF, SOF, TOF);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", FOS, SOS, TOS);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", FOT, SOT, TOT);
        }




        static int GetNumber(int player)
        {
            Console.WriteLine("\nPlayer {0},please enter a number",player);
            string numberAsString = Console.ReadLine();
            int number;

            if( Int32.TryParse(numberAsString,out number) )
                 number = Convert.ToInt32(numberAsString);

            return number;
        }




        static bool CheckNumber(int number, int player,
            char FOF, char SOF, char TOF,
            char FOS, char SOS, char TOS,
            char FOT, char SOT, char TOT)
        {
            switch (number)
            {
                case 1:
                    if(FOF != '1')
                    {
                        Console.WriteLine("Player {0},the number you enter is already chose.Input again a valid number !!!", player);
                        return false;
                    }
                    else { }
                    break;
                case 2:
                    if (SOF != '2')
                    {
                        Console.WriteLine("Player {0},the number you enter is already chose.Input again a valid number !!!", player);
                        return false;
                    }
                    break;
                case 3:
                    if (TOF != '3')
                    {
                        Console.WriteLine("Player {0},the number you enter is already chose.Input again a valid number !!!", player);
                        return false;
                    }
                    break;
                case 4:
                    if (FOS != '4')
                    {
                        Console.WriteLine("Player {0},the number you enter is already chose.Input again a valid number !!!", player);
                        return false;
                    }
                    break;
                case 5:
                    if (SOS != '5')
                    {
                        Console.WriteLine("Player {0},the number you enter is already chose.Input again a valid number !!!", player);
                        return false;
                    }
                    break;
                case 6:
                    if (TOS != '6')
                    {
                        Console.WriteLine("Player {0},the number you enter is already chose.Input again a valid number !!!", player);
                        return false;
                    }
                    break;
                case 7:
                    if (FOT != '7')
                    {
                        Console.WriteLine("Player {0},the number you enter is already chose.Input again a valid number !!!", player);
                        return false;
                    }
                    break;
                case 8:
                    if (SOT != '8')
                    {
                        Console.WriteLine("Player {0},the number you enter is already chose.Input again a valid number !!!", player);
                        return false;
                    }
                    break;
                case 9:
                    if (TOT != '9')
                    {
                        Console.WriteLine("Player {0},the number you enter is already chose.Input again a valid number !!!", player);
                        return false;
                    }
                    break;
                default:
                    Console.WriteLine("Player {0},the number you enter is invalid.Input again a valid number !!!", player);
                    return false;
            }
            return true;
        }




        static void GetNewField(int number, int player,
            char FOF, char SOF, char TOF,
            char FOS, char SOS, char TOS,
            char FOT, char SOT, char TOT)
        {
            Console.Clear();     // consoleda yazilan her seyi temizleyir

            Console.WriteLine("\nNew Field!!!\n");
            Console.WriteLine(" {0} | {1} | {2} ", FOF, SOF, TOF);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", FOS, SOS, TOS);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", FOT, SOT, TOT);
        }




        static int WhoIsWin(int number, int player,
            char FOF, char SOF, char TOF,
            char FOS, char SOS, char TOS,
            char FOT, char SOT, char TOT)
        {
            
           
            
                if (FOF == FOS && FOF == FOT) return player;
                else if (SOF == SOS && SOF == SOT) return player;
                else if (TOF == TOS && TOF == TOT) return player;
                else if (FOF == SOF && FOF == TOF) return player;
                else if (FOS == SOS && FOS == TOS) return player;
                else if (FOT == SOT && FOT == TOT) return player;
                else if (FOF == SOS && FOF == TOT) return player;
                else if (TOF == SOS && TOF == FOT) return player;
                
                else return 0; 
            
        }

    }
}