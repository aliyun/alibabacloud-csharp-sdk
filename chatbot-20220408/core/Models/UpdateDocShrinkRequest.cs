// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateDocShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The key for the business space. If this parameter is not specified, the default business space is used. You can obtain the key on the Business Management page of your master account.</para>
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
        /// <para><b>Splitter</b>: The method used to split the document. Valid values: <c>paragraphSplitter</c> (splits by paragraph, default) and <c>treeSplitter</c> (splits by hierarchical rules).</para>
        /// <para><b>ChunkSize</b>: The chunk size. The value must be an integer from 200 to 800. The default value is 500.</para>
        /// <para><b>TreePatterns</b>: An array of regular expressions that define the structure for rule-based splitting. The default value is <c>[]</c>.</para>
        /// <para><b>TitleSource</b>: The source of the document title. Valid values: <c>ocrTitle</c> (uses the OCR-recognized title, default) and <c>docName</c> (uses the document name as the title).</para>
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
        /// <para>文档内容</para>
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
        /// <para>文档问答模块功能说明文档</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>The time when the document expires. Specify the time in UTC, using the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
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
        /// <para>The metadata of the document, specified as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        /// <summary>
        /// <para>The time when the document becomes effective. Specify the time in UTC, using the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-25T16:28:36Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The tag IDs to associate with the document. Passing an empty array removes all existing tag associations.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public string TagIdsShrink { get; set; }

        /// <summary>
        /// <para>The document title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>文档问答功能说明</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
