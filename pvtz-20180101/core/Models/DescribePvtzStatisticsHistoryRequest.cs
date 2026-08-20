// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribePvtzStatisticsHistoryRequest : TeaModel {
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
        /// <para>The end of the query time range. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1571673600000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public string EndTimestamp { get; set; }

        /// <summary>
        /// <para>The statistics module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTH</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <para>The network parameters.</para>
        /// </summary>
        [NameInMap("NetworkParams")]
        [Validation(Required=false)]
        public List<DescribePvtzStatisticsHistoryRequestNetworkParams> NetworkParams { get; set; }
        public class DescribePvtzStatisticsHistoryRequestNetworkParams : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1hneq5pcy2gv87op0uf</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634808626233933</para>
            /// </summary>
            [NameInMap("VpcOwner")]
            [Validation(Required=false)]
            public string VpcOwner { get; set; }

            /// <summary>
            /// <para>The VPC type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>STANDARD</c>: Standard VPC.</para>
            /// </description></item>
            /// <item><description><para><c>EDS</c>: Elastic Desktop Service VPC.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

        }

        /// <summary>
        /// <para>The DNS response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Rcode")]
        [Validation(Required=false)]
        public string Rcode { get; set; }

        /// <summary>
        /// <para>The service region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServerRegion")]
        [Validation(Required=false)]
        public string ServerRegion { get; set; }

        /// <summary>
        /// <para>The start of the query time range. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516779348000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public string StartTimestamp { get; set; }

        /// <summary>
        /// <para>The type of statistics to collect.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>PROTOCOL: DNS request statistics by UDP and TCP protocol (global domain statistics only).</description></item>
        /// <item><description>FORWARD: Forwarding resolution volume, including successful resolutions, failed resolutions, and total resolutions.</description></item>
        /// <item><description>RECURSION: Recursive resolution volume, including successful resolutions, failed resolutions, and total resolutions.</description></item>
        /// <item><description>QTYPE: Distribution of DNS request record types, such as A, AAAA, CNAME, and MX.</description></item>
        /// <item><description>RCODE: Negative DNS response statistics.</description></item>
        /// <item><description>SUCCESS_RATIO: Average resolution success rate (resolution success rate = number of valid responses matching the requested record type (QTYPE) / total number of resolutions).</description></item>
        /// <item><description>LATENCY: Average DNS resolution latency (ms), which is the average time elapsed from when the Alibaba Cloud DNS server receives a DNS query to when it generates and returns a response.</description></item>
        /// <item><description>REQUEST: DNS request volume statistics, showing QPS query trends.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("StatisticalType")]
        [Validation(Required=false)]
        public string StatisticalType { get; set; }

        /// <summary>
        /// <para>The zone name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host.local</para>
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

    }

}
