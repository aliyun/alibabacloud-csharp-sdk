// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class QueryColumnarLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public QueryColumnarLogResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class QueryColumnarLogResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication action.</para>
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
            /// <para>The type of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The diagnostic information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaKPfwjY0MzMyODRGLUZCQkQtNTA1RS04MUUxLTc5NTkzODk2MUIzMg==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The type of the missing permission.</para>
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
        /// <para>The top-level SQL LIMIT offset that the service actually applied. The value is 0 if no offset is specified in the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AppliedOffset")]
        [Validation(Required=false)]
        public long? AppliedOffset { get; set; }

        /// <summary>
        /// <para>The maximum number of rows that the service actually returns after evaluating the top-level SQL LIMIT clause, MaxResultRows, the default value of the synchronous API, and the current service policy. This value does not include the extra row used to detect HasMore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("AppliedRowLimit")]
        [Validation(Required=false)]
        public long? AppliedRowLimit { get; set; }

        /// <summary>
        /// <para>Indicates whether the service or API row limit truncated the SQL statement submitted by the caller. The value is false when the SQL statement with a smaller LIMIT clause is fully executed, which does not indicate that no more data exists in the underlying table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The elapsed time from the start of the JDBC statement execution to the completion of reading the last returned row or probe row. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>125</para>
        /// </summary>
        [NameInMap("QueryElapsedTimeMilliseconds")]
        [Validation(Required=false)]
        public long? QueryElapsedTimeMilliseconds { get; set; }

        /// <summary>
        /// <para>The unique identifier generated by the service for this JDBC query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;NodeId\&quot;:\&quot;n_7844571364614995969\&quot;}</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <para>The list of query results. Each row is a JSON key-value object that maps column names to text values. All scalar values are returned as strings. SQL NULL is encoded as the string null, and empty strings remain as empty strings.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Records { get; set; }

        /// <summary>
        /// <para>The total number of UTF-8 bytes of the JSON objects across all returned rows, excluding the array and fixed response fields. The complete JSON response of the synchronous API is also subject to a 16 MiB upper limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("RecordsSizeBytes")]
        [Validation(Required=false)]
        public long? RecordsSizeBytes { get; set; }

        /// <summary>
        /// <para>The request ID. This ID is used throughout the entire process from access, authentication, and routing to query completion, which facilitates end-to-end troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-****-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of result rows actually returned in this synchronous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ReturnedRowCount")]
        [Validation(Required=false)]
        public long? ReturnedRowCount { get; set; }

    }

}
