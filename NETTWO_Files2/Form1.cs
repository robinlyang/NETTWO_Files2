using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NETTWO_Files2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {//save in Settings
            data d = new NETTWO_Files2.data();
            d.name = textBox1.Text;
            d.phone = textBox2.Text;
            d.Save();
        }

        private void read_Click(object sender, EventArgs e)
        {//read in Settings
            data d = new NETTWO_Files2.data();
            textBox1.Text = d.name;
            textBox2.Text = d.phone;
        }

        private void saveFile_Click(object sender, EventArgs e)
        {//save using a File Class
            string[] stuff = { textBox1.Text, textBox2.Text };
            File.WriteAllLines(@"C:\Users\ryang\Desktop\stuff.txt", stuff);
        }

        private void readFile_Click(object sender, EventArgs e)
        {
            string[] stuff = File.ReadAllLines(@"C:\Users\ryang\Desktop\stuff.dat");
            textBox1.Text = stuff[0];
            textBox2.Text = stuff[1];
        }

        private void saveRTF_Click(object sender, EventArgs e)
        {//save RTF
            richTextBox1.Text = textBox1.Text + "," + textBox2.Text;
            richTextBox1.SaveFile(@"C:\Users\ryang\Desktop\rtf.dat");
        }

        private void readRTF_Click(object sender, EventArgs e)
        {//read RTF
            richTextBox1.LoadFile(@"C:\Users\ryang\Desktop\rtf.dat");
            string[] data = richTextBox1.Text.Split(',');
            textBox1.Text = data[0];
            textBox2.Text = data[1];
        }

        private void saveSequential_Click(object sender, EventArgs e)
        {//save Sequential
            //before objects came along
            //open "c:\data\stuff.dat" for output as #1
            //write #1, x
            //write #1, y
            //close #1

            //now with .NET
            FileStream f = new FileStream(@"C:\Users\ryang\Desktop\seq.dat", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter w = new StreamWriter(f);
            w.WriteLine(textBox1.Text);
            w.WriteLine(textBox2.Text);
            w.Close();
            f.Close();
        }

        private void readSequential_Click(object sender, EventArgs e)
        {//read Sequential
            FileStream f = new FileStream(@"C:\Users\ryang\Desktop\seq.dat", FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(f);
            textBox1.Text = r.ReadLine();
            textBox2.Text = r.ReadLine();
            r.Close();
            f.Close();
        }

        private void sequentialCSV_Click(object sender, EventArgs e)
        {//write many csv records & read back
            string[] data = { "abc", "123", "xyz" };
            string record = string.Join(",", data); //creates string ready for csv file
            StreamWriter w = new StreamWriter(@"C:\Users\ryang\Desktop\demo.csv");  //one line StreamWriter destroys and recreates file
            w.WriteLine(record);
            w.WriteLine(record);
            w.Close();
            StreamReader r = new StreamReader(@"C:\Users\ryang\Desktop\demo.csv");
            while((record = r.ReadLine()) != null)
            {
                //pull apart csv record
                string[] stuff = record.Split(',');
                //now use stuff[0], stuff[1], etc.
            }
            r.Close();
        }

        private void sequentialFormatted_Click(object sender, EventArgs e)
        {//Sequential Formatted

        }
    }
}
