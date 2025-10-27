// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class StartExecutionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies that the <b>TaskToken</b>-related tasks are called back after the execution in the flow ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("CallbackFnFTaskToken")]
        [Validation(Required=false)]
        public string CallbackFnFTaskToken { get; set; }

        /// <summary>
        /// <para>The name of the execution. The execution name is unique within a workflow. Configure this parameter based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a letter or an underscore (_).</description></item>
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name is case-sensitive.</description></item>
        /// <item><description>The name must be 1 to 128 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>exec</para>
        /// </summary>
        [NameInMap("ExecutionName")]
        [Validation(Required=false)]
        public string ExecutionName { get; set; }

        /// <summary>
        /// <para>The name of the workflow to be executed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The input of the execution, which is in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
