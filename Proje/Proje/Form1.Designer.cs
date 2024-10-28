
namespace Proje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.burc = new System.Windows.Forms.ComboBox();
            this.burcresim = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comment.Location = new System.Drawing.Point(624, 251);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(505, 90);
            this.comment.TabIndex = 11;
            this.comment.Text = resources.GetString("comment.Text");
            this.comment.Click += new System.EventHandler(this.comment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(344, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "BURÇLAR";
            // 
            // image
            // 
            this.image.Image = global::Proje.Properties.Resources.koc;
            this.image.Location = new System.Drawing.Point(312, 251);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(250, 200);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 9;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // burc
            // 
            this.burc.FormattingEnabled = true;
            this.burc.Items.AddRange(new object[] {
            "Koç",
            "Boğa",
            "İkizler",
            "Yengeç",
            "Aslan",
            "Başak",
            "Terazi",
            "Akrep",
            "Yay",
            "Oğlak",
            "Kova",
            "Balık"});
            this.burc.Location = new System.Drawing.Point(123, 251);
            this.burc.Name = "burc";
            this.burc.Size = new System.Drawing.Size(125, 21);
            this.burc.TabIndex = 8;
            this.burc.Tag = "";
            this.burc.Text = "Koç";
            this.burc.SelectedIndexChanged += new System.EventHandler(this.burc_SelectedIndexChanged);
            // 
            // burcresim
            // 
            this.burcresim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("burcresim.ImageStream")));
            this.burcresim.TransparentColor = System.Drawing.Color.Transparent;
            this.burcresim.Images.SetKeyName(0, "akrep.PNG");
            this.burcresim.Images.SetKeyName(1, "aslan.PNG");
            this.burcresim.Images.SetKeyName(2, "balik.PNG");
            this.burcresim.Images.SetKeyName(3, "basak.PNG");
            this.burcresim.Images.SetKeyName(4, "boga.PNG");
            this.burcresim.Images.SetKeyName(5, "ikizler.PNG");
            this.burcresim.Images.SetKeyName(6, "koc.PNG");
            this.burcresim.Images.SetKeyName(7, "kova.PNG");
            this.burcresim.Images.SetKeyName(8, "oglak.PNG");
            this.burcresim.Images.SetKeyName(9, "terazi.PNG");
            this.burcresim.Images.SetKeyName(10, "yay.PNG");
            this.burcresim.Images.SetKeyName(11, "yengec.PNG");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 625);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.burc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.ComboBox burc;
        private System.Windows.Forms.ImageList burcresim;
    }
}

