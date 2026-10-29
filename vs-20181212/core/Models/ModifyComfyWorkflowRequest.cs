// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyComfyWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>The description of the workflow template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an image-to-video workflow</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The workflow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wf_3de1eb6e-1dfe-45aa-8f88-2269d0a30f53</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// <para>The name of the workflow template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Image-to-video workflow example</para>
        /// </summary>
        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

    }

}
