using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALVERSIONIHOPE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.IB10.RowCount; i++)
                {
                    main.IB10.Rows[i].Selected = false;
                    for (int j = 0; j < main.IB10.ColumnCount; j++)
                        if (main.IB10.Rows[i].Cells[j].Value != null)
                            if (main.IB10.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.IB10.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            if (main != null)
            {
                for (int i = 0; i < main.IB11.RowCount; i++)
                {
                    main.IB11.Rows[i].Selected = false;
                    for (int j = 0; j < main.IB11.ColumnCount; j++)
                        if (main.IB11.Rows[i].Cells[j].Value != null)
                            if (main.IB11.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.IB11.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            if (main != null)
            {
                for (int i = 0; i < main.IB20.RowCount; i++)
                {
                    main.IB20.Rows[i].Selected = false;
                    for (int j = 0; j < main.IB20.ColumnCount; j++)
                        if (main.IB20.Rows[i].Cells[j].Value != null)
                            if (main.IB20.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.IB20.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            if (main != null)
            {
                for (int i = 0; i < main.IB30.RowCount; i++)
                {
                    main.IB30.Rows[i].Selected = false;
                    for (int j = 0; j < main.IB30.ColumnCount; j++)
                        if (main.IB30.Rows[i].Cells[j].Value != null)
                            if (main.IB30.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.IB30.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            if (main != null)
            {
                for (int i = 0; i < main.IB31.RowCount; i++)
                {
                    main.IB31.Rows[i].Selected = false;
                    for (int j = 0; j < main.IB31.ColumnCount; j++)
                        if (main.IB31.Rows[i].Cells[j].Value != null)
                            if (main.IB31.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.IB31.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            if (main != null)
            {
                for (int i = 0; i < main.IB40.RowCount; i++)
                {
                    main.IB40.Rows[i].Selected = false;
                    for (int j = 0; j < main.IB40.ColumnCount; j++)
                        if (main.IB40.Rows[i].Cells[j].Value != null)
                            if (main.IB40.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.IB40.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            if (main != null)
            {
                for (int i = 0; i < main.PO10.RowCount; i++)
                {
                    main.PO10.Rows[i].Selected = false;
                    for (int j = 0; j < main.PO10.ColumnCount; j++)
                        if (main.PO10.Rows[i].Cells[j].Value != null)
                            if (main.PO10.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.PO10.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            if (main != null)
            {
                for (int i = 0; i < main.PO20.RowCount; i++)
                {
                    main.PO20.Rows[i].Selected = false;
                    for (int j = 0; j < main.PO20.ColumnCount; j++)
                        if (main.PO20.Rows[i].Cells[j].Value != null)
                            if (main.PO20.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.PO20.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            if (main != null)
            {
                for (int i = 0; i < main.PO30.RowCount; i++)
                {
                    main.PO30.Rows[i].Selected = false;
                    for (int j = 0; j < main.PO30.ColumnCount; j++)
                        if (main.PO30.Rows[i].Cells[j].Value != null)
                            if (main.PO30.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.PO30.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            if (main != null)
            {
                for (int i = 0; i < main.PO40.RowCount; i++)
                {
                    main.PO40.Rows[i].Selected = false;
                    for (int j = 0; j < main.PO40.ColumnCount; j++)
                        if (main.PO40.Rows[i].Cells[j].Value != null)
                            if (main.PO40.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.PO40.Rows[i].Selected = true;
                                break;
                            }
                }
            }

        }
    }
}
