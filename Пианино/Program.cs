namespace Пианино
{
    internal class Program
    {
        static int[] FirstOctave = { 37, 38, 39, 40, 41, 43, 46, 49, 55, 58, 61, 63 };
        static int[] SecondOctave = { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
        static int[] ThirdOctave = { 130, 138, 146, 155, 165, 174, 185, 196, 207, 220, 233, 246 };
        static int[] FourthOctave = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        static int[] FifthOctave = { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
        static void Main(string[] args)
        {
            Console.WriteLine("Выбери октаву: F1, F2, F3, F4, F5 \n " +
                "Клавиши: D, R, F, T, G, Y, H, U, J, I, K, L");
            while (true)
            {
                int[] ponchik = Octave();
                if (ponchik == FirstOctave)
                {
                    Console.WriteLine("Первая октава: ");
                    Sound(ponchik);
                }
                if (ponchik == SecondOctave)
                {
                    Console.WriteLine("Вторая октава");
                    Sound(ponchik);

                }
                if (ponchik == ThirdOctave)
                {
                    Console.WriteLine("Третья октава");
                    Sound(ponchik);
                }
                if (ponchik == FourthOctave)
                {
                    Console.WriteLine("Четвертая октава: ");
                    Sound(ponchik);
                }
                if (ponchik == FifthOctave)
                {
                    Console.WriteLine("Пятая октава");
                    Sound(ponchik);
                }
            }
            static int[] Octave()
            {
                int[] clavisha = new int[13];
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    Console.WriteLine(Key.Key);
                    if (Key.Key == ConsoleKey.F1)
                    {
                        Console.WriteLine("Первая октава: ");
                        clavisha = FirstOctave;
                        return clavisha;
                    }
                    if (Key.Key == ConsoleKey.F2)
                    {
                        Console.WriteLine("Вторая октава: ");
                        clavisha = SecondOctave;
                        return clavisha;
                    }
                    if (Key.Key == ConsoleKey.F3)
                    {
                        Console.WriteLine("Третья октава: ");
                        clavisha = ThirdOctave;
                        return clavisha;
                    }
                    if (Key.Key == ConsoleKey.F4)
                    {
                        Console.WriteLine("Четвертая октава: ");
                        clavisha = FourthOctave;
                        return clavisha;
                    }
                    if (Key.Key == ConsoleKey.F5)
                    {
                        Console.WriteLine("Пятая октава");
                        clavisha = FifthOctave;
                        return clavisha;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Выбери октаву: F1, F2, F3, F4, F5 \n " +
                            "Клавиши: D, R, F, T, G, H, U, J, I, K, L");
                        return clavisha;
                    }
                }
                }
            }

        private static int[] Sound(int[] ponchik)

        {
            int[] clavisha = new int[13];
            while (true)
            {
                ConsoleKey KeySound = Console.ReadKey().Key;
                switch (KeySound)
                {
                    case ConsoleKey.D:
                        Console.Beep(ponchik[0]+100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        Console.Beep(ponchik[1]+100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        Console.Beep(ponchik[2]+100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        Console.Beep(ponchik[3] + 100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        Console.Beep(ponchik[4] + 100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(ponchik[5] + 100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        Console.Beep(ponchik[6] + 100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        Console.Beep(ponchik[7] + 100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.J:
                        Console.Beep(ponchik[8] + 100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.I:
                        Console.Beep(ponchik[9] + 100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.K:
                        Console.Beep(ponchik[10] + 100, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.L:
                        Console.Beep(ponchik[11] + 100, 300);
                        Console.Clear();
                        break;
              
                    case ConsoleKey.F1:
                        ponchik = FirstOctave;
                        return ponchik;
                        break;
                    case ConsoleKey.F2:
                        ponchik = SecondOctave;
                        return ponchik;
                        break;
                    case ConsoleKey.F3:
                        ponchik = ThirdOctave;
                        return ponchik;
                        break;
                    case ConsoleKey.F4:
                        ponchik = FourthOctave;
                        return ponchik;
                        break;
                    case ConsoleKey.F5:
                        ponchik = FifthOctave;
                        return ponchik;
                        break;
                    default:
                        Console.Clear();
                        break;

                }
            }
        }
    }
    }






