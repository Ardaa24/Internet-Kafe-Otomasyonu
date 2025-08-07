using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Kafe
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saatTimer.Start(); // Timer başlasın
        }

        //SAAT BAŞLANGIÇ
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss"); // Saat:Dakika:Saniye


        }
        private void saatTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss"); // Saat:Dakika:Saniye


        }

        //SAAT BİTİŞ

        //Sürüm Notları
        private void btnSurum_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bu uygulama, internet kafelerdeki saat ve masa hesabını kolayca yönetebilmek için belirli programları referans  alınarak," +
                "açık kod şeklinde geliştirilmiştir.\n\n" + "Geliştirici: ARDA24\n", "Hakkında",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        //Program Kapatma
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Geliştirici Butonu 
        private void btnGelistirici_Click(object sender, EventArgs e)
        {
            Form popupForm = new Form();
            popupForm.Text = "Geliştirici Bağlantıları";
            popupForm.Size = new Size(300, 150);
            popupForm.StartPosition = FormStartPosition.CenterParent;
            popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            popupForm.MaximizeBox = false;
            popupForm.MinimizeBox = false;

            // GitHub butonu
            Button githubButton = new Button();
            githubButton.Text = "GitHub";
            githubButton.Size = new Size(100, 40);
            githubButton.Location = new Point(40, 40);
            githubButton.Click += (s, args) =>
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/Ardaa24",
                    UseShellExecute = true
                });
                popupForm.Close();
            };

            // Instagram butonu
            Button instagramButton = new Button();
            instagramButton.Text = "Instagram";
            instagramButton.Size = new Size(100, 40);
            instagramButton.Location = new Point(150, 40);
            instagramButton.Click += (s, args) =>
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "#",
                    UseShellExecute = true
                });
                popupForm.Close();
            };

            //Forma ekle
            popupForm.Controls.Add(githubButton);
            popupForm.Controls.Add(instagramButton);

            // Formu göster
            popupForm.ShowDialog();
        }


        //İletişim Paneli
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen en yakın servis ile iletişime geçiniz. \n Telefon  Numarası: 025634422574", "İletişim Paneli",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }


        //Masa Seçim Butonları
        Button btn;

        private void SecileneGore(object sender, MouseEventArgs e)
        {
            btn = sender as Button;
          
        }

        RadioButton radio;
        private void RbtnSecileneGore(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
            
        }
    }
}
