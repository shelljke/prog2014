using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class r_auto : Form
    {
        public r_auto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void diesel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void electric_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void petrol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sp = new SaveFileDialog() { Filter = "Заказ автомобиля|*.car" };
            var result = sp.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var fileName = sp.FileName;
                car c = new car();

                //марка
                switch (auto.SelectedItem.ToString())
                {
                    case "Оззи":
                        c.brand = car_brand.Оззи;
                        break;
                    case "Элегия":
                        c.brand = car_brand.Элегия;
                        break;
                    case "Инфернус":
                        c.brand = car_brand.Инфернус;
                        break;
                    case "Туризмо":
                        c.brand = car_brand.Туризмо;
                        break;
                    case "Эсперанто":
                        c.brand = car_brand.Эсперанто;
                        break;
                };

                //тип двигателя
                if (diesel.Checked)
                {
                    c.e_type = engine_type.Дизельный;
                }
                if (petrol.Checked)
                {
                    c.e_type = engine_type.Бензиновый;
                }
                if (electric.Checked)
                {
                    c.e_type = engine_type.Электрический;
                }

                //мощность двигателя

                if (p1.Checked)
                {
                    c.e_power = engine_power.Первый;
                }
                if (p2.Checked)
                {
                    c.e_power = engine_power.Второй;
                }
                if (p3.Checked)
                {
                    c.e_power = engine_power.Третий;
                }

                //опции
                c.opt = new List<options>();
                if (windows.Checked)
                {
                    c.opt.Add(options.Стеклоподъемники);
                }
                if (airbag.Checked)
                {
                    c.opt.Add(options.Подушки_безопасности);
                }
                if (parktronics.Checked)
                {
                    c.opt.Add(options.Парктроники);
                }
                if (top.Checked)
                {
                    c.opt.Add(options.Откидной_верх);
                }
                if (conditioner.Checked)
                {
                    c.opt.Add(options.Кондиционер);
                }

                XmlSerializer xs = new XmlSerializer(typeof(car));
                var fileStream = File.Create(fileName);
                xs.Serialize(fileStream, c);
                fileStream.Close();
            }
        }
        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog() { Filter = "Заказ автомобиля|*.car" };
            var result = op.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var xs = new XmlSerializer(typeof(car));
                var file = File.Open(op.FileName, FileMode.Open);
                var c = (car)xs.Deserialize(file);
                file.Close();

                windows.Checked = c.opt.Contains(options.Стеклоподъемники);
                airbag.Checked = c.opt.Contains(options.Подушки_безопасности);
                parktronics.Checked = c.opt.Contains(options.Парктроники);
                top.Checked = c.opt.Contains(options.Откидной_верх);
                conditioner.Checked = c.opt.Contains(options.Кондиционер);

                diesel.Checked = c.e_type == engine_type.Дизельный;
                petrol.Checked = c.e_type == engine_type.Бензиновый;
                electric.Checked = c.e_type == engine_type.Электрический;

                p1.Checked = c.e_power == engine_power.Первый;
                p2.Checked = c.e_power == engine_power.Второй;
                p3.Checked = c.e_power == engine_power.Третий;

                auto.SelectedItem = c.brand.ToString();

            }

        }

        private void auto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (auto.SelectedItem.ToString())
            {
                case "Оззи":
                    diesel.Enabled = true;
                    petrol.Enabled = true;
                    electric.Enabled = true;

                    p1.Enabled = true;
                    p2.Enabled = true;
                    p3.Enabled = true;

                    p1.Text = "75 л.с.";
                    p2.Text = "87 л.с.";
                    p3.Text = "94 л.с.";

                    //дополнительные опции
                    windows.Enabled = true;
                    parktronics.Enabled = true;
                    top.Enabled = false;
                    conditioner.Enabled = true;
                    airbag.Enabled = true;
                    //снимаем галочки с недоступных опций
                    top.Checked = false;
                    break;
                case "Элегия":
                    diesel.Enabled = true;
                    petrol.Enabled = true;
                    electric.Enabled = false;

                    p1.Enabled = true;
                    p2.Enabled = true;
                    p3.Enabled = true;

                    p1.Text = "120 л.с.";
                    p2.Text = "155 л.с.";
                    p3.Text = "164 л.с.";

                    windows.Enabled = true;
                    parktronics.Enabled = true;
                    top.Enabled = false;
                    conditioner.Enabled = true;
                    airbag.Enabled = true;

                    electric.Checked = false;
                    top.Checked = false;
                    break;
                case "Инфернус":
                    diesel.Enabled = true;
                    petrol.Enabled = true;
                    electric.Enabled = false;

                    p1.Enabled = true;
                    p2.Enabled = true;
                    p3.Enabled = false;

                    p1.Text = "611 л.с.";
                    p2.Text = "730 л.с.";
                    p3.Text = "-";

                    windows.Enabled = true;
                    parktronics.Enabled = false;
                    top.Enabled = true;
                    conditioner.Enabled = false;
                    airbag.Enabled = false;

                    electric.Checked = false;
                    parktronics.Checked = false;
                    conditioner.Checked = false;
                    airbag.Checked = false;
                    break;
                case "Эсперанто":
                    diesel.Enabled = true;
                    petrol.Enabled = true;
                    electric.Enabled = false;

                    p1.Enabled = true;
                    p2.Enabled = true;
                    p3.Enabled = true;

                    p1.Text = "255 л.с.";
                    p2.Text = "279 л.с.";
                    p3.Text = "311 л.с.";

                    windows.Enabled = true;
                    parktronics.Enabled = true;
                    top.Enabled = false;
                    conditioner.Enabled = true;
                    airbag.Enabled = true;

                    electric.Checked = false;
                    top.Checked = false;
                    break;
                case "Туризмо":
                    diesel.Enabled = true;
                    petrol.Enabled = true;
                    electric.Enabled = false;

                    p1.Enabled = true;
                    p2.Enabled = true;
                    p3.Enabled = true;

                    p1.Text = "120 л.с.";
                    p2.Text = "176 л.с.";
                    p3.Text = "201 л.с.";

                    windows.Enabled = true;
                    parktronics.Enabled = true;
                    top.Enabled = true;
                    conditioner.Enabled = true;
                    airbag.Enabled = true;

                    electric.Checked = false;
                    break;
            };

        }
    }
    public class car
    {
        public car_brand brand { get; set; }
        public engine_power e_power { get; set; }
        public engine_type e_type { get; set; }
        public List<options> opt { get; set; }
    }
    public enum car_brand
    {
        Эсперанто,
        Элегия,
        Туризмо,
        Инфернус,
        Оззи
    }
    public enum engine_type
    {
        Дизельный,
        Бензиновый,
        Электрический
    }
    public enum engine_power
    {
        Первый,
        Второй,
        Третий
    }
    public enum options
    {
        Стеклоподъемники,
        Подушки_безопасности,
        Парктроники,
        Откидной_верх,
        Кондиционер
    }
}

