using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third {
    class First {
        int[,] mass;
        public First() {
            mass = Mass.massive(mass);
        }
        void switchCols(int ind1, int ind2) {
            if (ind1 != -1 & ind2 != -1) {
                for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                    int tempInd = mass.Length;
                    for (int j = 0; j < mass.GetUpperBound(1)+1; j++) {
                        if (j == ind1 | j == ind2) {
                            if (tempInd != mass.Length) {
                                int temp = mass[i, tempInd];
                                mass[i, tempInd] = mass[i, j];
                                mass[i, j] = temp;
                                break;
                            } else {
                                tempInd = j;
                            }
                        }
                    }
                }
            }
        }
        public void swithCols1() {
            int counterCh = 0;
            int colCh = -1;
            for (int i = 0; i < mass.GetUpperBound(1)+1; i++) {
                if (mass[0,i] % 2 == 0) {
                    counterCh++;
                }
                if (counterCh == 2) { 
                    colCh = i;
                    break;
                }
            }

            int colNeg = -1;
            for (int i = mass.GetUpperBound(1); i >= 0; i--) {
                if (mass[0, i] < 0) {
                    colNeg = i;
                    break;
                }
            }

            switchCols(colCh, colNeg);

            Console.WriteLine();
            Mass.printMass(mass);
            Console.ReadLine();
        }

        public void swithCols2() {
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int maxCol = -1, minCol = -1;
            for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                for (int j = 0; j < mass.GetUpperBound(1)+1; j++) {
                    if (mass[i, j] >= max & mass[i, j] % 2 != 0) {
                        max = mass[i, j];
                        maxCol = j;
                    }
                    if (mass[i, j] <= min & mass[i, j] % 2 == 0) {
                        min = mass[i, j];
                        minCol = j;
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Максимальное: " + max + " (" + maxCol + ")");
            Console.Write(" Минимальное: " + min + " (" + minCol + ")");
            
            switchCols(minCol, maxCol);

            Console.WriteLine();
            Mass.printMass(mass);
            Console.ReadLine();
        }
    }
}