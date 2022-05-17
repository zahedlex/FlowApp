using System;

public class Control
{
    static void TopMenu()
    {
        Console.WriteLine("Welcome to the topmenue you can opt for Menu 1 menu 2 or menu 3");
        

       do
        {
            string strReadKey = Console.ReadKey().KeyChar.ToString();
            int.TryParse(strReadKey, out int val2);
            switch (val2)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                    
                case 1:
                    MenuOne();

                            break;
                case 2:
                        MenuTwo();
                        break;
                case 3:
                    MenuThree();
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }while(true);

        
    }
    
    static void MenuOne()
    {
        
        int TotalSum = 0;
        

                Console.WriteLine("How many persons are you");
        String strReadKey1 = Console.ReadKey().KeyChar.ToString();
        int.TryParse(strReadKey1, out int val1);

        int[] persons = new int[100];
        for (int i = 0; i < val1; i++)


            Console.WriteLine("Enter your age");
        String strReadKey2 = Console.ReadKey().KeyChar.ToString();
        int.TryParse(strReadKey2, out int val2);

       


        if (val2 < 20 && val1 >= 1)
            TotalSum += 80;
        Console.WriteLine($"{val1} persons and  {TotalSum} Group price kr");

        if (val2 > 64 && val1 >= 1)
            TotalSum += 90;
        Console.WriteLine($"{val1} persons and  {TotalSum} Group price kr");

        if (val2 < 20 && val2 > 64 && val1 >= 1)
            if (val2 < 20)
                TotalSum += 80 + 90;
        Console.WriteLine($"{val1} persons and  {TotalSum} Group price kr");


        if (val1 >= 1)
            TotalSum += 120;
       Console.WriteLine($"{val1} persons and  {TotalSum} Group price kr");

    }

    static void MenuTwo()
    {
        Console.WriteLine("Enter one arbitrary word");
        String read_user = Console.ReadLine();

        for (int i = 0; i < 10; i++)
            Console.WriteLine($"{read_user}");
    }

    static void MenuThree()
    {
        Console.Write("Enter no less than three words");
        string read_user = Console.ReadLine();
        char[] separators = new char[] { ' ' };
        string[] subs = read_user.Split(separators);
        for (int i = 0; i < subs.Length; i++)

            Console.WriteLine(subs[i=2]);
        
    }



     static void Main(string[] args)
    {
        TopMenu();

    }
    

}