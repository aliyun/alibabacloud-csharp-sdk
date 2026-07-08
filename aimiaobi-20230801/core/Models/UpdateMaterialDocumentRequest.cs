// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UpdateMaterialDocumentRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier of the workspace: <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67c520d1fa43455ea44fb69fa402d54d_p_beebot_public</para>
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
        /// <para>Document tags for categorization</para>
        /// </summary>
        [NameInMap("DocKeywords")]
        [Validation(Required=false)]
        public List<string> DocKeywords { get; set; }

        /// <summary>
        /// <para>Document type. Valid values: html, plainText, image, pdf, word, excel, csv, jsonLine</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>URL uploaded by an external customer. Used only for record keeping</para>
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
        /// <para>Primary key</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Publication time in yyyy-MM-dd HH:mm:ss format</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-11 06:14:07</para>
        /// </summary>
        [NameInMap("PubTime")]
        [Validation(Required=false)]
        public string PubTime { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Sharing attribute. Valid values: 0 (private), 1 (shared within the workspace)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShareAttr")]
        [Validation(Required=false)]
        public int? ShareAttr { get; set; }

        /// <summary>
        /// <para>Source of the document. Valid values: UserUpload, IntellijSearch, HotViewPoint</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserUpload</para>
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
        /// <para>Parsed text content. Empty for images</para>
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
        /// <para>标题</para>
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
