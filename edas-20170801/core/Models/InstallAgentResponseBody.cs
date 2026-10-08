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

        [NameInMap("ExecutionResultList")]
        [Validation(Required=false)]
        public InstallAgentResponseBodyExecutionResultList ExecutionResultList { get; set; }
        public class InstallAgentResponseBodyExecutionResultList : TeaModel {
            [NameInMap("ExecutionResult")]
            [Validation(Required=false)]
            public List<InstallAgentResponseBodyExecutionResultListExecutionResult> ExecutionResult { get; set; }
            public class InstallAgentResponseBodyExecutionResultListExecutionResult : TeaModel {
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InvokeRecordStatus")]
                [Validation(Required=false)]
                public string InvokeRecordStatus { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
