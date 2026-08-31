// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class QueryColumnarLogSSEResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public QueryColumnarLogSSEResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class QueryColumnarLogSSEResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>As described above.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The owner ID of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The identity type used for authentication in the request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SubUser: RAM user.</description></item>
            /// <item><description>AssumedRoleUser: RAM role.</description></item>
            /// <item><description>Federated: SSO federated identity.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encoded diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaKPfwjY0MzMyODRGLUZCQkQtNTA1RS04MUUxLTc5NTkzODk2MUIzMg==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>NoPermissionType</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIORITY</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>Returned only when Type is EOF. The top-level SQL LIMIT offset actually applied by the service. The value is 0 if the SQL statement does not specify an offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AppliedOffset")]
        [Validation(Required=false)]
        public long? AppliedOffset { get; set; }

        /// <summary>
        /// <para>Returned only when Type is EOF. The maximum number of rows actually applied by the service after combining the top-level SQL LIMIT, MaxResultRows, and the current service policy. This value does not include the extra row used to detect HasMore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("AppliedRowLimit")]
        [Validation(Required=false)]
        public long? AppliedRowLimit { get; set; }

        /// <summary>
        /// <para>The stable error code. This field is returned only when Type is ERROR. Handle errors based on this field instead of relying on the Message text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned only when Type is EOF. Indicates whether the service or API row limit truncated the SQL submitted by the caller. A value of false when the SQL statement has a smaller LIMIT that was fully executed does not indicate that no more data exists in the underlying table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The error summary. This field is returned only when Type is ERROR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Query execution failed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether at least one RECORD event was sent before the ERROR occurred. A value of true indicates that the results already received by the caller are incomplete and must not be treated as complete query results.</para>
        /// </summary>
        [NameInMap("Partial")]
        [Validation(Required=false)]
        public bool? Partial { get; set; }

        /// <summary>
        /// <para>Returned only when Type is EOF. The elapsed time from the start of JDBC statement execution to the completion of reading the last result row or probe row. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>125</para>
        /// </summary>
        [NameInMap("QueryElapsedTimeMilliseconds")]
        [Validation(Required=false)]
        public long? QueryElapsedTimeMilliseconds { get; set; }

        /// <summary>
        /// <para>The unique identifier generated by the service for this JDBC query. All events in the same SSE stream share the same QueryId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d3d88ea-3df0-4c2d-a8bb-2ec423b86b56</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <para>Returned only when Type is RECORD. A batch of query results carried by this event. Each row is a JSON key-value object that maps column names to text values. SQL NULL values are encoded as the string null.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Records { get; set; }

        /// <summary>
        /// <para>Returned only when Type is EOF. The sum of UTF-8 bytes of the JSON objects for all returned rows. This value does not include arrays, SSE frames, or fixed response fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("RecordsSizeBytes")]
        [Validation(Required=false)]
        public long? RecordsSizeBytes { get; set; }

        /// <summary>
        /// <para>The request ID. The same ID is used across all stages of the request, including access, authentication, routing, query execution, and all SSE events, to facilitate end-to-end troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C457B28E-9CAB-4B77-B5C6-5D71B7870B6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current ERROR is suitable for retry. A value of true indicates that you can retry the request based on the suggestion returned with the error. A value of false indicates that you need to modify the request or contact the service team for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Retryable")]
        [Validation(Required=false)]
        public bool? Retryable { get; set; }

        /// <summary>
        /// <para>Returned only when Type is EOF. The total number of result rows actually returned in this SSE stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ReturnedRowCount")]
        [Validation(Required=false)]
        public long? ReturnedRowCount { get; set; }

        /// <summary>
        /// <para>The sequence number of the RECORD event, starting from 1 and incrementing. This field indicates the event order and does not represent the result row offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public long? Sequence { get; set; }

        /// <summary>
        /// <para>The SSE event type. RECORD indicates a batch of query results. EOF indicates that the query has completed. ERROR indicates that the query ended abnormally.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RECORD</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
