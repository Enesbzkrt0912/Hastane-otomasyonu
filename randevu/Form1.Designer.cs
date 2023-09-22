
namespace randevu
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
            this.lbPol = new System.Windows.Forms.ListBox();
            this.lbDoktor = new System.Windows.Forms.ListBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.lbSaat = new System.Windows.Forms.ListBox();
            this.tbHasta = new System.Windows.Forms.TextBox();
            this.tbTc = new System.Windows.Forms.TextBox();
            this.dgRandevular = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPol
            // 
            this.lbPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPol.FormattingEnabled = true;
            this.lbPol.ItemHeight = 29;
            this.lbPol.Location = new System.Drawing.Point(117, 86);
            this.lbPol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPol.Name = "lbPol";
            this.lbPol.Size = new System.Drawing.Size(159, 178);
            this.lbPol.TabIndex = 0;
            this.lbPol.SelectedIndexChanged += new System.EventHandler(this.lbPol_SelectedIndexChanged);
            // 
            // lbDoktor
            // 
            this.lbDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDoktor.FormattingEnabled = true;
            this.lbDoktor.ItemHeight = 29;
            this.lbDoktor.Location = new System.Drawing.Point(299, 86);
            this.lbDoktor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbDoktor.Name = "lbDoktor";
            this.lbDoktor.Size = new System.Drawing.Size(237, 178);
            this.lbDoktor.TabIndex = 1;
            this.lbDoktor.SelectedIndexChanged += new System.EventHandler(this.lbDoktor_SelectedIndexChanged);
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(545, 86);
            this.dtTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(372, 36);
            this.dtTarih.TabIndex = 2;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            // 
            // lbSaat
            // 
            this.lbSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSaat.FormattingEnabled = true;
            this.lbSaat.ItemHeight = 29;
            this.lbSaat.Location = new System.Drawing.Point(952, 86);
            this.lbSaat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbSaat.Name = "lbSaat";
            this.lbSaat.Size = new System.Drawing.Size(159, 178);
            this.lbSaat.TabIndex = 3;
            // 
            // tbHasta
            // 
            this.tbHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbHasta.Location = new System.Drawing.Point(285, 313);
            this.tbHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHasta.Name = "tbHasta";
            this.tbHasta.Size = new System.Drawing.Size(233, 36);
            this.tbHasta.TabIndex = 4;
            // 
            // tbTc
            // 
            this.tbTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTc.Location = new System.Drawing.Point(671, 316);
            this.tbTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTc.Name = "tbTc";
            this.tbTc.Size = new System.Drawing.Size(261, 36);
            this.tbTc.TabIndex = 5;
            // 
            // dgRandevular
            // 
            this.dgRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRandevular.Location = new System.Drawing.Point(117, 398);
            this.dgRandevular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgRandevular.Name = "dgRandevular";
            this.dgRandevular.RowHeadersWidth = 51;
            this.dgRandevular.Size = new System.Drawing.Size(995, 185);
            this.dgRandevular.TabIndex = 6;
            this.dgRandevular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRandevular_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Poliklinikler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(347, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doktorlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(539, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Randevu Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(945, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Müsait Saatler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(124, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ad Soyad : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(555, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "TC No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(111, 363);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Randevular";
            // 
            // btKaydet
            // 
            this.btKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKaydet.Location = new System.Drawing.Point(952, 313);
            this.btKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btKaydet.Name = "btKaydet";
            this.btKaydet.Size = new System.Drawing.Size(160, 37);
            this.btKaydet.TabIndex = 14;
            this.btKaydet.Text = "Kaydet";
            this.btKaydet.UseVisualStyleBackColor = true;
            this.btKaydet.Click += new System.EventHandler(this.btKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 615);
            this.Controls.Add(this.btKaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRandevular);
            this.Controls.Add(this.tbTc);
            this.Controls.Add(this.tbHasta);
            this.Controls.Add(this.lbSaat);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.lbDoktor);
            this.Controls.Add(this.lbPol);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Hastane Randevu Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRandevular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPol;
        private System.Windows.Forms.ListBox lbDoktor;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ListBox lbSaat;
        private System.Windows.Forms.TextBox tbHasta;
        private System.Windows.Forms.TextBox tbTc;
        private System.Windows.Forms.DataGridView dgRandevular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btKaydet;
    }
}

