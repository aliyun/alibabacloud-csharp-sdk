// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AddDatasetDocumentRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据集名称</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The document.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Document")]
        [Validation(Required=false)]
        public AddDatasetDocumentRequestDocument Document { get; set; }
        public class AddDatasetDocumentRequestDocument : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("CategoryUuid")]
            [Validation(Required=false)]
            public string CategoryUuid { get; set; }

            /// <summary>
            /// <para>The content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>正文</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable the indexing of multimodal data, such as images and videos, in the current record. The default value is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableHandleMultimodalMedia")]
            [Validation(Required=false)]
            public bool? DisableHandleMultimodalMedia { get; set; }

            /// <summary>
            /// <para>The unique business ID of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("DocId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            /// <summary>
            /// <para>The type of the document.</para>
            /// <list type="bullet">
            /// <item><description><para>plainText: plain text. The content parameter is required.</para>
            /// </description></item>
            /// <item><description><para>richText: rich text in HTML format. The content parameter is required.</para>
            /// </description></item>
            /// <item><description><para>text: a text file. The url parameter is required.</para>
            /// </description></item>
            /// <item><description><para>pdf: a PDF file. The url parameter is required.</para>
            /// </description></item>
            /// <item><description><para>word: a Word document. The url parameter is required.</para>
            /// </description></item>
            /// <item><description><para>image: an image. The url parameter is required. Most common image formats are supported, such as GIF, PNG, JPG, and JPEG.</para>
            /// </description></item>
            /// <item><description><para>video: a video. The url parameter is required. Most common video formats are supported, such as MP4, AVI, WMV, and MOV.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// <para>The unique system ID of the document. The system automatically generates this ID. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("DocUuid")]
            [Validation(Required=false)]
            public string DocUuid { get; set; }

            /// <summary>
            /// <para>Extension field 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Extend1")]
            [Validation(Required=false)]
            public string Extend1 { get; set; }

            /// <summary>
            /// <para>Extension field 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("Extend2")]
            [Validation(Required=false)]
            public string Extend2 { get; set; }

            /// <summary>
            /// <para>Extension field 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Extend3")]
            [Validation(Required=false)]
            public string Extend3 { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public AddDatasetDocumentRequestDocumentMetadata Metadata { get; set; }
            public class AddDatasetDocumentRequestDocumentMetadata : TeaModel {
                /// <summary>
                /// <para>The speech or caption information.</para>
                /// </summary>
                [NameInMap("AsrSentences")]
                [Validation(Required=false)]
                public List<AddDatasetDocumentRequestDocumentMetadataAsrSentences> AsrSentences { get; set; }
                public class AddDatasetDocumentRequestDocumentMetadataAsrSentences : TeaModel {
                    /// <summary>
                    /// <para>The end time in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The speech or caption information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>The metadata in a key-value structure.</para>
                /// </summary>
                [NameInMap("KeyValues")]
                [Validation(Required=false)]
                public List<AddDatasetDocumentRequestDocumentMetadataKeyValues> KeyValues { get; set; }
                public class AddDatasetDocumentRequestDocumentMetadataKeyValues : TeaModel {
                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The parameter value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The description of the metadata. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The video shot information.</para>
                /// </summary>
                [NameInMap("VideoShots")]
                [Validation(Required=false)]
                public List<AddDatasetDocumentRequestDocumentMetadataVideoShots> VideoShots { get; set; }
                public class AddDatasetDocumentRequestDocumentMetadataVideoShots : TeaModel {
                    /// <summary>
                    /// <para>The end time in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The text information from the video shot analysis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

            }

            /// <summary>
            /// <para>Deprecated. This parameter is not available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("MultimodalIndexName")]
            [Validation(Required=false)]
            public string MultimodalIndexName { get; set; }

            /// <summary>
            /// <para>A list of multimodal data in the document.</para>
            /// <list type="bullet">
            /// <item><description><para>If a document, such as a rich text document, contains multimodal data like images or videos, you can pass the data using this parameter. This allows the data to be retrieved in search results.</para>
            /// </description></item>
            /// <item><description><para>If the document itself is multimodal data, leave this field empty and specify the data using the docType and url parameters.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("MultimodalMedias")]
            [Validation(Required=false)]
            public List<AddDatasetDocumentRequestDocumentMultimodalMedias> MultimodalMedias { get; set; }
            public class AddDatasetDocumentRequestDocumentMultimodalMedias : TeaModel {
                /// <summary>
                /// <para>The URL of the file. The URL must be accessible over the public network.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxx">http://xxx</a></para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                /// <summary>
                /// <para>The unique identifier of the multimodal data. The system automatically generates this ID. You do not need to specify this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The type of the multimodal data.</para>
                /// <list type="bullet">
                /// <item><description><para>image: an image</para>
                /// </description></item>
                /// <item><description><para>video: a video</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>image</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

            }

            /// <summary>
            /// <para>The publishing time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-09 13:35:40</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <para>The source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx媒体</para>
            /// </summary>
            [NameInMap("SourceFrom")]
            [Validation(Required=false)]
            public string SourceFrom { get; set; }

            /// <summary>
            /// <para>The summary of the article.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章摘要</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The tag name.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <para>The title of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The URL of the article. The URL must be accessible over the public network.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx">http://xxx</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Obtain a workspaceId</a>.</para>
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
