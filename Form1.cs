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

namespace WriteLineExampleWithFlush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            string filename = "papers.txt";
            MessageBox.Show("Will create file called \""  + filename + "\"");
            StreamWriter outputFile; // create the output stream
            outputFile = File.CreateText(filename); // create empty file 
            // add three lines of text
            outputFile.WriteLine("COMPX101 - Introduction to Computer Science");
            outputFile.WriteLine("COMPX151 - The Computing Experience");
            MessageBox.Show("Two first lines sent to stream. Check file on notepad.");
            MessageBox.Show("Empty! Now let's flush the stream to the file.");
            outputFile.Flush();
            MessageBox.Show("Done! Close the file on Notepad and reopen it.");

            outputFile.WriteLine("CSMAX101 - The World of Data");
            // add one more line of text via multiple Write operations, ending with a WriteLine
            outputFile.Write("These are ");
            outputFile.Write("written ");
            outputFile.Write("in the same ");
            outputFile.WriteLine("line");
            // close the stream/file, ensuring all data will be saved in the file
            outputFile.Close();
        }
    }
}
