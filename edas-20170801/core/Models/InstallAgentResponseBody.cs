// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InstallAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The execution result.</para>
        /// </summary>
        [NameInMap("ExecutionResultList")]
        [Validation(Required=false)]
        public InstallAgentResponseBodyExecutionResultList ExecutionResultList { get; set; }
        public class InstallAgentResponseBodyExecutionResultList : TeaModel {
            [NameInMap("ExecutionResult")]
            [Validation(Required=false)]
            public List<InstallAgentResponseBodyExecutionResultListExecutionResult> ExecutionResult { get; set; }
            public class InstallAgentResponseBodyExecutionResultListExecutionResult : TeaModel {
                /// <summary>
                /// <para>The time when the installation was complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20**-11-10T07:02:17Z</para>
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2ze7s2v0b789k*******</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The state of the installation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("InvokeRecordStatus")]
                [Validation(Required=false)]
                public string InvokeRecordStatus { get; set; }

                /// <summary>
                /// <para>The state of the installation command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Indicates whether the installation was successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-7ca7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
