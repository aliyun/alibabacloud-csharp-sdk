// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class GetSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSessionResponseBodyData Data { get; set; }
        public class GetSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the session was created, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The ID of the most recent run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run_example_001</para>
            /// </summary>
            [NameInMap("lastRunId")]
            [Validation(Required=false)]
            public string LastRunId { get; set; }

            /// <summary>
            /// <para>The status of the most recent run. Valid values: <c>PENDING</c> (pending execution), <c>RUNNING</c> (running), <c>WAITING_USER</c> (waiting for interrupt handling), <c>COMPLETED</c> (completed), <c>FAILED</c> (failed), <c>CANCELLED</c> (cancelled), and <c>REJECTED</c> (rejected).</para>
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
            /// <para>The session status. Valid values: <c>IDLE</c> (idle), <c>ACTIVE</c> (active), <c>WAITING_USER_INPUT</c> (waiting for user input), <c>WAITING_APPROVAL</c> (waiting for user confirmation), <c>WAITING_OUT_OF_BAND_APPROVAL</c> (waiting for out-of-band approval), and <c>CLOSED</c> (closed).</para>
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
            /// <para>The time when the session was last updated, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:01:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
