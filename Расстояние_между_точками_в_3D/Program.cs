double xA = new double();
double yA = new double();
double zA = new double();
double xB = new double();
double yB = new double();
double zB = new double();
double distance = new double();

Console.WriteLine("Введите координаты первой точки: ");
xA= Convert.ToDouble(Console.ReadLine());
yA= Convert.ToDouble(Console.ReadLine());
zA= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
xB= Convert.ToDouble(Console.ReadLine());
yB= Convert.ToDouble(Console.ReadLine());
zB= Convert.ToDouble(Console.ReadLine());

distance = Math.Pow(((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA) + (zB-zA)*(zB-zA)), 0.5);
distance = Math.Round(distance, 2);

Console.WriteLine($"Расстояние между точками: {distance}");
