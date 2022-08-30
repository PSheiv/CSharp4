{
    Console.WriteLine("task 25");

    Console.WriteLine("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 1;

    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

{
    Console.WriteLine("task 27");

    Console.WriteLine("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (a > 0)
    {
        int num = a % 10;
        a = a / 10;
        sum = sum + num;
    }
    Console.WriteLine("сумма всех цифр в числе равна: " + sum);

}

{
    // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

    Console.WriteLine("task 29");

    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 8);
    }
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }

}


