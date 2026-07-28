// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNisTrafficMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned per page or per query. In VPC scenarios, this represents the paging size. In TR and Internet Shared Bandwidth scenarios, this represents the SQL query limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1440</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The list of time series metric data points. Each element represents an aggregated time point and its corresponding metric value.</para>
        /// </summary>
        [NameInMap("MetricStatics")]
        [Validation(Required=false)]
        public List<GetNisTrafficMetricsResponseBodyMetricStatics> MetricStatics { get; set; }
        public class GetNisTrafficMetricsResponseBodyMetricStatics : TeaModel {
            /// <summary>
            /// <para>The timestamp of the data point, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785219000000</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public long? TimeStamp { get; set; }

            /// <summary>
            /// <para>The metric value at the current time point. The specific meaning and unit are determined by the MetricName in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102400.25</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

        /// <summary>
        /// <para>The paging token for the next page. Paging is supported only in VPC scenarios. An empty value indicates that no more pages exist. This field is typically not returned in TR and Internet Shared Bandwidth scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qqt9NJ3/AWeMXCntK4Kyhrt0QclAmfbtYB4899hEUzVNEo/F148UPCh2itDku111</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FA764-BA47-56F8-88E1-7AB503A62112</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of data points in the query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1440</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para><b>Unit and MetricName mapping</b></para>
        /// <list type="bullet">
        /// <item><description><para>Bandwidth  </para>
        /// <list type="bullet">
        /// <item><description>Unit: Bits/Second  </description></item>
        /// <item><description>Description: bits per second.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>PacketsRate  </para>
        /// <list type="bullet">
        /// <item><description>Unit: Packets/Second  </description></item>
        /// <item><description>Description: packets per second.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>RoundTripTime  </para>
        /// <list type="bullet">
        /// <item><description>Unit: MicroSecond  </description></item>
        /// <item><description>Description: TCP round-trip time.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>BandwidthUtilization  </para>
        /// <list type="bullet">
        /// <item><description>Unit: Percent  </description></item>
        /// <item><description>Description: bandwidth utilization.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>PacketsLostNoRouteRate  </para>
        /// <list type="bullet">
        /// <item><description>Unit: PacketsLostNoRouteRate  </description></item>
        /// <item><description>Description: rate of packets dropped due to no route.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>PacketsLostBlackholeRate  </para>
        /// <list type="bullet">
        /// <item><description>Unit: PacketsLostBlackholeRate  </description></item>
        /// <item><description>Description: rate of packets dropped due to blackhole routing.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>PacketsLostTTLExpiredRate  </para>
        /// <list type="bullet">
        /// <item><description>Unit: PacketsLostTTLExpiredRate  </description></item>
        /// <item><description>Description: rate of packets dropped due to TTL expiration.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Bits/Second</para>
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
