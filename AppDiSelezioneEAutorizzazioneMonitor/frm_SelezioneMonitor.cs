using AppDiSelezioneEAutorizzazioneMonitor.Classi;
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
using Newtonsoft.Json;

namespace AppDiSelezioneEAutorizzazioneMonitor
{
    public partial class frm_SelezioneMonitor : Form
    {
        public List<Monitor> Lista_Monitor_Rilevati = new List<Monitor>();
        public frm_SelezioneMonitor()
        {
            InitializeComponent();
        }

        public void cercaMonitor() //Crea un file con le informazioni dei monitor chiamato MonitorList.txt
        {
            string strCmdText;
            //strCmdText = "/C AppVerificaMonitor_Ver2.exe > MonitorList.txt";
            strCmdText = "/C DisplayScanner.exe > MonitorList.txt";
            System.Diagnostics.Process.Start("CMD.exe",strCmdText);


            Lista_Monitor_Rilevati = new List<Monitor>();
            string displayFile = @"MonitorList.txt";
            if (!File.Exists(displayFile))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (StreamReader sr = File.OpenText(displayFile))
                {
                    string row = "";
                    while ((row = sr.ReadLine()) != null)
                    {
                        Monitor m = new Monitor();
                        int found = row.IndexOf("DI");
                        row = row.Substring(found);
                        string[] info = row.Split(';');


                        m.DisplayDevice = info[0];
                        m.ID_GPU = Convert.ToInt32(info[1]);
                        m.Refresh_Rate = Convert.ToInt32(info[2]);
                        m.ID_Monitor = Convert.ToInt32(info[3]);
                        m.Name = info[4];

                        Lista_Monitor_Rilevati.Add(m);
                    }
                }
            }
            bs_MonitorRilevati.DataSource = Lista_Monitor_Rilevati;
        }

        public void Stampa_Autorizzazione_Monitor(int IdM, string NameM)
        {
            
            foreach(Monitor m in Lista_Monitor_Rilevati)
            {
                if(m.Name == NameM && m.ID_Monitor == IdM)
                {
                    string json = JsonConvert.SerializeObject(m);
                    string fileName = "PlayerCertificate_" + IdM.ToString() + "__" +DateTime.Now.Date.Day+"-"+DateTime.Now.Month+"-"+DateTime.Now.Year+ "-" + DateTime.Now.Hour+ "." + DateTime.Now.Minute+"."+DateTime.Now.Second+".json";
                    //File.WriteAllText("AutorizzazioneMonitor.json", json);
                    File.WriteAllText(fileName, json);
                    MessageBox.Show("Authorization file created successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }

        private void frm_SelezioneMonitor_Load(object sender, EventArgs e)
        {
            string strCmdText;
            //strCmdText = "/C AppVerificaMonitor_Ver2.exe > MonitorList.txt";
            strCmdText = "/C DisplayScanner.exe > MonitorList.txt";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void btn_Scan_Click(object sender, EventArgs e)
        {
            cercaMonitor();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                int IdM_Ricerca = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                string Nome_Ricerca = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Stampa_Autorizzazione_Monitor(IdM_Ricerca, Nome_Ricerca);

            }
            else
            {
                MessageBox.Show("Select a valid entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
