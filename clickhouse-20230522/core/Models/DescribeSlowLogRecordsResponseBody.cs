// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyData Data { get; set; }
        public class DescribeSlowLogRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp100p4q1g9z32****</para>
            /// </summary>
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cluster test</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The list of slow log records.</para>
            /// </summary>
            [NameInMap("ResultSet")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyDataResultSet> ResultSet { get; set; }
            public class DescribeSlowLogRecordsResponseBodyDataResultSet : TeaModel {
                /// <summary>
                /// <para>The IP address from which the query was initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0:0:0:0:0:ffff:1edd65ea</para>
                /// </summary>
                [NameInMap("InitialAddress")]
                [Validation(Required=false)]
                public string InitialAddress { get; set; }

                /// <summary>
                /// <para>The query ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\&quot;ae915a3ad30e77e67a7215d05b658cc6\&quot;</para>
                /// </summary>
                [NameInMap("InitialQueryId")]
                [Validation(Required=false)]
                public string InitialQueryId { get; set; }

                /// <summary>
                /// <para>The user who initiated the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bany</para>
                /// </summary>
                [NameInMap("InitialUser")]
                [Validation(Required=false)]
                public string InitialUser { get; set; }

                /// <summary>
                /// <para>The peak memory usage for the query. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4941696</para>
                /// </summary>
                [NameInMap("MemoryUsage")]
                [Validation(Required=false)]
                public long? MemoryUsage { get; set; }

                /// <summary>
                /// <para>The statement that was being executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select * from test</para>
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                /// <summary>
                /// <para>The execution duration of the slow query. The minimum value is <b>1000</b>. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("QueryDurationMs")]
                [Validation(Required=false)]
                public long? QueryDurationMs { get; set; }

                /// <summary>
                /// <para>The start time of the query. The time is in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-11 16:00:00</para>
                /// </summary>
                [NameInMap("QueryStartTime")]
                [Validation(Required=false)]
                public string QueryStartTime { get; set; }

                /// <summary>
                /// <para>The size of the scanned data. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4507128020832</para>
                /// </summary>
                [NameInMap("ReadBytes")]
                [Validation(Required=false)]
                public long? ReadBytes { get; set; }

                /// <summary>
                /// <para>The number of rows read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ReadRows")]
                [Validation(Required=false)]
                public long? ReadRows { get; set; }

                /// <summary>
                /// <para>The size of the result data. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ResultBytes")]
                [Validation(Required=false)]
                public long? ResultBytes { get; set; }

                /// <summary>
                /// <para>The type of the slow query log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ExceptionWhileProcessing</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF203CC8-5F68-5E3F-8050-3C77DD65731A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
