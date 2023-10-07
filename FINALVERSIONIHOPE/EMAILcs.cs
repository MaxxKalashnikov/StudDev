using System;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FINALVERSIONIHOPE
{
    public partial class EMAILcs : Form
    {
        public EMAILcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailbox.Text;
            
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE email = @e", db.getconnection());
            command.Parameters.Add("@e", MySqlDbType.VarChar).Value = email;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {              
                MailAddress from = new MailAddress("maxvanholl75@gmail.com", "Dec&Stud");
                
                MailAddress to = new MailAddress(email);

                MailMessage m = new MailMessage(from, to);

                m.Subject = "Восстановление пароля";
        
                Random rand = new Random();
                string value = rand.Next(256438, 999214).ToString();

                DB db2 = new DB();
                MySqlCommand command2 = new MySqlCommand("INSERT INTO forget (code) VALUES (@code)", db2.getconnection());
                command2.Parameters.Add("@code", MySqlDbType.VarChar).Value = value;
                db2.openconnection();

                if (command2.ExecuteNonQuery() == 1)
                {
                    int a = 0;
                    int count = a + 1;
                }

                else
                {
                    int b = 0;
                    int a = b + 1;
                }

                db2.closeconnection();

                m.Body = value;

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(from.Address, "Maxim04042001Kalashnikov");
                smtpClient.Send(m);
                MessageBox.Show("Сообщение отправлено на ваш E-Mail");
                panel1.Visible = false;
                label6.Visible = true;
            }
            else
            {
                MessageBox.Show("Такой почты не зарегестрированно! Проверьте правильность ввода");
            }                   
        }

        private void changepass_Click(object sender, EventArgs e)
        {
            string codeid = numbox.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM forget WHERE code = @code", db.getconnection());
            command.Parameters.Add("@code", MySqlDbType.VarChar).Value = codeid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                panel2.Visible = false;                
            }
            else
            {
                MessageBox.Show("Неправильный код!");
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == textBox2.Text)
                {
                    string pass = textBox1.Text;
                    string email = emailbox.Text;
                    DB db = new DB();
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("UPDATE users SET password = @p WHERE email = @e ", db.getconnection());
                    command.Parameters.Add("@p", MySqlDbType.VarChar).Value = pass;
                    command.Parameters.Add("@e", MySqlDbType.VarChar).Value = email;
                    db.openconnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Пароль изменен успешно!");
                    }
                    db.closeconnection();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
        }

    }

