using System;

namespace Juego
{
    class Program
    {
        static int puntos1 = 0;
        static int puntos2 = 0;
        static int option = 0;

        static void BinaryConversion()
        {
            int resp = 0;

            Console.Clear();
            Console.WriteLine("1.¿Cuanto es 10001 de binario a octal?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 21)
            {
                puntos1++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("2.¿Cuanto es 26 de octal a binario?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 10110)
            {
                puntos1++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("3.¿Cuanto es 77 de octal a binario?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 111111)
            {
                puntos1++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("4.¿Cuanto es 1111111 de binario a octal?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 177)
            {
                puntos1++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();

            }

            Console.Clear();
            Console.WriteLine("5.¿Cuanto es 111 de octal a binario?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 1001001)
            {
                puntos1++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();

            }

            Console.Clear();
            Console.WriteLine("6.¿Cuanto es 10101010 de binario a octal?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 252)
            {
                puntos1++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("7.¿Cuanto es 000111 de binario a octal?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 7)
            {
                puntos1++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("8.¿Cuanto es 210 de octal a binario?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 10001000)
            {
                puntos1++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("9.¿Cuanto es 56 de octal a binario?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 101110)
            {
                puntos1++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("10.¿Cuanto es 10101 de binario a octal?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 25)
            {
                puntos1++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }
        }

        static void HexaConversion()
        {
            int resp = 0;

            Console.Clear();
            Console.WriteLine("1.¿Cuanto es 11001 de binario a hexadecimal?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 19)
            {
                puntos2++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("2.¿Cuanto es 146 de hexadecimal a binario?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 101000110)
            {
                puntos2++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("3.¿Cuanto es 345 de hexadecimal a binario?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 1101000101)
            {
                puntos2++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("4.¿Cuanto es 1010101 de binario a hexadecimal?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 55)
            {
                puntos2++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("5.¿Cuanto es 11 de binario a hexadecimal?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 3)
            {
                puntos2++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("6.¿Cuanto es 6 de hexadecimal a binario?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 110)
            {
                puntos2++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("7.¿Cuanto es 33 de hexadecimal a binario?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 110011)
            {
                puntos2++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("8.¿Cuanto es 1000 de binario a hexadecimal?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 8)
            {
                puntos2++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
            }

            Console.Clear();
            Console.WriteLine("9.¿Cuanto es 111000 de binario a hexadecimal ? ");
            resp = int.Parse(Console.ReadLine());
            if (resp == 38)
            {
                puntos2++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("10.¿Cuanto es 99 de hexadecimal a binario?");
            resp = int.Parse(Console.ReadLine());
            if (resp == 10011001)
            {
                puntos2++;
                Console.WriteLine("Ganaste un punto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrecto");
                Console.ReadKey();
            }
        }

        static void Results()
        {
            int total = 0;
            total = puntos1 + puntos2;
            Console.Clear();
            Console.WriteLine("Puntos primer juego: " + puntos1);
            Console.WriteLine("Puntos segundo juego: " + puntos2);
            Console.WriteLine();
            if (total > 8)
            {
                Console.WriteLine("Eres un genio, Ganaste");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Mas Suerte la Proxima vez, Perdiste");
                Console.ReadKey();
            }
        }

        static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("=======Juego de agilidad respérica=======");
                Console.WriteLine("1. Binario-Octal o Octal-Binario");
                Console.WriteLine("2. Binario-Hexadecimal o Hexadecimal-Binario");
                Console.WriteLine("3. Ver notas");
                Console.WriteLine("4. No Jugar");
                Console.WriteLine("Seleccione una Clasificación.");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            BinaryConversion();
                            break;
                        }
                    case 2:
                        {
                            HexaConversion();
                            break;
                        }
                    case 3:
                        {
                            Results();
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                }
            } while (option != 4);
        }
    }
}