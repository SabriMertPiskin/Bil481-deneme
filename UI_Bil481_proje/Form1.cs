using Newtonsoft.Json;
using System.Diagnostics;

namespace UI_Bil481_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            int en = 0;
            int boy = 0;


            if (enlem.Text.Equals(""))
            {
                MessageBox.Show("enlem boþ býrakýlamaz !!!");
            }
            else if (boylam.Text.Equals(""))
            {
                MessageBox.Show("boylam boþ býrakýlamaz !!!");
            }
            else
            {
                if (int.TryParse(enlem.Text, out en) && int.TryParse(boylam.Text, out boy))
                {
                    string temp = en + "";
                    MessageBox.Show(temp);

                    Dictionary<string, int> userData = new Dictionary<string, int>()
{
    { "enlem", en },
    { "boylam", boy },
     {ucak_adi.Text, 0},
    // Uçak adýný da yakalýyorsanýz buraya "ucak_adi" ekleyin
};

                    // Kullanýcý verisi sözlüðünü JSON formatýna dönüþtürün
                    string jsonData = JsonConvert.SerializeObject(userData, Formatting.Indented);

                    // Doðrulama için JSON stringini gösterin (isteðe baðlý)
                    MessageBox.Show(jsonData, "Kullanýcý Verileri (JSON)");

                    SendDataToPython(jsonData);

                    // send ucak_adi, en, boy
                }
                else if (!int.TryParse(enlem.Text, out en) && int.TryParse(boylam.Text, out boy))
                {
                    MessageBox.Show("Hatalý enlem formatý !!!");
                }
                else if (int.TryParse(enlem.Text, out en) && !int.TryParse(boylam.Text, out boy))
                {
                    MessageBox.Show("Hatalý boylam formatý !!!");
                }
                else
                {
                    MessageBox.Show("Hatalý format !!!");
                }
            }
        }

        private void SendDataToPython(string jsonData)
        {
            // manipulation.py script'inin gerçek yolunu girin
            string pythonScriptPath = @"manipulation.py";

            // JSON verisini argüman olarak kullanarak Python script'ini çalýþtýran bir iþlem oluþturun
            Process process = new Process();
            process.StartInfo.FileName = "python";
            process.StartInfo.Arguments = $"{pythonScriptPath} {jsonData}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            process.WaitForExit();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void enlem_TextChanged(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
