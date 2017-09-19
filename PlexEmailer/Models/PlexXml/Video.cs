   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */

using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlexEmailer.Models.PlexXml
{
	[XmlRoot(ElementName = "Video")]
	public class Video
	{
		[XmlElement(ElementName = "Media")]
		public List<Media> Media { get; set; }

		[XmlAttribute(AttributeName = "ratingKey")]
		public string RatingKey { get; set; }

		[XmlAttribute(AttributeName = "key")]
		public string Key { get; set; }

		[XmlAttribute(AttributeName = "guid")]
		public string Guid { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "title")]
		public string Title { get; set; }

		[XmlAttribute(AttributeName = "titleSort")]
		public string TitleSort { get; set; }

		[XmlAttribute(AttributeName = "summary")]
		public string Summary { get; set; }

		[XmlAttribute(AttributeName = "index")]
		public string Index { get; set; }

		[XmlAttribute(AttributeName = "year")]
		public string Year { get; set; }

		[XmlAttribute(AttributeName = "thumb")]
		public string Thumb { get; set; }

		[XmlAttribute(AttributeName = "art")]
		public string Art { get; set; }

		[XmlAttribute(AttributeName = "duration")]
		public string Duration { get; set; }

		[XmlAttribute(AttributeName = "originallyAvailableAt")]
		public string OriginallyAvailableAt { get; set; }

		[XmlAttribute(AttributeName = "addedAt")]
		public string AddedAt { get; set; }

		[XmlAttribute(AttributeName = "extraType")]
		public string ExtraType { get; set; }

		[XmlElement(ElementName = "Genre")]
		public List<Genre> Genre { get; set; }

		[XmlElement(ElementName = "Director")]
		public Director Director { get; set; }

		[XmlElement(ElementName = "Writer")]
		public Writer Writer { get; set; }

		[XmlElement(ElementName = "Country")]
		public Country Country { get; set; }

		[XmlElement(ElementName = "Role")]
		public List<Role> Role { get; set; }

		[XmlAttribute(AttributeName = "studio")]
		public string Studio { get; set; }

		[XmlAttribute(AttributeName = "contentRating")]
		public string ContentRating { get; set; }

		[XmlAttribute(AttributeName = "rating")]
		public string Rating { get; set; }

		[XmlAttribute(AttributeName = "audienceRating")]
		public string AudienceRating { get; set; }

		[XmlAttribute(AttributeName = "tagline")]
		public string Tagline { get; set; }

		[XmlAttribute(AttributeName = "updatedAt")]
		public string UpdatedAt { get; set; }

		[XmlAttribute(AttributeName = "audienceRatingImage")]
		public string AudienceRatingImage { get; set; }

		[XmlAttribute(AttributeName = "chapterSource")]
		public string ChapterSource { get; set; }

		[XmlAttribute(AttributeName = "primaryExtraKey")]
		public string PrimaryExtraKey { get; set; }

		[XmlAttribute(AttributeName = "ratingImage")]
		public string RatingImage { get; set; }

		[XmlAttribute(AttributeName = "parentRatingKey")]
		public string ParentRatingKey { get; set; }

		[XmlAttribute(AttributeName = "grandparentRatingKey")]
		public string GrandparentRatingKey { get; set; }

		[XmlAttribute(AttributeName = "grandparentKey")]
		public string GrandparentKey { get; set; }

		[XmlAttribute(AttributeName = "parentKey")]
		public string ParentKey { get; set; }

		[XmlAttribute(AttributeName = "grandparentTitle")]
		public string GrandparentTitle { get; set; }

		[XmlAttribute(AttributeName = "parentTitle")]
		public string ParentTitle { get; set; }

		[XmlAttribute(AttributeName = "parentIndex")]
		public string ParentIndex { get; set; }

		[XmlAttribute(AttributeName = "parentThumb")]
		public string ParentThumb { get; set; }

		[XmlAttribute(AttributeName = "grandparentThumb")]
		public string GrandparentThumb { get; set; }

		[XmlAttribute(AttributeName = "grandparentArt")]
		public string GrandparentArt { get; set; }

		[XmlAttribute(AttributeName = "grandparentTheme")]
		public string GrandparentTheme { get; set; }
	}

}
