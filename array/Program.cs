// способы создания массива
// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 7;
// arr[2] = 5;
// arr[3] = 4;
// arr[4] = 3;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);

// int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

// int[] arr3 = { 1, 2, 3, 4, 5 }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int n = 10;
// int[] arr = new int[n];
// int i = 0;

// while (i < n)
// {
// 	arr[i] = i + 1;
// 	// Console.Write(arr[i]); 
// 	// Console.Write(' ');
// 	Console.Write($"{arr[i]} ");
// 	i++;
// }

// int n = 10;
// int[] arr = { 2, 4, 6, 11, 23, 42, 15, 22, 53, 56 };

// for (int i = 0; i < arr.Length; i++)
// {
// 	if (arr[i] % 2 == 0)
// 	{
// 		Console.Write($"{arr[i]} ");
// 	}
// }
// int[] arr = { 2, 4, 6, 10, 22, 42, 16, 24, 54, 56 };

// for (int i = 0; i < arr.Length; i++)
// {
// 	if (arr[i] % 2 == 0)
// 	{
// 		Console.Write($"{arr[i]} ");
// 	}
// }
int[] arr = { 1, 13, 14, 5, 3, 6, 19 };
int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] > max)
	{
		max = arr[i];
	}
}
Console.WriteLine(max);
foreach (int e in arr)
{
	max = e;
}
Console.WriteLine(max);