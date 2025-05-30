// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainDetailDataByLayerResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of IPv6 requests per second.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDomainDetailDataByLayerResponseBodyData Data { get; set; }
        public class DescribeDomainDetailDataByLayerResponseBodyData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainDetailDataByLayerResponseBodyDataDataModule> DataModule { get; set; }
            public class DescribeDomainDetailDataByLayerResponseBodyDataDataModule : TeaModel {
                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Acc")]
                [Validation(Required=false)]
                public long? Acc { get; set; }

                /// <summary>
                /// <para>The bandwidth of IPv6 requests. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21060178715.146667</para>
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                /// <summary>
                /// <para>The number of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description>You can call this operation up to 20 times per second per account.</description></item>
                /// <item><description>If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.</description></item>
                /// </list>
                /// <para><b>Time granularity</b></para>
                /// <para>The following table describes the time granularity, the time period within which historical data is available, and the data delay, which vary with the maximum time range per query. </para>
                /// <table>
                /// <thead>
                /// <tr>
                /// <th>Time granularity</th>
                /// <th>Maximum time range per query</th>
                /// <th>Historical data available</th>
                /// <th>Data delay</th>
                /// </tr>
                /// </thead>
                /// <tbody><tr>
                /// <td>5 minutes</td>
                /// <td>3 days</td>
                /// <td>93 days</td>
                /// <td>15 minutes</td>
                /// </tr>
                /// <tr>
                /// <td>1 hour</td>
                /// <td>31 days</td>
                /// <td>186 days</td>
                /// <td>4 hours</td>
                /// </tr>
                /// <tr>
                /// <td>1 days</td>
                /// <td>366 days</td>
                /// <td>366 days</td>
                /// <td>04:00 on the next day</td>
                /// </tr>
                /// </tbody></table>
                /// 
                /// <b>Example:</b>
                /// <para>200:44349|206:1753719|304:45|403:1095|416:1|499:332</para>
                /// </summary>
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

                /// <summary>
                /// <para>The bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Ipv6Acc")]
                [Validation(Required=false)]
                public long? Ipv6Acc { get; set; }

                /// <summary>
                /// <para>The number of IPv6 requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Ipv6Bps")]
                [Validation(Required=false)]
                public float? Ipv6Bps { get; set; }

                /// <summary>
                /// <para>The amount of network traffic generated by IPv6 requests. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Ipv6Qps")]
                [Validation(Required=false)]
                public float? Ipv6Qps { get; set; }

                /// <summary>
                /// <para>The proportions of HTTP status codes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>141718944482</para>
                /// </summary>
                [NameInMap("Ipv6Traf")]
                [Validation(Required=false)]
                public long? Ipv6Traf { get; set; }

                /// <summary>
                /// <para>The number of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5998.47</para>
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-07-05T22:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The bandwidth of IPv6 requests. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>789756701818</para>
                /// </summary>
                [NameInMap("Traf")]
                [Validation(Required=false)]
                public long? Traf { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of queries per second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
