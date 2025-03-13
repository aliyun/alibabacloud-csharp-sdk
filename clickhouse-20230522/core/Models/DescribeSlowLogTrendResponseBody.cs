// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeSlowLogTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlowLogTrendResponseBodyData Data { get; set; }
        public class DescribeSlowLogTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp100p4q1g9z3****</para>
            /// </summary>
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clusterTest</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The result sets.</para>
            /// </summary>
            [NameInMap("ResultSet")]
            [Validation(Required=false)]
            public List<DescribeSlowLogTrendResponseBodyDataResultSet> ResultSet { get; set; }
            public class DescribeSlowLogTrendResponseBodyDataResultSet : TeaModel {
                /// <summary>
                /// <para>The average execution duration of slow SQL queries. Minimum value: <b>1000</b>. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("AvgQueryDurationMs")]
                [Validation(Required=false)]
                public long? AvgQueryDurationMs { get; set; }

                /// <summary>
                /// <para>The total number of SQL queries within the specified time range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Cnt")]
                [Validation(Required=false)]
                public long? Cnt { get; set; }

                /// <summary>
                /// <para>The maximum execution duration of slow SQL queries. Minimum value: <b>1000</b>. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("MaxQueryDurationMs")]
                [Validation(Required=false)]
                public long? MaxQueryDurationMs { get; set; }

                /// <summary>
                /// <para>The minimum execution duration of slow SQL queries. Minimum value: <b>1000</b>. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MinQueryDurationMs")]
                [Validation(Required=false)]
                public long? MinQueryDurationMs { get; set; }

                /// <summary>
                /// <para>The beginning of the time range to query. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-13 17:48:00</para>
                /// </summary>
                [NameInMap("QueryStartTime")]
                [Validation(Required=false)]
                public string QueryStartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D3ECB0E-98CA-5E08-A9CA-F70C5A1E9BDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
