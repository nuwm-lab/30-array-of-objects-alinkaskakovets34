using System;

class cincle
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
class sphere : cincle
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

        int choice;
        cincle baseObj;

        Console.WriteLine("Choose an object to work on:");
        Console.WriteLine("0 - a circle");
        Console.WriteLine("1 - sphere");
        Console.Write("Your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 0)
        {
            baseObj = new cincle();
            baseObj.Input(0, 0, 5);
            baseObj.Display();
            Console.WriteLine($"circle length: {baseObj.Length():F2}");
        }
        else if (choice == 1)
        {
            sphere sph = new sphere();
            sph.Input(0, 0, 10, 5);
            sph.Display();
            Console.WriteLine($"Surface area of a sphere: {sph.Area():F2}");
        }
        else
        {
            Console.WriteLine("Wrong choice!");
        }

        Console.WriteLine("\nDemonstration of dynamic polymorphism:");
        baseObj = new sphere(); // створюємо посилання базового типу на об’єкт похідного класу
        baseObj.Input(1, 2, 7); // викликається метод базового класу
        baseObj.Display(); // викликається метод ПЕРЕВИЗНАЧЕНИЙ у похідному класі
    }
}
