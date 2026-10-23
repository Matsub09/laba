using System;
using System.Collections.Generic;

int[] A = new int[15];
int[] B = new int[20];
Random rnd = new Random();
List<int> C = new List<int>();

for (int i = 0; i < 15; i++) A[i] = rnd.Next(1, 10);
for (int i = 0; i < 20; i++) B[i] = rnd.Next(1, 10);

for (int i = 0; i < 15; i++)
{
    if (Array.IndexOf(A, A[i]) == Array.LastIndexOf(A, A[i]) && !C.Contains(A[i]))
        C.Add(A[i]);
}

for (int i = 0; i < 20; i++)
{
    if (Array.IndexOf(B, B[i]) == Array.LastIndexOf(B, B[i]) && !C.Contains(B[i]))
        C.Add(B[i]);
}

Console.WriteLine("Массив C:");
foreach (int item in C) Console.Write(item + " ");
Console.WriteLine();
