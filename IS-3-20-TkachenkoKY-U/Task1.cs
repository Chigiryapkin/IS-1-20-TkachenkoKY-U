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
    public partial class Task1 : Form
    {
        abstract class Complektac<S> // абстрактный класс
        {
            public int Price;
            public int Year_of_manufacture;
            public S Articul;

            public Complektac(int Price, int Year_of_manufacture, S Articul)
            {
                this.Price = Price;
                this.Articul = Articul;
                this.Year_of_manufacture = Year_of_manufacture;
            }

            public void Display()
            {
                Console.WriteLine($"Цена{Price}, ГодВыпуска{Year_of_manufacture}, Артикул: {Articul} ");
            }
        }
        class HardDrives<S> : Complektac<S>
        {
            public int Turnovers { get; set; }
            public string Interfac { get; set; }
            public int Volume { get; set; }


            public HardDrives(int Price, int Year_of_manufacture, S Articul, int Turnovers, string Interfac, int Volume) : base(Price, Year_of_manufacture, Articul)
            {
                this.Turnovers = Turnovers;
                this.Interfac = Interfac;
                this.Volume = Volume;
            }
            public new void Display()
            {
                Console.WriteLine($"Колвооборотов{Turnovers}, Интерфейс{Interfac}, Объём{Volume}, Артикул{Articul}, Цена{Price}, ГодВыпуска{Year_of_manufacture}");
            }
        }
        class Videoc<S> : Complektac<S>
        {
            public int Memory { get; set; }

            public string Manuf { get; set; }
            public int Freq { get; set; }
            

            public Videoc(S Articul, int Price, int Year_of_manufacture,  int Memory, string Manuf, int Freq ) : base(Price, Year_of_manufacture, Articul)
            {
                this.Manuf = Manuf;
                this.Freq = Freq;
                this.Memory = Memory;
            }
            public new void Display()
            {
                Console.WriteLine($" Артикуль{Articul}, Цена{Price}, ГодВып{Year_of_manufacture}, Частота{Freq}, Производитель{Manuf}, Объём памяти{Memory}");
            }
        }
        public Task1()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HardDrives<int> i1 = new HardDrives<int>(Convert.ToInt32(textBox7.Text),Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox1.Text),textBox5.Text, Convert.ToInt32(textBox4.Text));
            listBox1.Items.Add($"Цена {textBox7.Text}");
            listBox1.Items.Add($"ГодВыпуска {textBox6.Text}");
            listBox1.Items.Add($"Артикул {textBox9.Text}");
            listBox1.Items.Add($"Кол-во оборотов {textBox1.Text}");
            listBox1.Items.Add($"Интерфейс {textBox5.Text}");
            listBox1.Items.Add($"Объем {textBox4.Text}");
            i1.Display();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Videoc<int> g1 = new Videoc<int>(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox8.Text), Convert.ToString(textBox3.Text), Convert.ToInt32(textBox2.Text));
            listBox1.Items.Add($"Цена {textBox7.Text}");
            listBox1.Items.Add($"Год {textBox6.Text}");
            listBox1.Items.Add($"Артикул {textBox9.Text}");
            listBox1.Items.Add($"Частота {textBox8.Text}");
            listBox1.Items.Add($"Производитель {textBox3.Text}");
            listBox1.Items.Add($"Объем памяти {textBox2.Text}");
            g1.Display();
        }
    }
    
    
}