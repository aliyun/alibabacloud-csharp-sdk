// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class File : TeaModel {
        /// <summary>
        /// <para>The origin allowed in cross-origin requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aliyundoc.com">https://aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("AccessControlAllowOrigin")]
        [Validation(Required=false)]
        public string AccessControlAllowOrigin { get; set; }

        /// <summary>
        /// <para>The method to be used in the actual cross-origin request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUT</para>
        /// </summary>
        [NameInMap("AccessControlRequestMethod")]
        [Validation(Required=false)]
        public string AccessControlRequestMethod { get; set; }

        /// <summary>
        /// <para>The addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// <para>The album.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FirstAlbum</para>
        /// </summary>
        [NameInMap("Album")]
        [Validation(Required=false)]
        public string Album { get; set; }

        /// <summary>
        /// <para>The singer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("AlbumArtist")]
        [Validation(Required=false)]
        public string AlbumArtist { get; set; }

        /// <summary>
        /// <para>The artist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("Artist")]
        [Validation(Required=false)]
        public string Artist { get; set; }

        /// <summary>
        /// <para>The audio covers.</para>
        /// </summary>
        [NameInMap("AudioCovers")]
        [Validation(Required=false)]
        public List<Image> AudioCovers { get; set; }

        /// <summary>
        /// <para>The list of audio streams.</para>
        /// </summary>
        [NameInMap("AudioStreams")]
        [Validation(Required=false)]
        public List<AudioStream> AudioStreams { get; set; }

        /// <summary>
        /// <para>The bitrate. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13091201</para>
        /// </summary>
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        /// <summary>
        /// <para>The caching behavior of the web page when the object is downloaded.</para>
        /// <para>This parameter corresponds to the Cache-Control HTTP header of the OSS object. For more information, see <a href="https://help.aliyun.com/document_detail/31859.html">Manage object metadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no-cache</para>
        /// </summary>
        [NameInMap("CacheControl")]
        [Validation(Required=false)]
        public string CacheControl { get; set; }

        /// <summary>
        /// <para>The composer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("Composer")]
        [Validation(Required=false)]
        public string Composer { get; set; }

        /// <summary>
        /// <para>The name of the object during the download.</para>
        /// <para>This parameter corresponds to the Content-Disposition HTTP header of the OSS object. For more information, see <a href="https://help.aliyun.com/document_detail/31859.html">Manage object metadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>attachment; filename =test.jpg</para>
        /// </summary>
        [NameInMap("ContentDisposition")]
        [Validation(Required=false)]
        public string ContentDisposition { get; set; }

        /// <summary>
        /// <para>The content encoding format of the object when the object is downloaded.</para>
        /// <para>This parameter corresponds to the Content-Encoding HTTP header of the OSS object. For more information, see <a href="https://help.aliyun.com/document_detail/31859.html">Manage object metadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTF-8</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The language of the object content.</para>
        /// <para>This parameter corresponds to the Content-Language HTTP header of the OSS object. For more information, see <a href="https://help.aliyun.com/document_detail/31859.html">Manage object metadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ContentLanguage")]
        [Validation(Required=false)]
        public string ContentLanguage { get; set; }

        /// <summary>
        /// <para>The MD5 value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HZwoCnxPZ/fvhz4oRJ2+Fw==</para>
        /// </summary>
        [NameInMap("ContentMd5")]
        [Validation(Required=false)]
        public string ContentMd5 { get; set; }

        /// <summary>
        /// <para>The Multipurpose Internet Mail Extensions (MIME) type of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/jpeg</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The RFC3339Nano timestamp when the metadata was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The cropping suggestions for the image.</para>
        /// <remarks>
        /// <para>Not supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CroppingSuggestions")]
        [Validation(Required=false)]
        public List<CroppingSuggestion> CroppingSuggestions { get; set; }

        /// <summary>
        /// <para>The custom ID of the file. When the cluster is indexed into the dataset, the custom ID is stored as the data attribute. You can map the custom ID to other data in your business system. Configure this parameter based on your business requirements. For example, you can associate a URI with an ID in your system. We recommend that you set this parameter to a globally unique value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>member-image-id-0001</para>
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// <para>The custom labels of the file. This parameter is optional. The parameter stores custom key-value labels, which can be used to filter data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;MemberName&quot;: &quot;Tim&quot;,
        ///       &quot;Enabled&quot;: &quot;True&quot;,
        ///       &quot;ItemCount&quot;: &quot;10&quot;
        /// }</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// <para>The name of the dataset. You can obtain the name of the dataset from the response of the <a href="https://help.aliyun.com/document_detail/478160.html">CreateDataset</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The total duration of the video. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15.263000</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        /// <summary>
        /// <para>The ETag of the object. ETags are used to identify the content of objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;1D9C280A7C4F67F7EF873E28449****&quot;</para>
        /// </summary>
        [NameInMap("ETag")]
        [Validation(Required=false)]
        public string ETag { get; set; }

        /// <summary>
        /// <para>The original EXIF information about the image. The EXIF information is stored in the serialized JSON format. For more information, see <a href="https://help.aliyun.com/document_detail/44975.html">Query image information</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Compression&quot;:{&quot;value&quot;:&quot;6&quot;},&quot;DateTime&quot;:{&quot;value&quot;:&quot;2020:08:19 17:11:11&quot;}}</para>
        /// </summary>
        [NameInMap("EXIF")]
        [Validation(Required=false)]
        public string EXIF { get; set; }

        /// <summary>
        /// <para>The document elements that match the current query content when you call the SemanticQuery operation for semantic search.</para>
        /// </summary>
        [NameInMap("Elements")]
        [Validation(Required=false)]
        public List<Element> Elements { get; set; }

        /// <summary>
        /// <para>The number of persons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FigureCount")]
        [Validation(Required=false)]
        public long? FigureCount { get; set; }

        /// <summary>
        /// <para>The list of persons. The persons are detected via AI models.</para>
        /// </summary>
        [NameInMap("Figures")]
        [Validation(Required=false)]
        public List<Figure> Figures { get; set; }

        /// <summary>
        /// <para>The RFC3339Nano timestamp when the file was accessed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("FileAccessTime")]
        [Validation(Required=false)]
        public string FileAccessTime { get; set; }

        /// <summary>
        /// <para>The RFC3339Nano timestamp when the file was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The hash value of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d9c280a7c4f67f7ef873e28449dbe17</para>
        /// </summary>
        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        /// <summary>
        /// <para>The RFC3339Nano timestamp when the file was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("FileModifiedTime")]
        [Validation(Required=false)]
        public string FileModifiedTime { get; set; }

        /// <summary>
        /// <para>The name of the object. For an OSS object, the value of this parameter is the object name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sampleobject.jpg</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>The full name of the media format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QuickTime / MOV</para>
        /// </summary>
        [NameInMap("FormatLongName")]
        [Validation(Required=false)]
        public string FormatLongName { get; set; }

        /// <summary>
        /// <para>The name of the media format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mov</para>
        /// </summary>
        [NameInMap("FormatName")]
        [Validation(Required=false)]
        public string FormatName { get; set; }

        /// <summary>
        /// <para>The height of the image. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("ImageHeight")]
        [Validation(Required=false)]
        public long? ImageHeight { get; set; }

        /// <summary>
        /// <para>The score of the image. The score is calculated by using AI models.</para>
        /// </summary>
        [NameInMap("ImageScore")]
        [Validation(Required=false)]
        public ImageScore ImageScore { get; set; }

        /// <summary>
        /// <para>The width of the image. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>270</para>
        /// </summary>
        [NameInMap("ImageWidth")]
        [Validation(Required=false)]
        public long? ImageWidth { get; set; }

        /// <summary>
        /// <para>Summary and description of the file.</para>
        /// <remarks>
        /// <para>Not supported.</para>
        /// </remarks>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Insights")]
        [Validation(Required=false)]
        public Insights Insights { get; set; }

        /// <summary>
        /// <para>The labels of the file. The labels are detected via AI models.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The language specified by using a BCP 47 language tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eng</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The latitude and longitude.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30.134390,120.074997</para>
        /// </summary>
        [NameInMap("LatLong")]
        [Validation(Required=false)]
        public string LatLong { get; set; }

        /// <summary>
        /// <para>The media type of the file.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image</description></item>
        /// <item><description>other</description></item>
        /// <item><description>document</description></item>
        /// <item><description>archive</description></item>
        /// <item><description>audio</description></item>
        /// <item><description>video</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The Optical Character Recognition (OCR) results.</para>
        /// <remarks>
        /// <para>Not supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("OCRContents")]
        [Validation(Required=false)]
        public List<OCRContents> OCRContents { get; set; }

        /// <summary>
        /// <para>The text detected in the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud IMM</para>
        /// </summary>
        [NameInMap("OCRTexts")]
        [Validation(Required=false)]
        public string OCRTexts { get; set; }

        /// <summary>
        /// <para>The CRC64 value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>559890638950338001</para>
        /// </summary>
        [NameInMap("OSSCRC64")]
        [Validation(Required=false)]
        public string OSSCRC64 { get; set; }

        /// <summary>
        /// <para>The delete marker of the object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAEQMhiBgIDXiaaB0BYiIGQzYmRkZGUxMTM1ZDRjOTZhNjk4YjRjMTAyZjhl****</para>
        /// </summary>
        [NameInMap("OSSDeleteMarker")]
        [Validation(Required=false)]
        public string OSSDeleteMarker { get; set; }

        /// <summary>
        /// <para>The expiration time of the OSS object.</para>
        /// <para>This parameter corresponds to the Expires HTTP header of the OSS object. For more information, see <a href="https://help.aliyun.com/document_detail/31859.html">Manage object metadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2120-01-01T12:00:00.000Z</para>
        /// </summary>
        [NameInMap("OSSExpiration")]
        [Validation(Required=false)]
        public string OSSExpiration { get; set; }

        /// <summary>
        /// <para>The type of the OSS object. Set the value to <c>Normal</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("OSSObjectType")]
        [Validation(Required=false)]
        public string OSSObjectType { get; set; }

        /// <summary>
        /// <para>The storage class of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("OSSStorageClass")]
        [Validation(Required=false)]
        public string OSSStorageClass { get; set; }

        /// <summary>
        /// <para>The tag of the object.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/106678.html">Add tags to an object</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;val&quot;}</para>
        /// </summary>
        [NameInMap("OSSTagging")]
        [Validation(Required=false)]
        public Dictionary<string, object> OSSTagging { get; set; }

        /// <summary>
        /// <para>The number of OSS object tags.</para>
        /// <para>This parameter is available only if tags are added to the corresponding OSS object. For more information, see <a href="https://help.aliyun.com/document_detail/106678.html">Add tags to an object</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("OSSTaggingCount")]
        [Validation(Required=false)]
        public long? OSSTaggingCount { get; set; }

        /// <summary>
        /// <para>The URI of the OSS object. This parameter is available only if the value of the URI parameter is the URI of a file in Photo and Drive Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/sampleobject.jpg</para>
        /// </summary>
        [NameInMap("OSSURI")]
        [Validation(Required=false)]
        public string OSSURI { get; set; }

        /// <summary>
        /// <para>The user metadata of the OSS object.</para>
        /// <para>This parameter is available only if user metadata is configured for the OSS object. For more information, see <a href="https://help.aliyun.com/document_detail/31859.html">Manage object metadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;val&quot;}</para>
        /// </summary>
        [NameInMap("OSSUserMeta")]
        [Validation(Required=false)]
        public Dictionary<string, object> OSSUserMeta { get; set; }

        /// <summary>
        /// <para>The version of the object.</para>
        /// <para>This parameter is available only if versioning is enabled for the bucket. For more information, see <a href="https://help.aliyun.com/document_detail/109695.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAEQNhiBgMDJgZCA0BYiIDc4MGZjZGI2OTBjOTRmNTE5NmU5NmFhZjhjYmY0****</para>
        /// </summary>
        [NameInMap("OSSVersionId")]
        [Validation(Required=false)]
        public string OSSVersionId { get; set; }

        /// <summary>
        /// <para>The access control list (ACL) of the OSS object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ObjectACL")]
        [Validation(Required=false)]
        public string ObjectACL { get; set; }

        /// <summary>
        /// <para>The unique ID of the object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75d5de2c50754e3dadd5c35dbca5f9949369e37eb342a73821f690c94c36c7f7</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The status of the object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Indexed</para>
        /// </summary>
        [NameInMap("ObjectStatus")]
        [Validation(Required=false)]
        public string ObjectStatus { get; set; }

        /// <summary>
        /// <para>The type of the object. Set the value to <b>file</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The image rotation angle. You can obtain the value from the exchangeable image file format (EXIF).</para>
        /// <para>If the EXIF metadata does not contain the image rotation angle, this parameter is not included in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Orientation")]
        [Validation(Required=false)]
        public long? Orientation { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102321002467****</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The number of pages.</para>
        /// <remarks>
        /// <para>Not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// <para>The performer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("Performer")]
        [Validation(Required=false)]
        public string Performer { get; set; }

        /// <summary>
        /// <para>The time when the image was taken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("ProduceTime")]
        [Validation(Required=false)]
        public string ProduceTime { get; set; }

        /// <summary>
        /// <para>The number of programs in the media container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProgramCount")]
        [Validation(Required=false)]
        public long? ProgramCount { get; set; }

        /// <summary>
        /// <para>The name of the project. You can obtain the name of the project from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The reason why the file failed to run the index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[InternalError] The request has been failed due to some unknown error. status: 500, requestId: CC5ACFBD-BB7A-496D-A9D6-****</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The elements in the video segment, which are scene elements that you can extract from the video by using an AI model.</para>
        /// </summary>
        [NameInMap("SceneElements")]
        [Validation(Required=false)]
        public List<SceneElement> SceneElements { get; set; }

        /// <summary>
        /// <para>The reasons for which the current file is included in the search results when you call the SemanticQuery operation for semantic search.</para>
        /// </summary>
        [NameInMap("SemanticTypes")]
        [Validation(Required=false)]
        public List<string> SemanticTypes { get; set; }

        /// <summary>
        /// <para>The encryption method of the object.</para>
        /// <para>This parameter is available only if server encryption is configured for the OSS bucket. For more information, see <a href="https://help.aliyun.com/document_detail/31871.html">Server-side encryption</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SM4</para>
        /// </summary>
        [NameInMap("ServerSideDataEncryption")]
        [Validation(Required=false)]
        public string ServerSideDataEncryption { get; set; }

        /// <summary>
        /// <para>The encryption method on the server side.</para>
        /// <para>This parameter is available only if server encryption is configured for the OSS bucket. For more information, see <a href="https://help.aliyun.com/document_detail/31871.html">Server-side encryption</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AES256</para>
        /// </summary>
        [NameInMap("ServerSideEncryption")]
        [Validation(Required=false)]
        public string ServerSideEncryption { get; set; }

        /// <summary>
        /// <para>The algorithm that is used to encrypt the file on the server side.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SM4</para>
        /// </summary>
        [NameInMap("ServerSideEncryptionCustomerAlgorithm")]
        [Validation(Required=false)]
        public string ServerSideEncryptionCustomerAlgorithm { get; set; }

        /// <summary>
        /// <para>The ID of the customer master key (CMK) managed by Key Management Service (KMS).</para>
        /// <para>This parameter is available only if server encryption is configured for the OSS bucket. For more information, see <a href="https://help.aliyun.com/document_detail/31871.html">Server-side encryption</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9468da86-3509-4f8d-a61e-6eab1eac****</para>
        /// </summary>
        [NameInMap("ServerSideEncryptionKeyId")]
        [Validation(Required=false)]
        public string ServerSideEncryptionKeyId { get; set; }

        /// <summary>
        /// <para>The size of the object. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The time of the first frame. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        /// <summary>
        /// <para>The number of media streams in the media container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StreamCount")]
        [Validation(Required=false)]
        public long? StreamCount { get; set; }

        /// <summary>
        /// <para>The list of subtitle streams.</para>
        /// </summary>
        [NameInMap("Subtitles")]
        [Validation(Required=false)]
        public List<SubtitleStream> Subtitles { get; set; }

        /// <summary>
        /// <para>The time zone.</para>
        /// <remarks>
        /// <para> Not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The title of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// <remarks>
        /// <para>Not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("TravelClusterId")]
        [Validation(Required=false)]
        public string TravelClusterId { get; set; }

        /// <summary>
        /// <para>The URI of the file.</para>
        /// <para>The URI of an OSS object follows the oss://${Bucket}/${Object} format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Object}</c> is the path of the object with the extension included.</para>
        /// <para>The URI of a file in Photo and Drive Service follows the pds://domains/${domain}/drives/${drive}/files/${file}/revisions/${revision} format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/sampleobject.jpg</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

        /// <summary>
        /// <para>The RFC3339Nano timestamp when the metadata was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The height of the video. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("VideoHeight")]
        [Validation(Required=false)]
        public long? VideoHeight { get; set; }

        /// <summary>
        /// <para>The list of video streams.</para>
        /// </summary>
        [NameInMap("VideoStreams")]
        [Validation(Required=false)]
        public List<VideoStream> VideoStreams { get; set; }

        /// <summary>
        /// <para>The width of the video. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("VideoWidth")]
        [Validation(Required=false)]
        public long? VideoWidth { get; set; }

    }

}
