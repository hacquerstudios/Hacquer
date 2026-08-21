namespace HacQueR.QRcodeDATA
{
	public enum Format
	{
		Text
	}

	public class QRcodeData
	{
		public Format DataType { get; } = Format.Text;//TODO: change to public set; when other formats are added

		public string DataString { get; set; }

		public QRcodeData(string data)
		{
			DataString = data;
		}
	}
}
