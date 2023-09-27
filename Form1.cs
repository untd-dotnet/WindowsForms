using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApps
{
    /*public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)  
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            label1.Text = "File being processed ..pls wait";
            int count =await task;
            label1.Text = "No. of characters in file: " + count.ToString();
        }
        private int CountCharacters() {
            int count = 0;
            StreamReader streamReader = new StreamReader(@"C:\Users\nsreevani\Desktop\training\test.txt");
            string content = streamReader.ReadToEnd();
            count = content.Length;
            //Thread.Sleep(5000);
            Task.Delay(3000).Wait();
            return count;
        }
    }*/


    /*public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread th = new Thread(() => { count = CountCharacters(); });
            th.Start();
            label1.Text = "File being processed ..pls wait";
            th.Join(); // blocks IO 
            label1.Text = "No. of characters in file: " + count.ToString();
        }
        private int CountCharacters()
        {
            int count = 0;
            StreamReader streamReader = new StreamReader(@"C:\Users\nsreevani\Desktop\training\test.txt");
            string content = streamReader.ReadToEnd();
            count = content.Length;
            Thread.Sleep(5000); 
            return count;
        }
    }*/


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread th = new Thread(() => { 
                count = CountCharacters();
                //Prop created by main thread modified by worker thread -- avoid
                label1.Text = "No. of characters in file: " + count.ToString();
            });
            th.Start();
            label1.Text = "File being processed ..pls wait";
        }
        private int CountCharacters()
        {
            int count = 0;
            StreamReader streamReader = new StreamReader(@"C:\Users\nsreevani\Desktop\training\test.txt");
            string content = streamReader.ReadToEnd();
            count = content.Length;
            Thread.Sleep(5000);
            return count;
        }
    }
    }
