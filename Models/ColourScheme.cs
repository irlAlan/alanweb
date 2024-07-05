// Properties for the Colour Scheme

namespace BlazorAppTest.Models
{
	public class ColourScheme
	{
		public ColourScheme() { }
		private string ContentColDefault = "black";
		public string ContentCol { get { return ContentColDefault; } set { ContentColDefault = value; } }
	
		private string BackgroundDefault = "white";
		public string Background { get { return BackgroundDefault; } set { BackgroundDefault = value; } }

		private string AccentColDefault = "white";
		public string AccentCol { get { return AccentColDefault; } set { AccentColDefault = value; } }
	}
}
