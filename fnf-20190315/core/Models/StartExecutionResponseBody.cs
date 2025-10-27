// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class StartExecutionResponseBody : TeaModel {
        /// <summary>
        /// <para>The definition of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version: v1.0\ntype: flow\nname: test\nsteps:\n - type: pass\n name: mypass</para>
        /// </summary>
        [NameInMap("FlowDefinition")]
        [Validation(Required=false)]
        public string FlowDefinition { get; set; }

        /// <summary>
        /// <para>The name of the workflow.</para>
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
        /// <para>The name of the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The execution result, which is in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRequestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the execution started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-01T01:01:01.001Z</para>
        /// </summary>
        [NameInMap("StartedTime")]
        [Validation(Required=false)]
        public string StartedTime { get; set; }

        /// <summary>
        /// <para>The execution status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Starting</b></description></item>
        /// <item><description><b>Running</b></description></item>
        /// <item><description><b>Stopped</b></description></item>
        /// <item><description><b>Succeeded</b></description></item>
        /// <item><description><b>Failed</b></description></item>
        /// <item><description><b>TimedOut</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the execution stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-01T01:01:01.001Z</para>
        /// </summary>
        [NameInMap("StoppedTime")]
        [Validation(Required=false)]
        public string StoppedTime { get; set; }

    }

}
