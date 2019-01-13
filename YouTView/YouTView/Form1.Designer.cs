namespace YouTView
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_VideoList = new System.Windows.Forms.DataGridView();
            this.wb_playerYTV = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VideoList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VideoList
            // 
            this.dgv_VideoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VideoList.Location = new System.Drawing.Point(12, 234);
            this.dgv_VideoList.Name = "dgv_VideoList";
            this.dgv_VideoList.Size = new System.Drawing.Size(568, 150);
            this.dgv_VideoList.TabIndex = 0;
            // 
            // wb_playerYTV
            // 
            this.wb_playerYTV.Location = new System.Drawing.Point(12, 12);
            this.wb_playerYTV.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_playerYTV.Name = "wb_playerYTV";
            this.wb_playerYTV.Size = new System.Drawing.Size(568, 216);
            this.wb_playerYTV.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 406);
            this.Controls.Add(this.wb_playerYTV);
            this.Controls.Add(this.dgv_VideoList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VideoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VideoList;
        private System.Windows.Forms.WebBrowser wb_playerYTV;
    }
}

