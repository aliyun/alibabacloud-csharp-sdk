// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunSearchGenerationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Context.</para>
        /// </summary>
        [NameInMap("AgentContext")]
        [Validation(Required=false)]
        public string AgentContextShrink { get; set; }

        /// <summary>
        /// <para>Session configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ChatConfig")]
        [Validation(Required=false)]
        public string ChatConfigShrink { get; set; }

        /// <summary>
        /// <para>Image URL. Used for image search and hybrid text-and-image (prompt) search generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxx">http://xxxx</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>Model ID:</para>
        /// <list type="bullet">
        /// <item><description><para>quanmiao-max: Quanmiao-Max</para>
        /// </description></item>
        /// <item><description><para>quanmiao-plus: Quanmiao-Plus</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>quanmiao-max</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>Original session identifier. Usually empty. When non-empty, it indicates that the current conversation is based on the referenced session. The system loads parameters and search results from that session and replaces the generated result. Use this for re-generation, changing data sources, or adding new agents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("OriginalSessionId")]
        [Validation(Required=false)]
        public string OriginalSessionId { get; set; }

        /// <summary>
        /// <para>Search query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州亚运会吉祥物是什么</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>Unique identifier for the session task.</para>
        /// <remarks>
        /// <para>By default, you do not need to provide a TaskId. The system generates one automatically. If you specify the same TaskId in subsequent requests, those tasks are grouped into the same conversation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7AA2AE16-D873-5C5F-9708-15396C382EB1</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>ID of the Alibaba Cloud Model Studio workspace. To learn how to obtain this ID, see <a href="https://help.aliyun.com/document_detail/2782167.html">How to use workspaces</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
