using HacQueR.QRcodeDATA;
using QRCoder;
using System;
namespace HacQueR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void TEXTDATA_TextChanged(object sender, EventArgs e)
		{
			UpdateQR();
		}

		private void CODETYPE_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void QRCODE_Click(object sender, EventArgs e)
		{

		}
		private void UpdateQR()
		{
			if (string.IsNullOrWhiteSpace(TEXTDATA.Text))
			{
				QRCODE.Image = null;
				return;
			}

			QRcodeData qr = new QRcodeData(TEXTDATA.Text);

			string formatted = qr.DataString; // later: qr.GetFormatted()

			QRCodeGenerator gen = new QRCodeGenerator();
			QRCodeData data = gen.CreateQrCode(formatted, QRCodeGenerator.ECCLevel.Q);
			QRCode code = new QRCode(data);

			QRCODE.Image = code.GetGraphic(20);
		}

	}
}
