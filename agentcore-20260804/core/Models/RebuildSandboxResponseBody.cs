// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class RebuildSandboxResponseBody : TeaModel {
        /// <summary>
        /// <para>Task result code of the API request. A successful request returns SUCCESS. Query task result of the asynchronous task separately.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The acceptance result of the rebuild request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RebuildSandboxResponseBodyData Data { get; set; }
        public class RebuildSandboxResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The target instance incarnation for this rebuild. A rebuild increases the incarnation. The returned value only indicates that the request is accepted and does not indicate that the new instance is ready.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("incarnation")]
            [Validation(Required=false)]
            public long? Incarnation { get; set; }

            /// <summary>
            /// <para>The ID of the initial rebuild task. Use the operationId returned by RebuildSandbox. Always use this ID to query the overall result. You do not need to use the IDs of subsequently created tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01a1be92-7fa4-76b2-a871-b376d6d0****</para>
            /// </summary>
            [NameInMap("operationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <para>The logical sandbox ID that corresponds to this rebuild. The logical ID remains unchanged after the rebuild.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01a1b56a-b00f-7aa3-bacf-cc9d04b0****</para>
            /// </summary>
            [NameInMap("sandboxId")]
            [Validation(Required=false)]
            public string SandboxId { get; set; }

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
        /// <para>The result description of the API request. This does not indicate that the asynchronous rebuild task is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the request ID to locate the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1BE93-46A7-1A2A-BD62-159FCDAA****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API request is successful. A value of true does not indicate that the sandbox rebuild is complete.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
