// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeProcessListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProcessListResponseBodyData Data { get; set; }
        public class DescribeProcessListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-xxxx</para>
            /// </summary>
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The result sets.</para>
            /// </summary>
            [NameInMap("ResultSet")]
            [Validation(Required=false)]
            public List<DescribeProcessListResponseBodyDataResultSet> ResultSet { get; set; }
            public class DescribeProcessListResponseBodyDataResultSet : TeaModel {
                /// <summary>
                /// <para>The address to which the query statement is sent.</para>
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
                /// <para>\&quot;79f7e40b-87e2-4ef4-b6df-21889a3a030e\&quot;</para>
                /// </summary>
                [NameInMap("InitialQueryId")]
                [Validation(Required=false)]
                public string InitialQueryId { get; set; }

                /// <summary>
                /// <para>The user who executes the query statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bany</para>
                /// </summary>
                [NameInMap("InitialUser")]
                [Validation(Required=false)]
                public string InitialUser { get; set; }

                /// <summary>
                /// <para>The query statement that is running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select * from test</para>
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                /// <summary>
                /// <para>The minimum query duration. Minimum value: <b>1000</b>. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("QueryDurationMs")]
                [Validation(Required=false)]
                public long? QueryDurationMs { get; set; }

                /// <summary>
                /// <para>The beginning of the time range to query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-07-23T10:13:23Z</para>
                /// </summary>
                [NameInMap("QueryStartTime")]
                [Validation(Required=false)]
                public string QueryStartTime { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
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
        /// <para>xxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
