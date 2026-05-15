// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ExecuteStatementResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteStatementResponseBodyData Data { get; set; }
        public class ExecuteStatementResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidParameterValue</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("results")]
            [Validation(Required=false)]
            public List<ExecuteStatementResponseBodyDataResults> Results { get; set; }
            public class ExecuteStatementResponseBodyDataResults : TeaModel {
                [NameInMap("columnMetadata")]
                [Validation(Required=false)]
                public List<ExecuteStatementResponseBodyDataResultsColumnMetadata> ColumnMetadata { get; set; }
                public class ExecuteStatementResponseBodyDataResultsColumnMetadata : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nullable")]
                    [Validation(Required=false)]
                    public bool? Nullable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>int4</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para><b>Query ID</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>E3F4B2A7-1234-5678-9ABC-DEF012345678</para>
                /// </summary>
                [NameInMap("queryId")]
                [Validation(Required=false)]
                public string QueryId { get; set; }

                [NameInMap("records")]
                [Validation(Required=false)]
                public List<List<string>> Records { get; set; }

                [NameInMap("sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                [NameInMap("truncated")]
                [Validation(Required=false)]
                public bool? Truncated { get; set; }

                [NameInMap("updateCount")]
                [Validation(Required=false)]
                public int? UpdateCount { get; set; }

            }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParameterValue</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>819A7F0F-2951-540F-BD94-6A41ECF0281F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
