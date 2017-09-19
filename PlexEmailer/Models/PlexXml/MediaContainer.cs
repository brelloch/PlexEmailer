   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */

using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlexEmailer.Models.PlexXml
{
    [XmlRoot(ElementName = "MediaContainer")]
    public class MediaContainer
    {
        [XmlElement(ElementName = "Directory")]
        public List<Directory> Directory { get; set; }

        [XmlAttribute(AttributeName = "size")]
        public string Size { get; set; }

        [XmlAttribute(AttributeName = "allowCameraUpload")]
        public string AllowCameraUpload { get; set; }

        [XmlAttribute(AttributeName = "allowChannelAccess")]
        public string AllowChannelAccess { get; set; }

        [XmlAttribute(AttributeName = "allowMediaDeletion")]
        public string AllowMediaDeletion { get; set; }

        [XmlAttribute(AttributeName = "allowSharing")]
        public string AllowSharing { get; set; }

        [XmlAttribute(AttributeName = "allowSync")]
        public string AllowSync { get; set; }

        [XmlAttribute(AttributeName = "backgroundProcessing")]
        public string BackgroundProcessing { get; set; }

        [XmlAttribute(AttributeName = "certificate")]
        public string Certificate { get; set; }

        [XmlAttribute(AttributeName = "companionProxy")]
        public string CompanionProxy { get; set; }

        [XmlAttribute(AttributeName = "diagnostics")]
        public string Diagnostics { get; set; }

        [XmlAttribute(AttributeName = "eventStream")]
        public string EventStream { get; set; }

        [XmlAttribute(AttributeName = "friendlyName")]
        public string FriendlyName { get; set; }

        [XmlAttribute(AttributeName = "hubSearch")]
        public string HubSearch { get; set; }

        [XmlAttribute(AttributeName = "itemClusters")]
        public string ItemClusters { get; set; }

        [XmlAttribute(AttributeName = "livetv")]
        public string Livetv { get; set; }

        [XmlAttribute(AttributeName = "machineIdentifier")]
        public string MachineIdentifier { get; set; }

        [XmlAttribute(AttributeName = "mediaProviders")]
        public string MediaProviders { get; set; }

        [XmlAttribute(AttributeName = "multiuser")]
        public string Multiuser { get; set; }

        [XmlAttribute(AttributeName = "myPlex")]
        public string MyPlex { get; set; }

        [XmlAttribute(AttributeName = "myPlexMappingState")]
        public string MyPlexMappingState { get; set; }

        [XmlAttribute(AttributeName = "myPlexSigninState")]
        public string MyPlexSigninState { get; set; }

        [XmlAttribute(AttributeName = "myPlexSubscription")]
        public string MyPlexSubscription { get; set; }

        [XmlAttribute(AttributeName = "myPlexUsername")]
        public string MyPlexUsername { get; set; }

        [XmlAttribute(AttributeName = "ownerFeatures")]
        public string OwnerFeatures { get; set; }

        [XmlAttribute(AttributeName = "photoAutoTag")]
        public string PhotoAutoTag { get; set; }

        [XmlAttribute(AttributeName = "platform")]
        public string Platform { get; set; }

        [XmlAttribute(AttributeName = "platformVersion")]
        public string PlatformVersion { get; set; }

        [XmlAttribute(AttributeName = "pluginHost")]
        public string PluginHost { get; set; }

        [XmlAttribute(AttributeName = "readOnlyLibraries")]
        public string ReadOnlyLibraries { get; set; }

        [XmlAttribute(AttributeName = "requestParametersInCookie")]
        public string RequestParametersInCookie { get; set; }

        [XmlAttribute(AttributeName = "streamingBrainVersion")]
        public string StreamingBrainVersion { get; set; }

        [XmlAttribute(AttributeName = "sync")]
        public string Sync { get; set; }

        [XmlAttribute(AttributeName = "transcoderActiveVideoSessions")]
        public string TranscoderActiveVideoSessions { get; set; }

        [XmlAttribute(AttributeName = "transcoderAudio")]
        public string TranscoderAudio { get; set; }

        [XmlAttribute(AttributeName = "transcoderLyrics")]
        public string TranscoderLyrics { get; set; }

        [XmlAttribute(AttributeName = "transcoderPhoto")]
        public string TranscoderPhoto { get; set; }

        [XmlAttribute(AttributeName = "transcoderSubtitles")]
        public string TranscoderSubtitles { get; set; }

        [XmlAttribute(AttributeName = "transcoderVideo")]
        public string TranscoderVideo { get; set; }

        [XmlAttribute(AttributeName = "transcoderVideoBitrates")]
        public string TranscoderVideoBitrates { get; set; }

        [XmlAttribute(AttributeName = "transcoderVideoQualities")]
        public string TranscoderVideoQualities { get; set; }

        [XmlAttribute(AttributeName = "transcoderVideoResolutions")]
        public string TranscoderVideoResolutions { get; set; }

        [XmlAttribute(AttributeName = "updatedAt")]
        public string UpdatedAt { get; set; }

        [XmlAttribute(AttributeName = "updater")]
        public string Updater { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlAttribute(AttributeName = "voiceSearch")]
        public string VoiceSearch { get; set; }

        [XmlAttribute(AttributeName = "art")]
        public string Art { get; set; }

        [XmlAttribute(AttributeName = "identifier")]
        public string Identifier { get; set; }

        [XmlAttribute(AttributeName = "librarySectionID")]
        public string LibrarySectionID { get; set; }

        [XmlAttribute(AttributeName = "librarySectionTitle")]
        public string LibrarySectionTitle { get; set; }

        [XmlAttribute(AttributeName = "librarySectionUUID")]
        public string LibrarySectionUUID { get; set; }

        [XmlAttribute(AttributeName = "mediaTagPrefix")]
        public string MediaTagPrefix { get; set; }

        [XmlAttribute(AttributeName = "mediaTagVersion")]
        public string MediaTagVersion { get; set; }

        [XmlAttribute(AttributeName = "thumb")]
        public string Thumb { get; set; }

        [XmlAttribute(AttributeName = "title1")]
        public string Title1 { get; set; }

        [XmlAttribute(AttributeName = "title2")]
        public string Title2 { get; set; }

        [XmlAttribute(AttributeName = "viewGroup")]
        public string ViewGroup { get; set; }

        [XmlAttribute(AttributeName = "viewMode")]
        public string ViewMode { get; set; }

        [XmlElement(ElementName = "Video")]
        public List<Video> Video { get; set; }

    }

}
