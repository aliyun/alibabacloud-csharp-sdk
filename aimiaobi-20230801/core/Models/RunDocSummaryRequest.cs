// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocSummaryRequest : TeaModel {
        /// <summary>
        /// <para>Purge the current cache</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CleanCache")]
        [Validation(Required=false)]
        public bool? CleanCache { get; set; }

        /// <summary>
        /// <para>Document ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("DocId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>Custom model name specified by the User</para>
        /// 
        /// <b>Example:</b>
        /// <para>quanmiao-max、quanmiao-plus</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Custom requirements</para>
        /// 
        /// <b>Example:</b>
        /// <para>请总结一下这篇文档</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Content to be summarized</para>
        /// 
        /// <b>Example:</b>
        /// <para>要总结的内容</para>
        /// </summary>
        [NameInMap("RecommendContent")]
        [Validation(Required=false)]
        public string RecommendContent { get; set; }

        /// <summary>
        /// <para>Conversation ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0f56f98a-f2d8-47ec-98e9-1cbdcffa9539</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud Model Studio workspace ID. For more information about how to obtain it, see <a href="https://help.aliyun.com/document_detail/2587495.html">How to use a workspace</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2setzb9x4ewsd</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
