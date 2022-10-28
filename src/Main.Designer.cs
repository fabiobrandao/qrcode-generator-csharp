
namespace QRCodeGenerator
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxQRCode = new System.Windows.Forms.PictureBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txbContent = new System.Windows.Forms.TextBox();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.btnGenerateQRCode = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxQRCode
            // 
            this.pbxQRCode.Location = new System.Drawing.Point(13, 13);
            this.pbxQRCode.Name = "pbxQRCode";
            this.pbxQRCode.Size = new System.Drawing.Size(190, 173);
            this.pbxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxQRCode.TabIndex = 0;
            this.pbxQRCode.TabStop = false;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(214, 13);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(53, 13);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "Conteúdo";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(214, 63);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(43, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Largura";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(302, 63);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(34, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Altura";
            // 
            // txbContent
            // 
            this.txbContent.Location = new System.Drawing.Point(214, 29);
            this.txbContent.Name = "txbContent";
            this.txbContent.Size = new System.Drawing.Size(277, 20);
            this.txbContent.TabIndex = 4;
            this.txbContent.Text = "http://fabiobrandao.net.br/";
            // 
            // txbWidth
            // 
            this.txbWidth.Location = new System.Drawing.Point(214, 79);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(65, 20);
            this.txbWidth.TabIndex = 5;
            this.txbWidth.Text = "200";
            // 
            // txbHeight
            // 
            this.txbHeight.Location = new System.Drawing.Point(305, 79);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(65, 20);
            this.txbHeight.TabIndex = 6;
            this.txbHeight.Text = "200";
            // 
            // btnGenerateQRCode
            // 
            this.btnGenerateQRCode.Location = new System.Drawing.Point(214, 151);
            this.btnGenerateQRCode.Name = "btnGenerateQRCode";
            this.btnGenerateQRCode.Size = new System.Drawing.Size(164, 35);
            this.btnGenerateQRCode.TabIndex = 7;
            this.btnGenerateQRCode.Text = "Gerar QRCode";
            this.btnGenerateQRCode.UseVisualStyleBackColor = true;
            this.btnGenerateQRCode.Click += new System.EventHandler(this.btnGenerateQRCode_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(285, 82);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 199);
            this.Controls.Add(this.btnGenerateQRCode);
            this.Controls.Add(this.txbHeight);
            this.Controls.Add(this.txbWidth);
            this.Controls.Add(this.txbContent);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.pbxQRCode);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.pbxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxQRCode;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txbContent;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.Button btnGenerateQRCode;
        private System.Windows.Forms.Label lblX;
    }
}

