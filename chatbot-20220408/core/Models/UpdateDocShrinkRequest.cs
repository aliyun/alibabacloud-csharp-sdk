// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateDocShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If this parameter is not specified, the default business space is accessed. You can obtain the key value on the business management page of the primary account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The document category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231001028593</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The document parsing/chunking configuration.
        /// Configuration item: Splitter
        /// KEY: Splitter
        /// Valid values: paragraphSplitter - hierarchy recognition (default)
        /// Valid values: treeSplitter - rule-based hierarchy</para>
        /// <para>Configuration item: Document chunk size
        /// KEY: ChunkSize
        /// VALUE: Default 500. Range: [200,800]</para>
        /// <para>Configuration item: Rule-based hierarchy
        /// KEY: TreePatterns
        /// VALUE: Default []</para>
        /// <para>Configuration item: Document title source
        /// KEY: TitleSource
        /// Valid values: ocrTitle - OCR-recognized title (default)
        /// Valid values: docName - document name as title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Splitter&quot;:&quot;treeSplitter&quot;,&quot;ChunkSize&quot;:500,&quot;TreePatterns&quot;:[&quot;^# .<em>&quot;,&quot;^## .</em>&quot;,&quot;^### .<em>&quot;,&quot;^#### .</em>&quot;],&quot;TitleSource&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The document content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Document content</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("DocMetadata")]
        [Validation(Required=false)]
        public string DocMetadataShrink { get; set; }

        /// <summary>
        /// <para>The document name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Document QA Module Feature Description</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>The end of the effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-11T23:59:59Z</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The document ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001905617</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        /// <summary>
        /// <para>The document metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        /// <summary>
        /// <para>The start of the effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-25T16:28:36Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The list of tag IDs. If this parameter is left empty, the tag bindings are removed.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public string TagIdsShrink { get; set; }

        /// <summary>
        /// <para>The document title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Document QA Feature Description</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
