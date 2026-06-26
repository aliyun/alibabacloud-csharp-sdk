// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class StatementResult : TeaModel {
        /// <summary>
        /// <para>A temporary URL to download the result set, provided only when the result set is too large to return directly.</para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The error message, present only if the execution fails.</para>
        /// </summary>
        [NameInMap("error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>The error code, present only if the execution fails.</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The statement\&quot;s total execution time, in milliseconds.</para>
        /// </summary>
        [NameInMap("executionTime")]
        [Validation(Required=false)]
        public long? ExecutionTime { get; set; }

        /// <summary>
        /// <para>The zero-based index of the SQL statement in a batch execution.</para>
        /// </summary>
        [NameInMap("index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// <para>The number of rows affected or returned by the statement.</para>
        /// </summary>
        [NameInMap("rowCount")]
        [Validation(Required=false)]
        public int? RowCount { get; set; }

        /// <summary>
        /// <para>An array of objects describing the result set\&quot;s schema. Each object defines a column.</para>
        /// </summary>
        [NameInMap("schema")]
        [Validation(Required=false)]
        public List<StatementResultSchema> Schema { get; set; }
        public class StatementResultSchema : TeaModel {
            /// <summary>
            /// <para>The name of the column.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The data type of the column.</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The original SQL statement.</para>
        /// </summary>
        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        /// <summary>
        /// <para>The statement\&quot;s execution status. Possible values are <c>RUNNING</c>, <c>FINISHED</c>, <c>CANCELED</c>, or <c>FAILED</c>.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
