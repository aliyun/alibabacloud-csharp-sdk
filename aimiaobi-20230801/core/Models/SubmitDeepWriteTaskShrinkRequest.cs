// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitDeepWriteTaskShrinkRequest : TeaModel {
        [NameInMap("AgentOrchestration")]
        [Validation(Required=false)]
        public string AgentOrchestrationShrink { get; set; }

        [NameInMap("Files")]
        [Validation(Required=false)]
        public string FilesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        [NameInMap("Instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-1setzb9xb8m11vrc</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
