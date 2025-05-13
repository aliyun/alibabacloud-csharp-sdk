// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ExecuteWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>If the request is successful, the ID of the workflow instance is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExecuteWorkflowResponseBodyData Data { get; set; }
        public class ExecuteWorkflowResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The workflow instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("WfInstanceId")]
            [Validation(Required=false)]
            public long? WfInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The error message that is returned only if the corresponding error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cannot find product according to your domain.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F68ABED-AC31-4412-9297-D9A8F0401108</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
