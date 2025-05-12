//using System.Xml.Linq;

//Write a C# Sharp program to find the sum of the right diagonals of a matrix.
//Test Data :
//Input the size of the square matrix : 2
//Input elements in the first matrix :
//element - [0],[0] : 1
//element - [0],[1] : 2
//element - [1],[0] : 3
//element - [1],[1] : 4
//Expected Output :
//The matrix is :
//1 2
//3 4
//Addition of the right Diagonal elements is :5

int[,] matrix = new int[2, 2];


Console.WriteLine("Input elements in the first matrix:");
Console.Write("element 1: ");
matrix[0,0] = Convert.ToInt32(Console.ReadLine());
Console.Write("element 2: ");
matrix[0,1] = Convert.ToInt32(Console.ReadLine());
Console.Write("element 3: ");
matrix[1,0] = Convert.ToInt32(Console.ReadLine());
Console.Write("element 4: ");
matrix[1,1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The matrix is: ");

int sum = 0;
for (int i = 0; i < 2; i++)
{
    sum += matrix[i, i];
    for (int j = 0; j < 2; j++)
    {
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Addition of the right Diagonal elements is: {sum} ");

