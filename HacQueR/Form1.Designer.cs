namespace HacQueR
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			TEXTDATA = new TextBox();
			CODETYPE = new ComboBox();
			QRCODE = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)QRCODE).BeginInit();
			SuspendLayout();
			// 
			// TEXTDATA
			// 
			TEXTDATA.Location = new Point(70, 8);
			TEXTDATA.Name = "TEXTDATA";
			TEXTDATA.Size = new Size(100, 23);
			TEXTDATA.TabIndex = 0;
			TEXTDATA.TextChanged += TEXTDATA_TextChanged;
			// 
			// CODETYPE
			// 
			CODETYPE.Enabled = false;
			CODETYPE.FormattingEnabled = true;
			CODETYPE.Items.AddRange(new object[] { "Text" });
			CODETYPE.Location = new Point(70, 37);
			CODETYPE.Name = "CODETYPE";
			CODETYPE.Size = new Size(100, 23);
			CODETYPE.TabIndex = 1;
			CODETYPE.Text = "Text";
			CODETYPE.SelectedIndexChanged += CODETYPE_SelectedIndexChanged;
			// 
			// QRCODE
			// 
			QRCODE.Image = Properties.Resources.cartoon_monitor_with;
			QRCODE.Location = new Point(176, 10);
			QRCODE.Name = "QRCODE";
			QRCODE.Size = new Size(100, 50);
			QRCODE.SizeMode = PictureBoxSizeMode.StretchImage;
			QRCODE.TabIndex = 2;
			QRCODE.TabStop = false;
			QRCODE.Click += QRCODE_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(11, 13);
			label1.Name = "label1";
			label1.Size = new Size(28, 15);
			label1.TabIndex = 3;
			label1.Text = "Text";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(11, 42);
			label2.Name = "label2";
			label2.Size = new Size(58, 15);
			label2.TabIndex = 4;
			label2.Text = "Data Type";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(288, 72);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(QRCODE);
			Controls.Add(CODETYPE);
			Controls.Add(TEXTDATA);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)QRCODE).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TEXTDATA;
		private ComboBox CODETYPE;
		private PictureBox QRCODE;
		private Label label1;
		private Label label2;
	}
}
