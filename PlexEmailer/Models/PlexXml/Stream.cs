   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */

using System.Xml.Serialization;

namespace PlexEmailer.Models.PlexXml
{
	[XmlRoot(ElementName="Stream")]
	public class Stream {
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName="streamType")]
		public string StreamType { get; set; }
		[XmlAttribute(AttributeName="codec")]
		public string Codec { get; set; }
		[XmlAttribute(AttributeName="index")]
		public string Index { get; set; }
		[XmlAttribute(AttributeName="bitrate")]
		public string Bitrate { get; set; }
		[XmlAttribute(AttributeName="height")]
		public string Height { get; set; }
		[XmlAttribute(AttributeName="width")]
		public string Width { get; set; }
		[XmlAttribute(AttributeName="selected")]
		public string Selected { get; set; }
		[XmlAttribute(AttributeName="channels")]
		public string Channels { get; set; }
		[XmlAttribute(AttributeName="language")]
		public string Language { get; set; }
		[XmlAttribute(AttributeName="languageCode")]
		public string LanguageCode { get; set; }
	}

}
