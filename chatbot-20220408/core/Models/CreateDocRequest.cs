// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateDocRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000049006</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The document parsing and chunking configuration.</para>
        /// <para>Configuration item: Splitter
        /// KEY: Splitter
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ParagraphSplitter: recognition-based hierarchy.</description></item>
        /// <item><description>TreeSplitter: rule-based hierarchy.</description></item>
        /// </list>
        /// <para>Configuration item: Document chunk size
        /// KEY: ChunkSize
        /// VALUE: Default value: 500. Value range: [200, 800].</para>
        /// <para>Configuration item: Rule-based hierarchy
        /// KEY: TreePatterns
        /// VALUE: Default value: [].</para>
        /// <para>Configuration item: Document title source
        /// KEY: TitleSource
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ocrTitle: OCR-recognized title. This is the default value.</description></item>
        /// <item><description>docName: the document name is used as the title.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Splitter&quot;:&quot;treeSplitter&quot;,&quot;ChunkSize&quot;:500,&quot;TreePatterns&quot;:[&quot;^# .<em>&quot;,&quot;^## .</em>&quot;,&quot;^### .<em>&quot;,&quot;^#### .</em>&quot;],&quot;TitleSource&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The document content. Specify either this parameter or URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test content</para>
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
        /// <para>The effective end time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2032-05-25T16:28:36Z</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

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
        /// <para>The effective start time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-25T16:28:36Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The list of tag IDs.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<long?> TagIds { get; set; }

        /// <summary>
        /// <para>The document title.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The URL of the document. Specify either this parameter or Content. Supported formats: txt, pdf, markdown, doc, and docx. Limits for a single file: up to 100 pages, txt files smaller than 200 KB, pdf files smaller than 100 MB, markdown files smaller than 200 KB, doc files smaller than 100 MB, and docx files smaller than 100 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/example.pdf">https://example.com/example.pdf</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
