// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ExecuteMetaQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ExecuteMetaQueryResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ExecuteMetaQueryResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>Same as above.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>Same as above.</para>
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
            /// <para>NoPermissionType</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>PolicyType</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIORITY</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The list of instance details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExecuteMetaQueryResponseBodyData Data { get; set; }
        public class ExecuteMetaQueryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual top-level LIMIT offset applied to the SQL statement. If no offset is specified, the value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AppliedOffset")]
            [Validation(Required=false)]
            public long? AppliedOffset { get; set; }

            /// <summary>
            /// <para>The effective upper limit of returned rows for this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AppliedRowLimit")]
            [Validation(Required=false)]
            public long? AppliedRowLimit { get; set; }

            /// <summary>
            /// <para>The column names.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            /// <summary>
            /// <para>Indicates whether the query result contains at least one more row beyond the effective row limit for this request.</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>The size in bytes of the Rows JSON array in the returned result after UTF-8 encoding, excluding protocol overhead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("RecordsSizeBytes")]
            [Validation(Required=false)]
            public long? RecordsSizeBytes { get; set; }

            /// <summary>
            /// <para>The actual number of result rows returned for this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ReturnedRowCount")]
            [Validation(Required=false)]
            public long? ReturnedRowCount { get; set; }

            /// <summary>
            /// <para>The total number of data rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>97901</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public int? RowCount { get; set; }

            /// <summary>
            /// <para>The number of affected or returned rows. This field is available only for CN.</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Rows { get; set; }

        }

        /// <summary>
        /// <para>The additional message returned by the API operation. If the request is successful, success is returned. If an error occurs, the corresponding error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
