using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_3_20_TkachenkoKY_U
{
    public partial class One : Form
    {
        public One()
        {
            InitializeComponent();
        }
        public abstract class Components<P>
        {
            public P articul;
            public int price;
            public int date;
            public Components(int Price, int Date, P Articul)
            {
                price = Price;
                date = Date;
                articul = Articul;
            }
            public void Display()
            {
                MessageBox.Show($"Артикул : {articul}\nЦена:{price}\nГод выпуска:{date}");
            }
        }
        public class Harddrive<P>
        {
            public int turnovers { get; set; }
            public string interfac { get; set; }
            public int volume { get; set; }

            public Harddrive(int Price , int Date , int Turnovers , string Interfac , int Volume , P Articul) : base(Price , Date , Articul)
            {
                turnovers = Turnovers;
                interfac = Interfac;
                volume = Volume;

            }
            public new void Display()
            {
                MessageBox.Show($"Артикул : {Articul} \nЦена:{Price}\nГод выпуска: {Date}\nКоличество оборотов: {turnovers}\nИнтерфейс: {interfac}\nОбъём: {volume}");
            }
        }

        private void One_Load(object sender, EventArgs e)
        {

        }
    }
}
