// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class DescribeSlowQueryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSlowQueryResponseBodyData> Data { get; set; }
        public class DescribeSlowQueryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>::ffff:10.1.XX.XX</para>
            /// </summary>
            [NameInMap("InitialAddress")]
            [Validation(Required=false)]
            public string InitialAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7c28bbbb-753b-4eba-98b1-efcbe2b9bdf6</para>
            /// </summary>
            [NameInMap("InitialQueryId")]
            [Validation(Required=false)]
            public string InitialQueryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InitialUser")]
            [Validation(Required=false)]
            public string InitialUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024000000</para>
            /// </summary>
            [NameInMap("MemoryUsage")]
            [Validation(Required=false)]
            public long? MemoryUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>select * from test order by score limit 1;</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("QueryDurationMs")]
            [Validation(Required=false)]
            public long? QueryDurationMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-02-02T08:30:00Z</para>
            /// </summary>
            [NameInMap("QueryStartTime")]
            [Validation(Required=false)]
            public string QueryStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>QueryFinish</para>
            /// </summary>
            [NameInMap("QueryState")]
            [Validation(Required=false)]
            public string QueryState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9141300000</para>
            /// </summary>
            [NameInMap("ReadBytes")]
            [Validation(Required=false)]
            public long? ReadBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("ReadRows")]
            [Validation(Required=false)]
            public long? ReadRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8174</para>
            /// </summary>
            [NameInMap("ResultBytes")]
            [Validation(Required=false)]
            public long? ResultBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResultRows")]
            [Validation(Required=false)]
            public long? ResultRows { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48CBEEBE-FA07-5A06-8BA4-567B92ADD6A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
