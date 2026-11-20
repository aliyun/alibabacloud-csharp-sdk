// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ExecuteStatementResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether OpenAPI SQL execution is allowed. Valid values: true: Allowed. false: Not allowed.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteStatementResponseBodyData Data { get; set; }
        public class ExecuteStatementResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error code. This field is empty if the request is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameterValue</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. This field is empty if the request is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Invalid parameter value, such as an empty or excessively long SQL statement</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The list of execution results. The length is currently fixed to 1. If multiple SELECT queries are executed, only the result of the last SELECT query is returned.</para>
            /// </summary>
            [NameInMap("results")]
            [Validation(Required=false)]
            public List<ExecuteStatementResponseBodyDataResults> Results { get; set; }
            public class ExecuteStatementResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The <b>column metadata</b>.</para>
                /// </summary>
                [NameInMap("columnMetadata")]
                [Validation(Required=false)]
                public List<ExecuteStatementResponseBodyDataResultsColumnMetadata> ColumnMetadata { get; set; }
                public class ExecuteStatementResponseBodyDataResultsColumnMetadata : TeaModel {
                    /// <summary>
                    /// <para>The <b>column name</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the column is nullable.</para>
                    /// </summary>
                    [NameInMap("nullable")]
                    [Validation(Required=false)]
                    public bool? Nullable { get; set; }

                    /// <summary>
                    /// <para>The data type, such as int4, text, or bool.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>int4</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The number of rows returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The error code for the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL_ERROR</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message for the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ERROR: relation \&quot;non_existent_table\&quot; does not exist\n  Position: 15</para>
                /// </summary>
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

                /// <summary>
                /// <para>The set of query result rows. Each row is an array of strings. All values are serialized as strings, and NULL values are represented as \N.</para>
                /// </summary>
                [NameInMap("records")]
                [Validation(Required=false)]
                public List<List<string>> Records { get; set; }

                /// <summary>
                /// <para>The SQL statement that is actually executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select * from test_table limit 10;</para>
                /// </summary>
                [NameInMap("sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                /// <summary>
                /// <para>Indicates whether the request is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// <para>Indicates whether the result is truncated. The value is true if the result exceeds MaxResults.</para>
                /// </summary>
                [NameInMap("truncated")]
                [Validation(Required=false)]
                public bool? Truncated { get; set; }

                /// <summary>
                /// <para>The number of rows affected by the INSERT, UPDATE, or DELETE statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("updateCount")]
                [Validation(Required=false)]
                public int? UpdateCount { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the request is successful.</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The error code. This field is empty if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameterValue</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message. This field is empty if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid parameter value, such as an empty or excessively long SQL statement</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
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

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
