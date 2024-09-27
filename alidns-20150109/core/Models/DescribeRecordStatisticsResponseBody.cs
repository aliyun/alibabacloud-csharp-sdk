// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6AEC7A64-3CB1-4C49-8B35-0B901F1E26BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics on the DNS requests.</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public DescribeRecordStatisticsResponseBodyStatistics Statistics { get; set; }
        public class DescribeRecordStatisticsResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeRecordStatisticsResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeRecordStatisticsResponseBodyStatisticsStatistic : TeaModel {
                /// <summary>
                /// <para>The number of DNS requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15292887</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The statistical timestamp. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1556640000000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

        }

    }

}
