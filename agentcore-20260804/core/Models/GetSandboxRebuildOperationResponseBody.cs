// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetSandboxRebuildOperationResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code of the API request. A successful request returns SUCCESS. Query the asynchronous task result separately.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The overall result of the rebuild task.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSandboxRebuildOperationResponseBodyData Data { get; set; }
        public class GetSandboxRebuildOperationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The publicly accessible node error. This error is returned when the node fails, is canceled, or subsequent operations override it. It can be empty in other states.</para>
            /// </summary>
            [NameInMap("error")]
            [Validation(Required=false)]
            public GetSandboxRebuildOperationResponseBodyDataError Error { get; set; }
            public class GetSandboxRebuildOperationResponseBodyDataError : TeaModel {
                /// <summary>
                /// <para>The task error code. This code is used to distinguish between rebuild failures, subsequent instance creation failures, cancellations, or supersessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SandboxRebuild.Failed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The publicly accessible task error message. Keep the task ID for troubleshooting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The Sandbox rebuild did not complete. Contact support with the operation ID.</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The initial rebuild task ID. Use the operationId returned by RebuildSandbox. Always use this ID to query the overall result. You do not need to switch to the ID of a subsequent creation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01a1be92-7fa4-76b2-a871-b376d6d0****</para>
            /// </summary>
            [NameInMap("operationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <para>The logical sandbox ID corresponding to this rebuild. The logical ID remains unchanged after the rebuild.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01a1b56a-b00f-7aa3-bacf-cc9d04b0****</para>
            /// </summary>
            [NameInMap("sandboxId")]
            [Validation(Required=false)]
            public string SandboxId { get; set; }

            /// <summary>
            /// <para>The overall rebuild status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PENDING: Waiting to be processed.</description></item>
            /// <item><description>RUNNING: execute in progress.</description></item>
            /// <item><description>SUCCEEDED: Overall success.</description></item>
            /// <item><description>FAILED: Failed.</description></item>
            /// <item><description>CANCELED: Canceled.</description></item>
            /// <item><description>SUPERSEDED: override by subsequent operations.</description></item>
            /// <item><description>UNKNOWN: Unconfirmed.
            /// Only SUCCEEDED indicates completion. Do not treat UNKNOWN, missing status, or query exceptions as success, and do not automatically resubmit the rebuild.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The result message of the API request. This message does not indicate that the asynchronous rebuild task is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID used to trace the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1BE93-46A7-1A2A-BD62-159FCDAA****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API request is successful. A value of true does not indicate that the sandbox rebuild is completed.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
