using System;
using System.Drawing;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            if (txbContent.Text == string.Empty || txbWidth.Text == string.Empty && txbHeight.Text == string.Empty)
            {
                MessageBox.Show("Informe os dados corretamente");
                txbContent.Focus();
                return;
            }
            try
            {
                int width = Convert.ToInt32(txbWidth.Text);
                int height = Convert.ToInt32(txbHeight.Text);
                pbxQRCode.Image = GenerateQRCode(width, height, txbContent.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Bitmap GenerateQRCode(int width, int height, string text)
        {
            try
            {
                var bw = new ZXing.BarcodeWriter();
                var encOptions = new ZXing.Common.EncodingOptions() { Width = width, Height = height, Margin = 0 };
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;

                var result = new Bitmap(bw.Write(text));

                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}