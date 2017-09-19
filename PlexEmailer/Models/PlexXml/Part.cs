   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */

using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlexEmailer.Models.PlexXml
{

	[XmlRoot(ElementName = "Part")]
	public class Part
	{
		[XmlElement(ElementName = "Stream")]
		public List<Stream> Stream { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "duration")]
		public string Duration { get; set; }

		[XmlAttribute(AttributeName = "container")]
		public string Container { get; set; }

		[XmlAttribute(AttributeName = "key")]
		public string Key { get; set; }

		[XmlAttribute(AttributeName = "optimizedForStreaming")]
		public string OptimizedForStreaming { get; set; }

		[XmlAttribute(AttributeName = "file")]
		public string File { get; set; }

		[XmlAttribute(AttributeName = "size")]
		public string Size { get; set; }

		[XmlAttribute(AttributeName = "audioProfile")]
		public string AudioProfile { get; set; }

		[XmlAttribute(AttributeName = "videoProfile")]
		public string VideoProfile { get; set; }

	}
}
