using System;

namespace third {
    class Second {
        int[,] mass;
        public Second() {
            mass = Mass.massive(mass);
        }

        int[,] ResizeArray(int[,] arr, int[] newSizes) {
            if (newSizes.Length != arr.Rank) {
                throw new ArgumentException("arr must have the same number of dimensions " +
                                            "as there are elements in newSizes", "newSizes");
            }

            var temp = Array.CreateInstance(arr.GetType().GetElementType(), newSizes);
            int length = arr.Length <= temp.Length ? arr.Length : temp.Length;
            Array.ConstrainedCopy(arr, 0, temp, 0, length);
            return (int[,])temp;
        }

        public void doubleMaxRow() {
            int max = 0;
            int[] maxRow = new int[mass.GetUpperBound(1)+1];
            for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                for (int j = 0; j < mass.GetUpperBound(1)+1; j++) {
                    if (mass[i,j] >= max) {
                        max = mass[i,j];
                        for (int k = 0; k < maxRow.Length; k++) {
                            maxRow[k] = mass[i,k];
                        }
                    }
                }
            }

            for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                for (int j = 0; j < mass.GetUpperBound(1)+1; j++) {
                    if (mass[i,j] < 0 & mass[i,j] % 2 != 0) {
                        mass = ResizeArray(mass, new int[] {mass.GetUpperBound(0)+2, mass.GetUpperBound(1)+1});
                        for (int k = mass.GetUpperBound(0)-1; k >= i; k--) {
                            for (int m = 0; m < mass.GetUpperBound(1)+1; m++) {
                                mass[k+1,m] = mass[k,m];
                            }
                        }
                        for (int k = 0; k < mass.GetUpperBound(1)+1; k++) {
                            mass[i+1, k] = maxRow[k];
                        }
                        i++;
                        break;
                    }
                }
            }

            Console.WriteLine();
            Mass.printMass(mass);
            Console.ReadLine();
        }

        public void delMinRow() {
            int min = 0;
            int minCol = -1;
            for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                for (int j = 0; j < mass.GetUpperBound(1)+1; j++) {
                    if (mass[i, j] <= min & mass[i, j] < 0) {
                        min = mass[i,j];
                        minCol = j;
                    }
                }
            }

            if (minCol != -1) {
                for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                    for (int j = 0; j < mass.GetUpperBound(1); j++) {
                        if (j >= minCol) {
                            mass[i, j] = mass[i, j+1];
                        }
                    }
                }
                Console.WriteLine();
                Mass.printMass(mass);
                mass = ResizeArray(mass, new int[] {mass.GetUpperBound(0)+1, mass.GetUpperBound(1)});
            }
            
            Console.WriteLine();
            Mass.printMass(mass);
            Console.ReadLine();
        }
    }
}