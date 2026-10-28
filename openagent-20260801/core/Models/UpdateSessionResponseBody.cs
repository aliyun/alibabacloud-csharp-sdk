// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class UpdateSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The session information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateSessionResponseBodyData Data { get; set; }
        public class UpdateSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the session was created, in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The ID of the last run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run_example_001</para>
            /// </summary>
            [NameInMap("lastRunId")]
            [Validation(Required=false)]
            public string LastRunId { get; set; }

            /// <summary>
            /// <para>The status of the last run. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PENDING</c>: Pending.</description></item>
            /// <item><description><c>RUNNING</c>: Running.</description></item>
            /// <item><description><c>WAITING_USER</c>: Waiting for interrupt handling.</description></item>
            /// <item><description><c>COMPLETED</c>: Completed.</description></item>
            /// <item><description><c>FAILED</c>: Failed.</description></item>
            /// <item><description><c>CANCELLED</c>: Cancelled.</description></item>
            /// <item><description><c>REJECTED</c>: Rejected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("lastRunStatus")]
            [Validation(Required=false)]
            public string LastRunStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the session is pinned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("pinned")]
            [Validation(Required=false)]
            public bool? Pinned { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>session_example_001</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The session status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>IDLE</c>: Idle.</description></item>
            /// <item><description><c>ACTIVE</c>: Active.</description></item>
            /// <item><description><c>WAITING_USER_INPUT</c>: Waiting for user input.</description></item>
            /// <item><description><c>WAITING_APPROVAL</c>: Waiting for user confirmation.</description></item>
            /// <item><description><c>WAITING_OUT_OF_BAND_APPROVAL</c>: Waiting for out-of-band approval.</description></item>
            /// <item><description><c>CLOSED</c>: Closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IDLE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The session title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud resource inspection example</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The time when the session was last updated, in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:01:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. A value of true indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
