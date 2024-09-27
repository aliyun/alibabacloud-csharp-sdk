// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainStatisticsResponseBody : TeaModel {
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
        /// <para>The statistics on the Domain Name System (DNS) requests.</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public DescribeDomainStatisticsResponseBodyStatistics Statistics { get; set; }
        public class DescribeDomainStatisticsResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeDomainStatisticsResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeDomainStatisticsResponseBodyStatisticsStatistic : TeaModel {
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
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The statistical timestamp. Unit: milliseconds. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
