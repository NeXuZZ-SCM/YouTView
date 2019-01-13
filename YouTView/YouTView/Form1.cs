using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTView
{
    public partial class Form1 : Form
    {
        string BusquedaPorDefecto = new WebClient().DownloadString("https://www.googleapis.com/youtube/v3/search?part=snippet&q=programacion&key=AIzaSyC0EcMARH_nvtnGnO7aCJ4KvB65sJ1mZwA");

        public Form1()
        {
            InitializeComponent();
            //wb_playerYTV.ScriptErrorsSuppressed = true;
            var asd = new ExtendedWebBrowser();
            asd.UserAgent = "chrome";

            CargarFormulario();

        }
        private void CargarFormulario()
        {

            var json = this.BusquedaPorDefecto;
            //var json = new WebClient().DownloadString("https://www.googleapis.com/youtube/v3/search?part=snippet&q=programacion&key=AIzaSyC0EcMARH_nvtnGnO7aCJ4KvB65sJ1mZwA");
            //var json = new WebClient().DownloadString("https://www.googleapis.com/youtube/v3/search?order=date&part=snippet&channelId=UCne4X8czEkhh8GPRjXBIQJw&maxResults=25&key=AIzaSyADavf_BB9pkn2rrEv7kQZRLXDU5D5QK8A");
            ApiYoutube YTRequest = JsonConvert.DeserializeObject<ApiYoutube>(json);

            int total = ((ICollection)YTRequest.items).Count;

            for (int i = 0; i < total; i++)
            {
                dgv_VideoList.Rows.Add(YTRequest.items[i].id.videoId, ObtenerImagenViaURL(YTRequest.items[i].snippet.thumbnails.medium.url),YTRequest.items[i].snippet.title);
            }

        }
        public static Image ObtenerImagenViaURL(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        private void dgv_VideoList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int indiceVideo = e.RowIndex;
                wb_playerYTV.Url = new System.Uri("https://www.youtube.com/embed/" + dgv_VideoList.Rows[e.RowIndex].Cells[0].Value.ToString() + "?autoplay=1", System.UriKind.Absolute);
                //wb_playerYTV.Url = new System.Uri("https://www.youtube.com/embed/" + dgv_VideoList.Rows[e.RowIndex].Cells[0].Value.ToString() + "?autoplay=1", System.UriKind.Absolute);
                Debug.WriteLine(new System.Uri("https://www.youtube.com/embed/" + dgv_VideoList.Rows[e.RowIndex].Cells[0].Value.ToString() + "?autoplay=1", System.UriKind.Absolute));
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("VIDEO NO DISPONIBLE\n\nERROR CODIGO:\n\n" + ex);
            }


        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            this.BusquedaPorDefecto = new WebClient().DownloadString("https://www.googleapis.com/youtube/v3/search?part=snippet&q=" + txt_Busqueda.Text + "&key=AIzaSyC0EcMARH_nvtnGnO7aCJ4KvB65sJ1mZwA");
            dgv_VideoList.Rows.Clear();
            CargarFormulario();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

                this.TopMost = true;
                pictureBox1.Hide();
                pictureBox2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            pictureBox1.Show();
            pictureBox2.Hide();
        }

        private void txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.BusquedaPorDefecto = new WebClient().DownloadString("https://www.googleapis.com/youtube/v3/search?part=snippet&q=" + txt_Busqueda.Text + "&key=AIzaSyC0EcMARH_nvtnGnO7aCJ4KvB65sJ1mZwA");
                dgv_VideoList.Rows.Clear();
                CargarFormulario();
            }
        }
    }
}
