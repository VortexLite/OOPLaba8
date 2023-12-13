using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OOPLaba8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            copyName = NameFile.Text;
            NameFile.Text += path;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OutPutText_Click(object sender, EventArgs e)
        {

        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {


        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sr = new StreamWriter(path, true))
                {
                    sr.WriteLine(InputText.Text);
                }

                using (var sr = new StreamReader(path))
                {
                    InfoFile.Text = sr.ReadToEnd();
                }

                var text = InputText.Text;
                char[] reverse = text.Reverse().ToArray();
                OutPutText.Text = string.Join(string.Empty, reverse);
                text = Convert.ToString(InputText.Text.Length);
                CountSymbolString.Text += " " + text;

            }
            catch (Exception)
            {
            }
        }

        private void OKFile_Click(object sender, EventArgs e)
        {
            path = InputFile.Text;
            NameFile.Text = copyName + InputFile.Text;
        }

        private void InputFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResCude_Click(object sender, EventArgs e)
        {
            var rebro = InputRebro.Text;
            var bitch_square = 4 * Math.Pow(Convert.ToInt32(rebro), 2);
            var volume = Math.Pow(Convert.ToInt32(rebro), 3);

            OutputRes.Text = "Ребро куба - " + rebro + "\n Бічна площа куба - " + Convert.ToString(bitch_square) + "\n Об'єм куба - " + Convert.ToString(volume) + "\n";
        }
    }
}
