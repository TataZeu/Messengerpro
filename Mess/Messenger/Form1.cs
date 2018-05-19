using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int lenght;
        int count = 0;
        string hi;
      
        StreamReader sr = new StreamReader("Data.in.txt");
        StreamWriter sw = new StreamWriter("Data.out.txt");

      

        public Form1()
        {
            InitializeComponent();
        }

        private void Maria_Click(object sender, EventArgs e)
        {

            //  cod = 0;
            hi = "Maria:" + RichBoxText2.Text;

            if (count == 0)
            {
                lenght = RichBoxText1.TextLength;

                RichBoxText1.Text = hi;
                count++;
            }
            else
            {
                lenght = RichBoxText1.TextLength + 1;
                
                RichBoxText1.Text = RichBoxText1.Text +"\n"+ hi;
            }

           
            RichBoxText1.Select(lenght, hi.Length); 
            RichBoxText1.SelectionColor = Color.Red;
           

        }

        private void Ionel_Click(object sender, EventArgs e)
        {

            hi = "Ionel:" + RichBoxText2.Text;
            if (count == 0)
            {
                lenght = RichBoxText1.TextLength;
                
                RichBoxText1.Text = hi;
                count++;
            }
            else
            {
                lenght = RichBoxText1.TextLength + 1; 
                
                RichBoxText1.Text = RichBoxText1.Text +"\n"+ hi;
            }

            

             RichBoxText1.Select(lenght, hi.Length);
             RichBoxText1.SelectionColor = Color.Blue;
           
             
                

        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            RichBoxText1.Text = "";
            count = 0;
        }

        private void Salvare_Click(object sender, EventArgs e)
        { 
            
            hi = RichBoxText1.Text;
            sw.Write(hi);
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void Incarca_Click(object sender, EventArgs e)
        {
            RichBoxText1.Text = "";
            hi = sr.ReadToEnd();
            RichBoxText1.Text = hi;
        }

        
    }
}
