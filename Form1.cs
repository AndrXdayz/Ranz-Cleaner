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

namespace RanzCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void RanzbudeCleaner_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var DayzLogDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DayZ";
            var count = 0;
            if (Directory.Exists(DayzLogDir))
            progressBar1.Value = 0;
            {
               DirectoryInfo m_dir = new DirectoryInfo(DayzLogDir);
               foreach(FileInfo file in m_dir.GetFiles())
               {
                    if (file.Extension == ".RPT" || file.Extension == ".log" || file.Extension == ".mdmp")
                    {
                        progressBar1.Style = ProgressBarStyle.Marquee;
                        progressBar1.MarqueeAnimationSpeed = 30;
                        progressBar1.Value = 100;
                        count++;
                        file.Delete();
                    }
                }
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;

                if (count == 0)
                {
                    MessageBox.Show("No Files have been found!");

                }

                else
                {
                    MessageBox.Show(count + " Files have been found and deleted!");
                }


            }
            if (!Directory.Exists(DayzLogDir))
            {
                MessageBox.Show("No DayZ Directory found, please install Dayz");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
