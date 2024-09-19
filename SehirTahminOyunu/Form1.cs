using System;
using System.Drawing;
using System.Windows.Forms;

namespace SehirTahminOyunu
{
    public partial class Form1 : Form
    {
        string[] citylist = { "İstanbul", "Ankara", "İzmir", "Adana,", "Adiyaman", "AfyonKarahisar", "Ağrı", "Aksaray", "Amasya", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Karabük", "Karaman", "Kars", "Manisa", "Kütahya", "Malatya", "Uşak", "Zonguldak", "Tokat" };
        int numberoffoundletters = 0;
        string citynametobefound = "";
        int yourremainingrights = 4;
        Random rsg;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberoffoundletters = 0;
            btn_letterenter.Enabled = true;
            btnpredict.Enabled = true;
            enteredletters.Text = "";
            yourremainingrights = 4;
            cityfound();

            grpgame.Controls.Clear();

            for (int i = 0; i < citynametobefound.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 30, 20);
                label.Text = citynametobefound[i].ToString();
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label.Size = new System.Drawing.Size(15, 20);
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                grpgame.Controls.Add(label);
            }
        }

        private void btn_letterenter_Click(object sender, EventArgs e)
        {
            bool Arethereletters = false;

            if (txt_letter.Text.Length != 1)
            {
                MessageBox.Show("Lütfen Tek Harf Giriniz");
            }
            else
            {
                if (enteredletters.Text.Contains(txt_letter.Text))
                {
                    MessageBox.Show("Bu harfi daha önce girmiştiniz");
                    txt_letter.Text = "";
                    txt_letter.Focus();
                    return;
                }

                // Harfi etiketlerde kontrol et
                foreach (Control item in grpgame.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        if (label.Text.ToUpper() == txt_letter.Text.ToUpper())
                        {
                            label.ForeColor = Color.Black;
                            label.BackColor = Color.Lime;
                            Arethereletters = true;
                            numberoffoundletters++;
                        }
                    }
                }

                if (!Arethereletters)
                {
                    yourremainingrights--;
                    yourremainingentitlement.Text = yourremainingrights.ToString();

                    if (yourremainingrights == 0)
                    {
                        btnpredict.Enabled = false;
                        btn_letterenter.Enabled = false;
                        MessageBox.Show("Oyun Bitti. Kaybettiniz Yeni Oyun için, yeni oyun butonuna tıklayınız " + "Sehrin Adı:  "+ citynametobefound);
                    }
                }

                enteredletters.Text += txt_letter.Text + " ";

                if (numberoffoundletters == citynametobefound.Length)
                {
                    btn_letterenter.Enabled = false;
                    btnpredict.Enabled = false;
                    MessageBox.Show("Oyun Bitti, Tebrikler, Oyunu Kazandınız :)");
                }

                txt_letter.Text = "";
                txt_letter.Focus(); // harf kutusunu temizle ve tekrar odaklan
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_letterenter.Enabled = false;
            btn_letterenter.Enabled = false;
            rsg = new Random();

            this.AcceptButton = btn_letterenter;
        }

        private void cityfound()
        {
            int rsgnumber = rsg.Next(0, citylist.Length);
            citynametobefound = citylist[rsgnumber];
        }

        private void btnpredict_Click(object sender, EventArgs e)
        {
            if (citynametobefound.ToUpper() == txt_word.Text.ToUpper())
            {
                foreach (Control item in grpgame.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        label.ForeColor = Color.Black;
                        label.BackColor = Color.Lime;
                    }
                }
                MessageBox.Show("Oyun Bitti Tebrikler kazandınız :)");
            }
            else
            {
                MessageBox.Show("Oyun Bitti Maalesef kaybettiniz  " + " Sehrin Adı:  "+ citynametobefound);
            }
            btnpredict.Enabled = false;
            btn_letterenter.Enabled = false;
        }
    }
}
