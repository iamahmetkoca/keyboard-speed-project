using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace keyboard_speed
{
    public partial class Form1 : Form
    {
        int counter, truewords=0, wrongwords=0;
        Random r = new Random();
        string[] words = {
"about",
"all",
"also",
"and",
"as",
"at",
"be",
"because",
"but",
"by",
"can",
"come",
"could",
"day",
"do",
"even",
"find",
"first",
"for",
"from",
"get",
"give",
"go",
"have",
"he",
"her",
"here",
"him",
"his",
"how",
"if",
"in",
"into",
"it",
"its",
"just",
"know",
"like",
"look",
"make",
"man",
"many",
"me",
"more",
"my",
"new",
"no",
"not",
"now",
"of",
"on",
"one",
"only",
"or",
"other",
"our",
"out",
"people",
"say",
"see",
"she",
"so",
"some",
"take",
"tell",
"than",
"that",
"the",
"their",
"them",
"then",
"there",
"these",
"they",
"thing",
"think",
"this",
"those",
"time",
"to",
"two",
"up",
"use",
"very",
"want",
"way",
"we",
"well",
"what",
"when",
"which",
"who",
"will",
"with",
"would",
"year",
"you",
"your"
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible= true;
            lblCounter.Visible=true;
            textBox1.Visible=true;
            button1.Visible = false;
            textBox1.Focus();
            timer1.Enabled = true;     
            
            
            int no = r.Next(0, words.Length);
            label1.Text = words[no];


        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label1.Text)
            {
                truewords++;
                int no = r.Next(0, words.Length);
                label1.Text = words[no];
            }

            else
            {
                wrongwords++;
                int no = r.Next(0, words.Length);
                label1.Text = words[no];
            }
            lblCorrect.Text = truewords.ToString();
            lblWrong.Text = wrongwords.ToString();
            textBox1.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            groupBox1.ForeColor= Color.White;
            groupBox2.ForeColor= Color.White;
            label1.ForeColor= Color.White;
            lblCounter.ForeColor= Color.White;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            groupBox1.ForeColor = Color.Black;
            groupBox2.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            lblCounter.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled= false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            lblCounter.Text = counter.ToString();
            if (counter == 60) 
            {
                MessageBox.Show("Congratulations, correct word count in 60 seconds: "+truewords, "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
