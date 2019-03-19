using System.IO;
using System;

namespace Kingdom
{
    class Masukan
    {
        int[,] mjembatan;
        int [,] question;

        public int inc, inc2;

        public Masukan(){
            mjembatan = new int[0,0];
            question = new int[0,0];
            inc = 0;
            inc2 = 0;
        }

        public int getJembatan(int i, int j){
            return mjembatan[i,j];
        }

        public int getinc(){
            return inc;
        }

        public int getinc2(){
            return inc2;
        }

        public int getquestion(int i, int j){
            return question[i,j];
        }
        public void setQuestion(int i, int j, int x){
            question[i,j] = x;
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
                question = ResizeArray<int>(question, inc2+1, 4);

                line2 = sr2.ReadLine();
                for(int i=0; i<inc2; i++){
                    parts2 = line2.Split(' ');
                    question[i,0] = Convert.ToInt32(parts2[0]);
                    question[i,1] = Convert.ToInt32(parts2[1]);
                    question[i,2] = Convert.ToInt32(parts2[2]);

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
                    mjembatan[b,a] = 1;
                }
                
                //close the file
                sr.Close();
            }
            catch(Exception e){
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}