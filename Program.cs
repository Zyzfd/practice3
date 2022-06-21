using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Clear();
                Console.WriteLine("Выберете задание: ");
                Console.WriteLine("1 - 1 блок");
                Console.WriteLine("2 - 2 блок");
                Console.WriteLine("3 - 3 блок");
                Console.WriteLine("0 - Выход");
                Console.Write(">> ");
                try {
                    int menuInt = Convert.ToInt32(Console.ReadLine());

                    switch (menuInt) {
                        case 1: {
                            Console.WriteLine("Выберете задание: ");
                            Console.WriteLine("1 - 7 задание");
                            Console.WriteLine("2 - 1 задание");
                            Console.WriteLine("0 - Выход");
                            Console.Write(">> ");
                            int menuInt1 = Convert.ToInt32(Console.ReadLine());
                            First fr = new First();
                            switch (menuInt1)
                            {
                                case 1: {fr.swithCols1();} break;
                                case 2: {fr.swithCols2();} break;
                                case 0: {Environment.Exit(0);} break;
                                default: throw new Exception();
                            }
                        } break;
                        case 2: {
                            Console.WriteLine("Выберете задание: ");
                            Console.WriteLine("1 - 7 задание");
                            Console.WriteLine("2 - 1 задание");
                            Console.WriteLine("0 - Выход");
                            Console.Write(">> ");
                            int menuInt2 = Convert.ToInt32(Console.ReadLine());
                            Second sc = new Second();
                            switch (menuInt2)
                            {
                                case 1: {sc.doubleMaxRow();} break;
                                case 2: {sc.delMinRow();} break;
                                case 0: {Environment.Exit(0);} break;
                                default: throw new Exception();
                            }
                        } break;
                        case 3: {
                            Console.WriteLine("Выберете задание: ");
                            Console.WriteLine("1 - 7 задание");
                            Console.WriteLine("2 - 1 задание");
                            Console.WriteLine("0 - Выход");
                            Console.Write(">> ");
                            int menuInt3 = Convert.ToInt32(Console.ReadLine());
                            Third th = new Third();
                            switch (menuInt3)
                            {
                                case 1: {th.sortMaxRow();} break;
                                case 2: {th.sortMinRow();} break;
                                case 0: {Environment.Exit(0);} break;
                                default: throw new Exception();
                            }
                        } break;

                        case 0: {Environment.Exit(0);} break;
                        default: throw new Exception();
                    }
                }
                catch (Exception ex) { 
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
