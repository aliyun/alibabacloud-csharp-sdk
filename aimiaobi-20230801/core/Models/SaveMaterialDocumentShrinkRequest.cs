// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SaveMaterialDocumentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier for the workspace: <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c160c841c8e54295bf2f441432785944_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>Author</para>
        /// 
        /// <b>Example:</b>
        /// <para>作者名称</para>
        /// </summary>
        [NameInMap("Author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        /// <summary>
        /// <para>Is the material saved to both the private library and the shared library?</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BothSavePrivateAndShare")]
        [Validation(Required=false)]
        public bool? BothSavePrivateAndShare { get; set; }

        /// <summary>
        /// <para>Document tags used for classification, etc.</para>
        /// </summary>
        [NameInMap("DocKeywords")]
        [Validation(Required=false)]
        public string DocKeywordsShrink { get; set; }

        /// <summary>
        /// <para>Document type (html: web page, plainText: plain text, image: image, pdf: pdf, word: word, excel: excel, csv: csv, jsonLine: jsonLine)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>excel</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>URL uploaded by external customers, used only for record keeping</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxxx/xxx">http://xxxxx/xxx</a></para>
        /// </summary>
        [NameInMap("ExternalUrl")]
        [Validation(Required=false)]
        public string ExternalUrl { get; set; }

        /// <summary>
        /// <para>Formatted content</para>
        /// 
        /// <b>Example:</b>
        /// <para>网页内容</para>
        /// </summary>
        [NameInMap("HtmlContent")]
        [Validation(Required=false)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// <para>Publication time, format: yyyy-MM-dd HH:mm:ss</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-11 06:14:07</para>
        /// </summary>
        [NameInMap("PubTime")]
        [Validation(Required=false)]
        public string PubTime { get; set; }

        /// <summary>
        /// <para>Sharing attribute: 0: private, 1: shared within the workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShareAttr")]
        [Validation(Required=false)]
        public int? ShareAttr { get; set; }

        /// <summary>
        /// <para>Document source (UserUpload: User Upload, IntellijSearch: Intelligent Search, HotViewPoint: Hot Viewpoint)</para>
        /// 
        /// <b>Example:</b>
        /// <para>IntellijSearch</para>
        /// </summary>
        [NameInMap("SrcFrom")]
        [Validation(Required=false)]
        public string SrcFrom { get; set; }

        /// <summary>
        /// <para>Summary</para>
        /// 
        /// <b>Example:</b>
        /// <para>摘要</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>Parsed text content, empty for images</para>
        /// 
        /// <b>Example:</b>
        /// <para>文本内容</para>
        /// </summary>
        [NameInMap("TextContent")]
        [Validation(Required=false)]
        public string TextContent { get; set; }

        /// <summary>
        /// <para>Document title</para>
        /// 
        /// <b>Example:</b>
        /// <para>新闻标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>URL of the material</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxxx/xxx">http://xxxxx/xxx</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
