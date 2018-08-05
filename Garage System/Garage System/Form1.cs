using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            InitializeComponent();
            //loading data
            string str = string.Empty;
            for(int i=0; i<60000; i++)
            {
                str += i.ToString(); //init data
            }
            //Complete
            t.Abort();
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Size = new Size(width, height);
        }

        void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Welcome...";
            Application.Run(frm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Custom_MassageBox Custom_Msg = new Custom_MassageBox();
            Custom_Msg.ShowDialog();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if(this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            Custom_MassageBox CsMsgBox = new Custom_MassageBox();
            CsMsgBox.ShowDialog();
        }
    }
}
