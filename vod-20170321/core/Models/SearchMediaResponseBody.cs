// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of media asset information.</para>
        /// </summary>
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public List<SearchMediaResponseBodyMediaList> MediaList { get; set; }
        public class SearchMediaResponseBodyMediaList : TeaModel {
            [NameInMap("AiData")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAiData AiData { get; set; }
            public class SearchMediaResponseBodyMediaListAiData : TeaModel {
                [NameInMap("AiLabelInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaListAiDataAiLabelInfo> AiLabelInfo { get; set; }
                public class SearchMediaResponseBodyMediaListAiDataAiLabelInfo : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("LabelId")]
                    [Validation(Required=false)]
                    public string LabelId { get; set; }

                    [NameInMap("LabelName")]
                    [Validation(Required=false)]
                    public string LabelName { get; set; }

                    [NameInMap("Occurrences")]
                    [Validation(Required=false)]
                    public List<SearchMediaResponseBodyMediaListAiDataAiLabelInfoOccurrences> Occurrences { get; set; }
                    public class SearchMediaResponseBodyMediaListAiDataAiLabelInfoOccurrences : TeaModel {
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public double? From { get; set; }

                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public double? Score { get; set; }

                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public double? To { get; set; }

                    }

                }

                [NameInMap("OcrInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaListAiDataOcrInfo> OcrInfo { get; set; }
                public class SearchMediaResponseBodyMediaListAiDataOcrInfo : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public double? From { get; set; }

                    [NameInMap("To")]
                    [Validation(Required=false)]
                    public double? To { get; set; }

                }

            }

            [NameInMap("AiRoughData")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAiRoughData AiRoughData { get; set; }
            public class SearchMediaResponseBodyMediaListAiRoughData : TeaModel {
                [NameInMap("AiCategory")]
                [Validation(Required=false)]
                public string AiCategory { get; set; }

                [NameInMap("AiJobId")]
                [Validation(Required=false)]
                public string AiJobId { get; set; }

                [NameInMap("SaveType")]
                [Validation(Required=false)]
                public string SaveType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para><a href="https://help.aliyun.com/document_detail/86991.html">Auxiliary media asset information</a>.</para>
            /// </summary>
            [NameInMap("AttachedMedia")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAttachedMedia AttachedMedia { get; set; }
            public class SearchMediaResponseBodyMediaListAttachedMedia : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The business type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>watermark</b>: watermark.</description></item>
                /// <item><description><b>subtitle</b>: subtitle.</description></item>
                /// <item><description><b>material</b>: material.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>watermark</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <para>The list of category IDs.</para>
                /// </summary>
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaListAttachedMediaCategories> Categories { get; set; }
                public class SearchMediaResponseBodyMediaListAttachedMediaCategories : TeaModel {
                    /// <summary>
                    /// <para>The category ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10027394</para>
                    /// </summary>
                    [NameInMap("CateId")]
                    [Validation(Required=false)]
                    public long? CateId { get; set; }

                    /// <summary>
                    /// <para>The category name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cate1</para>
                    /// </summary>
                    [NameInMap("CateName")]
                    [Validation(Required=false)]
                    public string CateName { get; set; }

                    /// <summary>
                    /// <para>The category level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public long? Level { get; set; }

                    /// <summary>
                    /// <para>The parent node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-1</para>
                    /// </summary>
                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public long? ParentId { get; set; }

                }

                /// <summary>
                /// <para>The creation time. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:45:25Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud VOD-assisted media asset description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The auxiliary media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a82a2cd7d4e147ba0ed6c1ee372****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The last modification time. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:48:25Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b> (uploading): the initial state. The auxiliary media asset is being uploaded.</description></item>
                /// <item><description><b>Normal</b> (normal): the auxiliary media asset is uploaded.</description></item>
                /// <item><description><b>UploadFail</b> (failed): the auxiliary media asset failed to be uploaded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-bfefbb90a47c11*****7426.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud VOD-assisted media asset Title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The auxiliary media asset URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/****.png">https://example.com/****.png</a></para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para><a href="https://help.aliyun.com/document_detail/86991.html">Audio information</a>.</para>
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAudio Audio { get; set; }
            public class SearchMediaResponseBodyMediaListAudio : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The audio ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a82a2cd7d4e147bbed6c1ee372****</para>
                /// </summary>
                [NameInMap("AudioId")]
                [Validation(Required=false)]
                public string AudioId { get; set; }

                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000123</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cate1</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The thumbnail URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/image04.jpg">http://example.com/image04.jpg</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The creation time. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:45:25Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud VOD Audio Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The download switch. Offline download is allowed only when the switch is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b> (enabled): the initial state. Offline download is allowed.</description></item>
                /// <item><description><b>off</b> (disabled): offline download is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("DownloadSwitch")]
                [Validation(Required=false)]
                public string DownloadSwitch { get; set; }

                /// <summary>
                /// <para>The duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// <para>The source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>general</b> (ApsaraVideo VOD upload): standard upload.</description></item>
                /// <item><description><b>short_video</b> (the short video SDK): files uploaded to ApsaraVideo VOD by using the short video SDK. For more information, see <a href="https://help.aliyun.com/document_detail/53407.html">Short video SDK</a>.</description></item>
                /// <item><description><b>editing</b> (online editing): files uploaded to ApsaraVideo VOD by using online editing. For more information, see <a href="https://help.aliyun.com/document_detail/68536.html">Produce videos</a>.</description></item>
                /// <item><description><b>live</b> (live recording): files uploaded to ApsaraVideo VOD through live recording.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("MediaSource")]
                [Validation(Required=false)]
                public string MediaSource { get; set; }

                /// <summary>
                /// <para>The last modification time. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:48:25Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The preprocessing status. Only preprocessed videos can be used for live streaming. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UnPreprocess</b>: not preprocessed.</description></item>
                /// <item><description><b>Preprocessing</b>: preprocessing.</description></item>
                /// <item><description><b>PreprocessSucceed</b>: preprocessing complete.</description></item>
                /// <item><description><b>PreprocessFailed</b>: preprocessing failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UnPreprocess</para>
                /// </summary>
                [NameInMap("PreprocessStatus")]
                [Validation(Required=false)]
                public string PreprocessStatus { get; set; }

                /// <summary>
                /// <para>The custom ID. Only lowercase letters, uppercase letters, digits, hyphens, and underscores are supported. The value must be 6 to 64 characters in length and is unique at the user level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123-123</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>The expiration time of the media asset restoration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-30T10:14:14Z</para>
                /// </summary>
                [NameInMap("RestoreExpiration")]
                [Validation(Required=false)]
                public string RestoreExpiration { get; set; }

                /// <summary>
                /// <para>The media asset restoration status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Processing</b>: restoring.</description></item>
                /// <item><description><b>Success</b>: restoration successful.</description></item>
                /// <item><description><b>Failed</b>: restoration failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

                /// <summary>
                /// <para>The size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The list of automatic snapshots.</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<string> Snapshots { get; set; }

                /// <summary>
                /// <para>The list of sprites.</para>
                /// </summary>
                [NameInMap("SpriteSnapshots")]
                [Validation(Required=false)]
                public List<string> SpriteSnapshots { get; set; }

                /// <summary>
                /// <para>The status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b>: uploading.</description></item>
                /// <item><description><b>Normal</b>: normal.	</description></item>
                /// <item><description><b>UploadFail</b>: upload failed.</description></item>
                /// <item><description><b>Deleted</b>: deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage class of the media asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: standard.</description></item>
                /// <item><description><b>IA</b>: Infrequent Access (media asset).</description></item>
                /// <item><description><b>Archive</b>: Archive (media asset).</description></item>
                /// <item><description><b>ColdArchive</b>: Cold Archive (media asset).</description></item>
                /// <item><description><b>SourceIA</b>: Infrequent Access (source file).</description></item>
                /// <item><description><b>SourceArchive</b>: Archive (source file).</description></item>
                /// <item><description><b>SourceColdArchive</b>: Cold Archive (source file).</description></item>
                /// <item><description><b>Changing</b>: the storage class is being changed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <para>The storage region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-aaa*****aa.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1,tag2</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud VOD Audio Title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The transcoding mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FastTranscode</b> (standard transcoding, default): transcoding starts after the upload is complete, and the audio can be played only after transcoding is complete.</description></item>
                /// <item><description><b>NoTranscode</b> (distribution without transcoding): the audio can be played immediately after the upload is complete without transcoding.</description></item>
                /// <item><description><b>AsyncTranscode</b> (distribution and transcoding upon upload): the audio can be played immediately after the upload is complete, and transcoding is performed asynchronously.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FastTranscode</para>
                /// </summary>
                [NameInMap("TranscodeMode")]
                [Validation(Required=false)]
                public string TranscodeMode { get; set; }

            }

            /// <summary>
            /// <para>The time when the media asset was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-19T03:45:25Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para><a href="https://help.aliyun.com/document_detail/86991.html">Image information</a>.</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListImage Image { get; set; }
            public class SearchMediaResponseBodyMediaListImage : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000123</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cate1</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The creation time. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:45:25Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud VOD Image Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11130843741se99wqmoes****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The last modification time. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:48:25Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The image status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b> (uploading): the initial state. The image is being uploaded.</description></item>
                /// <item><description><b>Normal</b> (normal): the image is uploaded.</description></item>
                /// <item><description><b>UploadFail</b> (failed): the image failed to be uploaded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Uploading</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-bfefbb90a47c******163e1c7426.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud VOD Image Title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/****.png">https://example.com/****.png</a></para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para>The media ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a82a2cd7d4e147bbed6c1ee372****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The media type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>video</b>: video.</description></item>
            /// <item><description><b>audio</b>: audio.</description></item>
            /// <item><description><b>image</b>: image.</description></item>
            /// <item><description><b>attached</b>: auxiliary media asset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// <para><a href="https://help.aliyun.com/document_detail/86991.html">Video information</a>.</para>
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListVideo Video { get; set; }
            public class SearchMediaResponseBodyMediaListVideo : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000123</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video1</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The thumbnail URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.aliyundoc.com/image01.png">https://example.aliyundoc.com/image01.png</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the video information was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:45:25Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The video description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud VOD video description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The download switch. Offline download is allowed only when the switch is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b> (enabled): the initial state. Offline download is allowed.</description></item>
                /// <item><description><b>off</b> (disabled): offline download is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("DownloadSwitch")]
                [Validation(Required=false)]
                public string DownloadSwitch { get; set; }

                /// <summary>
                /// <para>The video duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// <para>The source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>general</b>: ApsaraVideo VOD upload.</description></item>
                /// <item><description><b>short_video</b>: the short video SDK.</description></item>
                /// <item><description><b>editing</b>: online editing.</description></item>
                /// <item><description><b>live</b>: live recording.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("MediaSource")]
                [Validation(Required=false)]
                public string MediaSource { get; set; }

                /// <summary>
                /// <para>The time when the video information was last modified. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:48:25Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The preprocessing status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UnPreprocess</b>: not preprocessed.</description></item>
                /// <item><description><b>Preprocessing</b>: preprocessing.</description></item>
                /// <item><description><b>PreprocessSucceed</b>: preprocessing complete.</description></item>
                /// <item><description><b>PreprocessFailed</b>: preprocessing failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Preprocessing</para>
                /// </summary>
                [NameInMap("PreprocessStatus")]
                [Validation(Required=false)]
                public string PreprocessStatus { get; set; }

                /// <summary>
                /// <para>The custom ID. Only lowercase letters, uppercase letters, digits, hyphens, and underscores are supported. The value must be 6 to 64 characters in length and is unique at the user level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123-123</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>The expiration time of the media asset restoration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-30T10:14:14Z</para>
                /// </summary>
                [NameInMap("RestoreExpiration")]
                [Validation(Required=false)]
                public string RestoreExpiration { get; set; }

                /// <summary>
                /// <para>The media asset restoration status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Processing</b>: restoring.</description></item>
                /// <item><description><b>Success</b>: restoration successful.</description></item>
                /// <item><description><b>Failed</b>: restoration failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

                /// <summary>
                /// <para>The video size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The list of automatic snapshots.</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<string> Snapshots { get; set; }

                /// <summary>
                /// <para>The list of sprites.</para>
                /// </summary>
                [NameInMap("SpriteSnapshots")]
                [Validation(Required=false)]
                public List<string> SpriteSnapshots { get; set; }

                /// <summary>
                /// <para>The status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b>: uploading.</description></item>
                /// <item><description><b>UploadFail</b>: upload failed.</description></item>
                /// <item><description><b>UploadSucc</b>: upload complete.</description></item>
                /// <item><description><b>Transcoding</b>: transcoding.</description></item>
                /// <item><description><b>TranscodeFail</b>: transcoding failed.</description></item>
                /// <item><description><b>Blocked</b>: blocked.</description></item>
                /// <item><description><b>Normal</b>: normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UploadSucc</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage class of the media asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: standard.</description></item>
                /// <item><description><b>IA</b>: Infrequent Access (media asset).</description></item>
                /// <item><description><b>Archive</b>: Archive (media asset).</description></item>
                /// <item><description><b>ColdArchive</b>: Cold Archive (media asset).</description></item>
                /// <item><description><b>SourceIA</b>: Infrequent Access (source file).</description></item>
                /// <item><description><b>SourceArchive</b>: Archive (source file).</description></item>
                /// <item><description><b>SourceColdArchive</b>: Cold Archive (source file).</description></item>
                /// <item><description><b>Changing</b>: the storage class of the media asset is being changed.</description></item>
                /// <item><description><b>SourceChanging</b>: the storage class of the source file is being changed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <para>The storage region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-bfefbb90a47c******163e1c7426.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The video tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The video title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud VOD Video Title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The transcoding mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FastTranscode</b> (standard transcoding): the default mode. Transcoding starts after the upload is complete, and the video can be played only after transcoding is complete.</description></item>
                /// <item><description><b>NoTranscode</b> (distribution without transcoding): the video can be played immediately after the upload is complete without transcoding.</description></item>
                /// <item><description><b>AsyncTranscode</b> (distribution and transcoding upon upload): the video can be played immediately after the upload is complete, and transcoding is performed asynchronously.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FastTranscode</para>
                /// </summary>
                [NameInMap("TranscodeMode")]
                [Validation(Required=false)]
                public string TranscodeMode { get; set; }

                /// <summary>
                /// <para>The video ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a82a2asdasqadaf3faa0ed6c1ee372****</para>
                /// </summary>
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E0CEF83-FB09-4E34-BA1451814B03****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24e0fba7188fae707e146esa54****</para>
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// <para>The total number of media assets that match the search conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
