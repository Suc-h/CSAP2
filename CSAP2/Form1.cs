using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSAP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                if (textBox1.Text == "")
                {
                    textBox1.Text = "2";
                }
                int n = Convert.ToInt32(textBox1.Text);
                List<int> list = new List<int>();

                if (n < 0)
                {
                    n = n * -1;
                }
                bool[] pole = new bool[n + 1];
                if (n > 1)
                {
                    for (int i = 2; i <= n; i++)
                    {
                        pole[i] = true;
                    }
                    for (int j = 2; j <= n; j++)
                    {
                        if (pole[j])
                        {
                            list.Add(j);
                            for (int k = 2 * j; k <= n; k += k)
                            {
                                pole[k] = false;
                            }
                        }
                    }
                    foreach (int a in list)
                    {
                        listBox1.Items.Add(a);
                    }
                }
                else
                {
                    MessageBox.Show("Chyba!", "Pozor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}