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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox2.Items.AddRange(new string[] { "ИБ-10, ИБ-11", "ИБ-30, ИБ-31", "ПО-10, ПО-20", "ПО-30, ПО-40" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            switch (index)
            {
                case 0:
                    richTextBox1.LoadFile(@"C:\Users\Максим\source\repos\FINALVERSIONIHOPE\FINALVERSIONIHOPE\schedule\1.rtf");
                    richTextBox1.Find("Text", RichTextBoxFinds.MatchCase);
                    break;
                case 1:
                    richTextBox1.LoadFile(@"C:\Users\Максим\source\repos\FINALVERSIONIHOPE\FINALVERSIONIHOPE\schedule\2.rtf");
                    richTextBox1.Find("Text", RichTextBoxFinds.MatchCase);
                    break;
                case 2:
                    richTextBox1.LoadFile(@"C:\Users\Максим\source\repos\FINALVERSIONIHOPE\FINALVERSIONIHOPE\schedule\3.rtf");
                    richTextBox1.Find("Text", RichTextBoxFinds.MatchCase);
                    break;
                case 3:
                    richTextBox1.LoadFile(@"C:\Users\Максим\source\repos\FINALVERSIONIHOPE\FINALVERSIONIHOPE\schedule\4.rtf");
                    richTextBox1.Find("Text", RichTextBoxFinds.MatchCase);
                    break;
            }
        }
    }
}
