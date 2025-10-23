using System;

class MaterialPoint
{
    public int x0, y0, z0; // Початкові координати
    public int v1, v2, v3; // Компоненти швидкості

    // Метод для задання початкових координат
    public void SetData(int x, int y, int z)
    {
        x0 = x;
        y0 = y;
        z0 = z;
    }

    // Метод для задання швидкості
    public void SetVelocity(int vx, int vy, int vz)
    {
        v1 = vx;
        v2 = vy;
        v3 = vz;
    }

    // Метод для обчислення нових координат і перевірки октанта
    public bool IsInFirstOctant(int t)
    {
        int x = x0 + v1 * t;
        int y = y0 + v2 * t;
        int z = z0 + v3 * t;

        Console.WriteLine($"New coordinates: ({x}, {y}, {z})");

        // Перевірка, чи потрапляє точка у перший октант
        return (x > 0 && y > 0 && z > 0);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter count of points: ");
        int count = Convert.ToInt32(Console.ReadLine());

        MaterialPoint[] points = new MaterialPoint[count];
        int time = 0;

        Console.Write("Enter time t: ");
        time = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            points[i] = new MaterialPoint();

            Console.WriteLine($"\nEnter coordinates of point {i + 1}:");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("z = ");
            int z = Convert.ToInt32(Console.ReadLine());
            points[i].SetData(x, y, z);

            Console.WriteLine($"Enter velocity components of point {i + 1}:");
            Console.Write("v1 = ");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("v2 = ");
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("v3 = ");
            int v3 = Convert.ToInt32(Console.ReadLine());
            points[i].SetVelocity(v1, v2, v3);
        }

        int countInFirstOctant = 0;
        for (int i = 0; i < count; i++)
        {
            if (points[i].IsInFirstOctant(time))
            {
                countInFirstOctant++;
                Console.WriteLine($"Point {i + 1} is in the 1st octant.");
            }
        }

        Console.WriteLine($"\nCount of points in 1st octant: {countInFirstOctant}");
    }
}
