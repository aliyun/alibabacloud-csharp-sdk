// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class DescribeExecutionRequest : TeaModel {
        /// <summary>
        /// <para>The name of the execution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec</para>
        /// </summary>
        [NameInMap("ExecutionName")]
        [Validation(Required=false)]
        public string ExecutionName { get; set; }

        /// <summary>
        /// <para>The name of the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The maximum period of time for long polling waits. Valid values: 0 to 60. Unit: seconds. Configure this parameter based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the value is 0, the system immediately returns the current execution status.</description></item>
        /// <item><description>If the value is greater than 0, the long polling request waits until the execution ends or the specified period elapses.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("WaitTimeSeconds")]
        [Validation(Required=false)]
        public int? WaitTimeSeconds { get; set; }

    }

}
