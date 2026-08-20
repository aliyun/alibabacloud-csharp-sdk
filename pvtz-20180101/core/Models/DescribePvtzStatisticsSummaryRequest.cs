// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribePvtzStatisticsSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The sort order. Valid values: ASC and DESC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

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
        /// <para>The end of the time range to query, specified as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1571673600000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public string EndTimestamp { get; set; }

        /// <summary>
        /// <para>Specifies the type of change in request volume to report. Valid values: up (request spikes) and down (request drops).</para>
        /// 
        /// <b>Example:</b>
        /// <para>up</para>
        /// </summary>
        [NameInMap("GrowType")]
        [Validation(Required=false)]
        public string GrowType { get; set; }

        /// <summary>
        /// <para>The statistics module. Valid values: AUTHORITY, AUTH_FAST, AUTH_SLOW, GLOBAL, CACHE, FORWARD, and RECURSION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTH_FAST</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <para>The network parameters.</para>
        /// </summary>
        [NameInMap("NetworkParams")]
        [Validation(Required=false)]
        public List<DescribePvtzStatisticsSummaryRequestNetworkParams> NetworkParams { get; set; }
        public class DescribePvtzStatisticsSummaryRequestNetworkParams : TeaModel {
            /// <summary>
            /// <para>The ID of the region where the VPC is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1uvv79h1t8unnzdh3nq</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1256177436790486</para>
            /// </summary>
            [NameInMap("VpcOwner")]
            [Validation(Required=false)]
            public string VpcOwner { get; set; }

            /// <summary>
            /// <para>The type of the VPC.</para>
            /// <list type="bullet">
            /// <item><description><para>STANDARD: A standard VPC.</para>
            /// </description></item>
            /// <item><description><para>EDS: A VPC for Elastic Desktop Service (EDS).</para>
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
        /// <para>The field by which to sort the results. To sort by fluctuation ratio, set this parameter to fluctuation_ratio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fluctuation_ratio</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The time granularity for the statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

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
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServerRegion")]
        [Validation(Required=false)]
        public string ServerRegion { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query, specified as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1571587200000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public string StartTimestamp { get; set; }

        /// <summary>
        /// <para>The type of statistics to collect. Valid values: QTYPE_RATIO: The ratio of DNS request record types. NEGATIVE_RCODE: Statistics on negative DNS responses. RCODE_DOMAIN: The top domain names that receive negative responses. RCODE_SOURCE_IP: The top source IP addresses for requests to a specified domain name that receive negative responses. REQUEST_ZONE: The top zones by request volume. REQUEST_DOMAIN: The top subdomains by request volume. VPC_RATIO: The ratio of request sources. SOURCE_VPC: Analysis of high-traffic source networks. SOURCE_IP: Statistics on source IP addresses. LINE_RATIO: The percentage of traffic per resolution line. LINE_HIT: Details about resolution line hits.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>QTYPE_RATIO: Distribution ratio of DNS request record types.</description></item>
        /// <item><description>NEGATIVE_RCODE: Negative DNS response type statistics.</description></item>
        /// <item><description>RCODE_DOMAIN: Top domains by negative response count</description></item>
        /// <item><description>RCODE_SOURCE_IP: Top source IP addresses requesting a specific domain with negative responses.</description></item>
        /// <item><description>REQUEST_ZONE: Domain request volume ranking (zone level).</description></item>
        /// <item><description>REQUEST_DOMAIN: Subdomain request volume ranking (domain name level).</description></item>
        /// <item><description>VPC_RATIO: Request source distribution ratio.</description></item>
        /// <item><description>SOURCE_VPC: Hot source network analysis for requests.</description></item>
        /// <item><description>SOURCE_IP: Request source IP address statistics.</description></item>
        /// <item><description>LINE_RATIO: Traffic distribution ratio by resolution line.</description></item>
        /// <item><description>LINE_HIT: Resolution line hit details.</description></item>
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
