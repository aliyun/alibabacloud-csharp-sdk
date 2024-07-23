// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByAILabelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public List<SearchMediaByAILabelResponseBodyMediaList> MediaList { get; set; }
        public class SearchMediaByAILabelResponseBodyMediaList : TeaModel {
            [NameInMap("AiData")]
            [Validation(Required=false)]
            public SearchMediaByAILabelResponseBodyMediaListAiData AiData { get; set; }
            public class SearchMediaByAILabelResponseBodyMediaListAiData : TeaModel {
                [NameInMap("AiLabelInfo")]
                [Validation(Required=false)]
                public List<SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfo> AiLabelInfo { get; set; }
                public class SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfo : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5FE19530C7A422197535FE74F5DB****</para>
                    /// </summary>
                    [NameInMap("FaceId")]
                    [Validation(Required=false)]
                    public string FaceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>103102503**</para>
                    /// </summary>
                    [NameInMap("LabelId")]
                    [Validation(Required=false)]
                    public string LabelId { get; set; }

                    [NameInMap("LabelName")]
                    [Validation(Required=false)]
                    public string LabelName { get; set; }

                    [NameInMap("LabelType")]
                    [Validation(Required=false)]
                    public string LabelType { get; set; }

                    [NameInMap("Occurrences")]
                    [Validation(Required=false)]
                    public List<SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfoOccurrences> Occurrences { get; set; }
                    public class SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfoOccurrences : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>158730355E4B82257D8AA1583A58****</para>
                        /// </summary>
                        [NameInMap("ClipId")]
                        [Validation(Required=false)]
                        public string ClipId { get; set; }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>103102503**</para>
                        /// </summary>
                        [NameInMap("FinegrainId")]
                        [Validation(Required=false)]
                        public string FinegrainId { get; set; }

                        [NameInMap("FinegrainName")]
                        [Validation(Required=false)]
                        public string FinegrainName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1.4</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public double? From { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://service-****-public.oss-cn-hangzhou.aliyuncs.com/1563457****438522/service-image/f788974f-9595-43b2-a478-7c7a1afb****.jpg">https://service-****-public.oss-cn-hangzhou.aliyuncs.com/1563457****438522/service-image/f788974f-9595-43b2-a478-7c7a1afb****.jpg</a></para>
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.75287705</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public double? Score { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>85010D1**</para>
                        /// </summary>
                        [NameInMap("TableBatchSeqId")]
                        [Validation(Required=false)]
                        public string TableBatchSeqId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2.5</para>
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public double? To { get; set; }

                        [NameInMap("Tracks")]
                        [Validation(Required=false)]
                        public List<SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfoOccurrencesTracks> Tracks { get; set; }
                        public class SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfoOccurrencesTracks : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>468.0;67.0;615.0;267.0</para>
                            /// </summary>
                            [NameInMap("Position")]
                            [Validation(Required=false)]
                            public string Position { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>50</para>
                            /// </summary>
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public double? Size { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1.4</para>
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public double? Timestamp { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vision</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                }

                [NameInMap("AsrInfo")]
                [Validation(Required=false)]
                public List<SearchMediaByAILabelResponseBodyMediaListAiDataAsrInfo> AsrInfo { get; set; }
                public class SearchMediaByAILabelResponseBodyMediaListAiDataAsrInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5FE19530C7A422197535FE74F5DB****</para>
                    /// </summary>
                    [NameInMap("ClipId")]
                    [Validation(Required=false)]
                    public string ClipId { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.4</para>
                    /// </summary>
                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public double? From { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.4</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public double? Timestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2.5</para>
                    /// </summary>
                    [NameInMap("To")]
                    [Validation(Required=false)]
                    public double? To { get; set; }

                }

                [NameInMap("OcrInfo")]
                [Validation(Required=false)]
                public List<SearchMediaByAILabelResponseBodyMediaListAiDataOcrInfo> OcrInfo { get; set; }
                public class SearchMediaByAILabelResponseBodyMediaListAiDataOcrInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5FE19530C7A422197535FE74F5DB****</para>
                    /// </summary>
                    [NameInMap("ClipId")]
                    [Validation(Required=false)]
                    public string ClipId { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.4</para>
                    /// </summary>
                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public double? From { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.4</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public double? Timestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2.5</para>
                    /// </summary>
                    [NameInMap("To")]
                    [Validation(Required=false)]
                    public double? To { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>app-1000000</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://example.aliyundoc.com/snapshot/****.jpg?auth_key=1498476426-0-0-f00b9455c49a423ce69cf4e27333">http://example.aliyundoc.com/snapshot/****.jpg?auth_key=1498476426-0-0-f00b9455c49a423ce69cf4e27333</a>****</para>
            /// </summary>
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-11-14T09:15:50Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12.2</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1c6ce34007d571ed94667630a6bc****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-11-14T09:15:50Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10897890</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public List<string> Snapshots { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>out-****.oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
