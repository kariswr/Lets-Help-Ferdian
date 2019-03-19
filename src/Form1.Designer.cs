namespace Kingdom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogV = new System.Windows.Forms.OpenFileDialog();
            this.InputQuestType = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.FindNonEx = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InputNonEx = new System.Windows.Forms.RichTextBox();
            this.AnswerPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Map = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Button();
            this.Ways = new System.Windows.Forms.RichTextBox();
            this.Answer = new System.Windows.Forms.Label();
            this.InputQuestPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InputQuest = new System.Windows.Forms.Button();
            this.QuestEx = new System.Windows.Forms.Button();
            this.ExternalQuestPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseInput = new System.Windows.Forms.Button();
            this.FindButtonEx = new System.Windows.Forms.Button();
            this.InputQuestEx = new System.Windows.Forms.TextBox();
            this.ExQuest = new System.Windows.Forms.Label();
            this.FirstPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GraphButt = new System.Windows.Forms.Button();
            this.InputGraph = new System.Windows.Forms.TextBox();
            this.InputEx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InputQuestType.SuspendLayout();
            this.AnswerPanel.SuspendLayout();
            this.InputQuestPanel.SuspendLayout();
            this.ExternalQuestPanel.SuspendLayout();
            this.FirstPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogV
            // 
            this.openFileDialogV.FileName = "openFileDialog1";
            this.openFileDialogV.Filter = "Text files|*.txt";
            // 
            // InputQuestType
            // 
            this.InputQuestType.BackgroundImage = global::Kingdom.Properties.Resources.abstract_art_black_background_1040499;
            this.InputQuestType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InputQuestType.Controls.Add(this.label6);
            this.InputQuestType.Controls.Add(this.FindNonEx);
            this.InputQuestType.Controls.Add(this.label2);
            this.InputQuestType.Controls.Add(this.InputNonEx);
            this.InputQuestType.Location = new System.Drawing.Point(0, 0);
            this.InputQuestType.Name = "InputQuestType";
            this.InputQuestType.Size = new System.Drawing.Size(906, 606);
            this.InputQuestType.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Harlow Solid Italic", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(148, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(609, 126);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hide N Seek";
            // 
            // FindNonEx
            // 
            this.FindNonEx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FindNonEx.Location = new System.Drawing.Point(398, 480);
            this.FindNonEx.Name = "FindNonEx";
            this.FindNonEx.Size = new System.Drawing.Size(132, 57);
            this.FindNonEx.TabIndex = 2;
            this.FindNonEx.Text = "Find Jose !";
            this.FindNonEx.UseVisualStyleBackColor = false;
            this.FindNonEx.Click += new System.EventHandler(this.FindButtonNonEx_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(315, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Questions :";
            // 
            // InputNonEx
            // 
            this.InputNonEx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InputNonEx.Location = new System.Drawing.Point(320, 297);
            this.InputNonEx.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.InputNonEx.Name = "InputNonEx";
            this.InputNonEx.Size = new System.Drawing.Size(279, 154);
            this.InputNonEx.TabIndex = 0;
            this.InputNonEx.Text = "";
            this.InputNonEx.WordWrap = false;
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.BackgroundImage = global::Kingdom.Properties.Resources.dmitry_ratushny_64773_unsplash;
            this.AnswerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnswerPanel.Controls.Add(this.label8);
            this.AnswerPanel.Controls.Add(this.Map);
            this.AnswerPanel.Controls.Add(this.Question);
            this.AnswerPanel.Controls.Add(this.Ways);
            this.AnswerPanel.Controls.Add(this.Answer);
            this.AnswerPanel.Location = new System.Drawing.Point(0, 2);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.Size = new System.Drawing.Size(907, 603);
            this.AnswerPanel.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Harlow Solid Italic", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(148, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(609, 126);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hide N Seek";
            // 
            // Map
            // 
            this.Map.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Map.Location = new System.Drawing.Point(491, 525);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(178, 43);
            this.Map.TabIndex = 4;
            this.Map.Text = "Change Map";
            this.Map.UseVisualStyleBackColor = false;
            this.Map.Click += new System.EventHandler(this.Map_Click);
            // 
            // Question
            // 
            this.Question.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Question.Location = new System.Drawing.Point(239, 526);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(178, 43);
            this.Question.TabIndex = 3;
            this.Question.Text = "Change Question";
            this.Question.UseVisualStyleBackColor = false;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // Ways
            // 
            this.Ways.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Ways.Location = new System.Drawing.Point(283, 255);
            this.Ways.Name = "Ways";
            this.Ways.ReadOnly = true;
            this.Ways.Size = new System.Drawing.Size(338, 230);
            this.Ways.TabIndex = 2;
            this.Ways.Text = "";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.BackColor = System.Drawing.Color.Transparent;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Answer.Location = new System.Drawing.Point(369, 200);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(157, 40);
            this.Answer.TabIndex = 0;
            this.Answer.Text = "Answer :";
            // 
            // InputQuestPanel
            // 
            this.InputQuestPanel.BackgroundImage = global::Kingdom.Properties.Resources.abstract_art_black_background_1040499;
            this.InputQuestPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InputQuestPanel.Controls.Add(this.label5);
            this.InputQuestPanel.Controls.Add(this.label1);
            this.InputQuestPanel.Controls.Add(this.InputQuest);
            this.InputQuestPanel.Controls.Add(this.QuestEx);
            this.InputQuestPanel.Location = new System.Drawing.Point(0, 2);
            this.InputQuestPanel.Name = "InputQuestPanel";
            this.InputQuestPanel.Size = new System.Drawing.Size(905, 603);
            this.InputQuestPanel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Harlow Solid Italic", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(148, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(609, 126);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hide N Seek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(93, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "How would you like to put your Question(s) ?";
            // 
            // InputQuest
            // 
            this.InputQuest.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InputQuest.Location = new System.Drawing.Point(520, 335);
            this.InputQuest.Name = "InputQuest";
            this.InputQuest.Size = new System.Drawing.Size(186, 75);
            this.InputQuest.TabIndex = 3;
            this.InputQuest.Text = "I\'ll type em ";
            this.InputQuest.UseVisualStyleBackColor = false;
            this.InputQuest.Click += new System.EventHandler(this.InputQuest_Click);
            // 
            // QuestEx
            // 
            this.QuestEx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.QuestEx.Location = new System.Drawing.Point(196, 333);
            this.QuestEx.Name = "QuestEx";
            this.QuestEx.Size = new System.Drawing.Size(186, 75);
            this.QuestEx.TabIndex = 0;
            this.QuestEx.Text = "External File";
            this.QuestEx.UseVisualStyleBackColor = false;
            this.QuestEx.Click += new System.EventHandler(this.QuestEx_Click);
            // 
            // ExternalQuestPanel
            // 
            this.ExternalQuestPanel.BackgroundImage = global::Kingdom.Properties.Resources.abstract_art_black_background_1040499;
            this.ExternalQuestPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExternalQuestPanel.Controls.Add(this.label4);
            this.ExternalQuestPanel.Controls.Add(this.BrowseInput);
            this.ExternalQuestPanel.Controls.Add(this.FindButtonEx);
            this.ExternalQuestPanel.Controls.Add(this.InputQuestEx);
            this.ExternalQuestPanel.Controls.Add(this.ExQuest);
            this.ExternalQuestPanel.Location = new System.Drawing.Point(0, 2);
            this.ExternalQuestPanel.Name = "ExternalQuestPanel";
            this.ExternalQuestPanel.Size = new System.Drawing.Size(905, 603);
            this.ExternalQuestPanel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(148, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(609, 126);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hide N Seek";
            // 
            // BrowseInput
            // 
            this.BrowseInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BrowseInput.Location = new System.Drawing.Point(622, 343);
            this.BrowseInput.Name = "BrowseInput";
            this.BrowseInput.Size = new System.Drawing.Size(130, 40);
            this.BrowseInput.TabIndex = 3;
            this.BrowseInput.Text = "Browse";
            this.BrowseInput.UseVisualStyleBackColor = false;
            this.BrowseInput.Click += new System.EventHandler(this.BrowseInput_Click);
            // 
            // FindButtonEx
            // 
            this.FindButtonEx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FindButtonEx.Location = new System.Drawing.Point(398, 433);
            this.FindButtonEx.Name = "FindButtonEx";
            this.FindButtonEx.Size = new System.Drawing.Size(144, 54);
            this.FindButtonEx.TabIndex = 2;
            this.FindButtonEx.Text = "Find Jose !";
            this.FindButtonEx.UseVisualStyleBackColor = false;
            this.FindButtonEx.Click += new System.EventHandler(this.FindButtonEx_Click);
            // 
            // InputQuestEx
            // 
            this.InputQuestEx.Location = new System.Drawing.Point(256, 347);
            this.InputQuestEx.Name = "InputQuestEx";
            this.InputQuestEx.Size = new System.Drawing.Size(338, 26);
            this.InputQuestEx.TabIndex = 1;
            // 
            // ExQuest
            // 
            this.ExQuest.AutoSize = true;
            this.ExQuest.BackColor = System.Drawing.Color.Transparent;
            this.ExQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExQuest.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ExQuest.Location = new System.Drawing.Point(35, 259);
            this.ExQuest.Name = "ExQuest";
            this.ExQuest.Size = new System.Drawing.Size(838, 40);
            this.ExQuest.TabIndex = 0;
            this.ExQuest.Text = "Input the name of question external file name (.txt) :";
            // 
            // FirstPanel
            // 
            this.FirstPanel.BackgroundImage = global::Kingdom.Properties.Resources.abstract_art_black_background_1040499;
            this.FirstPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirstPanel.Controls.Add(this.label7);
            this.FirstPanel.Controls.Add(this.label3);
            this.FirstPanel.Controls.Add(this.button1);
            this.FirstPanel.Controls.Add(this.GraphButt);
            this.FirstPanel.Controls.Add(this.InputGraph);
            this.FirstPanel.Controls.Add(this.InputEx);
            this.FirstPanel.Location = new System.Drawing.Point(0, 0);
            this.FirstPanel.Name = "FirstPanel";
            this.FirstPanel.Size = new System.Drawing.Size(907, 606);
            this.FirstPanel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(148, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 126);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hide N Seek";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(633, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BrowseGraph_Click);
            // 
            // GraphButt
            // 
            this.GraphButt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GraphButt.Location = new System.Drawing.Point(388, 403);
            this.GraphButt.Name = "GraphButt";
            this.GraphButt.Size = new System.Drawing.Size(138, 64);
            this.GraphButt.TabIndex = 3;
            this.GraphButt.Text = "Let\'s Graph !";
            this.GraphButt.UseVisualStyleBackColor = false;
            this.GraphButt.Click += new System.EventHandler(this.GraphButt_Click);
            // 
            // InputGraph
            // 
            this.InputGraph.Location = new System.Drawing.Point(206, 341);
            this.InputGraph.Name = "InputGraph";
            this.InputGraph.Size = new System.Drawing.Size(410, 26);
            this.InputGraph.TabIndex = 2;
            // 
            // InputEx
            // 
            this.InputEx.AutoSize = true;
            this.InputEx.BackColor = System.Drawing.Color.Transparent;
            this.InputEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEx.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.InputEx.Location = new System.Drawing.Point(153, 259);
            this.InputEx.Name = "InputEx";
            this.InputEx.Size = new System.Drawing.Size(612, 40);
            this.InputEx.TabIndex = 1;
            this.InputEx.Text = "Input the name of graph external file :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Harlow Solid Italic", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(149, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 126);
            this.label7.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 607);
            this.Controls.Add(this.FirstPanel);
            this.Controls.Add(this.ExternalQuestPanel);
            this.Controls.Add(this.InputQuestPanel);
            this.Controls.Add(this.InputQuestType);
            this.Controls.Add(this.AnswerPanel);
            this.Name = "Form1";
            this.Text = "HideAndSeek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputQuestType.ResumeLayout(false);
            this.InputQuestType.PerformLayout();
            this.AnswerPanel.ResumeLayout(false);
            this.AnswerPanel.PerformLayout();
            this.InputQuestPanel.ResumeLayout(false);
            this.InputQuestPanel.PerformLayout();
            this.ExternalQuestPanel.ResumeLayout(false);
            this.ExternalQuestPanel.PerformLayout();
            this.FirstPanel.ResumeLayout(false);
            this.FirstPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogV;
        private System.Windows.Forms.Panel InputQuestType;
        private System.Windows.Forms.Button FindNonEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox InputNonEx;
        private System.Windows.Forms.Panel AnswerPanel;
        private System.Windows.Forms.Button Map;
        private System.Windows.Forms.Button Question;
        private System.Windows.Forms.RichTextBox Ways;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Panel FirstPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GraphButt;
        private System.Windows.Forms.TextBox InputGraph;
        private System.Windows.Forms.Label InputEx;
        private System.Windows.Forms.Panel InputQuestPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InputQuest;
        private System.Windows.Forms.Button QuestEx;
        private System.Windows.Forms.Panel ExternalQuestPanel;
        private System.Windows.Forms.Button BrowseInput;
        private System.Windows.Forms.Button FindButtonEx;
        private System.Windows.Forms.TextBox InputQuestEx;
        private System.Windows.Forms.Label ExQuest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

