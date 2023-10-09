Main();
static void Main()
{
    Console.WriteLine("Красные клавиши: A, S, D, F, G, H");
    Console.WriteLine("Фиолетовые клавиши: W, E, R, T, Y");
    Console.WriteLine("Октавы: F1, F2, F3");
    Console.WriteLine("Для выхода программы нажмите клавишу Escape");
    Console.WriteLine("Выберите октаву");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    switch (key.Key)
    {
        case ConsoleKey.F1:
            FirtsOctave();
            break;
        case ConsoleKey.F2:
            SecondOctave();
            break;
        case ConsoleKey.F3:
            ThirdOctave();
            break;
        case ConsoleKey.Escape:
            Environment.Exit(0);
            break;
    }
}

static void FirtsOctave()
{
    int[] Octave = new int[]
        { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
    Note(Octave);
}

static void SecondOctave()
{
    int[] Octave = new int[]
        { 515, 545, 578, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
    Note(Octave);

}

static void ThirdOctave()
{
    int[] Octave = new int[]
        { 1047, 1109, 1175, 1245, 1391, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
    Note(Octave);
}

static void Note(int[] a)
{
    Console.WriteLine("Если вы хотите вернутся в меню к выбору октавы, нажмите клавишу Backspace");
    Console.WriteLine("Для выхода программы нажмите клавишу Escape");
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        Console.Clear();
        do
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.A)
            {
                Console.Beep((int)a[0], 100);
            }
            if (key.Key == ConsoleKey.S)
            {
                Console.Beep((int)a[1], 100);
            }
            if (key.Key == ConsoleKey.D)
            {
                Console.Beep((int)a[2], 100);
            }
            if (key.Key == ConsoleKey.F)
            {
                Console.Beep((int)a[3], 100);
            }
            if (key.Key == ConsoleKey.G)
            {
                Console.Beep((int)a[4], 100);
            }
            if (key.Key == ConsoleKey.H)
            {
                Console.Beep((int)a[5], 100);
            }
            if (key.Key == ConsoleKey.W)
            {
                Console.Beep((int)a[6], 100);
            }
            if (key.Key == ConsoleKey.E)
            {
                Console.Beep((int)a[7], 100);
            }
            if (key.Key == ConsoleKey.R)
            {
                Console.Beep((int)a[8], 100);
            }
            if (key.Key == ConsoleKey.T)
            {
                Console.Beep((int)a[9], 100);
            }
            if (key.Key == ConsoleKey.Y)
            {
                Console.Beep((int)a[10], 200);
            }
        } while (key.Key != ConsoleKey.Spacebar);
    }
}