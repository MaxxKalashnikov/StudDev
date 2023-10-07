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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main.IB10.Visible == true)
            {
                if (main != null)
                {
                    DataRow nRow = main.finaldatabaseDataSet.Tables[0].NewRow();
                    int rc = main.IB10.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = code.Text;
                    nRow[2] = name.Text;
                    nRow[3] = group.Text;
                    nRow[4] = date.Text;
                    nRow[5] = number.Text;
                    nRow[6] = mail.Text;
                    if (checkBox1.Checked == true)
                    {
                        nRow[7] = true;
                    }
                    if (checkBox2.Checked == true)
                    {
                        nRow[7] = false;
                    }
                    main.finaldatabaseDataSet.Tables[0].Rows.Add(nRow);
                    main.иБ_10TableAdapter.Update(main.finaldatabaseDataSet._ИБ_10);
                    main.finaldatabaseDataSet.Tables[0].AcceptChanges();
                    main.IB10.Refresh();
                    code.Text = "";
                    name.Text = "";
                    group.Text = "";
                    date.Text = "";
                    number.Text = "";
                    mail.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                }
            }
            if (main.IB11.Visible == true)
            {
                if (main != null)
                {
                    DataRow nRow = main.finaldatabaseDataSet1.Tables[0].NewRow();
                    int rc = main.IB11.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = code.Text;
                    nRow[2] = name.Text;
                    nRow[3] = group.Text;
                    nRow[4] = date.Text;
                    nRow[5] = number.Text;
                    nRow[6] = mail.Text;
                    if (checkBox1.Checked == true)
                    {
                        nRow[7] = true;
                    }
                    if (checkBox2.Checked == true)
                    {
                        nRow[7] = false;
                    }
                    main.finaldatabaseDataSet1.Tables[0].Rows.Add(nRow);
                    main.иБ_11TableAdapter.Update(main.finaldatabaseDataSet1._ИБ_11);
                    main.finaldatabaseDataSet1.Tables[0].AcceptChanges();
                    main.IB11.Refresh();
                    code.Text = "";
                    name.Text = "";
                    group.Text = "";
                    date.Text = "";
                    number.Text = "";
                    mail.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                }
            }
            if (main.IB20.Visible == true)
            {
                if (main != null)
                {
                    DataRow nRow = main.finaldatabaseDataSet2.Tables[0].NewRow();
                    int rc = main.IB20.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = code.Text;
                    nRow[2] = name.Text;
                    nRow[3] = group.Text;
                    nRow[4] = date.Text;
                    nRow[5] = number.Text;
                    nRow[6] = mail.Text;
                    if (checkBox1.Checked == true)
                    {
                        nRow[7] = true;
                    }
                    if (checkBox2.Checked == true)
                    {
                        nRow[7] = false;
                    }
                    main.finaldatabaseDataSet2.Tables[0].Rows.Add(nRow);
                    main.иБ_20TableAdapter.Update(main.finaldatabaseDataSet2._ИБ_20);
                    main.finaldatabaseDataSet2.Tables[0].AcceptChanges();
                    main.IB20.Refresh();
                    code.Text = "";
                    name.Text = "";
                    group.Text = "";
                    date.Text = "";
                    number.Text = "";
                    mail.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                }
            }
            if (main.IB30.Visible == true)
            {
                if (main != null)
                {
                    DataRow nRow = main.finaldatabaseDataSet3.Tables[0].NewRow();
                    int rc = main.IB30.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = code.Text;
                    nRow[2] = name.Text;
                    nRow[3] = group.Text;
                    nRow[4] = date.Text;
                    nRow[5] = number.Text;
                    nRow[6] = mail.Text;
                    if (checkBox1.Checked == true)
                    {
                        nRow[7] = true;
                    }
                    if (checkBox2.Checked == true)
                    {
                        nRow[7] = false;
                    }
                    main.finaldatabaseDataSet3.Tables[0].Rows.Add(nRow);
                    main.иБ_30TableAdapter.Update(main.finaldatabaseDataSet3._ИБ_30);
                    main.finaldatabaseDataSet3.Tables[0].AcceptChanges();
                    main.IB30.Refresh();
                    code.Text = "";
                    name.Text = "";
                    group.Text = "";
                    date.Text = "";
                    number.Text = "";
                    mail.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                }
            }
            if (main.IB31.Visible == true)
            {
                if (main != null)
                {
                    DataRow nRow = main.finaldatabaseDataSet4.Tables[0].NewRow();
                    int rc = main.IB31.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = code.Text;
                    nRow[2] = name.Text;
                    nRow[3] = group.Text;
                    nRow[4] = date.Text;
                    nRow[5] = number.Text;
                    nRow[6] = mail.Text;
                    if (checkBox1.Checked == true)
                    {
                        nRow[7] = true;
                    }
                    if (checkBox2.Checked == true)
                    {
                        nRow[7] = false;
                    }
                    main.finaldatabaseDataSet4.Tables[0].Rows.Add(nRow);
                    main.иБ_31TableAdapter.Update(main.finaldatabaseDataSet4._ИБ_31);
                    main.finaldatabaseDataSet4.Tables[0].AcceptChanges();
                    main.IB31.Refresh();
                    code.Text = "";
                    name.Text = "";
                    group.Text = "";
                    date.Text = "";
                    number.Text = "";
                    mail.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                }
            }
            if (main.IB40.Visible == true)
            {
                if (main != null)
                {
                    DataRow nRow = main.finaldatabaseDataSet5.Tables[0].NewRow();
                    int rc = main.IB40.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = code.Text;
                    nRow[2] = name.Text;
                    nRow[3] = group.Text;
                    nRow[4] = date.Text;
                    nRow[5] = number.Text;
                    nRow[6] = mail.Text;
                    if (checkBox1.Checked == true)
                    {
                        nRow[7] = true;
                    }
                    if (checkBox2.Checked == true)
                    {
                        nRow[7] = false;
                    }
                    main.finaldatabaseDataSet5.Tables[0].Rows.Add(nRow);
                    main.иБ_40TableAdapter.Update(main.finaldatabaseDataSet5._ИБ_40);
                    main.finaldatabaseDataSet5.Tables[0].AcceptChanges();
                    main.IB40.Refresh();
                    code.Text = "";
                    name.Text = "";
                    group.Text = "";
                    date.Text = "";
                    number.Text = "";
                    mail.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                }
            }
            if (main.PO10.Visible == true)
                    {
                        if (main != null)
                        {
                            DataRow nRow = main.finaldatabaseDataSet6.Tables[0].NewRow();
                            int rc = main.PO10.RowCount + 1;
                            nRow[0] = rc;
                            nRow[1] = code.Text;
                            nRow[2] = name.Text;
                            nRow[3] = group.Text;
                            nRow[4] = date.Text;
                            nRow[5] = number.Text;
                            nRow[6] = mail.Text;
                            if (checkBox1.Checked == true)
                            {
                                nRow[7] = true;
                            }
                            if (checkBox2.Checked == true)
                            {
                                nRow[7] = false;
                            }
                            main.finaldatabaseDataSet6.Tables[0].Rows.Add(nRow);
                            main.пО_10TableAdapter.Update(main.finaldatabaseDataSet6._ПО_10);
                            main.finaldatabaseDataSet6.Tables[0].AcceptChanges();
                            main.PO10.Refresh();
                            code.Text = "";
                            name.Text = "";
                            group.Text = "";
                            date.Text = "";
                            number.Text = "";
                            mail.Text = "";
                            checkBox1.Checked = false;
                            checkBox2.Checked = false;
                        }
                    }
            if (main.PO20.Visible == true)
                    {
                        if (main != null)
                        {
                            DataRow nRow = main.finaldatabaseDataSet7.Tables[0].NewRow();
                            int rc = main.PO20.RowCount + 1;
                            nRow[0] = rc;
                            nRow[1] = code.Text;
                            nRow[2] = name.Text;
                            nRow[3] = group.Text;
                            nRow[4] = date.Text;
                            nRow[5] = number.Text;
                            nRow[6] = mail.Text;
                            if (checkBox1.Checked == true)
                            {
                                nRow[7] = true;
                            }
                            if (checkBox2.Checked == true)
                            {
                                nRow[7] = false;
                            }
                            main.finaldatabaseDataSet7.Tables[0].Rows.Add(nRow);
                            main.пО_20TableAdapter.Update(main.finaldatabaseDataSet7._ПО_20);
                            main.finaldatabaseDataSet7.Tables[0].AcceptChanges();
                            main.PO20.Refresh();
                            code.Text = "";
                            name.Text = "";
                            group.Text = "";
                            date.Text = "";
                            number.Text = "";
                            mail.Text = "";
                            checkBox1.Checked = false;
                            checkBox2.Checked = false;
                        }
                    }
            if (main.PO30.Visible == true)
                    {
                        if (main != null)
                        {
                            DataRow nRow = main.finaldatabaseDataSet8.Tables[0].NewRow();
                            int rc = main.PO30.RowCount + 1;
                            nRow[0] = rc;
                            nRow[1] = code.Text;
                            nRow[2] = name.Text;
                            nRow[3] = group.Text;
                            nRow[4] = date.Text;
                            nRow[5] = number.Text;
                            nRow[6] = mail.Text;
                            if (checkBox1.Checked == true)
                            {
                                nRow[7] = true;
                            }
                            if (checkBox2.Checked == true)
                            {
                                nRow[7] = false;
                            }
                            main.finaldatabaseDataSet8.Tables[0].Rows.Add(nRow);
                            main.пО_30TableAdapter.Update(main.finaldatabaseDataSet8._ПО_30);
                            main.finaldatabaseDataSet8.Tables[0].AcceptChanges();
                            main.PO30.Refresh();
                            code.Text = "";
                            name.Text = "";
                            group.Text = "";
                            date.Text = "";
                            number.Text = "";
                            mail.Text = "";
                            checkBox1.Checked = false;
                            checkBox2.Checked = false;
                        }
                    }
            if (main.PO40.Visible == true)
                    {
                        if (main != null)
                        {
                            DataRow nRow = main.finaldatabaseDataSet9.Tables[0].NewRow();
                            int rc = main.PO40.RowCount + 1;
                            nRow[0] = rc;
                            nRow[1] = code.Text;
                            nRow[2] = name.Text;
                            nRow[3] = group.Text;
                            nRow[4] = date.Text;
                            nRow[5] = number.Text;
                            nRow[6] = mail.Text;
                            if (checkBox1.Checked == true)
                            {
                                nRow[7] = true;
                            }
                            if (checkBox2.Checked == true)
                            {
                                nRow[7] = false;
                            }
                            main.finaldatabaseDataSet9.Tables[0].Rows.Add(nRow);
                            main.пО_40TableAdapter.Update(main.finaldatabaseDataSet9._ПО_40);
                            main.finaldatabaseDataSet9.Tables[0].AcceptChanges();
                            main.PO40.Refresh();
                            code.Text = "";
                            name.Text = "";
                            group.Text = "";
                            date.Text = "";
                            number.Text = "";
                            mail.Text = "";
                            checkBox1.Checked = false;
                            checkBox2.Checked = false;
                        }
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 }
    
     
