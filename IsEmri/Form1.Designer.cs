namespace IsEmri
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridEmirler = new System.Windows.Forms.DataGridView();
            this.gridDuruslar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridRapor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDuruslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmirler
            // 
            this.gridEmirler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmirler.Location = new System.Drawing.Point(13, 236);
            this.gridEmirler.Name = "gridEmirler";
            this.gridEmirler.Size = new System.Drawing.Size(415, 307);
            this.gridEmirler.TabIndex = 0;
            // 
            // gridDuruslar
            // 
            this.gridDuruslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDuruslar.Location = new System.Drawing.Point(434, 236);
            this.gridDuruslar.Name = "gridDuruslar";
            this.gridDuruslar.Size = new System.Drawing.Size(415, 306);
            this.gridDuruslar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emir Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duruş Listesi";
            // 
            // gridRapor
            // 
            this.gridRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRapor.Location = new System.Drawing.Point(13, 25);
            this.gridRapor.Name = "gridRapor";
            this.gridRapor.Size = new System.Drawing.Size(836, 171);
            this.gridRapor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Emir Listesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 555);
            this.Controls.Add(this.gridRapor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDuruslar);
            this.Controls.Add(this.gridEmirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDuruslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmirler;
        private System.Windows.Forms.DataGridView gridDuruslar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridRapor;
        private System.Windows.Forms.Label label3;
    }
}

