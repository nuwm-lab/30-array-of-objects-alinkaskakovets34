using System;


class MaterialPoint
{
    public int x0, y0, z0;
    public int v1, v2, v3;




    public void SetData(int x, int y, int z)
    {
        x0 = x;
        y0 = y;
        z0 = z;
    }
    // метод для задання або обрахунку через певний t із v
    public int abracadabra(int v, int t)
    {
        int x = x0 + v * t;
        int y = y0 + v * t;
        int z = z0 + v * t;
        Console.WriteLine("new coordinates {0}, {1}, {2}", x, y, z);
        int moroz;
        if (x > 0 && y > 0 && z > 0)
        {
            moroz = 1;
        }
        else
        {
            moroz = 2;
        }
        if (x < 0 && y < 0 && z < 0)
        {
            moroz = 3;


        }
        else
        {
            moroz = 4;
        }
        return moroz;


    }
    class Program
    {
        static void Main(string[] args)
        {
            MaterialPoint[] k = new MaterialPoint[10];
            int x = 0, y = 0, z = 0;
            int kx, ky, kz;
            int count;
            int a = 0;
            Console.WriteLine("Enter count of points");
            count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                k[i] = new MaterialPoint();
                Console.WriteLine("Enter coordinates of point {0}", i + 1);
                Console.Write("x=");
                kx = Convert.ToInt32(Console.ReadLine());
                Console.Write("y=");
                ky = Convert.ToInt32(Console.ReadLine());
                Console.Write("z=");
                kz = Convert.ToInt32(Console.ReadLine());
                k[i].SetData(kx, ky, kz);
            }
            for (int i = 0; i < count; i++)
            {
                if (k[i].abracadabra(2, 3) == 1)
                {
                    a++;
                    Console.WriteLine("Point {0} is in 1st octant", i + 1);
                }


            }
            Console.WriteLine("Count of points in 1st octant is {0}", a);
        }


    }


}
