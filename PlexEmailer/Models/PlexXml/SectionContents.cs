   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */

using System.Xml.Serialization;

namespace PlexEmailer.Models.PlexXml
{

	[XmlRoot(ElementName="Genre")]
	public class Genre {
		[XmlAttribute(AttributeName="tag")]
		public string Tag { get; set; }
	}

	[XmlRoot(ElementName="Director")]
	public class Director {
		[XmlAttribute(AttributeName="tag")]
		public string Tag { get; set; }
	}

	[XmlRoot(ElementName="Writer")]
	public class Writer {
		[XmlAttribute(AttributeName="tag")]
		public string Tag { get; set; }
	}

	[XmlRoot(ElementName="Country")]
	public class Country {
		[XmlAttribute(AttributeName="tag")]
		public string Tag { get; set; }
	}

	[XmlRoot(ElementName="Role")]
	public class Role {
		[XmlAttribute(AttributeName="tag")]
		public string Tag { get; set; }
	}


}
