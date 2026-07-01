// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A collection of media assets that match the criteria.</para>
        /// </summary>
        [NameInMap("MediaInfoList")]
        [Validation(Required=false)]
        public List<SearchMediaResponseBodyMediaInfoList> MediaInfoList { get; set; }
        public class SearchMediaResponseBodyMediaInfoList : TeaModel {
            /// <summary>
            /// <para>The detailed AI data.</para>
            /// </summary>
            [NameInMap("AiData")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaInfoListAiData AiData { get; set; }
            public class SearchMediaResponseBodyMediaInfoListAiData : TeaModel {
                /// <summary>
                /// <para>A list of AI label information.</para>
                /// </summary>
                [NameInMap("AiLabelInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfo> AiLabelInfo { get; set; }
                public class SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfo : TeaModel {
                    /// <summary>
                    /// <para>The category of the label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Vehicle</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The ID of the recognized face.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5FE19530C7A422197535FE74F5DB****</para>
                    /// </summary>
                    [NameInMap("FaceId")]
                    [Validation(Required=false)]
                    public string FaceId { get; set; }

                    /// <summary>
                    /// <para>The ID of the entity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10310250338</para>
                    /// </summary>
                    [NameInMap("LabelId")]
                    [Validation(Required=false)]
                    public string LabelId { get; set; }

                    /// <summary>
                    /// <para>The name of the entity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Car</para>
                    /// </summary>
                    [NameInMap("LabelName")]
                    [Validation(Required=false)]
                    public string LabelName { get; set; }

                    /// <summary>
                    /// <para>The type of the label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Object</para>
                    /// </summary>
                    [NameInMap("LabelType")]
                    [Validation(Required=false)]
                    public string LabelType { get; set; }

                    /// <summary>
                    /// <para>A list of clips where the entity appears.</para>
                    /// </summary>
                    [NameInMap("Occurrences")]
                    [Validation(Required=false)]
                    public List<SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfoOccurrences> Occurrences { get; set; }
                    public class SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfoOccurrences : TeaModel {
                        /// <summary>
                        /// <para>The text content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Pipi</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The fine-grained ID of the entity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10310250338</para>
                        /// </summary>
                        [NameInMap("FinegrainId")]
                        [Validation(Required=false)]
                        public string FinegrainId { get; set; }

                        /// <summary>
                        /// <para>The fine-grained name of the entity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Car</para>
                        /// </summary>
                        [NameInMap("FinegrainName")]
                        [Validation(Required=false)]
                        public string FinegrainName { get; set; }

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
                        /// <para>The optimal image of the recognized face, encoded in Base64.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>99C64F6287</para>
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        /// <summary>
                        /// <para>The confidence score for the recognition result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.75287705</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public double? Score { get; set; }

                        /// <summary>
                        /// <para>The sequence ID of the vector table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>85010D1</para>
                        /// </summary>
                        [NameInMap("TableBatchSeqId")]
                        [Validation(Required=false)]
                        public string TableBatchSeqId { get; set; }

                        /// <summary>
                        /// <para>The end time of the clip.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2.5</para>
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public double? To { get; set; }

                        /// <summary>
                        /// <para>A sequence of tracks that represent the entity within the clip.</para>
                        /// </summary>
                        [NameInMap("Tracks")]
                        [Validation(Required=false)]
                        public List<SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfoOccurrencesTracks> Tracks { get; set; }
                        public class SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfoOccurrencesTracks : TeaModel {
                            /// <summary>
                            /// <para>The coordinates of the bounding box.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>468.0;67.0;615.0;267.0</para>
                            /// </summary>
                            [NameInMap("Position")]
                            [Validation(Required=false)]
                            public string Position { get; set; }

                            /// <summary>
                            /// <para>The size of the bounding box.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>50.2</para>
                            /// </summary>
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public double? Size { get; set; }

                            /// <summary>
                            /// <para>The timestamp of the track data point.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1.4</para>
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public double? Timestamp { get; set; }

                        }

                        /// <summary>
                        /// <para>The clip ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5FE19530C7A422197535FE74F5DB****</para>
                        /// </summary>
                        [NameInMap("clipId")]
                        [Validation(Required=false)]
                        public string ClipId { get; set; }

                    }

                    /// <summary>
                    /// <para>The source of the AI data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vision</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                }

                /// <summary>
                /// <para>A list of Automatic Speech Recognition (ASR) results.</para>
                /// </summary>
                [NameInMap("AsrInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaInfoListAiDataAsrInfo> AsrInfo { get; set; }
                public class SearchMediaResponseBodyMediaInfoListAiDataAsrInfo : TeaModel {
                    /// <summary>
                    /// <para>The clip ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5FE19530C7A422197535FE74F5DB****</para>
                    /// </summary>
                    [NameInMap("ClipId")]
                    [Validation(Required=false)]
                    public string ClipId { get; set; }

                    /// <summary>
                    /// <para>The transcribed text content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>I am Pipi.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

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
                    /// <para>The timestamp of the clip.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.4</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public double? Timestamp { get; set; }

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

                /// <summary>
                /// <para>A list of Optical Character Recognition (OCR) results.</para>
                /// </summary>
                [NameInMap("OcrInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaInfoListAiDataOcrInfo> OcrInfo { get; set; }
                public class SearchMediaResponseBodyMediaInfoListAiDataOcrInfo : TeaModel {
                    /// <summary>
                    /// <para>The clip ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5FE19530C7A422197535FE74F5DB****</para>
                    /// </summary>
                    [NameInMap("ClipId")]
                    [Validation(Required=false)]
                    public string ClipId { get; set; }

                    /// <summary>
                    /// <para>The recognized text content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>我是皮皮</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

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
                    /// <para>The timestamp of the clip.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.4</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public double? Timestamp { get; set; }

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
            /// <para>A summary of the AI processing data.</para>
            /// </summary>
            [NameInMap("AiRoughData")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaInfoListAiRoughData AiRoughData { get; set; }
            public class SearchMediaResponseBodyMediaInfoListAiRoughData : TeaModel {
                /// <summary>
                /// <para>The AI category applied to the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>视频AI分类</para>
                /// </summary>
                [NameInMap("AiCategory")]
                [Validation(Required=false)]
                public string AiCategory { get; set; }

                /// <summary>
                /// <para>The ID of the AI job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cd35b0b0025f71edbfcb472190a9****</para>
                /// </summary>
                [NameInMap("AiJobId")]
                [Validation(Required=false)]
                public string AiJobId { get; set; }

                /// <summary>
                /// <para>The URL of the raw AI result file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.json">http://xxxx.json</a></para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The save type of the AI data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEXT</para>
                /// </summary>
                [NameInMap("SaveType")]
                [Validation(Required=false)]
                public string SaveType { get; set; }

                /// <summary>
                /// <para>The save status of the AI data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SaveSuccess</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Custom fields for filtering, provided as a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;intField1\&quot;:12,\&quot;strField1\&quot;:\&quot;abc\&quot;}</para>
            /// </summary>
            [NameInMap("CustomFields")]
            [Validation(Required=false)]
            public string CustomFields { get; set; }

            /// <summary>
            /// <para>A list of file information.</para>
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<SearchMediaResponseBodyMediaInfoListFileInfoList> FileInfoList { get; set; }
            public class SearchMediaResponseBodyMediaInfoListFileInfoList : TeaModel {
                /// <summary>
                /// <para>Basic information about the file, such as its duration and size.</para>
                /// </summary>
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public SearchMediaResponseBodyMediaInfoListFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class SearchMediaResponseBodyMediaInfoListFileInfoListFileBasicInfo : TeaModel {
                    /// <summary>
                    /// <para>The bitrate of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1912.13</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The time when the file was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-05-30T02:02:17Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The duration of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60.00000</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The name of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>164265080291300080527050.wav</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The file size in bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>324784</para>
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// <para>The status of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    /// <summary>
                    /// <para>The type of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>source_file</para>
                    /// </summary>
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// <para>The Object Storage Service (OSS) URL of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://outin-d3f4681ddfd911ec99a600163e1403e7.oss-cn-shanghai.aliyuncs.com/sv/23d5cdd1-18180984899/23d5cdd1-1818098****.mp4">https://outin-d3f4681ddfd911ec99a600163e1403e7.oss-cn-shanghai.aliyuncs.com/sv/23d5cdd1-18180984899/23d5cdd1-1818098****.mp4</a></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <para>The container format of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mov,mp4,m4a,3gp,3g2,mj2</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <para>The height of the video in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>480</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>Information about the image set.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("ImagesInput")]
                    [Validation(Required=false)]
                    public string ImagesInput { get; set; }

                    /// <summary>
                    /// <para>The time when the file was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-12-10T12:19Z</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    /// <summary>
                    /// <para>The region where the file is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The width of the video in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1920</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// <para>A list of indexing statuses for different index types.</para>
            /// </summary>
            [NameInMap("IndexStatusList")]
            [Validation(Required=false)]
            public List<SearchMediaResponseBodyMediaInfoListIndexStatusList> IndexStatusList { get; set; }
            public class SearchMediaResponseBodyMediaInfoListIndexStatusList : TeaModel {
                /// <summary>
                /// <para>The status of the index. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Running</c>: The index is being created.</para>
                /// </description></item>
                /// <item><description><para><c>Fail</c>: The index creation failed.</para>
                /// </description></item>
                /// <item><description><para><c>Success</c>: The index was created.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("IndexStatus")]
                [Validation(Required=false)]
                public string IndexStatus { get; set; }

                /// <summary>
                /// <para>The type of the index. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>mm</c>: Large Language Model (LLM).</para>
                /// </description></item>
                /// <item><description><para><c>face</c>: Face.</para>
                /// </description></item>
                /// <item><description><para><c>aiLabel</c>: Smart tagging.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>mm</para>
                /// </summary>
                [NameInMap("IndexType")]
                [Validation(Required=false)]
                public string IndexType { get; set; }

            }

            /// <summary>
            /// <para>Basic information about the media asset.</para>
            /// </summary>
            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaInfoListMediaBasicInfo MediaBasicInfo { get; set; }
            public class SearchMediaResponseBodyMediaInfoListMediaBasicInfo : TeaModel {
                /// <summary>
                /// <para>The business to which the media asset belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IMS</para>
                /// </summary>
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                /// <summary>
                /// <para>The business type of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>opening</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Subcategory 1</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The category of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The URL of the cover image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/e694372e-4f5b-4821-ae09-efd064f2****_large_cover_url.jpg">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/e694372e-4f5b-4821-ae09-efd064f2****_large_cover_url.jpg</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the media asset was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-01T19:48Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the media asset was deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-01T19:48Z</para>
                /// </summary>
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                /// <summary>
                /// <para>The description of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>对这个视频进行转码处理了</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The source URL of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://clipres/longvideo/material/voice/prod/20220418/07d7c799f6054dc3bbef250854cf8498165024814****</para>
                /// </summary>
                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                /// <summary>
                /// <para>The media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>132bd600fc3c71ec99476732a78f****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The tags assigned to the media asset. Multiple tags are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tags,tags2</para>
                /// </summary>
                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }

                /// <summary>
                /// <para>The type of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>The time when the media asset was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-01T19:48Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name-1</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>A unique, custom ID for the user. It must be 6 to 64 characters long and can contain letters, digits, hyphens (-), and underscores (_).</para>
                /// 
                /// <b>Example:</b>
                /// <para>123-123</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>Snapshot information in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;bucket&quot;:&quot;example-bucket&quot;,&quot;count&quot;:&quot;3&quot;,&quot;iceJobId&quot;:&quot;<b><b><b>f48f0e4154976b2b8c45</b></b></b>&quot;,&quot;location&quot;:&quot;oss-cn-beijing&quot;,&quot;snapshotRegular&quot;:&quot;example.jpg&quot;,&quot;templateId&quot;:&quot;<b><b><b>e6a6440b29eb60bd7c</b></b></b>&quot;}]</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public string Snapshots { get; set; }

                /// <summary>
                /// <para>The source of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>Sprite Image information in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;bucket&quot;:&quot;example-bucket&quot;,&quot;count&quot;:&quot;32&quot;,&quot;iceJobId&quot;:&quot;<b><b><b>83ec44d58b2069def2e</b></b></b>&quot;,&quot;location&quot;:&quot;oss-cn-shanghai&quot;,&quot;snapshotRegular&quot;:&quot;example/example-{Count}.jpg&quot;,&quot;spriteRegular&quot;:&quot;example/example-{TileCount}.jpg&quot;,&quot;templateId&quot;:&quot;<b><b><b>e438b14ff39293eaec25</b></b></b>&quot;,&quot;tileCount&quot;:&quot;1&quot;}]</para>
                /// </summary>
                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }

                /// <summary>
                /// <para>The status of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The stream status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("StreamStatus")]
                [Validation(Required=false)]
                public string StreamStatus { get; set; }

                /// <summary>
                /// <para>The title of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Smart landscape-to-portrait conversion</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The transcoding status of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Init</para>
                /// </summary>
                [NameInMap("TranscodeStatus")]
                [Validation(Required=false)]
                public string TranscodeStatus { get; set; }

                /// <summary>
                /// <para>The upload source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("UploadSource")]
                [Validation(Required=false)]
                public string UploadSource { get; set; }

                /// <summary>
                /// <para>The custom user data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userData</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

                /// <summary>
                /// <para>A computer-vision-generated description of the media content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>足球进球</para>
                /// </summary>
                [NameInMap("VisionDescription")]
                [Validation(Required=false)]
                public string VisionDescription { get; set; }

            }

            /// <summary>
            /// <para>The media asset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3b187b3620c8490886cfc2a9578c****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F61C357-ACC0-57FB-876E-D5879533****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8C4F642184DBDA5D93907A70AAE****</para>
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of media assets matching the search criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>163</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
