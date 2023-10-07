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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Все студенты специальности 'ИБ'", "Все студенты специальности ПО", "Все студенты 1-го курса", "Все студенты 2-го курса", "Все студенты 3-го курса", "Все студенты 4-го курса" });
            comboBox3.Items.AddRange(new string[] { "ИБ-10", "ИБ-11", "ИБ-20", "ИБ-30", "ИБ-31", "ИБ-40", "ПО-10", "ПО-20", "ПО-30", "ПО-40" });
            comboBox2.Items.AddRange(new string[] { "Список несовершеннолетних студентов", "Список студентов, имеющих военный билет" });
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet36.ВСЕПО". При необходимости она может быть перемещена или удалена.
            this.вСЕПОTableAdapter.Fill(this.finaldatabaseDataSet36.ВСЕПО);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet35.ВСЕИБ". При необходимости она может быть перемещена или удалена.
            this.вСЕИБTableAdapter.Fill(this.finaldatabaseDataSet35.ВСЕИБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet34.ВЕСЬ4". При необходимости она может быть перемещена или удалена.
            this.вЕСЬ4TableAdapter.Fill(this.finaldatabaseDataSet34.ВЕСЬ4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet33.ВЕСЬ3". При необходимости она может быть перемещена или удалена.
            this.вЕСЬ3TableAdapter.Fill(this.finaldatabaseDataSet33.ВЕСЬ3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet32.ВЕСЬ2". При необходимости она может быть перемещена или удалена.
            this.вЕСЬ2TableAdapter.Fill(this.finaldatabaseDataSet32.ВЕСЬ2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet31.ВЕСЬ1". При необходимости она может быть перемещена или удалена.
            this.вЕСЬ1TableAdapter.Fill(this.finaldatabaseDataSet31.ВЕСЬ1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet30._ПО_40_ДАТА". При необходимости она может быть перемещена или удалена.
            this.пО_40_ДАТАTableAdapter.Fill(this.finaldatabaseDataSet30._ПО_40_ДАТА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet29._ПО_30_ДАТА". При необходимости она может быть перемещена или удалена.
            this.пО_30_ДАТАTableAdapter.Fill(this.finaldatabaseDataSet29._ПО_30_ДАТА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet28._ПО_20_ДАТА". При необходимости она может быть перемещена или удалена.
            this.пО_20_ДАТАTableAdapter.Fill(this.finaldatabaseDataSet28._ПО_20_ДАТА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet27._ПО_10_ДАТА". При необходимости она может быть перемещена или удалена.
            this.пО_10_ДАТАTableAdapter.Fill(this.finaldatabaseDataSet27._ПО_10_ДАТА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet26._ИБ_40_ДАТА". При необходимости она может быть перемещена или удалена.
            this.иБ_40_ДАТАTableAdapter.Fill(this.finaldatabaseDataSet26._ИБ_40_ДАТА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet25._ИБ_31_ДАТА". При необходимости она может быть перемещена или удалена.
            this.иБ_31_ДАТАTableAdapter.Fill(this.finaldatabaseDataSet25._ИБ_31_ДАТА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet24._ИБ_30_ДАТА". При необходимости она может быть перемещена или удалена.
            this.иБ_30_ДАТАTableAdapter.Fill(this.finaldatabaseDataSet24._ИБ_30_ДАТА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet23._ИБ_20_ДАТА". При необходимости она может быть перемещена или удалена.
            this.иБ_20_ДАТАTableAdapter.Fill(this.finaldatabaseDataSet23._ИБ_20_ДАТА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet22._ИБ_11_ДАТА". При необходимости она может быть перемещена или удалена.
            this.иБ_11_ДАТАTableAdapter.Fill(this.finaldatabaseDataSet22._ИБ_11_ДАТА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet21._ИБ_10_ДАТА". При необходимости она может быть перемещена или удалена.
            this.иБ_10_ДАТАTableAdapter.Fill(this.finaldatabaseDataSet21._ИБ_10_ДАТА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet20._ПО_40_ВБ". При необходимости она может быть перемещена или удалена.
            this.пО_40_ВБTableAdapter.Fill(this.finaldatabaseDataSet20._ПО_40_ВБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet19._ПО_30_ВБ". При необходимости она может быть перемещена или удалена.
            this.пО_30_ВБTableAdapter1.Fill(this.finaldatabaseDataSet19._ПО_30_ВБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet18._ПО_30_ВБ". При необходимости она может быть перемещена или удалена.
            this.пО_30_ВБTableAdapter.Fill(this.finaldatabaseDataSet18._ПО_30_ВБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet17._ПО_20_ВБ". При необходимости она может быть перемещена или удалена.
            this.пО_20_ВБTableAdapter.Fill(this.finaldatabaseDataSet17._ПО_20_ВБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet16._ПО_10_ВБ". При необходимости она может быть перемещена или удалена.
            this.пО_10_ВБTableAdapter.Fill(this.finaldatabaseDataSet16._ПО_10_ВБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet15._ИБ_40_ВБ". При необходимости она может быть перемещена или удалена.
            this.иБ_40_ВБTableAdapter.Fill(this.finaldatabaseDataSet15._ИБ_40_ВБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet14._ИБ_31_ВБ". При необходимости она может быть перемещена или удалена.
            this.иБ_31_ВБTableAdapter.Fill(this.finaldatabaseDataSet14._ИБ_31_ВБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet13._ИБ_30_ВБ". При необходимости она может быть перемещена или удалена.
            this.иБ_30_ВБTableAdapter.Fill(this.finaldatabaseDataSet13._ИБ_30_ВБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet12._ИБ_20_ВБ". При необходимости она может быть перемещена или удалена.
            this.иБ_20_ВБTableAdapter.Fill(this.finaldatabaseDataSet12._ИБ_20_ВБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet11._ИБ_11_ВБ". При необходимости она может быть перемещена или удалена.
            this.иБ_11_ВБTableAdapter.Fill(this.finaldatabaseDataSet11._ИБ_11_ВБ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finaldatabaseDataSet10._ИБ_10_ВБ". При необходимости она может быть перемещена или удалена.
            this.иБ_10_ВБTableAdapter.Fill(this.finaldatabaseDataSet10._ИБ_10_ВБ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index1 = comboBox1.SelectedIndex;
            switch(index1)
            {
                case 0:
                    IB10DATA.Visible = false;
                    IB10VB.Visible = false;
                    IB11DATA.Visible = false;
                    IB11VB.Visible = false;
                    IB20DATA.Visible = false;
                    IB20VB.Visible = false;
                    IB30DATA.Visible = false;
                    IB30VB.Visible = false;
                    IB31DATA.Visible = false;
                    IB31VB.Visible = false;
                    IB40DATA.Visible = false;
                    IB40VB.Visible = false;
                    PO10DATA.Visible = false;
                    PO10VB.Visible = false;
                    PO20DATA.Visible = false;
                    PO20VB.Visible = false;
                    PO30DATA.Visible = false;
                    PO30VB.Visible = false;
                    PO40DATA.Visible = false;
                    PO40VB.Visible = false;
                    ALL1.Visible = false;
                    ALL2.Visible = false;
                    ALL3.Visible = false;
                    ALL4.Visible = false;
                    ALLIB.Visible = true;
                    ALLPO.Visible = false;
                    break;
                case 1:
                    IB10DATA.Visible = false;
                    IB10VB.Visible = false;
                    IB11DATA.Visible = false;
                    IB11VB.Visible = false;
                    IB20DATA.Visible = false;
                    IB20VB.Visible = false;
                    IB30DATA.Visible = false;
                    IB30VB.Visible = false;
                    IB31DATA.Visible = false;
                    IB31VB.Visible = false;
                    IB40DATA.Visible = false;
                    IB40VB.Visible = false;
                    PO10DATA.Visible = false;
                    PO10VB.Visible = false;
                    PO20DATA.Visible = false;
                    PO20VB.Visible = false;
                    PO30DATA.Visible = false;
                    PO30VB.Visible = false;
                    PO40DATA.Visible = false;
                    PO40VB.Visible = false;
                    ALL1.Visible = false;
                    ALL2.Visible = false;
                    ALL3.Visible = false;
                    ALL4.Visible = false;
                    ALLIB.Visible = false;
                    ALLPO.Visible = true;
                    break;
                case 2:
                    IB10DATA.Visible = false;
                    IB10VB.Visible = false;
                    IB11DATA.Visible = false;
                    IB11VB.Visible = false;
                    IB20DATA.Visible = false;
                    IB20VB.Visible = false;
                    IB30DATA.Visible = false;
                    IB30VB.Visible = false;
                    IB31DATA.Visible = false;
                    IB31VB.Visible = false;
                    IB40DATA.Visible = false;
                    IB40VB.Visible = false;
                    PO10DATA.Visible = false;
                    PO10VB.Visible = false;
                    PO20DATA.Visible = false;
                    PO20VB.Visible = false;
                    PO30DATA.Visible = false;
                    PO30VB.Visible = false;
                    PO40DATA.Visible = false;
                    PO40VB.Visible = false;
                    ALL1.Visible = true;
                    ALL2.Visible = false;
                    ALL3.Visible = false;
                    ALL4.Visible = false;
                    ALLIB.Visible = false;
                    ALLPO.Visible = false;
                    break;
                case 3:
                    IB10DATA.Visible = false;
                    IB10VB.Visible = false;
                    IB11DATA.Visible = false;
                    IB11VB.Visible = false;
                    IB20DATA.Visible = false;
                    IB20VB.Visible = false;
                    IB30DATA.Visible = false;
                    IB30VB.Visible = false;
                    IB31DATA.Visible = false;
                    IB31VB.Visible = false;
                    IB40DATA.Visible = false;
                    IB40VB.Visible = false;
                    PO10DATA.Visible = false;
                    PO10VB.Visible = false;
                    PO20DATA.Visible = false;
                    PO20VB.Visible = false;
                    PO30DATA.Visible = false;
                    PO30VB.Visible = false;
                    PO40DATA.Visible = false;
                    PO40VB.Visible = false;
                    ALL1.Visible = false;
                    ALL2.Visible = true;
                    ALL3.Visible = false;
                    ALL4.Visible = false;
                    ALLIB.Visible = false;
                    ALLPO.Visible = false;
                    break;
                case 4:
                    IB10DATA.Visible = false;
                    IB10VB.Visible = false;
                    IB11DATA.Visible = false;
                    IB11VB.Visible = false;
                    IB20DATA.Visible = false;
                    IB20VB.Visible = false;
                    IB30DATA.Visible = false;
                    IB30VB.Visible = false;
                    IB31DATA.Visible = false;
                    IB31VB.Visible = false;
                    IB40DATA.Visible = false;
                    IB40VB.Visible = false;
                    PO10DATA.Visible = false;
                    PO10VB.Visible = false;
                    PO20DATA.Visible = false;
                    PO20VB.Visible = false;
                    PO30DATA.Visible = false;
                    PO30VB.Visible = false;
                    PO40DATA.Visible = false;
                    PO40VB.Visible = false;
                    ALL1.Visible = false;
                    ALL2.Visible = false;
                    ALL3.Visible = true;
                    ALL4.Visible = false;
                    ALLIB.Visible = false;
                    ALLPO.Visible = false;
                    break;
                case 5:
                    IB10DATA.Visible = false;
                    IB10VB.Visible = false;
                    IB11DATA.Visible = false;
                    IB11VB.Visible = false;
                    IB20DATA.Visible = false;
                    IB20VB.Visible = false;
                    IB30DATA.Visible = false;
                    IB30VB.Visible = false;
                    IB31DATA.Visible = false;
                    IB31VB.Visible = false;
                    IB40DATA.Visible = false;
                    IB40VB.Visible = false;
                    PO10DATA.Visible = false;
                    PO10VB.Visible = false;
                    PO20DATA.Visible = false;
                    PO20VB.Visible = false;
                    PO30DATA.Visible = false;
                    PO30VB.Visible = false;
                    PO40DATA.Visible = false;
                    PO40VB.Visible = false;
                    ALL1.Visible = false;
                    ALL2.Visible = false;
                    ALL3.Visible = false;
                    ALL4.Visible = true;
                    ALLIB.Visible = false;
                    ALLPO.Visible = false;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index2 = comboBox2.SelectedIndex;
            int index3 = comboBox3.SelectedIndex;
            if (index2 == 0)
            {
                switch(index3)
                {                   
                    case 0:
                        IB10DATA.Visible = true;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 1:                   
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = true;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 2:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = true;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 3:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = true;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 4:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = true;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 5:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = true;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 6:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = true;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 7:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = true;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 8:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = true;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 9:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = true;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                }
            }
            if (index2 == 1)
            {
                switch(index3)
                {
                    case 0:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = true;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 1:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = true;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 2:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = true;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 3:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = true;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 4:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = true;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 5:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = true;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 6:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = true;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 7:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = true;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 8:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = true;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = false;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                    case 9:
                        IB10DATA.Visible = false;
                        IB10VB.Visible = false;
                        IB11DATA.Visible = false;
                        IB11VB.Visible = false;
                        IB20DATA.Visible = false;
                        IB20VB.Visible = false;
                        IB30DATA.Visible = false;
                        IB30VB.Visible = false;
                        IB31DATA.Visible = false;
                        IB31VB.Visible = false;
                        IB40DATA.Visible = false;
                        IB40VB.Visible = false;
                        PO10DATA.Visible = false;
                        PO10VB.Visible = false;
                        PO20DATA.Visible = false;
                        PO20VB.Visible = false;
                        PO30DATA.Visible = false;
                        PO30VB.Visible = false;
                        PO40DATA.Visible = false;
                        PO40VB.Visible = true;
                        ALL1.Visible = false;
                        ALL2.Visible = false;
                        ALL3.Visible = false;
                        ALL4.Visible = false;
                        ALLIB.Visible = false;
                        ALLPO.Visible = false;
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < IB10DATA.RowCount; i++)
            {
                IB10DATA.Rows[i].Selected = false;
                for (int j = 0; j < IB10DATA.ColumnCount; j++)
                    if (IB10DATA.Rows[i].Cells[j].Value != null)
                        if (IB10DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB10DATA.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < IB11DATA.RowCount; i++)
            {
                IB11DATA.Rows[i].Selected = false;
                for (int j = 0; j < IB11DATA.ColumnCount; j++)
                    if (IB11DATA.Rows[i].Cells[j].Value != null)
                        if (IB11DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB11DATA.Rows[i].Selected = true;
                            break;
                        }
            }
            for (int i = 0; i < IB20DATA.RowCount; i++)
            {
                IB20DATA.Rows[i].Selected = false;
                for (int j = 0; j < IB20DATA.ColumnCount; j++)
                    if (IB20DATA.Rows[i].Cells[j].Value != null)
                        if (IB20DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB20DATA.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < IB31DATA.RowCount; i++)
            {
                IB31DATA.Rows[i].Selected = false;
                for (int j = 0; j < IB31DATA.ColumnCount; j++)
                    if (IB31DATA.Rows[i].Cells[j].Value != null)
                        if (IB31DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB31DATA.Rows[i].Selected = true;
                            break;
                        }
            }
            for (int i = 0; i < IB30DATA.RowCount; i++)
            {
                IB30DATA.Rows[i].Selected = false;
                for (int j = 0; j < IB30DATA.ColumnCount; j++)
                    if (IB30DATA.Rows[i].Cells[j].Value != null)
                        if (IB30DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB30DATA.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < IB40DATA.RowCount; i++)
            {
                IB40DATA.Rows[i].Selected = false;
                for (int j = 0; j < IB40DATA.ColumnCount; j++)
                    if (IB40DATA.Rows[i].Cells[j].Value != null)
                        if (IB40DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB40DATA.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < PO10DATA.RowCount; i++)
            {
                PO10DATA.Rows[i].Selected = false;
                for (int j = 0; j < PO10DATA.ColumnCount; j++)
                    if (PO10DATA.Rows[i].Cells[j].Value != null)
                        if (PO10DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            PO10DATA.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < PO20DATA.RowCount; i++)
            {
                PO20DATA.Rows[i].Selected = false;
                for (int j = 0; j < PO20DATA.ColumnCount; j++)
                    if (PO20DATA.Rows[i].Cells[j].Value != null)
                        if (PO20DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            PO20DATA.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < PO10DATA.RowCount; i++)
            {
                PO10DATA.Rows[i].Selected = false;
                for (int j = 0; j < PO10DATA.ColumnCount; j++)
                    if (PO10DATA.Rows[i].Cells[j].Value != null)
                        if (PO10DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            PO10DATA.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < PO30DATA.RowCount; i++)
            {
                PO30DATA.Rows[i].Selected = false;
                for (int j = 0; j < PO30DATA.ColumnCount; j++)
                    if (PO30DATA.Rows[i].Cells[j].Value != null)
                        if (PO30DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            PO30DATA.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < PO10DATA.RowCount; i++)
            {
                PO10DATA.Rows[i].Selected = false;
                for (int j = 0; j < PO10DATA.ColumnCount; j++)
                    if (PO10DATA.Rows[i].Cells[j].Value != null)
                        if (PO10DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            PO10DATA.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < PO40DATA.RowCount; i++)
            {
                PO40DATA.Rows[i].Selected = false;
                for (int j = 0; j < PO40DATA.ColumnCount; j++)
                    if (PO40DATA.Rows[i].Cells[j].Value != null)
                        if (PO40DATA.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            PO40DATA.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < PO20VB.RowCount; i++)
            {
                PO20VB.Rows[i].Selected = false;
                for (int j = 0; j < PO20VB.ColumnCount; j++)
                    if (PO20VB.Rows[i].Cells[j].Value != null)
                        if (PO20VB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            PO20VB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < PO10VB.RowCount; i++)
            {
                PO10VB.Rows[i].Selected = false;
                for (int j = 0; j < PO10VB.ColumnCount; j++)
                    if (PO10VB.Rows[i].Cells[j].Value != null)
                        if (PO10VB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            PO10VB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < PO30VB.RowCount; i++)
            {
                PO30VB.Rows[i].Selected = false;
                for (int j = 0; j < PO30VB.ColumnCount; j++)
                    if (PO30VB.Rows[i].Cells[j].Value != null)
                        if (PO30VB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            PO30VB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < PO40VB.RowCount; i++)
            {
                PO40VB.Rows[i].Selected = false;
                for (int j = 0; j < PO40VB.ColumnCount; j++)
                    if (PO40VB.Rows[i].Cells[j].Value != null)
                        if (PO40VB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            PO40VB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < IB10VB.RowCount; i++)
            {
                IB10VB.Rows[i].Selected = false;
                for (int j = 0; j < IB10VB.ColumnCount; j++)
                    if (IB10VB.Rows[i].Cells[j].Value != null)
                        if (IB10VB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB10VB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < IB11VB.RowCount; i++)
            {
                IB11VB.Rows[i].Selected = false;
                for (int j = 0; j < IB11VB.ColumnCount; j++)
                    if (IB11VB.Rows[i].Cells[j].Value != null)
                        if (IB11VB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB11VB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < IB20VB.RowCount; i++)
            {
                IB20VB.Rows[i].Selected = false;
                for (int j = 0; j < IB20VB.ColumnCount; j++)
                    if (IB20VB.Rows[i].Cells[j].Value != null)
                        if (IB20VB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB20VB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < IB31VB.RowCount; i++)
            {
                IB31VB.Rows[i].Selected = false;
                for (int j = 0; j < IB31VB.ColumnCount; j++)
                    if (IB31VB.Rows[i].Cells[j].Value != null)
                        if (IB31VB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB31VB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < IB30VB.RowCount; i++)
            {
                IB30VB.Rows[i].Selected = false;
                for (int j = 0; j < IB30VB.ColumnCount; j++)
                    if (IB30VB.Rows[i].Cells[j].Value != null)
                        if (IB30VB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB30VB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < IB40VB.RowCount; i++)
            {
                IB40VB.Rows[i].Selected = false;
                for (int j = 0; j < IB40VB.ColumnCount; j++)
                    if (IB40VB.Rows[i].Cells[j].Value != null)
                        if (IB40VB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IB40VB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < ALL1.RowCount; i++)
            {
                ALL1.Rows[i].Selected = false;
                for (int j = 0; j < ALL1.ColumnCount; j++)
                    if (ALL1.Rows[i].Cells[j].Value != null)
                        if (ALL1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            ALL1.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < ALL2.RowCount; i++)
            {
                ALL2.Rows[i].Selected = false;
                for (int j = 0; j < ALL2.ColumnCount; j++)
                    if (ALL2.Rows[i].Cells[j].Value != null)
                        if (ALL2.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            ALL2.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < ALL3.RowCount; i++)
            {
                ALL3.Rows[i].Selected = false;
                for (int j = 0; j < ALL3.ColumnCount; j++)
                    if (ALL3.Rows[i].Cells[j].Value != null)
                        if (ALL3.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            ALL3.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < ALL4.RowCount; i++)
            {
                ALL4.Rows[i].Selected = false;
                for (int j = 0; j < ALL4.ColumnCount; j++)
                    if (ALL4.Rows[i].Cells[j].Value != null)
                        if (ALL4.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            ALL4.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < ALLIB.RowCount; i++)
            {
                ALLIB.Rows[i].Selected = false;
                for (int j = 0; j < ALLIB.ColumnCount; j++)
                    if (ALLIB.Rows[i].Cells[j].Value != null)
                        if (ALLIB.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            ALLIB.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < ALLPO.RowCount; i++)
            {
                ALLPO.Rows[i].Selected = false;
                for (int j = 0; j < ALLPO.ColumnCount; j++)
                    if (ALLPO.Rows[i].Cells[j].Value != null)
                        if (ALLPO.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            ALLPO.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void ALLPO_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
