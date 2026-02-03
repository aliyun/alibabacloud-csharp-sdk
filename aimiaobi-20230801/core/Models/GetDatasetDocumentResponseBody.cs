// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetDatasetDocumentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDatasetDocumentResponseBodyData Data { get; set; }
        public class GetDatasetDocumentResponseBodyData : TeaModel {
            [NameInMap("CategoryUuid")]
            [Validation(Required=false)]
            public string CategoryUuid { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisableHandleMultimodalMedia")]
            [Validation(Required=false)]
            public bool? DisableHandleMultimodalMedia { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>用户指定的文档唯一ID</para>
            /// </summary>
            [NameInMap("DocId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>内部文档唯一ID</para>
            /// </summary>
            [NameInMap("DocUuid")]
            [Validation(Required=false)]
            public string DocUuid { get; set; }

            [NameInMap("Extend1")]
            [Validation(Required=false)]
            public string Extend1 { get; set; }

            [NameInMap("Extend2")]
            [Validation(Required=false)]
            public string Extend2 { get; set; }

            [NameInMap("Extend3")]
            [Validation(Required=false)]
            public string Extend3 { get; set; }

            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public GetDatasetDocumentResponseBodyDataMetadata Metadata { get; set; }
            public class GetDatasetDocumentResponseBodyDataMetadata : TeaModel {
                [NameInMap("AsrSentences")]
                [Validation(Required=false)]
                public List<GetDatasetDocumentResponseBodyDataMetadataAsrSentences> AsrSentences { get; set; }
                public class GetDatasetDocumentResponseBodyDataMetadataAsrSentences : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("KeyValues")]
                [Validation(Required=false)]
                public List<GetDatasetDocumentResponseBodyDataMetadataKeyValues> KeyValues { get; set; }
                public class GetDatasetDocumentResponseBodyDataMetadataKeyValues : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("VideoShots")]
                [Validation(Required=false)]
                public List<GetDatasetDocumentResponseBodyDataMetadataVideoShots> VideoShots { get; set; }
                public class GetDatasetDocumentResponseBodyDataMetadataVideoShots : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-14 08:54:33</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>来源</para>
            /// </summary>
            [NameInMap("SourceFrom")]
            [Validation(Required=false)]
            public string SourceFrom { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>文章摘要</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
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
        public bool? Success { get; set; }

    }

}
