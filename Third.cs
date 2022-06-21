using System;

namespace third {
    class Third {
        int[,] mass;
        public Third() {
            mass = Mass.massive(mass);
        }
        public void sortMaxRow() {
            int max = Int32.MinValue;
            int maxCol = -1;
            for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                for (int j = 0; j < mass.GetUpperBound(1)+1; j++) {
                    if (mass[i, j] >= max) {
                        max = mass[i,j];
                        maxCol = j;
                    }
                }
            }

            int[] massMaxCol = new int[mass.GetUpperBound(0)+1];
            for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                massMaxCol[i] = mass[i, maxCol];
            }

            bool need = true;
            while (need) {
                need = false;
                for (int i = 0; i < massMaxCol.Length-1; i++) {
                    if (massMaxCol[i] > massMaxCol[i + 1]) {
                        int temp = massMaxCol[i];
                        massMaxCol[i] = massMaxCol[i+1];
                        massMaxCol[i+1] = temp;

                        for (int m = 0; m < mass.GetUpperBound(1)+1; m++) {
                            int temp1 = mass[i, m];
                            mass[i, m] = mass[i+1, m];
                            mass[i+1, m] = temp1;
                        }
                        need = true;
                    }
                }
            }

            Console.WriteLine();
            Mass.printMass(mass);
            Console.ReadLine();
        }

        public void sortMinRow() {
            int min = Int32.MaxValue;
            int minCol = -1;
            for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                for (int j = 0; j < mass.GetUpperBound(1)+1; j++) {
                    if (mass[i, j] <= min) {
                        min = mass[i,j];
                        minCol = j;
                    }
                }
            }

            int[] massMinCol = new int[mass.GetUpperBound(0)+1];
            for (int i = 0; i < mass.GetUpperBound(0)+1; i++) {
                massMinCol[i] = mass[i, minCol];
            }

            bool need = true;
            while (need) {
                need = false;
                for (int i = 0; i < massMinCol.Length-1; i++) {
                    if (massMinCol[i] < massMinCol[i + 1]) {
                        int temp = massMinCol[i];
                        massMinCol[i] = massMinCol[i+1];
                        massMinCol[i+1] = temp;

                        for (int m = 0; m < mass.GetUpperBound(1)+1; m++) {
                            int temp1 = mass[i, m];
                            mass[i, m] = mass[i+1, m];
                            mass[i+1, m] = temp1;
                        }
                        need = true;
                    }
                }
            }

            Console.WriteLine();
            Mass.printMass(mass);
            Console.ReadLine();
        }
    }
}