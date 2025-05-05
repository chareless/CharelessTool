using HtmlAgilityPack;
using System.Net;
using System.Text;
using System.Xml;

namespace CharelessTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            CheckUpdate();
        }

        private void toolStripButtonContact_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://chareless.github.io/saribayirdeniz/#contact",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Site A��lamad�: " + ex.Message);
            }
        }

        private void CheckUpdate()
        {
            try
            {
                Uri url = new Uri("https://chareless.github.io/saribayirdeniz/charelesstool.html");
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div/div/div[2]/div/div/div/div/div[2]/div[2]/div/div/p[2]/h7");
                string version = "";
                foreach (HtmlNode title in titles)
                {
                    version = title.InnerText;
                }

                if (version == General.VERSION)
                {
                    MessageBox.Show("S�r�m G�ncel", "G�ncellemeleri Denetle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("G�ncelleme Mevcut. Yeni S�r�m� �ndirmek �ster Misiniz?", "G�ncellemeleri Denetle",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = "https://github.com/chareless/CharelessTool-for-Windows/archive/master.zip",
                                UseShellExecute = true
                            };
                            System.Diagnostics.Process.Start(psi);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("�ndirme s�ras�nda bir hata olu�tu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("G�ncel S�r�m Bulunurken Hata!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDigitalDiary_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "DigitalDiary", "Digital Diary.exe");

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Uygulama bulunamad�: " + filePath);
            }
        }


        private void buttonRandomTools_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "RandomTools", "RandomTools.exe");

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Uygulama bulunamad�: " + filePath);
            }
        }


        private void buttonOrtalama_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "Ortalama-Excel", "Ortalama.xlsx");

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true // Excel ile a��lmas�n� sa�lar
                });
            }
            else
            {
                MessageBox.Show("Dosya bulunamad�: " + filePath);
            }
        }


        private void buttonTombala_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "E-Tombala", "Tombala.exe");

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Uygulama bulunamad�: " + filePath);
            }
        }


        private void buttonBackpack_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "Knapsack", "Opti.exe");

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Uygulama bulunamad�: " + filePath);
            }
        }


        private void buttonInsta_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "Insta-Followers", "Insta Followers Desktop", "Insta-Followers.exe");

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Uygulama bulunamad�: " + filePath);
            }
        }

        private void buttonInstaConsole_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "Insta-Followers", "Insta Followers Console", "InstagramFollowersControl.exe");

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Uygulama bulunamad�: " + filePath);
            }
        }


        private void buttonEarthquake_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "Earthquake Monitor", "APP", "EarthquakeDataFormsApp.exe");

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Uygulama bulunamad�: " + filePath);
            }
        }


        private void buttonEarthquakeConsole_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "Earthquake Monitor", "Console", "EarthquakeData.exe");

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Uygulama bulunamad�: " + filePath);
            }
        }

    }
}
