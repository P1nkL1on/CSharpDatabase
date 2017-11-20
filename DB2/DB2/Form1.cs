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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var context = new LaborExchangeEntities();
            var transHumans = from h in context.Человек
                              select new
                              {
                                  HumanID = h.IDчеловека,
                                  HumanFIO = h.ФИО,
                                  HumanDate = h.ДатаРождения,
                                  HumanAdress = h.Адрес
                              };
            var transHumanSpec = from h in context.Человек
                                 join d in context.Диплом on h.IDчеловека equals d.IDчеловека
                                 join s in context.Специальность on d.IDспециальности equals s.IDспециальности
                                 select new
                                 {
                                     HumanFIO = h.ФИО,
                                     Diplom = d.ДатаВыдачи,
                                     Spec = s.Название
                                 };
            var transHumanPredpr = from h in context.Человек
                                   join k in context.Контракт on h.IDчеловека equals k.IDчеловека
                                   join v in context.Вакансия on k.IDвакансии equals v.IDвакансии
                                   join p in context.Предприятие on v.IDпредприятия equals p.IDпредприятия
                                   join s in context.Специальность on v.IDспециальности equals s.IDспециальности
                                   select new
                                   {
                                       HumanFIO = h.ФИО,
                                       KontraktID = k.IDконтракта,
                                       VakansID = v.IDвакансии,
                                       Predpreyatie = p.Адрес,
                                       Dolzhn = s.Название,
                                       Zarplata = v.Зарплата,
                                       Time = v.КоличествоЧасовВНеделю
                                   };
            humanGrid.DataSource = transHumans.ToList();
            humanGrid.Columns[0].Width = 15;

            moreGrid.DataSource = transHumanPredpr.ToList();
            moreGrid.Columns[1].Width = 15;
            moreGrid.Columns[2].Width = 15;
        }
    }
}
