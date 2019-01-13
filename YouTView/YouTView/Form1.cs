using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarFormulario(object sender, EventArgs e)
        {
            var json = new WebClient().DownloadString("https://www.googleapis.com/youtube/v3/search?part=snippet&q=programacion&key=AIzaSyC0EcMARH_nvtnGnO7aCJ4KvB65sJ1mZwA");

        }
    }
}
