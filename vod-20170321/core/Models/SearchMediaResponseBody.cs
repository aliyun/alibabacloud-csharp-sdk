// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the media assets.</para>
        /// </summary>
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public List<SearchMediaResponseBodyMediaList> MediaList { get; set; }
        public class SearchMediaResponseBodyMediaList : TeaModel {
            /// <summary>
            /// <para>Details about AI data.</para>
            /// </summary>
            [NameInMap("AiData")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAiData AiData { get; set; }
            public class SearchMediaResponseBodyMediaListAiData : TeaModel {
                /// <summary>
                /// <para>The AI tags.</para>
                /// </summary>
                [NameInMap("AiLabelInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaListAiDataAiLabelInfo> AiLabelInfo { get; set; }
                public class SearchMediaResponseBodyMediaListAiDataAiLabelInfo : TeaModel {
                    /// <summary>
                    /// <para>The category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Transportation</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The ID of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10310250338</para>
                    /// </summary>
                    [NameInMap("LabelId")]
                    [Validation(Required=false)]
                    public string LabelId { get; set; }

                    /// <summary>
                    /// <para>The name of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Vehicles</para>
                    /// </summary>
                    [NameInMap("LabelName")]
                    [Validation(Required=false)]
                    public string LabelName { get; set; }

                    /// <summary>
                    /// <para>The clips.</para>
                    /// </summary>
                    [NameInMap("Occurrences")]
                    [Validation(Required=false)]
                    public List<SearchMediaResponseBodyMediaListAiDataAiLabelInfoOccurrences> Occurrences { get; set; }
                    public class SearchMediaResponseBodyMediaListAiDataAiLabelInfoOccurrences : TeaModel {
                        /// <summary>
                        /// <para>The start time of the clip.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.4</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public double? From { get; set; }

                        /// <summary>
                        /// <para>The score.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.75287705</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public double? Score { get; set; }

                        /// <summary>
                        /// <para>The end time of the clip.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2.5</para>
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public double? To { get; set; }

                    }

                }

                /// <summary>
                /// <para>The information about subtitles.</para>
                /// </summary>
                [NameInMap("OcrInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaListAiDataOcrInfo> OcrInfo { get; set; }
                public class SearchMediaResponseBodyMediaListAiDataOcrInfo : TeaModel {
                    /// <summary>
                    /// <para>The text content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>I\&quot;m Jane.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The start time of the subtitle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.4</para>
                    /// </summary>
                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public double? From { get; set; }

                    /// <summary>
                    /// <para>The end time of the subtitle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.5</para>
                    /// </summary>
                    [NameInMap("To")]
                    [Validation(Required=false)]
                    public double? To { get; set; }

                }

            }

            /// <summary>
            /// <para>The basic information about AI data.</para>
            /// </summary>
            [NameInMap("AiRoughData")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAiRoughData AiRoughData { get; set; }
            public class SearchMediaResponseBodyMediaListAiRoughData : TeaModel {
                /// <summary>
                /// <para>The AI category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TV series</para>
                /// </summary>
                [NameInMap("AiCategory")]
                [Validation(Required=false)]
                public string AiCategory { get; set; }

                /// <summary>
                /// <para>The ID of the AI task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cd35b0b0025f71edbfcb472190a9xxxx</para>
                /// </summary>
                [NameInMap("AiJobId")]
                [Validation(Required=false)]
                public string AiJobId { get; set; }

                /// <summary>
                /// <para>The save type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEXT</para>
                /// </summary>
                [NameInMap("SaveType")]
                [Validation(Required=false)]
                public string SaveType { get; set; }

                /// <summary>
                /// <para>The data status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SaveSuccess</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para><a href="https://help.aliyun.com/document_detail/86991.html">The information about the auxiliary media asset</a>.</para>
            /// </summary>
            [NameInMap("AttachedMedia")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAttachedMedia AttachedMedia { get; set; }
            public class SearchMediaResponseBodyMediaListAttachedMedia : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The type of the auxiliary media asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>watermark</b></description></item>
                /// <item><description><b>subtitle</b></description></item>
                /// <item><description><b>material</b></description></item>
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
                    /// <para>The category ID of the auxiliary media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10027394</para>
                    /// </summary>
                    [NameInMap("CateId")]
                    [Validation(Required=false)]
                    public long? CateId { get; set; }

                    /// <summary>
                    /// <para>The name of the category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test1</para>
                    /// </summary>
                    [NameInMap("CateName")]
                    [Validation(Required=false)]
                    public string CateName { get; set; }

                    /// <summary>
                    /// <para>The level of the category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public long? Level { get; set; }

                    /// <summary>
                    /// <para>The ID of the parent node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-1</para>
                    /// </summary>
                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public long? ParentId { get; set; }

                }

                /// <summary>
                /// <para>The time when the auxiliary media asset was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:45:25Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the auxiliary media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test3</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the auxiliary media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a82a2cd7d4e147ba0ed6c1ee372****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The time when the auxiliary media asset was updated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:48:25Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The status of the auxiliary media asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b></description></item>
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>UploadFail</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The region in which the auxiliary media asset is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-bfefbb90a47c11*****7426.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The tags of the auxiliary media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test2</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The title of the auxiliary media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The URL of the auxiliary media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/****.png">https://example.com/****.png</a></para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para><a href="https://help.aliyun.com/document_detail/86991.html">The information about the audio</a>.</para>
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAudio Audio { get; set; }
            public class SearchMediaResponseBodyMediaListAudio : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The ID of the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a82a2cd7d4e147bbed6c1ee372****</para>
                /// </summary>
                [NameInMap("AudioId")]
                [Validation(Required=false)]
                public string AudioId { get; set; }

                /// <summary>
                /// <para>The ID of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000123</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The name of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ceshi</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The URL of the thumbnail.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/image04.jpg">http://example.com/image04.jpg</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the audio stream was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:45:25Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>audio description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The download switch. The audio file can be downloaded offline only when the download switch is turned on. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("DownloadSwitch")]
                [Validation(Required=false)]
                public string DownloadSwitch { get; set; }

                /// <summary>
                /// <para>The duration of the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// <para>The source of the audio file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>general</b>: The audio file is uploaded by using ApsaraVideo VOD.</description></item>
                /// <item><description><b>short_video</b>: The audio file is uploaded to ApsaraVideo VOD by using the short video SDK. For more information, see <a href="https://help.aliyun.com/document_detail/53407.html">Introduction</a>.</description></item>
                /// <item><description><b>editing</b>: The audio file is uploaded to ApsaraVideo VOD after online editing and production. For more information, see <a href="https://help.aliyun.com/document_detail/68536.html">ProduceEditingProjectVideo</a>.</description></item>
                /// <item><description><b>live</b>: The audio file is recorded and uploaded as a file to ApsaraVideo VOD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("MediaSource")]
                [Validation(Required=false)]
                public string MediaSource { get; set; }

                /// <summary>
                /// <para>The time when the audio file was updated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:48:25Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The preprocessing status. Only preprocessed videos can be used for live streaming in the production studio. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UnPreprocess</b></description></item>
                /// <item><description><b>Preprocessing</b></description></item>
                /// <item><description><b>PreprocessSucceed</b></description></item>
                /// <item><description><b>PreprocessFailed</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UnPreprocess</para>
                /// </summary>
                [NameInMap("PreprocessStatus")]
                [Validation(Required=false)]
                public string PreprocessStatus { get; set; }

                /// <summary>
                /// <para>The period of time in which the audio file remains in the restored state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-30T10:14:14Z</para>
                /// </summary>
                [NameInMap("RestoreExpiration")]
                [Validation(Required=false)]
                public string RestoreExpiration { get; set; }

                /// <summary>
                /// <para>The restoration status of the audio file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Processing</b></description></item>
                /// <item><description><b>Success</b></description></item>
                /// <item><description><b>Failed</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

                /// <summary>
                /// <para>The size of the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The automatic snapshots.</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<string> Snapshots { get; set; }

                /// <summary>
                /// <para>The sprite snapshots.</para>
                /// </summary>
                [NameInMap("SpriteSnapshots")]
                [Validation(Required=false)]
                public List<string> SpriteSnapshots { get; set; }

                /// <summary>
                /// <para>The status of the audio file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b></description></item>
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>UploadFail</b></description></item>
                /// <item><description><b>Deleted</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage class of the audio file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: All media resources are stored as Standard objects.</description></item>
                /// <item><description><b>IA</b>: All media resources are stored as IA objects.</description></item>
                /// <item><description><b>Archive</b>: All media resources are stored as Archive objects.</description></item>
                /// <item><description><b>ColdArchive</b>: All media resources are stored as Cold Archive objects.</description></item>
                /// <item><description><b>SourceIA</b>: Only the source file is stored as an IA object.</description></item>
                /// <item><description><b>SourceArchive</b>: Only the source file is stored as an Archive object.</description></item>
                /// <item><description><b>SourceColdArchive</b>: Only the source file is stored as a Cold Archive object.</description></item>
                /// <item><description><b>Changing</b>: The storage class is being modified.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <para>The region in which the audio is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-aaa*****aa.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The tags of the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1,tag2</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The title of the audio file</para>
                /// 
                /// <b>Example:</b>
                /// <para>audio</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The transcoding mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FastTranscode</b>: The audio file is immediately transcoded after it is uploaded. You cannot play the file before it is transcoded.</description></item>
                /// <item><description><b>NoTranscode</b>: The audio file can be played without being transcoded. You can immediately play the file after it is uploaded.</description></item>
                /// <item><description><b>AsyncTranscode</b>: The audio file can be immediately played and asynchronously transcoded after it is uploaded.</description></item>
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
            /// <para>The time when the media asset was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-19T03:45:25Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para><a href="https://help.aliyun.com/document_detail/86991.html">The information about the image</a>.</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListImage Image { get; set; }
            public class SearchMediaResponseBodyMediaListImage : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The ID of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000123</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The name of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>beauty</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The time when the image was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:45:25Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the image file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the image file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11130843741se99wqmoes****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The time when the image file was updated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:48:25Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The status of the image file.</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b></description></item>
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>UploadFail</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Uploading</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The region in which the image is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-bfefbb90a47c******163e1c7426.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The tags of the image file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The title of the image file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image1</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The URL of the image file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/****.png">https://example.com/****.png</a></para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para>The ID of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a82a2cd7d4e147bbed6c1ee372****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The type of the media asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>video</b></description></item>
            /// <item><description><b>audio</b></description></item>
            /// <item><description><b>image</b></description></item>
            /// <item><description><b>attached</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// <para><a href="https://help.aliyun.com/document_detail/86991.html">The information about the video</a>.</para>
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListVideo Video { get; set; }
            public class SearchMediaResponseBodyMediaListVideo : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The ID of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000123</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The name of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video1</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The URL of the thumbnail.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.aliyundoc.com/image01.png">https://example.aliyundoc.com/image01.png</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the video file was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-19T03:45:25Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Video test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The download switch. The video file can be downloaded offline only when the download switch is turned on. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("DownloadSwitch")]
                [Validation(Required=false)]
                public string DownloadSwitch { get; set; }

                /// <summary>
                /// <para>The duration of the video file. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// <para>The source of the video file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>general</b>: The video file is uploaded by using ApsaraVideo VOD.</description></item>
                /// <item><description><b>short_video</b>: The video file is uploaded by using the short video SDK.</description></item>
                /// <item><description><b>editing</b>: The video file is produced after online editing.</description></item>
                /// <item><description><b>live</b>: The video stream is recorded and uploaded as a file.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("MediaSource")]
                [Validation(Required=false)]
                public string MediaSource { get; set; }

                /// <summary>
                /// <para>The time when the video file was updated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
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
                /// <item><description><b>UnPreprocess</b></description></item>
                /// <item><description><b>Preprocessing</b></description></item>
                /// <item><description><b>PreprocessSucceed</b></description></item>
                /// <item><description><b>PreprocessFailed</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Preprocessing</para>
                /// </summary>
                [NameInMap("PreprocessStatus")]
                [Validation(Required=false)]
                public string PreprocessStatus { get; set; }

                /// <summary>
                /// <para>The period of time in which the video file remains in the restored state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-30T10:14:14Z</para>
                /// </summary>
                [NameInMap("RestoreExpiration")]
                [Validation(Required=false)]
                public string RestoreExpiration { get; set; }

                /// <summary>
                /// <para>The restoration status of the video file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Processing</b></description></item>
                /// <item><description><b>Success</b></description></item>
                /// <item><description><b>Failed</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

                /// <summary>
                /// <para>The size of the video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The automatic snapshots.</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<string> Snapshots { get; set; }

                /// <summary>
                /// <para>The sprite snapshots.</para>
                /// </summary>
                [NameInMap("SpriteSnapshots")]
                [Validation(Required=false)]
                public List<string> SpriteSnapshots { get; set; }

                /// <summary>
                /// <para>The status of the file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b></description></item>
                /// <item><description><b>UploadFail</b></description></item>
                /// <item><description><b>UploadSucc</b></description></item>
                /// <item><description><b>Transcoding</b></description></item>
                /// <item><description><b>TranscodeFail</b></description></item>
                /// <item><description><b>Blocked</b></description></item>
                /// <item><description><b>Normal</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UploadSucc</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage class of the video file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: All media resources are stored as Standard objects.</description></item>
                /// <item><description><b>IA</b>: All media resources are stored as IA objects.</description></item>
                /// <item><description><b>Archive</b>: All media resources are stored as Archive objects.</description></item>
                /// <item><description><b>ColdArchive</b>: All media resources are stored as Cold Archive objects.</description></item>
                /// <item><description><b>SourceIA</b>: Only the source file is stored as an IA object.</description></item>
                /// <item><description><b>SourceArchive</b>: Only the source file is stored as an Archive object.</description></item>
                /// <item><description><b>SourceColdArchive</b>: Only the source file is stored as a Cold Archive object.</description></item>
                /// <item><description><b>Changing</b>: The storage class of the video file is being changed.</description></item>
                /// <item><description><b>SourceChanging</b>: The storage class of the source file is being changed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <para>The region in which the video is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-bfefbb90a47c******163e1c7426.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The tags of the video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The title of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ceshi</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The transcoding mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FastTranscode</b>: The video file is immediately transcoded after it is uploaded. You cannot play the file before it is transcoded.</description></item>
                /// <item><description><b>NoTranscode</b>: The video file can be played without being transcoded. You can immediately play the file after it is uploaded.</description></item>
                /// <item><description><b>AsyncTranscode</b>: The video file can be immediately played and asynchronously transcoded after it is uploaded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FastTranscode</para>
                /// </summary>
                [NameInMap("TranscodeMode")]
                [Validation(Required=false)]
                public string TranscodeMode { get; set; }

                /// <summary>
                /// <para>The ID of the video file.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E0CEF83-FB09-4E34-BA1451814B03****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The pagination identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24e0fba7188fae707e146esa54****</para>
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// <para>The total number of data records that meet the specified filter criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
