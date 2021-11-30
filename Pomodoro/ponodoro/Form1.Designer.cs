
namespace ponodoro
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDakika = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnUzun = new System.Windows.Forms.Button();
            this.btnKisa = new System.Windows.Forms.Button();
            this.btnYarım = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDakika.Location = new System.Drawing.Point(46, 27);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(107, 76);
            this.lblDakika.TabIndex = 0;
            this.lblDakika.Text = "00";
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBasla.Location = new System.Drawing.Point(8, 120);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(145, 58);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaniye.Location = new System.Drawing.Point(205, 27);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(107, 76);
            this.lblSaniye.TabIndex = 2;
            this.lblSaniye.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(153, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.btnDurdur);
            this.panel1.Controls.Add(this.btnBasla);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDakika);
            this.panel1.Controls.Add(this.lblSaniye);
            this.panel1.Location = new System.Drawing.Point(224, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 195);
            this.panel1.TabIndex = 4;
            // 
            // btnDurdur
            // 
            this.btnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurdur.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDurdur.Location = new System.Drawing.Point(181, 120);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(145, 58);
            this.btnDurdur.TabIndex = 4;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnUzun
            // 
            this.btnUzun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUzun.ForeColor = System.Drawing.Color.IndianRed;
            this.btnUzun.Location = new System.Drawing.Point(152, 87);
            this.btnUzun.Name = "btnUzun";
            this.btnUzun.Size = new System.Drawing.Size(145, 58);
            this.btnUzun.TabIndex = 4;
            this.btnUzun.Text = "25 DK";
            this.btnUzun.UseVisualStyleBackColor = true;
            this.btnUzun.Click += new System.EventHandler(this.btnUzun_Click);
            // 
            // btnKisa
            // 
            this.btnKisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisa.ForeColor = System.Drawing.Color.IndianRed;
            this.btnKisa.Location = new System.Drawing.Point(318, 87);
            this.btnKisa.Name = "btnKisa";
            this.btnKisa.Size = new System.Drawing.Size(145, 58);
            this.btnKisa.TabIndex = 5;
            this.btnKisa.Text = "5 DK";
            this.btnKisa.UseVisualStyleBackColor = true;
            this.btnKisa.Click += new System.EventHandler(this.btnKisa_Click);
            // 
            // btnYarım
            // 
            this.btnYarım.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYarım.ForeColor = System.Drawing.Color.IndianRed;
            this.btnYarım.Location = new System.Drawing.Point(486, 87);
            this.btnYarım.Name = "btnYarım";
            this.btnYarım.Size = new System.Drawing.Size(145, 58);
            this.btnYarım.TabIndex = 6;
            this.btnYarım.Text = "20 DK";
            this.btnYarım.UseVisualStyleBackColor = true;
            this.btnYarım.Click += new System.EventHandler(this.btnYarım_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(504, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Long Break";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(339, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Short Break";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(165, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pomodoro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnYarım);
            this.Controls.Add(this.btnKisa);
            this.Controls.Add(this.btnUzun);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUzun;
        private System.Windows.Forms.Button btnKisa;
        private System.Windows.Forms.Button btnYarım;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

