
namespace AppDiSelezioneEAutorizzazioneMonitor
{
    partial class frm_SelezioneMonitor
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.txt_Title = new System.Windows.Forms.Label();
            this.btn_Scan = new System.Windows.Forms.Button();
            this.displayDeviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_MonitorRilevati = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MonitorRilevati)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.displayDeviceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iDMonitorDataGridViewTextBoxColumn,
            this.refreshRateDataGridViewTextBoxColumn,
            this.iDGPUDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bs_MonitorRilevati;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 401);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label1);
            this.panel_Title.Controls.Add(this.txt_Title);
            this.panel_Title.Controls.Add(this.btn_Scan);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(895, 118);
            this.panel_Title.TabIndex = 1;
            // 
            // txt_Title
            // 
            this.txt_Title.AutoSize = true;
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(12, 45);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(247, 24);
            this.txt_Title.TabIndex = 1;
            this.txt_Title.Text = "Select a monitor to authorize";
            // 
            // btn_Scan
            // 
            this.btn_Scan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Scan.Location = new System.Drawing.Point(808, 12);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(75, 23);
            this.btn_Scan.TabIndex = 0;
            this.btn_Scan.Text = "Scan";
            this.btn_Scan.UseVisualStyleBackColor = true;
            this.btn_Scan.Click += new System.EventHandler(this.btn_Scan_Click);
            // 
            // displayDeviceDataGridViewTextBoxColumn
            // 
            this.displayDeviceDataGridViewTextBoxColumn.DataPropertyName = "DisplayDevice";
            this.displayDeviceDataGridViewTextBoxColumn.HeaderText = "DisplayDevice";
            this.displayDeviceDataGridViewTextBoxColumn.Name = "displayDeviceDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // iDMonitorDataGridViewTextBoxColumn
            // 
            this.iDMonitorDataGridViewTextBoxColumn.DataPropertyName = "ID_Monitor";
            this.iDMonitorDataGridViewTextBoxColumn.HeaderText = "ID_Monitor";
            this.iDMonitorDataGridViewTextBoxColumn.Name = "iDMonitorDataGridViewTextBoxColumn";
            // 
            // refreshRateDataGridViewTextBoxColumn
            // 
            this.refreshRateDataGridViewTextBoxColumn.DataPropertyName = "Refresh_Rate";
            this.refreshRateDataGridViewTextBoxColumn.HeaderText = "Refresh_Rate";
            this.refreshRateDataGridViewTextBoxColumn.Name = "refreshRateDataGridViewTextBoxColumn";
            // 
            // iDGPUDataGridViewTextBoxColumn
            // 
            this.iDGPUDataGridViewTextBoxColumn.DataPropertyName = "ID_GPU";
            this.iDGPUDataGridViewTextBoxColumn.HeaderText = "ID_GPU";
            this.iDGPUDataGridViewTextBoxColumn.Name = "iDGPUDataGridViewTextBoxColumn";
            // 
            // bs_MonitorRilevati
            // 
            this.bs_MonitorRilevati.DataSource = typeof(AppDiSelezioneEAutorizzazioneMonitor.Classi.Monitor);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(794, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double click on it";
            // 
            // frm_SelezioneMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_Title);
            this.Name = "frm_SelezioneMonitor";
            this.Text = "Selezione Monitor";
            this.Load += new System.EventHandler(this.frm_SelezioneMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MonitorRilevati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bs_MonitorRilevati;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label txt_Title;
        private System.Windows.Forms.Button btn_Scan;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayDeviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMonitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refreshRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

