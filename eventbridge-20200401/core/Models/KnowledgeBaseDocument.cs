// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class KnowledgeBaseDocument : TeaModel {
        /// <summary>
        /// <para>The snapshot of the document-level chunking policy actually used for this document. This field is returned only if ChunkConfiguration was explicitly specified during upload (BeginUpload) or update (UpdateDocument). If not specified, the document is chunked based on the knowledge base-level default configurations, and this field is not returned. The knowledge base-level configuration is not echoed back to avoid misleading users about the actual chunking basis for this document when the knowledge base-level configuration is subsequently changed.</para>
        /// </summary>
        [NameInMap("ChunkConfiguration")]
        [Validation(Required=false)]
        public KnowledgeBaseDocumentChunkConfiguration ChunkConfiguration { get; set; }
        public class KnowledgeBaseDocumentChunkConfiguration : TeaModel {
            /// <summary>
            /// <para>The heading level (1 to 6) used for splitting in the BY_HEADING strategy. Headings at or above this level serve as split boundaries. Deeper-level headings are retained in the chunk body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HeadingLevel")]
            [Validation(Required=false)]
            public int? HeadingLevel { get; set; }

            /// <summary>
            /// <para>The maximum character length of a single chunk. Starting from revision 22, this value is character-based. Valid values: 1 to 6000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxChunkSize")]
            [Validation(Required=false)]
            public int? MaxChunkSize { get; set; }

            /// <summary>
            /// <para>The overlap character length between adjacent chunks. This parameter takes effect only for the BY_LENGTH strategy. If the value is greater than 0, the beginning of the next chunk repeats the content from the end of the previous chunk within this window. The overlap does not cause a chunk to exceed MaxChunkSize. A value of 0 indicates no overlap.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("OverlapSize")]
            [Validation(Required=false)]
            public int? OverlapSize { get; set; }

            /// <summary>
            /// <para>The snapshot of preprocessing rules.</para>
            /// </summary>
            [NameInMap("PreprocessRules")]
            [Validation(Required=false)]
            public KnowledgeBaseDocumentChunkConfigurationPreprocessRules PreprocessRules { get; set; }
            public class KnowledgeBaseDocumentChunkConfigurationPreprocessRules : TeaModel {
                /// <summary>
                /// <para>Specifies whether to remove URLs and email addresses during parsing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("RemoveUrlsAndEmails")]
                [Validation(Required=false)]
                public bool? RemoveUrlsAndEmails { get; set; }

                /// <summary>
                /// <para>Specifies whether to replace consecutive whitespace characters (spaces, line breaks, and tab characters) with a single space.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ReplaceConsecutiveWhitespace")]
                [Validation(Required=false)]
                public bool? ReplaceConsecutiveWhitespace { get; set; }

            }

            /// <summary>
            /// <para>The separator used in the BY_SEPARATOR strategy. The separator is matched as a literal string (not a regular expression). The maximum length is 32 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\\n\\n</para>
            /// </summary>
            [NameInMap("Separator")]
            [Validation(Required=false)]
            public string Separator { get; set; }

            /// <summary>
            /// <para>The chunking strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AUTO: intelligent splitting (heading-aware + paragraph packing).</description></item>
            /// <item><description>BY_LENGTH: sliding window splitting by length. You can specify OverlapSize.</description></item>
            /// <item><description>BY_SEPARATOR: splitting by separator. You must specify Separator.</description></item>
            /// <item><description>BY_HEADING: splitting by heading level. You must specify HeadingLevel.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BY_SEPARATOR</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public string Strategy { get; set; }

        }

        /// <summary>
        /// <para>The number of chunks generated after processing is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("ChunkCount")]
        [Validation(Required=false)]
        public int? ChunkCount { get; set; }

        /// <summary>
        /// <para>The time when the document was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-24T10:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The unique identifier of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc-bp1xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DocumentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// <para>The stable error code returned when processing fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FILE_CORRUPTED</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The desensitized error message returned when processing fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>parse pdf failed</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The file name of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manual.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The file size of the document, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>The document-level metadata key-value pairs, including constant field values and system variable values. This field is not returned if no metadata is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;department&quot;,&quot;Value&quot;:&quot;R&amp;D&quot;}]</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public List<KnowledgeBaseDocumentMetadata> Metadata { get; set; }
        public class KnowledgeBaseDocumentMetadata : TeaModel {
            /// <summary>
            /// <para>The metadata field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The metadata field value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The last modification time in the upstream source system, in epoch milliseconds. This field is empty if no source information is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788000000000</para>
        /// </summary>
        [NameInMap("SourceModifiedTime")]
        [Validation(Required=false)]
        public long? SourceModifiedTime { get; set; }

        /// <summary>
        /// <para>The delivery channel through which the document entered the knowledge base. This value is written by the system and cannot be specified by users. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UPLOAD: manually uploaded through the console or API.</description></item>
        /// <item><description>OSS: imported through an OSS event stream.</description></item>
        /// </list>
        /// <para>New values may be added when new channels are supported. The values are not restricted to a fixed enumeration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPLOAD</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The original source address of the document, such as oss://bucket/path/file.md. This field may be empty for manually uploaded documents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://my-bucket/docs/handbook.pdf</para>
        /// </summary>
        [NameInMap("SourceUri")]
        [Validation(Required=false)]
        public string SourceUri { get; set; }

        /// <summary>
        /// <para>The processing status of the document. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UPLOADING: uploading in progress.</description></item>
        /// <item><description>PENDING: upload complete and queued for processing. This is typically a transitional state that lasts for seconds.</description></item>
        /// <item><description>PROCESSING: parsing and processing in progress.</description></item>
        /// <item><description>COMPLETED: processing complete and searchable.</description></item>
        /// <item><description>FAILED: processing failed.</description></item>
        /// <item><description>DELETING: deletion in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the document was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-24T10:00:00Z</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
