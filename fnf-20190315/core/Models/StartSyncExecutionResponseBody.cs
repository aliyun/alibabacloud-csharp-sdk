// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class StartSyncExecutionResponseBody : TeaModel {
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public StartSyncExecutionResponseBodyEnvironment Environment { get; set; }
        public class StartSyncExecutionResponseBodyEnvironment : TeaModel {
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<StartSyncExecutionResponseBodyEnvironmentVariables> Variables { get; set; }
            public class StartSyncExecutionResponseBodyEnvironmentVariables : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code that is returned if the execution failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ActionNotSupported</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that indicates the execution timed out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard execution is not supported</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The name of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_flow_name</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The name of the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_exec_name:{UUID}</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output of the execution, which is in the JSON format.</para>
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
        /// <para>The status of the execution. Valid values:</para>
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
