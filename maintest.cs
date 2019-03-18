using System;

namespace Kingdom
{
    class maintest{
        static void Main(string[] args){
            Console.WriteLine("START");
            Console.Write("Enter file name with extention (bridge):");
            string file1 = Console.ReadLine();

            Console.Write("Question from : (1. File/2. Input) :");
            string choice = Console.ReadLine();

            if(choice == "1"){
                Console.WriteLine("Enter file name with extention (question):");
                string file2 = Console.ReadLine();

                Masukan inputt = new Masukan();
                inputt.inputFromFileJembatan(file1);
                inputt.inputFromFileQuestion(file2);

                Hide_n_Seek H = new Hide_n_Seek(inputt.getinc());
                
                // copy matrix mjembatan ke H.map
                for(int i = 1; i<inputt.getinc()+1; i++){
                    for(int j = 1; j<inputt.getinc()+1; j++){
                        if(inputt.getJembatan(i,j)==1){
                            H.map.makeNeighbors(i-1,j-1);
                        }
                    }
                }
                for(int i = 1; i <= inputt.getinc(); i++) {
                    H.findLevel(1,i,1);
                }

                Console.WriteLine("Level Tiap Rumah : ");
                for(int i = 0; i < inputt.getinc()-1; i++) {
                    Console.Write(H.map.getLevel(i) + " ");
                }
                Console.WriteLine("");

                Console.WriteLine("Matriks Ketetanggaan : ");
                //Console.WriteLine(H.map.getLevel(inputt.getinc()-1));
                for(int i = 0; i < inputt.getinc(); i++) {
                    for(int j = 0; j < inputt.getinc()-1; j++) {
                        Console.Write(H.map.getNeighbors(i,j) + " "); 
                    }
                    Console.WriteLine(H.map.getNeighbors(i,inputt.getinc()-1));
                }


                for(int i = 0; i < inputt.getinc2(); i++) {
                    Check c = new Check();
                    H.Trace(inputt.getquestion(i,0),inputt.getquestion(i,1),inputt.getquestion(i,2),c);
                    if(c.getFound()) {
                        inputt.setQuestion(i,3,1);
                    }
                    else {
                        inputt.setQuestion(i,3,0);
                    }
                }
                Console.WriteLine("Answer : ");
                for(int i = 0; i < inputt.getinc2(); i++) {
                    for(int j = 0; j < 3; j++) {
                        Console.Write(inputt.getquestion(i,j) + " ");
                    }
                    Console.WriteLine(inputt.getquestion(i,3));
                }
                
            } else if(choice == "2"){
                Masukan inputt = new Masukan();
                inputt.inputFromFileJembatan(file1);

                Hide_n_Seek H = new Hide_n_Seek(inputt.getinc());
                
                // copy matrix mjembatan ke H.map
                for(int i = 1; i<inputt.getinc()+1; i++){
                    for(int j = 1; j<inputt.getinc()+1; j++){
                        if(inputt.getJembatan(i,j)==1){
                            H.map.makeNeighbors(i-1,j-1);
                        }
                    }
                }
                for(int i = 1; i <= inputt.getinc(); i++) {
                    H.findLevel(1,i,1);
                }

                Console.WriteLine("Level Tiap Rumah : ");
                for(int i = 0; i < inputt.getinc()-1; i++) {
                    Console.Write(H.map.getLevel(i) + " ");
                }

                Console.WriteLine("");

                Console.WriteLine("Matriks Ketetanggaan : ");
                //Console.WriteLine(H.map.getLevel(inputt.getinc()-1));
                for(int i = 0; i < inputt.getinc(); i++) {
                    for(int j = 0; j < inputt.getinc()-1; j++) {
                        Console.Write(H.map.getNeighbors(i,j) + " "); 
                    }
                    Console.WriteLine(H.map.getNeighbors(i,inputt.getinc()-1));
                }

                Console.Write("Input how many question you want to ask");
                int p = Convert.ToInt32(Console.ReadLine());
                int[,] ques = new int [p,4];
                Console.WriteLine("Input your question : ");
                for(int i = 0; i < p; i++) {
                    string line = Console.ReadLine();
                    string[] s = line.Split(new char[] {' '});
                    for(int j = 0; j < 3; j++) {
                        ques[i,j] = Convert.ToInt32(s[j]);
                    }
                }

                for(int i = 0; i < p; i++) {
                    Check c = new Check();
                    H.Trace(ques[i,0],ques[i,1],ques[i,2],c);
                    if(c.getFound()) {
                        ques[i,3] = 1;
                    }
                    else {
                        ques[i,3] = 0;
                    }
                }
                Console.WriteLine("Answer : ");
                for(int i = 0; i < p; i++) {
                    for(int j = 0; j < 3; j++) {
                        Console.Write(ques[i,j] + " ");
                    }
                    Console.WriteLine(ques[i,3]);
                }

            } else{
                Console.WriteLine("Salah cuy");
            }
        } 
    }
}