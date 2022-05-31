// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class File : TeaModel {
        /// <summary>
        /// AccessControlAllowOrigin
        /// </summary>
        [NameInMap("AccessControlAllowOrigin")]
        [Validation(Required=false)]
        public string AccessControlAllowOrigin { get; set; }

        /// <summary>
        /// AccessControlRequestMethod
        /// </summary>
        [NameInMap("AccessControlRequestMethod")]
        [Validation(Required=false)]
        public string AccessControlRequestMethod { get; set; }

        /// <summary>
        /// Addresses
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Album
        /// </summary>
        [NameInMap("Album")]
        [Validation(Required=false)]
        public string Album { get; set; }

        /// <summary>
        /// AlbumArtist
        /// </summary>
        [NameInMap("AlbumArtist")]
        [Validation(Required=false)]
        public string AlbumArtist { get; set; }

        /// <summary>
        /// Artist
        /// </summary>
        [NameInMap("Artist")]
        [Validation(Required=false)]
        public string Artist { get; set; }

        /// <summary>
        /// AudioCovers
        /// </summary>
        [NameInMap("AudioCovers")]
        [Validation(Required=false)]
        public List<Image> AudioCovers { get; set; }

        /// <summary>
        /// AudioStreams
        /// </summary>
        [NameInMap("AudioStreams")]
        [Validation(Required=false)]
        public List<AudioStream> AudioStreams { get; set; }

        /// <summary>
        /// Bitrate
        /// </summary>
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        /// <summary>
        /// CacheControl
        /// </summary>
        [NameInMap("CacheControl")]
        [Validation(Required=false)]
        public string CacheControl { get; set; }

        /// <summary>
        /// Composer
        /// </summary>
        [NameInMap("Composer")]
        [Validation(Required=false)]
        public string Composer { get; set; }

        /// <summary>
        /// ContentDisposition
        /// </summary>
        [NameInMap("ContentDisposition")]
        [Validation(Required=false)]
        public string ContentDisposition { get; set; }

        /// <summary>
        /// ContentEncoding
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// ContentLanguage
        /// </summary>
        [NameInMap("ContentLanguage")]
        [Validation(Required=false)]
        public string ContentLanguage { get; set; }

        /// <summary>
        /// ContentMd5
        /// </summary>
        [NameInMap("ContentMd5")]
        [Validation(Required=false)]
        public string ContentMd5 { get; set; }

        /// <summary>
        /// ContentType
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// CroppingSuggestions
        /// </summary>
        [NameInMap("CroppingSuggestions")]
        [Validation(Required=false)]
        public List<CroppingSuggestion> CroppingSuggestions { get; set; }

        /// <summary>
        /// CustomId
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// CustomLabels
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// DatasetName
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// DocumentContent
        /// </summary>
        [NameInMap("DocumentContent")]
        [Validation(Required=false)]
        public string DocumentContent { get; set; }

        /// <summary>
        /// DocumentLanguage
        /// </summary>
        [NameInMap("DocumentLanguage")]
        [Validation(Required=false)]
        public string DocumentLanguage { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        /// <summary>
        /// ETag
        /// </summary>
        [NameInMap("ETag")]
        [Validation(Required=false)]
        public string ETag { get; set; }

        /// <summary>
        /// EXIF
        /// </summary>
        [NameInMap("EXIF")]
        [Validation(Required=false)]
        public string EXIF { get; set; }

        /// <summary>
        /// FigureCount
        /// </summary>
        [NameInMap("FigureCount")]
        [Validation(Required=false)]
        public long? FigureCount { get; set; }

        /// <summary>
        /// Figures
        /// </summary>
        [NameInMap("Figures")]
        [Validation(Required=false)]
        public List<Figure> Figures { get; set; }

        /// <summary>
        /// FileAccessTime
        /// </summary>
        [NameInMap("FileAccessTime")]
        [Validation(Required=false)]
        public string FileAccessTime { get; set; }

        /// <summary>
        /// FileCreateTime
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// FileHash
        /// </summary>
        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        /// <summary>
        /// FileModifiedTime
        /// </summary>
        [NameInMap("FileModifiedTime")]
        [Validation(Required=false)]
        public string FileModifiedTime { get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// FormatLongName
        /// </summary>
        [NameInMap("FormatLongName")]
        [Validation(Required=false)]
        public string FormatLongName { get; set; }

        /// <summary>
        /// FormatName
        /// </summary>
        [NameInMap("FormatName")]
        [Validation(Required=false)]
        public string FormatName { get; set; }

        /// <summary>
        /// ImageHeight
        /// </summary>
        [NameInMap("ImageHeight")]
        [Validation(Required=false)]
        public long? ImageHeight { get; set; }

        [NameInMap("ImageScore")]
        [Validation(Required=false)]
        public ImageScore ImageScore { get; set; }

        /// <summary>
        /// ImageWidth
        /// </summary>
        [NameInMap("ImageWidth")]
        [Validation(Required=false)]
        public long? ImageWidth { get; set; }

        /// <summary>
        /// Labels
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// LatLong
        /// </summary>
        [NameInMap("LatLong")]
        [Validation(Required=false)]
        public string LatLong { get; set; }

        /// <summary>
        /// MediaType
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// OCRContents
        /// </summary>
        [NameInMap("OCRContents")]
        [Validation(Required=false)]
        public List<OCRContents> OCRContents { get; set; }

        /// <summary>
        /// OSSCRC64
        /// </summary>
        [NameInMap("OSSCRC64")]
        [Validation(Required=false)]
        public string OSSCRC64 { get; set; }

        /// <summary>
        /// OSSDeleteMarker
        /// </summary>
        [NameInMap("OSSDeleteMarker")]
        [Validation(Required=false)]
        public string OSSDeleteMarker { get; set; }

        /// <summary>
        /// OSSExpiration
        /// </summary>
        [NameInMap("OSSExpiration")]
        [Validation(Required=false)]
        public string OSSExpiration { get; set; }

        /// <summary>
        /// OSSObjectType
        /// </summary>
        [NameInMap("OSSObjectType")]
        [Validation(Required=false)]
        public string OSSObjectType { get; set; }

        /// <summary>
        /// OSSStorageClass
        /// </summary>
        [NameInMap("OSSStorageClass")]
        [Validation(Required=false)]
        public string OSSStorageClass { get; set; }

        /// <summary>
        /// OSSTagging
        /// </summary>
        [NameInMap("OSSTagging")]
        [Validation(Required=false)]
        public Dictionary<string, object> OSSTagging { get; set; }

        /// <summary>
        /// OSSTaggingCount
        /// </summary>
        [NameInMap("OSSTaggingCount")]
        [Validation(Required=false)]
        public long? OSSTaggingCount { get; set; }

        /// <summary>
        /// OSSURI
        /// </summary>
        [NameInMap("OSSURI")]
        [Validation(Required=false)]
        public string OSSURI { get; set; }

        /// <summary>
        /// OSSUserMeta
        /// </summary>
        [NameInMap("OSSUserMeta")]
        [Validation(Required=false)]
        public Dictionary<string, object> OSSUserMeta { get; set; }

        /// <summary>
        /// OSSVersionId
        /// </summary>
        [NameInMap("OSSVersionId")]
        [Validation(Required=false)]
        public string OSSVersionId { get; set; }

        /// <summary>
        /// ObjectACL
        /// </summary>
        [NameInMap("ObjectACL")]
        [Validation(Required=false)]
        public string ObjectACL { get; set; }

        /// <summary>
        /// ObjectId
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// ObjectType
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// Orientation
        /// </summary>
        [NameInMap("Orientation")]
        [Validation(Required=false)]
        public long? Orientation { get; set; }

        /// <summary>
        /// OwnerId
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// PageCount
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// Performer
        /// </summary>
        [NameInMap("Performer")]
        [Validation(Required=false)]
        public string Performer { get; set; }

        /// <summary>
        /// ProduceTime
        /// </summary>
        [NameInMap("ProduceTime")]
        [Validation(Required=false)]
        public string ProduceTime { get; set; }

        /// <summary>
        /// ProgramCount
        /// </summary>
        [NameInMap("ProgramCount")]
        [Validation(Required=false)]
        public long? ProgramCount { get; set; }

        /// <summary>
        /// ProjectName
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// ServerSideDataEncryption
        /// </summary>
        [NameInMap("ServerSideDataEncryption")]
        [Validation(Required=false)]
        public string ServerSideDataEncryption { get; set; }

        /// <summary>
        /// ServerSideEncryption
        /// </summary>
        [NameInMap("ServerSideEncryption")]
        [Validation(Required=false)]
        public string ServerSideEncryption { get; set; }

        /// <summary>
        /// ServerSideEncryptionCustomerAlgorithm
        /// </summary>
        [NameInMap("ServerSideEncryptionCustomerAlgorithm")]
        [Validation(Required=false)]
        public string ServerSideEncryptionCustomerAlgorithm { get; set; }

        /// <summary>
        /// ServerSideEncryptionKeyId
        /// </summary>
        [NameInMap("ServerSideEncryptionKeyId")]
        [Validation(Required=false)]
        public string ServerSideEncryptionKeyId { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// StartTime
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// StreamCount
        /// </summary>
        [NameInMap("StreamCount")]
        [Validation(Required=false)]
        public long? StreamCount { get; set; }

        /// <summary>
        /// Subtitles
        /// </summary>
        [NameInMap("Subtitles")]
        [Validation(Required=false)]
        public List<SubtitleStream> Subtitles { get; set; }

        /// <summary>
        /// Timezone
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// TravelClusterId
        /// </summary>
        [NameInMap("TravelClusterId")]
        [Validation(Required=false)]
        public string TravelClusterId { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

        /// <summary>
        /// UpdateTime
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// VideoHeight
        /// </summary>
        [NameInMap("VideoHeight")]
        [Validation(Required=false)]
        public long? VideoHeight { get; set; }

        /// <summary>
        /// VideoStartTime
        /// </summary>
        [NameInMap("VideoStartTime")]
        [Validation(Required=false)]
        public float? VideoStartTime { get; set; }

        /// <summary>
        /// VideoStreams
        /// </summary>
        [NameInMap("VideoStreams")]
        [Validation(Required=false)]
        public List<VideoStream> VideoStreams { get; set; }

        /// <summary>
        /// VideoWidth
        /// </summary>
        [NameInMap("VideoWidth")]
        [Validation(Required=false)]
        public long? VideoWidth { get; set; }

    }

}
