// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class AsyncSqlResponseData : TeaModel {
        /// <summary>
        /// <para>The metadata of the SQL query.</para>
        /// </summary>
        [NameInMap("AsyncSqlMetaPB")]
        [Validation(Required=false)]
        public AsyncSqlResponseDataAsyncSqlMetaPB AsyncSqlMetaPB { get; set; }
        public class AsyncSqlResponseDataAsyncSqlMetaPB : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("cpu_cores")]
            [Validation(Required=false)]
            public int? CpuCores { get; set; }

            /// <summary>
            /// <para>The total CPU time consumed in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("cpu_sec")]
            [Validation(Required=false)]
            public double? CpuSec { get; set; }

            /// <summary>
            /// <para>The SQL query running time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000</para>
            /// </summary>
            [NameInMap("elapsed_milli")]
            [Validation(Required=false)]
            public long? ElapsedMilli { get; set; }

            /// <summary>
            /// <para>The names of the columns in the SQL result. The keys correspond one-to-one with the fields in the SELECT statement.</para>
            /// </summary>
            [NameInMap("keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

            /// <summary>
            /// <para>The number of raw data rows processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000000</para>
            /// </summary>
            [NameInMap("processed_rows")]
            [Validation(Required=false)]
            public long? ProcessedRows { get; set; }

            /// <summary>
            /// <para>Indicates whether the SQL result is accurate. Valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para>Complete: The result is accurate.</para>
            /// </description></item>
            /// <item><description><para>Incomplete: The result is not accurate.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The total number of rows in the result. When you read the results, the offset value must not exceed this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12000</para>
            /// </summary>
            [NameInMap("result_rows")]
            [Validation(Required=false)]
            public int? ResultRows { get; set; }

        }

        /// <summary>
        /// <para>If the SQL query fails to execute, this parameter contains the specific error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidQuery</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>If the SQL query fails to execute, this parameter contains the specific error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>line 37:14: Column \&quot;xyz\&quot; cannot be resolved</para>
        /// </summary>
        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous SQL query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>690C4F2A16FBD65C40000484_14</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The SQL result. Each element in the array is also an array that corresponds to a specific row of the result.</para>
        /// </summary>
        [NameInMap("rows")]
        [Validation(Required=false)]
        public List<List<string>> Rows { get; set; }

        /// <summary>
        /// <para>The current execution state of the asynchronous SQL query. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>RUNNING</para>
        /// </description></item>
        /// <item><description><para>FINISHED</para>
        /// </description></item>
        /// <item><description><para>FAILED</para>
        /// </description></item>
        /// <item><description><para>CANCELLED</para>
        /// </description></item>
        /// </list>
        /// <para>RUNNING is a temporary state that indicates the SQL query is still running. You can read the results only when the state is FINISHED. The error_code and error_message parameters are valid only when the state is FAILED.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
