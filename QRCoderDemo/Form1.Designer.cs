using System.Windows.Forms;

namespace QRCoderDemo
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelIconsize = new System.Windows.Forms.Label();
            this.radGroupBox1 = new System.Windows.Forms.Panel();
            this.patholab_picture = new System.Windows.Forms.PictureBox();
            this.patholab_CreateImage = new System.Windows.Forms.Button();
            this.patho_barcode_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patho_above_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.comboPrintResolution = new System.Windows.Forms.ComboBox();
            this.comboPaperSource = new System.Windows.Forms.ComboBox();
            this.comboPaperSize = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patholab_picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIconsize
            // 
            this.labelIconsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIconsize.AutoSize = true;
            this.labelIconsize.Location = new System.Drawing.Point(41, 486);
            this.labelIconsize.Name = "labelIconsize";
            this.labelIconsize.Size = new System.Drawing.Size(52, 13);
            this.labelIconsize.TabIndex = 8;
            this.labelIconsize.Text = "Icon size:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.patholab_picture);
            this.radGroupBox1.Controls.Add(this.patholab_CreateImage);
            this.radGroupBox1.Controls.Add(this.patho_barcode_text);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.patho_above_text);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Location = new System.Drawing.Point(25, 38);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(347, 444);
            this.radGroupBox1.TabIndex = 14;
            this.radGroupBox1.Text = "For Patholab";
            // 
            // patholab_picture
            // 
            this.patholab_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patholab_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.patholab_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patholab_picture.Location = new System.Drawing.Point(0, 186);
            this.patholab_picture.Name = "patholab_picture";
            this.patholab_picture.Size = new System.Drawing.Size(344, 191);
            this.patholab_picture.TabIndex = 13;
            this.patholab_picture.TabStop = false;
            // 
            // patholab_CreateImage
            // 
            this.patholab_CreateImage.Location = new System.Drawing.Point(101, 127);
            this.patholab_CreateImage.Name = "patholab_CreateImage";
            this.patholab_CreateImage.Size = new System.Drawing.Size(133, 37);
            this.patholab_CreateImage.TabIndex = 12;
            this.patholab_CreateImage.Text = "Create Image";
            this.patholab_CreateImage.UseVisualStyleBackColor = true;
            this.patholab_CreateImage.Click += new System.EventHandler(this.patholab_CreateImage_Click);
            // 
            // patho_barcode_text
            // 
            this.patho_barcode_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patho_barcode_text.Location = new System.Drawing.Point(142, 39);
            this.patho_barcode_text.Name = "patho_barcode_text";
            this.patho_barcode_text.Size = new System.Drawing.Size(148, 20);
            this.patho_barcode_text.TabIndex = 10;
            this.patho_barcode_text.Text = "P000088/16.1.1.1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "text to generate:";
            // 
            // patho_above_text
            // 
            this.patho_above_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patho_above_text.Location = new System.Drawing.Point(143, 80);
            this.patho_above_text.Name = "patho_above_text";
            this.patho_above_text.Size = new System.Drawing.Size(148, 20);
            this.patho_above_text.TabIndex = 8;
            this.patho_above_text.Text = "Le123456/16.1.1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "teax above image";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(408, 350);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 26);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // comboPrintResolution
            // 
            this.comboPrintResolution.FormattingEnabled = true;
            this.comboPrintResolution.Location = new System.Drawing.Point(43, 79);
            this.comboPrintResolution.Name = "comboPrintResolution";
            this.comboPrintResolution.Size = new System.Drawing.Size(121, 21);
            this.comboPrintResolution.TabIndex = 16;
            this.comboPrintResolution.Text = "comboPrintResolution";
            // 
            // comboPaperSource
            // 
            this.comboPaperSource.FormattingEnabled = true;
            this.comboPaperSource.Location = new System.Drawing.Point(43, 41);
            this.comboPaperSource.Name = "comboPaperSource";
            this.comboPaperSource.Size = new System.Drawing.Size(121, 21);
            this.comboPaperSource.TabIndex = 17;
            this.comboPaperSource.Text = "comboPaperSource";
            this.comboPaperSource.SelectedIndexChanged += new System.EventHandler(this.comboPaperSource_SelectedIndexChanged);
            // 
            // comboPaperSize
            // 
            this.comboPaperSize.FormattingEnabled = true;
            this.comboPaperSize.Location = new System.Drawing.Point(43, 3);
            this.comboPaperSize.Name = "comboPaperSize";
            this.comboPaperSize.Size = new System.Drawing.Size(121, 21);
            this.comboPaperSize.TabIndex = 18;
            this.comboPaperSize.Text = "comboPaperSize";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboPaperSize);
            this.panel1.Controls.Add(this.comboPrintResolution);
            this.panel1.Controls.Add(this.comboPaperSource);
            this.panel1.Location = new System.Drawing.Point(496, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 228);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.labelIconsize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(559, 602);
            this.Name = "Form1";
            this.Text = "QRCoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patholab_picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIconsize;
        private Panel radGroupBox1;
        private System.Windows.Forms.PictureBox patholab_picture;
        private System.Windows.Forms.Button patholab_CreateImage;
        private System.Windows.Forms.TextBox patho_barcode_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patho_above_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private ComboBox comboPrintResolution;
        private ComboBox comboPaperSource;
        private ComboBox comboPaperSize;
        private Panel panel1;
        private Button button1;
    }
}

