// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class StartWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>The workflow input. Only media assets are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Type&quot;: &quot;Media&quot;,
        ///       &quot;Media&quot;: &quot;<b><b><b>30706071edbfe290b488</b></b></b>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TaskInput")]
        [Validation(Required=false)]
        public string TaskInput { get; set; }

        /// <summary>
        /// <para>The user-defined data in the JSON format, which cannot be up to 512 bytes in length. You can specify a custom callback URL. For more information, see <a href="https://help.aliyun.com/document_detail/451631.htm">Configure a callback upon editing completion</a>.</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the workflow template. To view the template ID, log on to the <a href="https://ims.console.aliyun.com/settings/workflow/list">IMS console</a> and choose Configurations &gt; Workflow Template.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>f0e54971ecbffd472190</b></b></b></para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
