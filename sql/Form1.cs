using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql
{
    public partial class Form1 : Form
    {
        static List<Mezo> adatok =new List<Mezo>();
        static List<ComboBox> mezoAdatok = new List<ComboBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            Beolvas(textBox1.Text);
        }

        private void Beolvas(string fajl)
        {
            adatok = FileIO.Beolvas(fajl);
            if (adatok.Count==0)
            {
                MessageBox.Show("Nem sikerült 1 sor adatot sem beolvasni!","Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
            Mezobeallitas();
        }

        private void Mezobeallitas()
        {
            mezoAdatok = new List<ComboBox>();
            for (int i = 0; i < adatok[0].Rekordok.Count; i++)
            {
                Label ujlabel = new Label();
                ujlabel.Text = $"{i + 1}. oszlop típusa: ";
                ujlabel.Location = new Point(30, 138+i*50);
                this.Controls.Add(ujlabel);

                ComboBox ujComboBox = new ComboBox();
                ujComboBox.Items.Add("szám");
                ujComboBox.Items.Add("szöveg");
                ujComboBox.Items.Add("dátum");
                ujComboBox.Items.Add("idő");
                ujComboBox.Location = new Point(165, 138 + i * 50);
                this.Controls.Add(ujComboBox);
                mezoAdatok.Add(ujComboBox);
            }

            Button mentes = new Button();
            mentes.Text = "Mentés";
            mentes.Location = new Point(30, adatok[0].Rekordok.Count * 50 + 138);
            this.Controls.Add(mentes);
            mentes.Click += new EventHandler(mentes_klikk);

            this.Size = new Size(this.Size.Width, mentes.Location.Y + 50+mentes.Height);
        }

        private void mentes_klikk(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                adatok.RemoveAt(0);
            }

        }
    }
}
