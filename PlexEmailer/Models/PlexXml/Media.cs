   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */

using System.Xml.Serialization;

namespace PlexEmailer.Models.PlexXml
{

	[XmlRoot(ElementName = "Media")]
	public class Media
	{
		[XmlElement(ElementName = "Part")]
		public Part Part { get; set; }

		[XmlAttribute(AttributeName = "videoResolution")]
		public string VideoResolution { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "duration")]
		public string Duration { get; set; }

		[XmlAttribute(AttributeName = "bitrate")]
		public string Bitrate { get; set; }

		[XmlAttribute(AttributeName = "width")]
		public string Width { get; set; }

		[XmlAttribute(AttributeName = "height")]
		public string Height { get; set; }

		[XmlAttribute(AttributeName = "aspectRatio")]
		public string AspectRatio { get; set; }

		[XmlAttribute(AttributeName = "audioCodec")]
		public string AudioCodec { get; set; }

		[XmlAttribute(AttributeName = "videoCodec")]
		public string VideoCodec { get; set; }

		[XmlAttribute(AttributeName = "container")]
		public string Container { get; set; }

		[XmlAttribute(AttributeName = "premium")]
		public string Premium { get; set; }

		[XmlAttribute(AttributeName = "audioChannels")]
		public string AudioChannels { get; set; }

		[XmlAttribute(AttributeName = "videoFrameRate")]
		public string VideoFrameRate { get; set; }

		[XmlAttribute(AttributeName = "audioProfile")]
		public string AudioProfile { get; set; }

		[XmlAttribute(AttributeName = "videoProfile")]
		public string VideoProfile { get; set; }

	}

}
