using System.IO;
using System;

namespace TUBES_2
{
    public class Masukan
    {
        int[,] mjembatan;
        string[,] question;

        int inc, inc2;

        public Masukan(){
            mjembatan = new int[1,1];
            question = new string[1,1];
            inc = 0;
            inc2 = 0;
        }

        private T[,] ResizeArray<T>(T[,] original, int rows, int cols)
        {
            var newArray = new T[rows,cols];
            int minRows = Math.Min(rows, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            for(int i = 0; i < minRows; i++)
                for(int j = 0; j < minCols; j++)
                newArray[i, j] = original[i, j];
            return newArray;
        }

        public void inputFromFileQuestion(string file2){
            //Pass the file path and file name to the StreamReader constructor
            try{
                StreamReader sr2 = new StreamReader(file2);

                //Read the first line of text
                string line2 = sr2.ReadLine();
                inc2 = Convert.ToInt32(line2);

                string[] parts2;
                question = ResizeArray<string>(question, inc2+1, 4);

                line2 = sr2.ReadLine();
                for(int i=0; i<inc2; i++){
                    parts2 = line2.Split(' ');
                    question[i,0] = parts2[0];
                    question[i,1] = parts2[1];
                    question[i,2] = parts2[2];

                    line2 = sr2.ReadLine();
                }


                //close the file
                sr2.Close();
            }
            catch(Exception e){
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void inputFromFileJembatan(string file1){
            try {
                StreamReader sr = new StreamReader(file1);

                string line = sr.ReadLine();
                inc = Convert.ToInt32(line);

                string[] parts;
                mjembatan = ResizeArray<int>(mjembatan, inc+2, inc+2);

                for(int i=0; i<inc; i++){ //initializing mjembatan with 0
                    for(int j=0; j<inc; j++){
                        mjembatan[i,j] = 0;
                    }
                }

                //Continue to read until you reach end of file
                while((line = sr.ReadLine()) != null) {
                    parts = line.Split(' ');
                    int a = Convert.ToInt32(parts[0]);
                    int b = Convert.ToInt32(parts[1]);

                    mjembatan[a,b] = 1;
                }
                
                //close the file
                sr.Close();
            }
            catch(Exception e){
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Printjembatan(){
            for(int i=1; i<=inc; i++){
                for(int j=1; j<=inc; j++){
                    if(mjembatan[i,j] == 1){
                        Console.Write("jembatan");
                        Console.Write(i);
                        Console.Write("-");
                        Console.WriteLine(j);
                    }
                }
            }
        }

        public void PrintQuestion(){
            for(int i=0; i<inc2; i++){
                Console.Write(question[i,0]);
                Console.Write(" ");
                Console.Write(question[i,1]);
                Console.Write(" ");
                Console.WriteLine(question[i,2]);
            }
        }

    }

    public class Test{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name with extention (bridge than question):");
            string file1 = Console.ReadLine();
            string file2 = Console.ReadLine();

            Masukan inputt = new Masukan();
            inputt.inputFromFileJembatan(file1);
            inputt.inputFromFileQuestion(file2);
            inputt.PrintQuestion();
            inputt.Printjembatan();

        }
    }
}
