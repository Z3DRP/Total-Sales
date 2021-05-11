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

namespace TotalSales
{
    public partial class Sales : Form
    {
        string userFileName;
        public Sales()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
            //calc avg lrgst smlst
        }

        private void getSalesBtn_Click(object sender, EventArgs e)
        {
            double[] sales;
            double total;
            double average;
            int highestSale;
            int lowestSale;
            int fileCount;
            int elmnt = 0;

            try
            {
                StreamReader inputFile = File.OpenText(userFileName);
                fileCount = GetFileLength(inputFile);
                sales = new double[fileCount];
                //totalLabl.Text = fileCount.ToString();
                ReadFileToArray(ref sales, inputFile);
                total = TotalArray(sales);
                inputFile.Close();
                average = AverageArray(sales);
                highestSale = FindHighest(sales);
                lowestSale = FindLowest(sales);


                hiLabel.Text = sales[highestSale].ToString("c");
                loLabel.Text = sales[lowestSale].ToString("c");
                avgLabel.Text = average.ToString("c");

                foreach (double element in sales)
                    salesList.Items.Add(element.ToString("c"));
                totLabel.Text = total.ToString("c");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private int GetFileLength(StreamReader file)
        {
            int fileLength = 0;
            
            if(file.EndOfStream) // if file at EOS then reset to begining of file
                file.BaseStream.Seek(0, SeekOrigin.Begin);
            while (!file.EndOfStream)
            {
                file.ReadLine();
                fileLength++;
            }
            
            return fileLength;
        }
        private void ReadFileToArray(ref double[] salesArray, StreamReader file)
        {
            if(file.EndOfStream) // if file at EOS then reset to begining of file
                file.BaseStream.Seek(0, SeekOrigin.Begin);

            try
            {
                int len = salesArray.Length;
                int line = 0;

                while (line < salesArray.Length && !file.EndOfStream)
                {
                    salesArray[line] = double.Parse(file.ReadLine());
                    line++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid values in file");
            }


        }
        private double TotalArray(double[] aray)
        {
           double total = 0;

            for (int elmnt = 0; elmnt < aray.Length; elmnt++)
                total += aray[elmnt];
            return total;
        }
        private double AverageArray(double[] aray)
        {
            double sum = 0;
            double average = 0;
            int len = aray.Length;

            for (int elmnt = 0; elmnt < len; elmnt++)
                sum += aray[elmnt];
            average = sum / len;

            return average;
        }
        private int FindLowest(double[] aray)
        {
            int lowstIndex = 0;
            double lowstVal = aray[0];
            for (int elmnt = 0; elmnt < aray.Length; elmnt++)
            {
                if (aray[elmnt] < lowstVal)
                {
                    lowstVal = aray[elmnt];
                    lowstIndex = elmnt;
                }
                    
            }
            return lowstIndex;
        }
        private int FindHighest(double[] aray)
        {
            int highstIndex = 0;
            double highstVal = aray[0];
            for (int elmnt = 0; elmnt < aray.Length; elmnt++)
            {
                if (aray[elmnt] > highstVal)
                {
                    highstVal = aray[elmnt];
                    highstIndex = elmnt;
                }
            }
            return highstIndex;
        }
        private string GetFileName()
        {
            string userFile = "";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                userFile = openFileDialog.FileName;
            }

            return userFile;
        }
        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            userFileName = GetFileName();
        }
    }
}
