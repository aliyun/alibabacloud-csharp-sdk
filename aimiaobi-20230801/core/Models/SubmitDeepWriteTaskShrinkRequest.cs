// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitDeepWriteTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The agent orchestration options.</para>
        /// </summary>
        [NameInMap("AgentOrchestration")]
        [Validation(Required=false)]
        public string AgentOrchestrationShrink { get; set; }

        /// <summary>
        /// <para>A list of attachments.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public string FilesShrink { get; set; }

        /// <summary>
        /// <para>The user\&quot;s question.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>北京2025年新能源汽车发展趋势</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请根据北京新能源汽车在汽车品牌、新车发布、能源等方面进行分析</para>
        /// </summary>
        [NameInMap("Instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">The workspace ID.</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-1setzb9xb8m11vrc</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
