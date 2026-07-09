// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ExecuteQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The result column types.</para>
        /// </summary>
        [NameInMap("columnTypes")]
        [Validation(Required=false)]
        public List<string> ColumnTypes { get; set; }

        /// <summary>
        /// <para>The result column information.</para>
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public List<string> Columns { get; set; }

        /// <summary>
        /// <para>The metadata of the returned data.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public ExecuteQueryResponseBodyMeta Meta { get; set; }
        public class ExecuteQueryResponseBodyMeta : TeaModel {
            /// <summary>
            /// <para>The number of log rows scanned or processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("affectedRows")]
            [Validation(Required=false)]
            public int? AffectedRows { get; set; }

            /// <summary>
            /// <para>The number of log rows returned by this query request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The time consumed by this execution, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("elapsedMillisecond")]
            [Validation(Required=false)]
            public long? ElapsedMillisecond { get; set; }

            /// <summary>
            /// <para>Indicates whether the query result is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("truncation")]
            [Validation(Required=false)]
            public ExecuteQueryResponseBodyMetaTruncation Truncation { get; set; }
            public class ExecuteQueryResponseBodyMetaTruncation : TeaModel {
                [NameInMap("truncated")]
                [Validation(Required=false)]
                public bool? Truncated { get; set; }

                [NameInMap("truncatedColumnIndexes")]
                [Validation(Required=false)]
                public List<List<int?>> TruncatedColumnIndexes { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB27D183-8F6C-5C5A-A6A3-E0508AF54F78</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result rows.</para>
        /// </summary>
        [NameInMap("rows")]
        [Validation(Required=false)]
        public List<List<object>> Rows { get; set; }

    }

}
