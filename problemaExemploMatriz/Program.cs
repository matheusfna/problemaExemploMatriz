using System;

namespace problemaExemploMatriz {
    class URI {
        static void Main(string[] args) {


            int m, n; 
            int[,] a;

            string[] s1 = Console.ReadLine().Split(' ');
            m = int.Parse(s1[0]);
            n = int.Parse(s1[1]);
            a = new int[m,n];


            for(int i = 0; i < m; i++) {
            string[] vet = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++) {
                    a[i,j] = int.Parse(vet[j]);
                }
            }

            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n;  j++) {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}



