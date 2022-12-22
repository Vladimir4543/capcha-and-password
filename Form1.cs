using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonKrasoti
{
    public partial class Form1 : Form
    {
        public static Пользователи USER { get; set; }
        Model1 db = new Model1();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // проверяем, что в текстовые поля введены данные
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }

            // ищем запись пользователя с введенным логином
            Пользователи usr = db.Пользователи.SingleOrDefault(m => m.Логин == textBox1.Text);

            // если такой пользователь есть и его пароль совпадает с введенным
            if ((usr != null) && (usr.Логин == textBox2.Text))
            {
                // сохраняем данные пользователя в статической переменной
                // для использования данных пользователя в других формах
                USER = usr;

                if (usr.IDРоли == 1)
                {
                    // создаем форму Пользователи
                    Form3 frm = new Form3();
                    // показываем форму Пользователя
                    frm.Show();
                    //  форму подключения скрываем (но не закрываем!)
                    this.Hide();
                }
                // если роль = «Менеджер», то вызываем форму Менеджера
                else if (usr.IDРоли == 2)
                {
                    // создаем форму менеджера
                    Form4 frm = new Form4();
                    // показываем форму менеджера
                    frm.Show();
                    // начальную форму подключения скрываем (но не закрываем!)
                    this.Hide();
                }
                else if (usr.IDРоли == 3)
                {
                    // создаем форму администратора
                    Form5 frm = new Form5();
                    // показываем форму администратора
                    frm.Show();
                    // начальную форму подключения скрываем (но не закрываем!)
                    this.Hide();
                }
                else // если такой роли нет
                {
                    // если данные введены не правильно, то показываем сообщение
                    MessageBox.Show($"Роли {usr.IDРоли} в системе нет!");
                    return;
                }
            }
            else
            {
                // если данные введены не правильно, то показываем сообщение
                MessageBox.Show("Пользователя с таким логином и паролем нет!");
                return;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
