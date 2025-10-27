// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class StartSyncExecutionRequest : TeaModel {
        /// <summary>
        /// <para>The name of the execution that you want to start. The name must meet the following conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must start with a letter or an underscore (_).</description></item>
        /// <item><description>The name is case-sensitive.</description></item>
        /// <item><description>The name must be 1 to 128 characters in length.</description></item>
        /// </list>
        /// <para>Different from the StartExecution operation, in the synchronous execution mode, the execution name is no longer required to be unique within a flow. You can choose to provide an execution name to identify the current execution. In this case, the system adds a UUID to the current execution name. The used format is {ExecutionName}:{UUID}. If you do not specify the execution name, the system automatically generates an execution name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_exec_name</para>
        /// </summary>
        [NameInMap("ExecutionName")]
        [Validation(Required=false)]
        public string ExecutionName { get; set; }

        /// <summary>
        /// <para>The name of the workflow to be executed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_flow_name</para>
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
