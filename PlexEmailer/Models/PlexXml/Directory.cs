   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */

using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlexEmailer.Models.PlexXml
{
	[XmlRoot(ElementName = "Directory")]
	public class Directory
	{
		[XmlElement(ElementName = "Location")]
		public Location Location { get; set; }

		[XmlAttribute(AttributeName = "allowSync")]
		public string AllowSync { get; set; }

		[XmlAttribute(AttributeName = "art")]
		public string Art { get; set; }

		[XmlAttribute(AttributeName = "composite")]
		public string Composite { get; set; }

		[XmlAttribute(AttributeName = "filters")]
		public string Filters { get; set; }

		[XmlAttribute(AttributeName = "refreshing")]
		public string Refreshing { get; set; }

		[XmlAttribute(AttributeName = "thumb")]
		public string Thumb { get; set; }

		[XmlAttribute(AttributeName = "key")]
		public string Key { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "title")]
		public string Title { get; set; }

		[XmlAttribute(AttributeName = "agent")]
		public string Agent { get; set; }

		[XmlAttribute(AttributeName = "scanner")]
		public string Scanner { get; set; }

		[XmlAttribute(AttributeName = "language")]
		public string Language { get; set; }

		[XmlAttribute(AttributeName = "uuid")]
		public string Uuid { get; set; }

		[XmlAttribute(AttributeName = "updatedAt")]
		public string UpdatedAt { get; set; }

		[XmlAttribute(AttributeName = "createdAt")]
		public string CreatedAt { get; set; }

		[XmlAttribute(AttributeName = "count")]
		public string Count { get; set; }

		[XmlAttribute(AttributeName = "addedAt")]
		public string AddedAt { get; set; }

		[XmlElement(ElementName = "Genre")]
		public List<Genre> Genre { get; set; }

		[XmlElement(ElementName = "Role")]
		public List<Role> Role { get; set; }

		[XmlAttribute(AttributeName = "ratingKey")]
		public string RatingKey { get; set; }

		[XmlAttribute(AttributeName = "studio")]
		public string Studio { get; set; }

		[XmlAttribute(AttributeName = "contentRating")]
		public string ContentRating { get; set; }

		[XmlAttribute(AttributeName = "summary")]
		public string Summary { get; set; }

		[XmlAttribute(AttributeName = "index")]
		public string Index { get; set; }

		[XmlAttribute(AttributeName = "rating")]
		public string Rating { get; set; }

		[XmlAttribute(AttributeName = "year")]
		public string Year { get; set; }

		[XmlAttribute(AttributeName = "banner")]
		public string Banner { get; set; }

		[XmlAttribute(AttributeName = "theme")]
		public string Theme { get; set; }

		[XmlAttribute(AttributeName = "duration")]
		public string Duration { get; set; }

		[XmlAttribute(AttributeName = "originallyAvailableAt")]
		public string OriginallyAvailableAt { get; set; }

		[XmlAttribute(AttributeName = "leafCount")]
		public string LeafCount { get; set; }

		[XmlAttribute(AttributeName = "viewedLeafCount")]
		public string ViewedLeafCount { get; set; }

		[XmlAttribute(AttributeName = "childCount")]
		public string ChildCount { get; set; }

		[XmlAttribute(AttributeName = "primaryExtraKey")]
		public string PrimaryExtraKey { get; set; }


	}


}
