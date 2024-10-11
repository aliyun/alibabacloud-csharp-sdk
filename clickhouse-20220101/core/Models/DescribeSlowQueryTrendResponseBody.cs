// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class DescribeSlowQueryTrendResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSlowQueryTrendResponseBodyData> Data { get; set; }
        public class DescribeSlowQueryTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("AvgDurationMs")]
            [Validation(Required=false)]
            public long? AvgDurationMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("MaxDurationMs")]
            [Validation(Required=false)]
            public long? MaxDurationMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MinDurationMs")]
            [Validation(Required=false)]
            public long? MinDurationMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-02-02T08:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48CBEEBE-FA07-5A06-8BA4-567B92ADD6A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
