void Main ()
{
    int N = ReadInt ("Введите верхнюю границу чисел: ");
    PrintNumbers(N);
}

int M = ReadInt ("Введите нижнюю границу чисел: ");
void PrintNumbers (int number)
{
    if (number < M)
    {
        return;
    }
    System.Console.Write (number + " ");
    PrintNumbers (number - 1);
    }

int ReadInt (string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
Main ();