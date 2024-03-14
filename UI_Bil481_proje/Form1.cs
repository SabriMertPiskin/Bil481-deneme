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
                MessageBox.Show("enlem bo� b�rak�lamaz !!!");
            }
            else if (boylam.Text.Equals(""))
            {
                MessageBox.Show("boylam bo� b�rak�lamaz !!!");
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
    // U�ak ad�n� da yakal�yorsan�z buraya "ucak_adi" ekleyin
};

                    // Kullan�c� verisi s�zl���n� JSON format�na d�n��t�r�n
                    string jsonData = JsonConvert.SerializeObject(userData, Formatting.Indented);

                    // Do�rulama i�in JSON stringini g�sterin (iste�e ba�l�)
                    MessageBox.Show(jsonData, "Kullan�c� Verileri (JSON)");

                    SendDataToPython(jsonData);

                    // send ucak_adi, en, boy
                }
                else if (!int.TryParse(enlem.Text, out en) && int.TryParse(boylam.Text, out boy))
                {
                    MessageBox.Show("Hatal� enlem format� !!!");
                }
                else if (int.TryParse(enlem.Text, out en) && !int.TryParse(boylam.Text, out boy))
                {
                    MessageBox.Show("Hatal� boylam format� !!!");
                }
                else
                {
                    MessageBox.Show("Hatal� format !!!");
                }
            }
        }

        private void SendDataToPython(string jsonData)
        {
            // manipulation.py script'inin ger�ek yolunu girin
            string pythonScriptPath = @"manipulation.py";

            // JSON verisini arg�man olarak kullanarak Python script'ini �al��t�ran bir i�lem olu�turun
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
