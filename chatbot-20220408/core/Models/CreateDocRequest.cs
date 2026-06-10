// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateDocRequest : TeaModel {
        /// <summary>
        /// <para>The key for the business space. If this parameter is not specified, the default business space is used. You can obtain the key from the Business Management page of your primary account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The document category ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000049006</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The configuration for document splitting. Set the key to <c>Splitter</c>. Valid values are <c>paragraphSplitter</c> (identifies content hierarchy) and <c>treeSplitter</c> (uses a rule-based hierarchy).</para>
        /// <para>The document chunk size. Set the key to <c>ChunkSize</c>. The default value is 500. The value must be in the range of 200 to 800.</para>
        /// <para>The patterns for the rule-based hierarchy. Set the key to <c>TreePatterns</c>. The default value is an empty array (<c>[]</c>).</para>
        /// <para>The document title source. Set the key to <c>TitleSource</c>. Valid values are <c>ocrTitle</c> (default), which uses the title recognized by Optical Character Recognition (OCR), and <c>docName</c>, which uses the document name as the title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Splitter&quot;:&quot;treeSplitter&quot;,&quot;ChunkSize&quot;:500,&quot;TreePatterns&quot;:[&quot;^# .<em>&quot;,&quot;^## .</em>&quot;,&quot;^### .<em>&quot;,&quot;^#### .</em>&quot;],&quot;TitleSource&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The document content. You must specify either this parameter or <c>Url</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试内容</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("DocMetadata")]
        [Validation(Required=false)]
        public List<CreateDocRequestDocMetadata> DocMetadata { get; set; }
        public class CreateDocRequestDocMetadata : TeaModel {
            [NameInMap("BusinessViewId")]
            [Validation(Required=false)]
            public string BusinessViewId { get; set; }

            [NameInMap("BusinessViewName")]
            [Validation(Required=false)]
            public string BusinessViewName { get; set; }

            [NameInMap("MetaCellInfoDTOList")]
            [Validation(Required=false)]
            public List<CreateDocRequestDocMetadataMetaCellInfoDTOList> MetaCellInfoDTOList { get; set; }
            public class CreateDocRequestDocMetadataMetaCellInfoDTOList : TeaModel {
                [NameInMap("FieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the document expires. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2032-05-25T16:28:36Z</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The passthrough data of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        /// <summary>
        /// <para>The time when the document takes effect. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-25T16:28:36Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>A list of tag IDs.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<long?> TagIds { get; set; }

        /// <summary>
        /// <para>The document title.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The URL of the document. You must specify either this parameter or <c>Content</c>. Supported formats include .txt, .pdf, .markdown, .doc, and .docx. The following limits apply to a single file: a maximum of 100 pages, less than 200 KB for .txt and .markdown files, and less than 100 MB for .pdf, .doc, and .docx files.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/example.pdf">https://example.com/example.pdf</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
