
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


            if (enlem1.Text.Equals(""))
            {
                MessageBox.Show("enlem boþ býrakýlamaz...");
            }
            else if (boylam1.Text.Equals(""))
            {
                MessageBox.Show("boylam boþ býrakýlamaz...");
            }
            else
            {

                double e1 = 0, e2 = 0, b1 = 0, b2 = 0;

                try
                {
                    e1 = double.Parse(enlem1.Text, System.Globalization.CultureInfo.InvariantCulture);
                    if (!(e1 <= 90 && e1 >= -90))
                    {
                        e1 = 0;
                        throw new Exception("enlem1 uygun aralýkta deðil... Tekrar deneyiniz...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("enlem1 geçerli deðil... " + ex.Message);
                }

                try
                {
                    e2 = double.Parse(enlem2.Text, System.Globalization.CultureInfo.InvariantCulture);
                    if (!(e2 <= 90 && e2 >= -90) && e1 > e2)
                    {
                        e2 = 0;
                        throw new Exception("enlem2 uygun aralýkta deðil... Tekrar deneyiniz...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("enlem2 geçerli deðil... " + ex.Message);
                }

                try
                {
                    b1 = double.Parse(boylam1.Text, System.Globalization.CultureInfo.InvariantCulture);
                    if (!(b1 <= 180 && b1 >= -180))
                    {
                        b1 = 0;
                        throw new Exception("boylam1 uygun aralýkta deðil... Tekrar deneyiniz...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("boylam1 geçerli deðil... " + ex.Message);
                }

                try
                {
                    b2 = double.Parse(boylam2.Text, System.Globalization.CultureInfo.InvariantCulture);
                    if (!(b2 <= 180 && b2 >= -180) && b1 > b2)
                    {
                        b2 = 0;
                        throw new Exception("boylam2 uygun aralýkta deðil... Tekrar deneyiniz...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("boylam2 geçerli deðil... " + ex.Message);
                }


                // send data (writing input.txt)
                try
                {
                    //Pass the filepath and filename to the StreamWriter Constructor
                    String path = "C:\\Users\\ASUS\\source\\repos\\UI_Bil481_proje\\UI_Bil481_proje";
                    StreamWriter sw = new StreamWriter(path + "\\input.txt");

                    sw.WriteLine(e1);
                    sw.WriteLine(e2);
                    sw.WriteLine(b1);
                    sw.WriteLine(b2);
                    sw.WriteLine(ucak_adi.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosyaya yazýlamadý... Exception: " + ex.Message + "\nTekrar gönderiniz...");
                }

            }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
