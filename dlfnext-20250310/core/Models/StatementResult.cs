// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class StatementResult : TeaModel {
        /// <summary>
        /// <para>The presigned URL of the Arrow IPC file. This parameter is returned when a result set exists. The URL is valid for 1 hour and contains full data. The value is null for an empty result set (rowCount == 0).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.oss-cn-hangzhou.aliyuncs.com/xxxx">https://xxx.oss-cn-hangzhou.aliyuncs.com/xxxx</a></para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned only when the status is FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL_ERROR</para>
        /// </summary>
        [NameInMap("error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>The error code. This parameter is returned only when the status is FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This feature is not implemented: xxx</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The execution duration of the statement, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("executionTime")]
        [Validation(Required=false)]
        public long? ExecutionTime { get; set; }

        /// <summary>
        /// <para>The statement sequence number (0-based).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// <para>The total number of rows in the result. The value is 0 for statements that do not return a result set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("rowCount")]
        [Validation(Required=false)]
        public int? RowCount { get; set; }

        /// <summary>
        /// <para>The result column information. This parameter is returned when a result set exists.</para>
        /// </summary>
        [NameInMap("schema")]
        [Validation(Required=false)]
        public List<StatementResultSchema> Schema { get; set; }
        public class StatementResultSchema : TeaModel {
            /// <summary>
            /// <para>The column name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The data type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The SQL text of the statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from table_name;</para>
        /// </summary>
        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        /// <summary>
        /// <para>The status of the statement. Valid values: COMPLETED and FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
