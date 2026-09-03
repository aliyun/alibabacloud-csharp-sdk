// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSessionStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5528624-C6ED-5CA4-A4A2-7C30DBF2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics information.</para>
        /// </summary>
        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public List<DescribeSessionStatisticResponseBodyStatistic> Statistic { get; set; }
        public class DescribeSessionStatisticResponseBodyStatistic : TeaModel {
            /// <summary>
            /// <para>The total number of sessions within the interval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The time point. UNIX timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1690164443508</para>
            /// </summary>
            [NameInMap("TimePoint")]
            [Validation(Required=false)]
            public long? TimePoint { get; set; }

        }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
