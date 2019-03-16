using System;

namespace Kingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jumlah Rumah : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Hide_n_Seek H = new Hide_n_Seek(n);
            for(int i = 0; i < n-1; i++) {
                string line = Console.ReadLine();
                string[] s = line.Split(new char[] {' '});
                int[] input = new int [2];
                for(int j = 0; j < 2; j++) {
                    input[j] = Convert.ToInt32(s[j]);
                }
                H.map.makeNeighbors(input[0]-1,input[1]-1);
            }
            for(int i = 1; i <= n; i++) {
                H.findLevel(1,i,1);
            }
            Console.WriteLine("Level Tiap Rumah : ");
            for(int i = 0; i < n-1; i++) {
                Console.Write(H.map.getLevel(i) + " ");
            }
            Console.WriteLine("Matriks Ketetanggaan : ");
            Console.WriteLine(H.map.getLevel(n-1));
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n-1; j++) {
                    Console.Write(H.map.getNeighbors(i,j) + " "); 
                }
                Console.WriteLine(H.map.getNeighbors(i,n-1));
            }
            Console.Write("Jumlah Pertanyaan : ");
            int p = Convert.ToInt32(Console.ReadLine());
            int[,] question = new int [p,4];
            Console.WriteLine("Masukkan Pertanyaan : ");
            for(int i = 0; i < p; i++) {
                string line = Console.ReadLine();
                string[] s = line.Split(new char[] {' '});
                for(int j = 0; j < 3; j++) {
                    question[i,j] = Convert.ToInt32(s[j]);
                }
            }
            for(int i = 0; i < p; i++) {
                Check c = new Check();
                H.Trace(question[i,0],question[i,1],question[i,2],c);
                if(c.getFound()) {
                    question[i,3] = 1;
                }
                else {
                    question[i,3] = 0;
                }
            }
            Console.WriteLine("Jawaban Pertanyaan : ");
            for(int i = 0; i < p; i++) {
                for(int j = 0; j < 3; j++) {
                    Console.Write(question[i,j] + " ");
                }
                Console.WriteLine(question[i,3]);
            }

        }
    }
}
