// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ExecuteStatementResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution result of the SQL statement.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteStatementResponseBodyData Data { get; set; }
        public class ExecuteStatementResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error code for the SQL statement execution. This parameter is returned only if the execution fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameterValue</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message for the SQL statement execution. This parameter is returned only if the execution fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>参数值不合法（如 SQL 为空、超长等）</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>A list of execution results. This list always contains exactly one result object. If you execute multiple SELECT statements, only the result of the last one is returned.</para>
            /// </summary>
            [NameInMap("results")]
            [Validation(Required=false)]
            public List<ExecuteStatementResponseBodyDataResults> Results { get; set; }
            public class ExecuteStatementResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The metadata of columns in the result set.</para>
                /// </summary>
                [NameInMap("columnMetadata")]
                [Validation(Required=false)]
                public List<ExecuteStatementResponseBodyDataResultsColumnMetadata> ColumnMetadata { get; set; }
                public class ExecuteStatementResponseBodyDataResultsColumnMetadata : TeaModel {
                    /// <summary>
                    /// <para>The name of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the column can be null.</para>
                    /// </summary>
                    [NameInMap("nullable")]
                    [Validation(Required=false)]
                    public bool? Nullable { get; set; }

                    /// <summary>
                    /// <para>The data type of the column, such as <c>int4</c>, <c>text</c>, or <c>bool</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>int4</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The number of rows returned by a SELECT statement.</para>
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
                /// <para>The ID of the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>E3F4B2A7-1234-5678-9ABC-DEF012345678</para>
                /// </summary>
                [NameInMap("queryId")]
                [Validation(Required=false)]
                public string QueryId { get; set; }

                /// <summary>
                /// <para>The set of records that are returned by the query. Each row is an array of strings, and all values are serialized as strings. A NULL value is represented as &quot;\N&quot;.</para>
                /// </summary>
                [NameInMap("records")]
                [Validation(Required=false)]
                public List<List<string>> Records { get; set; }

                /// <summary>
                /// <para>The executed SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select * from test_table limit 10;</para>
                /// </summary>
                [NameInMap("sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                /// <summary>
                /// <para>Indicates whether the SQL statement was executed successfully.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// <para>Indicates whether the result set was truncated. The value is <c>true</c> if the number of returned rows exceeds the value of <c>MaxResults</c>.</para>
                /// </summary>
                [NameInMap("truncated")]
                [Validation(Required=false)]
                public bool? Truncated { get; set; }

                /// <summary>
                /// <para>The number of rows affected by an INSERT, UPDATE, or DELETE statement. This parameter is not returned for SELECT statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("updateCount")]
                [Validation(Required=false)]
                public int? UpdateCount { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the SQL statement was executed successfully.</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The error code. This parameter is returned only if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameterValue</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned only if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>参数值不合法（如 SQL 为空、超长等）</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>819A7F0F-2951-540F-BD94-6A41ECF0281F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
