// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocWashingRequest : TeaModel {
        /// <summary>
        /// <para>Model ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>quanmiao-max、quanmiao-plus</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>Additional prompt requirements</para>
        /// 
        /// <b>Example:</b>
        /// <para>按英文输出</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The article to rewrite</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>文章内容</para>
        /// </summary>
        [NameInMap("ReferenceContent")]
        [Validation(Required=false)]
        public string ReferenceContent { get; set; }

        /// <summary>
        /// <para>Channel ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Topic of the rewritten article</para>
        /// 
        /// <b>Example:</b>
        /// <para>云南旅游主题</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>Required word count after rewriting</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("WordNumber")]
        [Validation(Required=false)]
        public int? WordNumber { get; set; }

        /// <summary>
        /// <para>Unique identifier for Alibaba Cloud Model Studio workspace: Get <a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2setzb9x4ewsd</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>Writing style type name</para>
        /// 
        /// <b>Example:</b>
        /// <para>小红书文体
        /// 朋友圈文体
        /// 专业新闻文体
        /// 政府公文文体
        /// 报纸文章文体
        /// 意见信文体</para>
        /// </summary>
        [NameInMap("WritingTypeName")]
        [Validation(Required=false)]
        public string WritingTypeName { get; set; }

        /// <summary>
        /// <para>Example article for writing style</para>
        /// 
        /// <b>Example:</b>
        /// <para>该值若不为空则按该值优先</para>
        /// </summary>
        [NameInMap("WritingTypeRefDoc")]
        [Validation(Required=false)]
        public string WritingTypeRefDoc { get; set; }

    }

}
