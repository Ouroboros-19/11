class Program
{
    static void Main()
    {
        Random r = new Random();
        int a = 10, min, max;
        bool flag, t = true;
        int[] array = new int[a];
        array[0] = r.Next(0, 10);
        Console.Write("{0,3}", array[0]);
        min = max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            array[i] = r.Next(0, 10);
            Console.Write("{0,3}", array[i]);
            if (array[i] < min)
                min = array[i];
            if (array[i] > max)
                max = array[i];
        }
        Console.WriteLine("\n Целые числа в интервале[{0},{1}] не входящие в массив:", min, max);
        for (int i = min + 1; i < max; i++)
        {
            flag = true;
            for (int j = 0; j < a; j++)
                if (i == array[j])
                    flag = false;
            if (flag == true)
            {
                Console.Write("{0,5}", i);
                t = false;
            }
        }
        if (t == true)
            Console.WriteLine(" нет таких");
        Console.WriteLine("");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        if (povtor == "")
            Main();
    }
}