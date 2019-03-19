using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Glee.Drawing;

namespace Kingdom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FirstPanel.BringToFront();
        }

        static Graph Graph = new Graph("graph");
        static Masukan X = new Masukan();
        Form GraphForm = new Form2();
        static Microsoft.Glee.GraphViewerGdi.GViewer Viewer = new Microsoft.Glee.GraphViewerGdi.GViewer();
  
        private void GraphButt_Click(object sender, EventArgs e)
        {
            if (InputGraph.Text != "")
            {
                X.inputFromFileJembatan(InputGraph.Text);

                StreamReader file = new StreamReader(@InputGraph.Text);
                string N = file.ReadLine();
                int n = Int32.Parse(N);
                for (int i = 1; i <= n - 1; i++)
                {
                    string[] s = file.ReadLine().Split();
                    Edge E = Graph.AddEdge(s[0], s[1]);
                    E.Attr.ArrowHeadAtTarget = ArrowStyle.None;
                }

                Viewer.Graph = Graph;
                Viewer.Dock = DockStyle.Fill;
                GraphForm.Controls.Add(Viewer);
                GraphForm.Show();
                InputQuestPanel.BringToFront();
            } else
            {
                MessageBox.Show("Input External First !");
            }
        }

        public String getGraphtxt()
        {
            return InputGraph.Text;
        }

        private void QuestEx_Click(object sender, EventArgs e)
        {
            ExternalQuestPanel.BringToFront();
        }

        private void BrowseGraph_Click(object sender, EventArgs e)
        {
            DialogResult validate = this.openFileDialogV.ShowDialog();
            if (validate == DialogResult.OK)
            {
                this.InputGraph.Text = this.openFileDialogV.FileName;
            }
        }

        private void BrowseInput_Click(object sender, EventArgs e)
        {
            DialogResult validate = this.openFileDialogV.ShowDialog();
            if (validate == DialogResult.OK)
            {
                this.InputQuestEx.Text = this.openFileDialogV.FileName;
            }
        }


        static Hide_n_Seek H;


        public void matrixReady()
        {
            H = new Hide_n_Seek(X.getinc());
            for (int i = 1; i < X.getinc() + 1; i++)
            {
                for (int j = 1; j < X.getinc() + 1; j++)
                {
                    if (X.getJembatan(i, j) == 1)
                    {
                        //nputNonEx.Text += i + " " + j + "";
                        H.map.makeNeighbors(i - 1, j - 1);
                        //InputNonEx.Text += H.map.neighbor[0,0];
                    }
                }
            }
            Check c = new Check();
            for (int i = 1; i <= X.getinc(); i++)
            {
                H.findLevel(1, i, 1, c);
                c.setFound(false);
            }
        }


        private void FindButtonEx_Click(object sender, EventArgs e)
        {
            if (InputQuestEx.Text == "")
            {
                MessageBox.Show("Please input file First !");
            }
            else
            {
                matrixReady();
                Console.WriteLine(InputQuestEx.Text);
                string[] S = InputQuestEx.Text.Split('\\');
                Console.WriteLine(S[0]);
                Console.WriteLine(S[S.Length - 1]);
                X.inputFromFileQuestion(S[S.Length-1]);
                Console.WriteLine(X.getinc2());
                Solution[] Solutions = new Solution[X.getinc2()];
                for (int i = 0; i < X.getinc2(); i++)
                {
                    Console.WriteLine("Test Dong !" + i + " \n");
                    Check c = new Check();
                    Solution s = new Solution();
                    H.Trace(X.getquestion(i, 0), X.getquestion(i, 1), X.getquestion(i, 2), c, s);
                    if (c.getFound())
                    {
                        X.setQuestion(i, 3, 1);
                    }
                    else
                    {
                        X.setQuestion(i, 3, 0);
                        s.Add('-');
                    }
                    Solutions[i] = s;
                }
                for (int i = 0; i < X.getinc2(); i++)
                {
                    Ways.Text += i + 1 + " .";
                    for (int j = 0; j <= 2; j++)
                    {
                        Ways.Text += X.getquestion(i, j) + " ";
                    }
                    Ways.Text += " - ";
                    if (X.getquestion(i, 3) == 1)
                    {
                        
                        Ways.Text += "YES, Route : ";
                        for(int j = 0; j < Solutions[i].getLength() - 1; j++)
                        {
                            Ways.Text += Solutions[i].getElement(j) + " - ";

                        }
                        Ways.Text += Solutions[i].getElement(Solutions[i].getLength()-1) + "\n";
                    }
                    else
                    {
                        Ways.Text += "NO ROUTE MAN !\n";
                    }
                }

                AnswerPanel.BringToFront();
            }
        }

        private void FindButtonNonEx_Click(object sender, EventArgs e)
        {
            //InputNonEx.Text = "Plis muncul";
            if (InputNonEx.Text == "")
            {
                MessageBox.Show("Please Input Some Question(s)");
            } else
            {
                matrixReady();
                String[] s = InputNonEx.Text.Split('\n');
                int[,] ques = new int[s.Length, s[0].Length];
                for (int i =0; i < s.Length; i++)
                {
                    if (s[i] != "")
                    {
                        Console.WriteLine("Isinya itu : " + s[i]);
                        String[] y = s[i].Split(' ');
                        for (int j = 0; j < y.Length; j++)
                        {
                            ques[i, j] = Convert.ToInt32(y[j]);
                            Console.WriteLine(i + " , " + j + ques[i, j]);
                        }
                    }                   
                }
                Solution[] Solutions = new Solution[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != "")
                    {
                        Check c = new Check();
                        Solution S = new Solution();
                        H.Trace(ques[i, 0], ques[i, 1], ques[i, 2], c, S);
                        if (c.getFound())
                        {
                            ques[i, 3] = 1;
                        }
                        else
                        {
                            ques[i, 3] = 0;
                            S.Add('-');
                        }
                        Solutions[i] = S;
                    }
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != "")
                    {

                        Ways.Text += i + 1 + " .";
                        for (int j = 0; j <= 2; j++)
                        {
                            Ways.Text += ques[i, j] + " ";
                        }
                        Ways.Text += " - ";
                        if (ques[i, 3] == 1)
                        {
                            Ways.Text += "YES, Route : ";
                            for (int j = 0; j < Solutions[i].getLength() - 1; j++)
                            {
                                Ways.Text += Solutions[i].getElement(j) + " - ";

                            }
                            Ways.Text += Solutions[i].getElement(Solutions[i].getLength() - 1) + "\n";
                        }
                        else
                        {
                            Ways.Text += "NO ROUTE MAN !\n";
                        }
                    }
                }
                AnswerPanel.BringToFront();
            }
        }



        public String getInputNonEx()
        {
            return InputNonEx.Text;
        }

        public int getTotalInputNonEx()
        {
            String[] x = InputNonEx.Text.Split('\n');
            return x.Length;
        }

        private void Question_Click(object sender, EventArgs e)
        {
            InputNonEx.Text = "";
            InputQuestEx.Text = "";
            Ways.Text = "";
            InputQuestPanel.BringToFront();
        }

        private void Map_Click(object sender, EventArgs e)
        {
            InputGraph.Text = "";
            InputNonEx.Text = "";
            InputQuestEx.Text = "";
            Ways.Text = "";
            FirstPanel.BringToFront();
        }

        private void InputQuest_Click(object sender, EventArgs e)
        {
            InputQuestType.BringToFront();
        }

    }
}
