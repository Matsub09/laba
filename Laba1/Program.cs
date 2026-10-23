int []mas =new int[15];

Random random = new Random();
for(int i = 0;i < mas.Length; i++)
{
    mas[i] = random.Next(1,10);
    Console.WriteLine(mas[i] + " ");
}
Console.WriteLine();

int sum = 0;
int middleIndex = mas.Length / 2;
for(int i = 0; i < middleIndex; i++)
{
    sum += mas[i];
}

Console.WriteLine($"Сумма элементов до центрального {sum}");

