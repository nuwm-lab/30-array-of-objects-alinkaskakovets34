using System;

class Cincle
{
    public int x0;
    public int y0;
    public int r;

    // Метод для задання значень полів
    public virtual void Input(int x, int y, int radius)
    {
        x0 = x;
        y0 = y;
        r = radius;
    }

    // Віртуальний метод для виведення даних кола
    public virtual void Display()
    {
        Console.WriteLine($"Center: ({x0}, {y0}), Radius: {r}");
    }

    // Метод для обчислення довжини кола
    public virtual double Length()
    {
        return 2 * Math.PI * r;
    }
}

// Похідний клас — сфера
class Sphere : Cincle
{
    public int z0;

    // Перевизначення методу введення
    public void Input(int x, int y, int z, int radius)
    {
        x0 = x;
        y0 = y;
        z0 = z;
        r = radius;
    }

    // Перевизначення методу відображення (динамічний поліморфізм)
    public override void Display()
    {
        Console.WriteLine($"Center: ({x0}, {y0}, {z0}), Radius: {r}");
    }

    // Новий метод — обчислення площі поверхні сфери
    public double Area()
    {
        return 4 * Math.PI * r * r;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Choose an object to work on:");
        Console.WriteLine("0 - Circle");
        Console.WriteLine("1 - Sphere");
        Console.Write("Your choice: ");

        int userSelect = Convert.ToInt32(Console.ReadLine());
        Cincle baseObj;

        if (userSelect == 0)
        {
            baseObj = new Cincle();
            baseObj.Input(0, 0, 5);
            baseObj.Display();
            Console.WriteLine($"Circle length: {baseObj.Length():F2}");
        }
        else if (userSelect == 1)
        {
            Sphere sph = new Sphere();
            sph.Input(0, 0, 10, 5);
            sph.Display();
            Console.WriteLine($"Surface area of sphere: {sph.Area():F2}");
        }
        else
        {
            Console.WriteLine("Wrong choice!");
        }

        // Демонстрація динамічного поліморфізму
        Console.WriteLine("\nDemonstration of dynamic polymorphism:");
        baseObj = new Sphere();  // створюємо посилання базового типу на об’єкт похідного класу

        // Викликається метод базового класу Input, бо аргументи відповідають саме йому
        baseObj.Input(1, 2, 7);

        // Викликається перевизначений метод Display у похідному класі Sphere
        baseObj.Display();
    }
}
