using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Skladero
{
    public partial class Form1 : Form
    {
        string filename=null;
        bool calculated = false;
        bool Calculated
        {
            get { return calculated; }
            set
            {
                calculated = value;
                if (value==false)NeedUpdate();
            }
        }

        private void NeedUpdate()
        {
            string mes = "Данные не актуальны";
            n0txtBox.Text = mes;
            T0txtBox.Text = mes;
            ptxtBox.Text = mes;
            n0AlttxtBox.Text = mes;
            T0AlttxtBox.Text = mes;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            bool notempty = IsAnyBoxEmpty();
            bool alldouble = CheckForDouble();
            if (!notempty && alldouble)Calculate();
            else
            {
               if(notempty)
                {
                    MessageBox.Show("Есть незаполненные поля.\nЗаполните их и повторите попытку", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               else MessageBox.Show("Есть неправильно заполненные поля.\nЗаполните их и повторите попытку", "Неправильные поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool CheckForDouble()
        {
            try
            {
                double c1 = Convert.ToDouble(c1txtBox.Text);
                double c2 = Convert.ToDouble(c1txtBox.Text);
                double c3 = Convert.ToDouble(c1txtBox.Text);
                double Q = Convert.ToDouble(QtxtBox.Text);
                double N = Convert.ToDouble(NtxtBox.Text);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        private void Calculate()
        {
            double c1 = Convert.ToDouble(c1txtBox.Text);
            double c2 = Convert.ToDouble(c2txtBox.Text);
            double c3 = Convert.ToDouble(c3txtBox.Text);
            double Q = Convert.ToDouble(QtxtBox.Text);
            double N = Convert.ToDouble(NtxtBox.Text);

            double n0, T0, p, nAlt0, TAlt0;
            n0 = Math.Sqrt((2 * c1 * N) / (c2 * Q));
            T0 = Math.Sqrt((2 * c1 * Q) / (c2 * N));
            p = c3 / (c2 + c3);
            nAlt0 = n0 / Math.Sqrt(p);
            TAlt0 = T0 / Math.Sqrt(p);

            n0txtBox.Text = Convert.ToString(n0);
            T0txtBox.Text = Convert.ToString(T0);
            ptxtBox.Text = Convert.ToString(p);
            n0AlttxtBox.Text = Convert.ToString(nAlt0);
            T0AlttxtBox.Text = Convert.ToString(TAlt0);
            Calculated = true;
        }

        private void C1txtBox_TextChanged(object sender, EventArgs e)
        {
            CheckData(c1txtBox);
            Calculated = false;
            IsAnyBoxEmpty();
        }

        private bool IsAnyBoxEmpty()
        {
            bool OneEmpty = false;
            if (c1txtBox.Text == "") OneEmpty = true;
            if (c2txtBox.Text == "") OneEmpty = true;
            if (c3txtBox.Text == "") OneEmpty = true;
            if (NtxtBox.Text == "") OneEmpty = true;
            if (QtxtBox.Text == "") OneEmpty = true;
            if (OneEmpty)
            {
                n0txtBox.Text = "Некоторые поля пусты";
                T0txtBox.Text = "Некоторые поля пусты";
                ptxtBox.Text = "Некоторые поля пусты";
                n0AlttxtBox.Text = "Некоторые поля пусты";
                T0AlttxtBox.Text = "Некоторые поля пусты";
            }
            return OneEmpty;
        }

        private void C2txtBox_TextChanged(object sender, EventArgs e)
        {
            CheckData(c2txtBox);
            Calculated = false;
            IsAnyBoxEmpty();
        }

        private void CheckData(TextBox data)
        {
            int loc = data.SelectionStart;
            string res = "";
            int dots = 0;
            foreach (char c in data.Text)
            {
                if ((c == '.' || c == ',') && dots < 1)
                {
                    res += ',';
                    dots++;
                }
                else if (char.IsDigit(c)) res += c;
                else
                {
                    res = res.Remove(res.IndexOf(','), 1);
                    res += ',';
                    loc--;
                }

            }
            data.Text = res;
            data.SelectionStart = loc;
        }

        private void C3txtBox_TextChanged(object sender, EventArgs e)
        {
            CheckData(c3txtBox);
            Calculated = false;
            IsAnyBoxEmpty();
        }

        private void QtxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckData(QtxtBox);
            Calculated = false;
            IsAnyBoxEmpty();
        }

        private void NtxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckData(NtxtBox);
            Calculated = false;
            IsAnyBoxEmpty();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!IsAnyBoxEmpty()) Calculate();
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Файл склада .skd|*.skd|Все файлы|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                filename = sf.FileName;
                string data = $"NAME:{NametxtBox.Text}|c1:{c1txtBox.Text}|c2:{c2txtBox.Text}|c3:{c3txtBox.Text}|N:{NtxtBox.Text}|Q:{QtxtBox.Text}|calculated:{Convert.ToString(calculated)}";
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(data);
                sw.Close();
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (filename!=null)
            {
                string data = $"NAME:{NametxtBox.Text}|c1:{c1txtBox.Text}|c2:{c2txtBox.Text}|c3:{c3txtBox.Text}|N:{NtxtBox.Text}|Q:{QtxtBox.Text}|calculated:{Convert.ToString(calculated)}";
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(data);
                sw.Close();
            }
            else
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Файл склада .skd|*.skd|Все файлы|*.*";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    filename = sf.FileName;
                    string data = $"NAME:{NametxtBox.Text}|c1:{c1txtBox.Text}|c2:{c2txtBox.Text}|c3:{c3txtBox.Text}|N:{NtxtBox.Text}|Q:{QtxtBox.Text}|calculated:{Convert.ToString(calculated)}";
                    StreamWriter sw = new StreamWriter(filename);
                    sw.WriteLine(data);
                    sw.Close();
                }
            }
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            string data;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Файл склада .skd|*.skd|Все файлы|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                NametxtBox.Text = "";
                c1txtBox.Text = "";
                c2txtBox.Text = "";
                c3txtBox.Text = "";
                NtxtBox.Text = "";
                QtxtBox.Text = "";

                n0txtBox.Text = "";
                T0txtBox.Text = "";
                ptxtBox.Text = "";
                n0AlttxtBox.Text = "";
                T0AlttxtBox.Text = "";
                try
                {

                    filename = fd.FileName;
                    StreamReader sr = new StreamReader(filename);
                    data = sr.ReadLine();
                    string[] infos = data.Split('|');
                    string name = "", c1 = "", c2 = "", c3 = "", N = "", Q = "", calc = "";
                    foreach (string st in infos)
                    {
                        if (st.Contains("NAME:")) name = st.Split(':')[1];
                        if (st.Contains("c1:")) c1 = st.Split(':')[1];
                        if (st.Contains("c2:")) c2 = st.Split(':')[1];
                        if (st.Contains("c3:")) c3 = st.Split(':')[1];
                        if (st.Contains("N:")) N = st.Split(':')[1];
                        if (st.Contains("Q:")) Q = st.Split(':')[1];
                        if (st.Contains("calculated:")) calc = st.Split(':')[1];
                    }
                    NametxtBox.Text = name;
                    c1txtBox.Text = c1;
                    c2txtBox.Text = c2;
                    c3txtBox.Text = c3;
                    NtxtBox.Text = N;
                    QtxtBox.Text = Q;
                    if (Convert.ToBoolean(calc) == true) if (!IsAnyBoxEmpty()) Calculate();
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось считать файл! \nУбедитесь в правильности файла и попытайтесь еще раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    filename = null;
                }
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void HelpmenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("skladero.chm"))
            {
                Process[] proc = Process.GetProcessesByName("hh");
                if (proc.Count()>0)
                {
                    foreach(Process pr in proc)
                    {
                        pr.Kill();
                    }
                }
                System.Threading.Thread.Sleep(300);
                File.Delete("skladero.chm");
            }
            byte[] file = Skladero.Properties.Resources.Skladero;
            File.WriteAllBytes("skladero.chm", file);
            File.SetAttributes("skladero.chm", FileAttributes.Hidden);
            Process.Start("skladero.chm");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("skladero.chm"))
            {
                Process[] proc = Process.GetProcessesByName("hh");
                if (proc.Count() > 0)
                {
                    foreach (Process pr in proc)
                    {
                        pr.Kill();
                    }
                }
                File.Delete("skladero.chm");
            }
            DialogResult ds = MessageBox.Show("Возможно есть несохраненные изменения, желаете сохранить?", "Сохранить?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (ds == DialogResult.Yes) SaveMenuItem_Click(new object(), EventArgs.Empty);
            else if (ds == DialogResult.Cancel) e.Cancel=true;
        }
    }
}
