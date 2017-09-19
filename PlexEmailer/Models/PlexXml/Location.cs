   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */

using System.Xml.Serialization;

namespace PlexEmailer.Models.PlexXml
{
	[XmlRoot(ElementName="Location")]
	public class Location {
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName="path")]
		public string Path { get; set; }
	}

}
