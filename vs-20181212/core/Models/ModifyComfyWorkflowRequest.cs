// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyComfyWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>The new workflow description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个图生视频的工作流</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the workflow to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wf_3de1eb6e-1dfe-45aa-8f88-2269d0a30f53</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// <para>The new workflow name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>图生视频工作流示例</para>
        /// </summary>
        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

    }

}
