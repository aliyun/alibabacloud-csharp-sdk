// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AddDatasetDocumentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>数据集名称</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Document")]
        [Validation(Required=false)]
        public AddDatasetDocumentRequestDocument Document { get; set; }
        public class AddDatasetDocumentRequestDocument : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableHandleMultimodalMedia")]
            [Validation(Required=false)]
            public bool? DisableHandleMultimodalMedia { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>业务文档唯一ID</para>
            /// </summary>
            [NameInMap("DocId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>文档类型</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>扩展字段1</para>
            /// </summary>
            [NameInMap("Extend1")]
            [Validation(Required=false)]
            public string Extend1 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>扩展字段2</para>
            /// </summary>
            [NameInMap("Extend2")]
            [Validation(Required=false)]
            public string Extend2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>扩展字段3</para>
            /// </summary>
            [NameInMap("Extend3")]
            [Validation(Required=false)]
            public string Extend3 { get; set; }

            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public AddDatasetDocumentRequestDocumentMetadata Metadata { get; set; }
            public class AddDatasetDocumentRequestDocumentMetadata : TeaModel {
                [NameInMap("AsrSentences")]
                [Validation(Required=false)]
                public List<AddDatasetDocumentRequestDocumentMetadataAsrSentences> AsrSentences { get; set; }
                public class AddDatasetDocumentRequestDocumentMetadataAsrSentences : TeaModel {
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

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("VideoShots")]
                [Validation(Required=false)]
                public List<AddDatasetDocumentRequestDocumentMetadataVideoShots> VideoShots { get; set; }
                public class AddDatasetDocumentRequestDocumentMetadataVideoShots : TeaModel {
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
            /// <para>模型名称 todo 商业化 仅个别账号可传入</para>
            /// </summary>
            [NameInMap("MultimodalIndexName")]
            [Validation(Required=false)]
            public string MultimodalIndexName { get; set; }

            [NameInMap("MultimodalMedias")]
            [Validation(Required=false)]
            public List<AddDatasetDocumentRequestDocumentMultimodalMedias> MultimodalMedias { get; set; }
            public class AddDatasetDocumentRequestDocumentMultimodalMedias : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>图片或视频文件地址</para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>多模态数据唯一标识</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>多模态数据类型</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-09 13:35:40</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>文章摘要</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxxx@xxxxx.com">xxxxx@xxxxx.com</a></para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
