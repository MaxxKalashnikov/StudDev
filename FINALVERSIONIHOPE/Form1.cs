using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace FINALVERSIONIHOPE
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Информационная безопасность", "Програмная инженерия" });
            comboBox2.Items.AddRange(new string[] { "1 курс", "2 курс", "3 курс", "4 курс" });
        }
       
       
        private void Form1_Load(object sender, EventArgs e)
        {           
            this.пО_40TableAdapter.Fill(this.finaldatabaseDataSet9._ПО_40);           
            this.пО_30TableAdapter.Fill(this.finaldatabaseDataSet8._ПО_30);            
            this.пО_20TableAdapter.Fill(this.finaldatabaseDataSet7._ПО_20);           
            this.пО_10TableAdapter.Fill(this.finaldatabaseDataSet6._ПО_10);           
            this.иБ_40TableAdapter.Fill(this.finaldatabaseDataSet5._ИБ_40);           
            this.иБ_31TableAdapter.Fill(this.finaldatabaseDataSet4._ИБ_31);            
            this.иБ_30TableAdapter.Fill(this.finaldatabaseDataSet3._ИБ_30);           
            this.иБ_20TableAdapter.Fill(this.finaldatabaseDataSet2._ИБ_20);            
            this.иБ_11TableAdapter.Fill(this.finaldatabaseDataSet1._ИБ_11);           
            this.иБ_10TableAdapter.Fill(this.finaldatabaseDataSet._ИБ_10);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int index2 = comboBox2.SelectedIndex;
            int index1 = comboBox1.SelectedIndex;
            comboBox3.Visible = true;
            if (index1 == 0)
            {
                switch (index2)
                {
                    case 0:
                        comboBox3.Items.AddRange(new string[] { "ИБ-10", "ИБ-11" });
                        comboBox3.Items.Remove("ИБ-20");
                        comboBox3.Items.Remove("ИБ-30");
                        comboBox3.Items.Remove("ИБ-31");
                        comboBox3.Items.Remove("ИБ-40");
                        comboBox3.Items.Remove("ПО-10");
                        comboBox3.Items.Remove("ПО-20");
                        comboBox3.Items.Remove("ПО-30");
                        comboBox3.Items.Remove("ПО-40");
                        break;
                    case 1:
                        comboBox3.Items.AddRange(new string[] { "ИБ-20" });
                        comboBox3.Items.Remove("ИБ-10");
                        comboBox3.Items.Remove("ИБ-11");
                        comboBox3.Items.Remove("ИБ-30");
                        comboBox3.Items.Remove("ИБ-31");
                        comboBox3.Items.Remove("ИБ-40");
                        comboBox3.Items.Remove("ПО-10");
                        comboBox3.Items.Remove("ПО-20");
                        comboBox3.Items.Remove("ПО-30");
                        comboBox3.Items.Remove("ПО-40");
                        break;
                    case 2:
                        comboBox3.Items.AddRange(new string[] { "ИБ-30", "ИБ-31" });
                        comboBox3.Items.Remove("ИБ-10");
                        comboBox3.Items.Remove("ИБ-11");
                        comboBox3.Items.Remove("ИБ-20");
                        comboBox3.Items.Remove("ИБ-40");
                        comboBox3.Items.Remove("ПО-10");
                        comboBox3.Items.Remove("ПО-20");
                        comboBox3.Items.Remove("ПО-30");
                        comboBox3.Items.Remove("ПО-40");
                        break;
                    case 3:
                        comboBox3.Items.AddRange(new string[] { "ИБ-40" });
                        comboBox3.Items.Remove("ИБ-10");
                        comboBox3.Items.Remove("ИБ-11");
                        comboBox3.Items.Remove("ИБ-20");
                        comboBox3.Items.Remove("ИБ-30");
                        comboBox3.Items.Remove("ИБ-31");
                        comboBox3.Items.Remove("ПО-10");
                        comboBox3.Items.Remove("ПО-20");
                        comboBox3.Items.Remove("ПО-30");
                        comboBox3.Items.Remove("ПО-40");
                        break;
                }
            }
            if (index1 == 1)
            {
                switch (index2)
                {
                    case 0:
                        comboBox3.Items.AddRange(new string[] { "ПО-10" });
                        comboBox3.Items.Remove("ИБ-11");
                        comboBox3.Items.Remove("ИБ-20");
                        comboBox3.Items.Remove("ИБ-30");
                        comboBox3.Items.Remove("ИБ-31");
                        comboBox3.Items.Remove("ИБ-40");
                        comboBox3.Items.Remove("ИБ-10");
                        comboBox3.Items.Remove("ПО-20");
                        comboBox3.Items.Remove("ПО-30");
                        comboBox3.Items.Remove("ПО-40");
                        break;
                    case 1:
                        comboBox3.Items.AddRange(new string[] { "ПО-20" });
                        comboBox3.Items.Remove("ИБ-10");
                        comboBox3.Items.Remove("ИБ-11");
                        comboBox3.Items.Remove("ИБ-30");
                        comboBox3.Items.Remove("ИБ-31");
                        comboBox3.Items.Remove("ИБ-40");
                        comboBox3.Items.Remove("ПО-10");
                        comboBox3.Items.Remove("ИБ-20");
                        comboBox3.Items.Remove("ПО-30");
                        comboBox3.Items.Remove("ПО-40");
                        break;
                    case 2:
                        comboBox3.Items.AddRange(new string[] { "ПО-30" });
                        comboBox3.Items.Remove("ИБ-10");
                        comboBox3.Items.Remove("ИБ-11");
                        comboBox3.Items.Remove("ИБ-20");
                        comboBox3.Items.Remove("ИБ-40");
                        comboBox3.Items.Remove("ПО-10");
                        comboBox3.Items.Remove("ПО-20");
                        comboBox3.Items.Remove("ИБ-30");
                        comboBox3.Items.Remove("ИБ-31");
                        comboBox3.Items.Remove("ПО-40");
                        break;
                    case 3:
                        comboBox3.Items.AddRange(new string[] { "ПО-40" });
                        comboBox3.Items.Remove("ИБ-10");
                        comboBox3.Items.Remove("ИБ-11");
                        comboBox3.Items.Remove("ИБ-20");
                        comboBox3.Items.Remove("ИБ-30");
                        comboBox3.Items.Remove("ИБ-31");
                        comboBox3.Items.Remove("ПО-10");
                        comboBox3.Items.Remove("ПО-20");
                        comboBox3.Items.Remove("ПО-30");
                        comboBox3.Items.Remove("ИБ-40");
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index1 = comboBox1.SelectedIndex;
            int index2 = comboBox2.SelectedIndex;
            int index3 = comboBox3.SelectedIndex;
            if (index1 == 0 && index2 == 0 && index3 == 0)
            {
                IB10.Visible = true;
                IB11.Visible = false;
                IB20.Visible = false;
                IB30.Visible = false;
                IB31.Visible = false;
                IB40.Visible = false;
                PO10.Visible = false;
                PO20.Visible = false;
                PO30.Visible = false;
                PO40.Visible = false;
            }
            else
            {
                if(index1 == 0 && index2 == 0 && index3 == 1)
                {
                    IB10.Visible = false;
                    IB11.Visible = true;
                    IB20.Visible = false;
                    IB30.Visible = false;
                    IB31.Visible = false;
                    IB40.Visible = false;
                    PO10.Visible = false;
                    PO20.Visible = false;
                    PO30.Visible = false;
                    PO40.Visible = false;
                }
            }
            if (index1 == 0 && index2 == 1 && index3 == 0)
            {
                IB10.Visible = false;
                IB11.Visible = false;
                IB20.Visible = true;
                IB30.Visible = false;
                IB31.Visible = false;
                IB40.Visible = false;
                PO10.Visible = false;
                PO20.Visible = false;
                PO30.Visible = false;
                PO40.Visible = false;
            }
            if (index1 == 0 && index2 == 2 && index3 == 0)
            {
                IB10.Visible = false;
                IB11.Visible = false;
                IB20.Visible = false;
                IB30.Visible = true;
                IB31.Visible = false;
                IB40.Visible = false;
                PO10.Visible = false;
                PO20.Visible = false;
                PO30.Visible = false;
                PO40.Visible = false;
            }
            else
            {
                if (index1 == 0 && index2 == 2 && index3 == 1)
                {
                    IB10.Visible = false;
                    IB11.Visible = false;
                    IB20.Visible = false;
                    IB30.Visible = false;
                    IB31.Visible = true;
                    IB40.Visible = false;
                    PO10.Visible = false;
                    PO20.Visible = false;
                    PO30.Visible = false;
                    PO40.Visible = false;
                }
            }
            if (index1 == 0 && index2 == 3 && index3 == 0)
            {
                IB10.Visible = false;
                IB11.Visible = false;
                IB20.Visible = false;
                IB30.Visible = false;
                IB31.Visible = false;
                IB40.Visible = true;
                PO10.Visible = false;
                PO20.Visible = false;
                PO30.Visible = false;
                PO40.Visible = false;
            }
            if (index1 == 1 && index2 == 0 && index3 == 0)
            {
                IB10.Visible = false;
                IB11.Visible = false;
                IB20.Visible = false;
                IB30.Visible = false;
                IB31.Visible = false;
                IB40.Visible = false;
                PO10.Visible = true;
                PO20.Visible = false;
                PO30.Visible = false;
                PO40.Visible = false;
            }
            if (index1 == 1 && index2 == 1 && index3 == 0)
            {
                IB10.Visible = false;
                IB11.Visible = false;
                IB20.Visible = false;
                IB30.Visible = false;
                IB31.Visible = false;
                IB40.Visible = false;
                PO10.Visible = false;
                PO20.Visible = true;
                PO30.Visible = false;
                PO40.Visible = false;
            }
            if (index1 == 1 && index2 == 2 && index3 == 0)
            {
                IB10.Visible = false;
                IB11.Visible = false;
                IB20.Visible = false;
                IB30.Visible = false;
                IB31.Visible = false;
                IB40.Visible = false;
                PO10.Visible = false;
                PO20.Visible = false;
                PO30.Visible = true;
                PO40.Visible = false;
            }
            if (index1 == 1 && index2 == 3 && index3 == 0)
            {
                IB10.Visible = false;
                IB11.Visible = false;
                IB20.Visible = false;
                IB30.Visible = false;
                IB31.Visible = false;
                IB40.Visible = false;
                PO10.Visible = false;
                PO20.Visible = false;
                PO30.Visible = false;
                PO40.Visible = true;
            }
        }


        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Owner = this;
            frm3.Show();
        }

        private void PO40_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void выбратьПоУсловиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void поискПоТаблицеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Owner = this;
            frm2.Show();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Owner = this;
            frm5.Show();
        }

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            иБ_10TableAdapter.Update(finaldatabaseDataSet);
            иБ_11TableAdapter.Update(finaldatabaseDataSet1);
            иБ_20TableAdapter.Update(finaldatabaseDataSet2);
            иБ_30TableAdapter.Update(finaldatabaseDataSet3);
            иБ_31TableAdapter.Update(finaldatabaseDataSet4);
            иБ_40TableAdapter.Update(finaldatabaseDataSet5);
            пО_10TableAdapter.Update(finaldatabaseDataSet6);
            пО_20TableAdapter.Update(finaldatabaseDataSet7);
            пО_30TableAdapter.Update(finaldatabaseDataSet8);
            пО_40TableAdapter.Update(finaldatabaseDataSet9);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @l AND password = @p", db.getconnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = pass;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/kllmeplss");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EMAILcs f = new EMAILcs();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 t = new Form7();
            t.Show();
        }
    }
}
