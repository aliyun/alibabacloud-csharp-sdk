// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetAgentWorkLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The agent operation records in reverse chronological order. If no records are saved, an empty list is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("logs")]
        [Validation(Required=false)]
        public List<GetAgentWorkLogResponseBodyLogs> Logs { get; set; }
        public class GetAgentWorkLogResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>The record type. Valid values: THINK, REPLY, TOOL_CALL, SKILL_CALL, and ARTIFACT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REPLY</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The saved raw record content. Tool invocations and artifact metadata are represented as JSON strings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The data query for the current round is completed</para>
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The duration of this operation record, in milliseconds. The value is 0 for artifact records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The key of the node to which the record belongs. This is not the session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>query.amount</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The time when the event was recorded, in ISO 8601 format. If the source record has no time, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-14T08:00:00Z</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The current page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of filtered operation log entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
