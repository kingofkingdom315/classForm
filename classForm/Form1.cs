using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;


namespace classForm
{
    public partial class Form1 : Form
    {
        ClassMass a;

        public Form1()
        {
            InitializeComponent();
            label3.Text = "Введите значение 1 элемента";
        }

        private void addEmptyMassBut_Click(object sender, EventArgs e)
        {
            try
            {
                a = new ClassMass(int.Parse(leghtText.Text));
                leghtText.ReadOnly = true;
                fullMassText.ReadOnly = true;
                numText.ReadOnly = false;
                addFullMassBut.Click -= addFullMassBut_Click;
                addEmptyMassBut.Click -= addEmptyMassBut_Click;
                addNumBut.Click += addNumBut_Click;
            }
            catch
            {
                if (leghtText.Text == "")
                {
                    MessageBox.Show("Введите размер маcива", "Ошибка", MessageBoxButtons.OK);
                }
                else 
                {
                    MessageBox.Show("Неверный формат размера", "Ошибка", MessageBoxButtons.OK);
                }
           }
        }

        private void addNumBut_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                foreach (char m in infoText.Text)
                {
                    if (m == ':')
                        i++;
                }
                if (i < a.getLeght)
                {
                    a[i] = int.Parse(numText.Text);
                    infoText.Text += numText.Text + ":";
                    numText.Text = "";
                }
                i = 0;
                foreach (char m in infoText.Text)
                {
                    if (m == ':')
                        i++;
                }
                if (i == a.getLeght)
                {
                    for (int s = 0; s < a.getLeght; s++)
                    {
                        comboBox1.Items.Add(s);
                    }
                    leghtText.ReadOnly = true;
                    fullMassText.ReadOnly = true;
                    numText.ReadOnly = true;
                    curText.ReadOnly = false;
                    addFullMassBut.Click -= addFullMassBut_Click;
                    addEmptyMassBut.Click -= addEmptyMassBut_Click;
                    addNumBut.Click -= addNumBut_Click;
                    minusBut.Click += minusBut_Click;
                    minusNumBut.Click += minusNumBut_Click;
                    leghtBut.Click += leghtBut_Click;
                    numBut.Click += numBut_Click;
                }
            }
            catch
            {
                if (numText.Text == "")
                {
                    MessageBox.Show("Введите значение элемента", "Ошибка", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Неверный формат значения", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void addFullMassBut_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (char m in fullMassText.Text)
            {
                if (m == ':')
                    i++;
            }
            int n = 1, cursor = 0;
            int[] massbuf = new int[i];
            i = i - 1;
            for (int j = fullMassText.Text.Length - 1; j >= 0; j--)
            {
                if (fullMassText.Text[j] != ':' && fullMassText.Text[j] != '-' && j != 0)
                {
                    cursor += int.Parse(fullMassText.Text[j].ToString()) * n;
                    n = n * 10;
                }
                else if (fullMassText.Text[j] == '-')
                {
                    massbuf[i] = cursor * -1;
                    cursor = 0;
                    n = 1;
                    i--;
                    j--;
                }
                else if (fullMassText.Text[j] == ':')
                {
                    massbuf[i] = cursor;
                    cursor = 0;
                    n = 1;
                    i--;
                }
                else
                {
                    cursor += int.Parse(fullMassText.Text[j].ToString()) * n;
                    massbuf[i] = cursor;
                }
            }
            a = new ClassMass(massbuf);
            foreach (int k in massbuf)
            {
                infoText.Text += k.ToString() + ":";
            }
            for (int s = 0; s < a.getLeght; s++)
            {
                comboBox1.Items.Add(s);
            }
            leghtText.ReadOnly = true;
            fullMassText.ReadOnly = true;
            curText.ReadOnly = false;
            addFullMassBut.Click -= addFullMassBut_Click;
            addEmptyMassBut.Click -= addEmptyMassBut_Click;
            minusBut.Click += minusBut_Click;
            minusNumBut.Click += minusNumBut_Click;
            leghtBut.Click += leghtBut_Click;
            numBut.Click += numBut_Click;

        }

        private void minusBut_Click(object sender, EventArgs e)
        {
            infoText.Text += "\n" + a.GiveNumber() + ';';
        }

        private void minusNumBut_Click(object sender, EventArgs e)
        {
            if (int.Parse(curText.Text) < 0)
            {
                infoText.Text += "\n" + a.GiveNumber(int.Parse(curText.Text)) + ";";
            }
        }

        private void leghtBut_Click(object sender, EventArgs e)
        {
            infoText.Text += "\n" + a.getLeght + ";";
        }

        private void numBut_Click(object sender, EventArgs e)
        {
            try
            {
                infoText.Text += "\n" + a.GiveNumber(int.Parse(comboBox1.Text)) + ";";
            }
            catch
            {
                MessageBox.Show("Выберите номер элемента", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            infoText.Text = "";

            for (int i = 0; i < a.getLeght;i++)
            {
                infoText.Text += a[i] + ":";
            }
        }
    }
}
