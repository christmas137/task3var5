using System;

namespace task3var5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Planet planet = new Planet("Unnamed");
            int action;
            
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                                  "\t1)Создать планету\n\t2)Вывести название материка\n" +
                                  "\t3)Вывести название острова\n\t4)Вывести название океана\n" +
                                  "\t6)Вывести кол-во материков\n" +
                                  "\t7)Вывести кол-во островов\n\t8)Вывести кол-во океанов\n" +
                                  "\t5)Вывести планету\n");
                
                action = Convert.ToInt32(Console.ReadLine());
                
                if (action == 0) break;
                
                switch (action)
                {
                    case 1:
                        planet = createPlanet();
                        break;
                    case 2:
                        printMat(planet);
                        break;
                    case 3:
                        printOcean(planet);
                        break;
                    case 4:
                        printLend(planet);
                        break;
                    case 5:
                        printPlanet(planet);
                        break;
                    case 6:
                        Console.WriteLine($"Всего материков: {planet.numderOfMats()})");
                        break;
                    case 7:
                        Console.WriteLine($"Всего островов: {planet.numderOfLends()})");
                        break;
                    case 8:
                        Console.WriteLine($"Всего океанов: {planet.numderOfOceans()})");
                        break;
                }
            }
            
            
        }

        private static void printMat(Planet planet)
        {
            int n = planet.numderOfMats();
            Console.WriteLine($"Всего материков: {n}. Введите номер материка:");
            int mat = Convert.ToInt32(Console.ReadLine());
            while (mat <= 0 || mat > n)
            {
                Console.WriteLine($"Введите номер материка: (Допустимые значение от 1 до {n})");
                mat = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(planet.getMat(mat));
        }
        
        private static void printOcean(Planet planet)
        {
            int n = planet.numderOfOceans();
            Console.WriteLine($"Всего океанов: {n}. Введите номер океана:");
            int ocean = Convert.ToInt32(Console.ReadLine());
            while (ocean <= 0 || ocean > n)
            {
                Console.WriteLine($"Введите номер океанов: (Допустимые значение от 1 до {n})");
                ocean = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(planet.getOcean(ocean));
        }
        
        private static void printLend(Planet planet)
        {
            int n = planet.numderOfLends();
            Console.WriteLine($"Всего островов: {n}. Введите номер острова:");
            int lend = Convert.ToInt32(Console.ReadLine());
            while (lend <= 0 || lend > n)
            {
                Console.WriteLine($"Введите номер острова: (Допустимые значение от 1 до {n})");
                lend = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(planet.getLend(lend));
        }


        static void printPlanet(Planet planet)
        {
            Console.WriteLine(planet);
        }

        static Planet createPlanet()
        {
            Planet planet;
            
            Console.WriteLine("Введите название планеты");
            string name = Console.ReadLine();

            Console.WriteLine("Введите количество материков (n=>0)");
            int mats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество океанов (n=>0)");
            int oceans = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество островов (n=>0)");
            int lends = Convert.ToInt32(Console.ReadLine());
            if ((mats < 0) || (oceans < 0) || (lends < 0))
            {
                Console.WriteLine("Введены некорректные параметры");
                
                planet = new Planet("Unnamed");
            }
            else
            {
                
                planet = new Planet(name);
                for (int i = 0; i < mats; i++)
                {
                    addMat(planet);
                }
                for (int i = 0; i < oceans; i++)
                {
                    addOcean(planet);
                }
                for (int i = 0; i < lends; i++)
                {
                    addLend(planet);
                }
            }
            

            return planet;
        }

        static void addMat(Planet planet)
        {
            Console.WriteLine("Введите название материка: ");
            string name = Console.ReadLine();
            planet.addMat(name);
        }
        
        static void addOcean(Planet planet)
        {
            Console.WriteLine("Введите название океана: ");
            string name = Console.ReadLine();
            planet.addOcean(name);
        }
        
        static void addLend(Planet planet)
        {
            Console.WriteLine("Введите название острова: ");
            string name = Console.ReadLine();
            planet.addLend(name);
        }
        
        
    }
}