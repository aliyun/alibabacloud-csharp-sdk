// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainStatisticsSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC625C21-8832-4683-BF10-C3CFB1A4FA13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics on the Domain Name System (DNS) requests.</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public DescribeDomainStatisticsSummaryResponseBodyStatistics Statistics { get; set; }
        public class DescribeDomainStatisticsSummaryResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeDomainStatisticsSummaryResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeDomainStatisticsSummaryResponseBodyStatisticsStatistic : TeaModel {
                /// <summary>
                /// <para>The number of DNS requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35509014</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ali-gslb.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The type of the domain name. The parameter value is not case-sensitive. Valid values:</para>
                /// <para>PUBLIC (default): hosted public domain name</para>
                /// <para>CACHE: cache-accelerated domain name</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                /// <summary>
                /// <para>Indicates whether the DNS traffic analysis feature is enabled for the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OPEN</description></item>
                /// <item><description>CLOSE</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OPEN</para>
                /// </summary>
                [NameInMap("resolveAnalysisStatus")]
                [Validation(Required=false)]
                public string ResolveAnalysisStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of data records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
