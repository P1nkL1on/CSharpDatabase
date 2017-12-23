using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            add = true;
            wasID = -1;
        }
        bool add;
        int wasID;
        public void ChangeToChangeForm(Человек ofwhat)
        {
            FioBox.Text = ofwhat.ФИО;
            Adressbox.Text = ofwhat.Адрес;
            Datebox.Text = ofwhat.ДатаРождения;
            this.Text = "Changeform";
            add = false;
            wasID = ofwhat.IDчеловека;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            var context = new LaborExchangeEntities();


            string FIO = FioBox.Text, date = Datebox.Text, Adress = Adressbox.Text;
            string FIONoncontent = "`1234567890+_/\\";
            for (int i = 0; i < FIONoncontent.Length; i++)
                if (FIO.IndexOf(FIONoncontent[i]) >= 0)
                {
                    MessageBox.Show("ФИО не может содержать следующие символы " + FIONoncontent + "\nПерепроверьте правильность введенных данных!", "Ошибка!");
                    return;
                }
            if (!add)
                context.Человек.Remove(context.Человек.Find(wasID));
            Человек a = context.Человек.Add(new Человек { ФИО = FIO, ДатаРождения = date, Адрес = Adress, IDчеловека = (add)?context.Человек.Count() + 1 : wasID });

            context.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
