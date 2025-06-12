// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class File : TeaModel {
        [NameInMap("AccessControlAllowOrigin")]
        [Validation(Required=false)]
        public string AccessControlAllowOrigin { get; set; }

        [NameInMap("AccessControlRequestMethod")]
        [Validation(Required=false)]
        public string AccessControlRequestMethod { get; set; }

        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<Address> Addresses { get; set; }

        [NameInMap("Album")]
        [Validation(Required=false)]
        public string Album { get; set; }

        [NameInMap("AlbumArtist")]
        [Validation(Required=false)]
        public string AlbumArtist { get; set; }

        [NameInMap("Artist")]
        [Validation(Required=false)]
        public string Artist { get; set; }

        [NameInMap("AudioCovers")]
        [Validation(Required=false)]
        public List<Image> AudioCovers { get; set; }

        [NameInMap("AudioStreams")]
        [Validation(Required=false)]
        public List<AudioStream> AudioStreams { get; set; }

        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        [NameInMap("CacheControl")]
        [Validation(Required=false)]
        public string CacheControl { get; set; }

        [NameInMap("Composer")]
        [Validation(Required=false)]
        public string Composer { get; set; }

        [NameInMap("ContentDisposition")]
        [Validation(Required=false)]
        public string ContentDisposition { get; set; }

        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        [NameInMap("ContentLanguage")]
        [Validation(Required=false)]
        public string ContentLanguage { get; set; }

        [NameInMap("ContentMd5")]
        [Validation(Required=false)]
        public string ContentMd5 { get; set; }

        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CroppingSuggestions")]
        [Validation(Required=false)]
        public List<CroppingSuggestion> CroppingSuggestions { get; set; }

        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        [NameInMap("ETag")]
        [Validation(Required=false)]
        public string ETag { get; set; }

        [NameInMap("EXIF")]
        [Validation(Required=false)]
        public string EXIF { get; set; }

        [NameInMap("Elements")]
        [Validation(Required=false)]
        public List<Element> Elements { get; set; }

        [NameInMap("FigureCount")]
        [Validation(Required=false)]
        public long? FigureCount { get; set; }

        [NameInMap("Figures")]
        [Validation(Required=false)]
        public List<Figure> Figures { get; set; }

        [NameInMap("FileAccessTime")]
        [Validation(Required=false)]
        public string FileAccessTime { get; set; }

        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        [NameInMap("FileModifiedTime")]
        [Validation(Required=false)]
        public string FileModifiedTime { get; set; }

        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("FormatLongName")]
        [Validation(Required=false)]
        public string FormatLongName { get; set; }

        [NameInMap("FormatName")]
        [Validation(Required=false)]
        public string FormatName { get; set; }

        [NameInMap("ImageHeight")]
        [Validation(Required=false)]
        public long? ImageHeight { get; set; }

        [NameInMap("ImageScore")]
        [Validation(Required=false)]
        public ImageScore ImageScore { get; set; }

        [NameInMap("ImageWidth")]
        [Validation(Required=false)]
        public long? ImageWidth { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Insights")]
        [Validation(Required=false)]
        public Insights Insights { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("LatLong")]
        [Validation(Required=false)]
        public string LatLong { get; set; }

        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        [NameInMap("OCRContents")]
        [Validation(Required=false)]
        public List<OCRContents> OCRContents { get; set; }

        [NameInMap("OCRTexts")]
        [Validation(Required=false)]
        public string OCRTexts { get; set; }

        [NameInMap("OSSCRC64")]
        [Validation(Required=false)]
        public string OSSCRC64 { get; set; }

        [NameInMap("OSSDeleteMarker")]
        [Validation(Required=false)]
        public string OSSDeleteMarker { get; set; }

        [NameInMap("OSSExpiration")]
        [Validation(Required=false)]
        public string OSSExpiration { get; set; }

        [NameInMap("OSSObjectType")]
        [Validation(Required=false)]
        public string OSSObjectType { get; set; }

        [NameInMap("OSSStorageClass")]
        [Validation(Required=false)]
        public string OSSStorageClass { get; set; }

        [NameInMap("OSSTagging")]
        [Validation(Required=false)]
        public Dictionary<string, object> OSSTagging { get; set; }

        [NameInMap("OSSTaggingCount")]
        [Validation(Required=false)]
        public long? OSSTaggingCount { get; set; }

        [NameInMap("OSSURI")]
        [Validation(Required=false)]
        public string OSSURI { get; set; }

        [NameInMap("OSSUserMeta")]
        [Validation(Required=false)]
        public Dictionary<string, object> OSSUserMeta { get; set; }

        [NameInMap("OSSVersionId")]
        [Validation(Required=false)]
        public string OSSVersionId { get; set; }

        [NameInMap("ObjectACL")]
        [Validation(Required=false)]
        public string ObjectACL { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("ObjectStatus")]
        [Validation(Required=false)]
        public string ObjectStatus { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("Orientation")]
        [Validation(Required=false)]
        public long? Orientation { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        [NameInMap("Performer")]
        [Validation(Required=false)]
        public string Performer { get; set; }

        [NameInMap("ProduceTime")]
        [Validation(Required=false)]
        public string ProduceTime { get; set; }

        [NameInMap("ProgramCount")]
        [Validation(Required=false)]
        public long? ProgramCount { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("SceneElements")]
        [Validation(Required=false)]
        public List<SceneElement> SceneElements { get; set; }

        [NameInMap("SemanticTypes")]
        [Validation(Required=false)]
        public List<string> SemanticTypes { get; set; }

        [NameInMap("ServerSideDataEncryption")]
        [Validation(Required=false)]
        public string ServerSideDataEncryption { get; set; }

        [NameInMap("ServerSideEncryption")]
        [Validation(Required=false)]
        public string ServerSideEncryption { get; set; }

        [NameInMap("ServerSideEncryptionCustomerAlgorithm")]
        [Validation(Required=false)]
        public string ServerSideEncryptionCustomerAlgorithm { get; set; }

        [NameInMap("ServerSideEncryptionKeyId")]
        [Validation(Required=false)]
        public string ServerSideEncryptionKeyId { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        [NameInMap("StreamCount")]
        [Validation(Required=false)]
        public long? StreamCount { get; set; }

        [NameInMap("Subtitles")]
        [Validation(Required=false)]
        public List<SubtitleStream> Subtitles { get; set; }

        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("TravelClusterId")]
        [Validation(Required=false)]
        public string TravelClusterId { get; set; }

        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("VideoHeight")]
        [Validation(Required=false)]
        public long? VideoHeight { get; set; }

        [NameInMap("VideoStreams")]
        [Validation(Required=false)]
        public List<VideoStream> VideoStreams { get; set; }

        [NameInMap("VideoWidth")]
        [Validation(Required=false)]
        public long? VideoWidth { get; set; }

    }

}
