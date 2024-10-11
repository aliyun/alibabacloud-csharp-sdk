// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeProcessListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProcessListResponseBodyData Data { get; set; }
        public class DescribeProcessListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cc-xxxx</para>
            /// </summary>
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("ResultSet")]
            [Validation(Required=false)]
            public List<DescribeProcessListResponseBodyDataResultSet> ResultSet { get; set; }
            public class DescribeProcessListResponseBodyDataResultSet : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0:0:0:0:0:ffff:1edd65ea</para>
                /// </summary>
                [NameInMap("InitialAddress")]
                [Validation(Required=false)]
                public string InitialAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>\&quot;79f7e40b-87e2-4ef4-b6df-21889a3a030e\&quot;</para>
                /// </summary>
                [NameInMap("InitialQueryId")]
                [Validation(Required=false)]
                public string InitialQueryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bany</para>
                /// </summary>
                [NameInMap("InitialUser")]
                [Validation(Required=false)]
                public string InitialUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>select * from test</para>
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("QueryDurationMs")]
                [Validation(Required=false)]
                public long? QueryDurationMs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-23T10:13:23Z</para>
                /// </summary>
                [NameInMap("QueryStartTime")]
                [Validation(Required=false)]
                public string QueryStartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
