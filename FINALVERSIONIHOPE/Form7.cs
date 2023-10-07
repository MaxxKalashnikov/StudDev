using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALVERSIONIHOPE
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите имя");
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите фамилию");
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Введите логин");
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("Введите пароль");
            }

            if (checkuser())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (login, password, name, surname, email) VALUES (@login, @password, @name, @surname, @email)", db.getconnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox5.Text;
            db.openconnection();

            if (command.ExecuteNonQuery() == 1)
            {
                string email = textBox5.Text;

                MailAddress from = new MailAddress("maxvanholl75@gmail.com", "Dec&Stud");

                MailAddress to = new MailAddress(email);

                MailMessage m = new MailMessage(from, to);

                m.Subject = "Добро пожаловать в Dec&Stud!";

                m.Body = "Спасибо за регистрацию в нашем приложении!";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(from.Address, "Maxim04042001Kalashnikov");
                smtpClient.Send(m);
                MessageBox.Show("Вы успешно зарегистрированны!");
            }
            else
                MessageBox.Show("Упс! Что-то пошло не так :(");

            db.closeconnection();           
        }

        public Boolean checkuser()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @l", db.getconnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = textBox3.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует!");
                return true;
            }
            else
            {              
                return false;
            }
        }
    }
}
