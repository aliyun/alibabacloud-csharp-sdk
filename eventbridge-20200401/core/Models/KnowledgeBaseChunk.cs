// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class KnowledgeBaseChunk : TeaModel {
        /// <summary>
        /// <para>The sequence number of the chunk within the document, starting from 1 and numbered consecutively.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("ChunkSeq")]
        [Validation(Required=false)]
        public int? ChunkSeq { get; set; }

        /// <summary>
        /// <para>The number of characters in the chunk content, measured in UTF-16 code units, consistent with MaxChunkSize. You can use this value to evaluate chunk saturation against the chunking configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// <para>The content of the chunk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventBridge supports routing events to multiple target services</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The time when the chunk was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-24T10:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The ID of the document to which the chunk belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc-bp1xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DocumentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// <para>Indicates whether the chunk is enabled. Disabled chunks are excluded from retrieval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The file name of the document to which the chunk belongs. This value is from the same source as the FileName returned by GetDocument.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product-handbook.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The location of the chunk in the original document. The format varies by document type: for PDF, the value is p.PageNumber (such as p.3). For PPT/PPTX, the value is s.SlideNumber (such as s.2). For XLS/XLSX, the value is the sheet name. For other formats (such as txt, md, html, doc, or docx), this field is not returned if no source location is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p.3</para>
        /// </summary>
        [NameInMap("SourceLocation")]
        [Validation(Required=false)]
        public string SourceLocation { get; set; }

        /// <summary>
        /// <para>The hierarchical title path of the chunk, connected by &gt;. If no recognizable title exists in the original document, the value falls back to a summary of the first paragraph content (such as CONTENT). This field is for display purposes only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Installation Guide&gt;Prerequisites</para>
        /// </summary>
        [NameInMap("TitlePath")]
        [Validation(Required=false)]
        public string TitlePath { get; set; }

        /// <summary>
        /// <para>The time when the chunk was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-24T10:00:00Z</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
