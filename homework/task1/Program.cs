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
    PrintNumbers (number - 1);
    System.Console.Write (number + " ");
}
int ReadInt (string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
Main ();