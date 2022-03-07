double distance = new double();


Console.WriteLine("Введите координаты первой точки через пробел: ");
double[] arrayA = Console.ReadLine().Split(' ').Select(x => Convert.ToDouble(x)).ToArray();

Console.WriteLine("Введите координаты второй точки через пробел: ");
double[] arrayB = Console.ReadLine().Split(' ').Select(x => Convert.ToDouble(x)).ToArray();


distance = Math.Pow(((arrayB[0] - arrayA[0]) * (arrayB[0] - arrayA[0]) + (arrayB[1] - arrayA[1]) * (arrayB[1] - arrayA[1]) + (arrayB[2] - arrayA[2]) * (arrayB[2] - arrayA[2])), 0.5);
distance = Math.Round(distance, 2);


Console.WriteLine($"Расстояние между точками: {distance}");
