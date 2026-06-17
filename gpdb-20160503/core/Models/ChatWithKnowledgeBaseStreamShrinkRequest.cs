// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ChatWithKnowledgeBaseStreamShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances in a specified region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the retrieved knowledge base results in the response. Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeKnowledgeBaseResults")]
        [Validation(Required=false)]
        public bool? IncludeKnowledgeBaseResults { get; set; }

        /// <summary>
        /// <para>Parameters for knowledge retrieval. If omitted, the API performs a chat-only operation.</para>
        /// </summary>
        [NameInMap("KnowledgeParams")]
        [Validation(Required=false)]
        public string KnowledgeParamsShrink { get; set; }

        /// <summary>
        /// <para>An object that contains parameters for the Large Language Model (LLM) call.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModelParams")]
        [Validation(Required=false)]
        public string ModelParamsShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>A template for the system prompt. It must include placeholders such as <c>{{text_chunks}}</c>, <c>{{user_system_prompt}}</c>, <c>{{graph_entities}}</c>, and <c>{{graph_relations}}</c>. If omitted, no custom prompt template is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;参考以下知识回答问题:{{ text_chunks }}&quot;</para>
        /// </summary>
        [NameInMap("PromptParams")]
        [Validation(Required=false)]
        public string PromptParams { get; set; }

        /// <summary>
        /// <para>The instance\&quot;s region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
