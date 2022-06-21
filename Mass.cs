using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third {
    class Mass {
        public static int[,] massive(int[,] mass) {
            bool exit = false;
            while (!exit) {
                try {
                    Random rand = new Random();
                    Console.Write("Введите количество строк массива: ");
                    int rows = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите количество столбцов массива: ");
                    int cols = Convert.ToInt32(Console.ReadLine());
                    mass = new int[rows, cols];
                    Console.Write("Рандом (0, 1)? ");
                    int randAsk = Convert.ToInt32(Console.ReadLine());

                    if (randAsk == 1) {
                        for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                            for (int j = 0; j < mass.GetUpperBound(1)+1; j++) {
                                mass[i,j] = rand.Next(-1000, 1000);
                                Console.Write($"{mass[i, j]} \t");
                            }
                            Console.WriteLine();
                        }
                    } else {
                        for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                            for (int j = 0; j < mass.GetUpperBound(1)+1; j++) {
                                Console.Write("Введите число: ");
                                mass[i,j] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        printMass(mass);
                    }
                    exit = true;
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            return mass;
        }

        public static void printMass(int[,] mass) {
            Console.WriteLine();
            for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                for (int j = 0; j < mass.GetUpperBound(1)+1; j++) {
                    Console.Write($"{mass[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}