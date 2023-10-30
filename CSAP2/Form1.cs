using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool PrimeNumber(int x)
        {
            int number = x;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number == 1) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        private bool IsPrime(bool[] pole)
        {
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            bool[] pole = new bool[n];
            for(int i = 0; i < n; i++)
            {
                pole[i] = false;
            }
            for (int i = 2; i < n; i++)
            {
                pole[2] = true;
                for (int j = i; i < n; i += i)
                {
                    
                    pole[j] = false;
                }
                
            }
            foreach (bool a in pole)
            {
                listBox2.Items.Add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
