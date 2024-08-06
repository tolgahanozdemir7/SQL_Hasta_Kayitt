
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hasta_Kayit = new System.Windows.Forms.Button();
            this.Hasta_Silme = new System.Windows.Forms.Button();
            this.Hasta_Listele = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hasta_Kayit
            // 
            this.Hasta_Kayit.Location = new System.Drawing.Point(53, 320);
            this.Hasta_Kayit.Name = "Hasta_Kayit";
            this.Hasta_Kayit.Size = new System.Drawing.Size(187, 66);
            this.Hasta_Kayit.TabIndex = 0;
            this.Hasta_Kayit.Text = "Hasta_Kayit";
            this.Hasta_Kayit.UseVisualStyleBackColor = true;
            this.Hasta_Kayit.Click += new System.EventHandler(this.Hasta_Kayıt_Click);
            // 
            // Hasta_Silme
            // 
            this.Hasta_Silme.Location = new System.Drawing.Point(263, 320);
            this.Hasta_Silme.Name = "Hasta_Silme";
            this.Hasta_Silme.Size = new System.Drawing.Size(188, 66);
            this.Hasta_Silme.TabIndex = 1;
            this.Hasta_Silme.Text = "Hasta_Silme";
            this.Hasta_Silme.UseVisualStyleBackColor = true;
            // 
            // Hasta_Listele
            // 
            this.Hasta_Listele.Location = new System.Drawing.Point(53, 417);
            this.Hasta_Listele.Name = "Hasta_Listele";
            this.Hasta_Listele.Size = new System.Drawing.Size(192, 65);
            this.Hasta_Listele.TabIndex = 2;
            this.Hasta_Listele.Text = "Hasta_Listele";
            this.Hasta_Listele.UseVisualStyleBackColor = true;
            this.Hasta_Listele.Click += new System.EventHandler(this.Hasta_Listele_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 280);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Hasta_Listele);
            this.Controls.Add(this.Hasta_Silme);
            this.Controls.Add(this.Hasta_Kayit);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Hasta_Kayit;
        private System.Windows.Forms.Button Hasta_Silme;
        private System.Windows.Forms.Button Hasta_Listele;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


