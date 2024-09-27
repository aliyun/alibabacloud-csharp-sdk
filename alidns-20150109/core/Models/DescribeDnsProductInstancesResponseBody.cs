// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsProductInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The paid Alibaba Cloud DNS instances.</para>
        /// </summary>
        [NameInMap("DnsProducts")]
        [Validation(Required=false)]
        public DescribeDnsProductInstancesResponseBodyDnsProducts DnsProducts { get; set; }
        public class DescribeDnsProductInstancesResponseBodyDnsProducts : TeaModel {
            [NameInMap("DnsProduct")]
            [Validation(Required=false)]
            public List<DescribeDnsProductInstancesResponseBodyDnsProductsDnsProduct> DnsProduct { get; set; }
            public class DescribeDnsProductInstancesResponseBodyDnsProductsDnsProduct : TeaModel {
                /// <summary>
                /// <para>Indicates whether auto-renewal was enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Auto-renewal was enabled.</description></item>
                /// <item><description>false: Auto-renewal was not enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                /// <summary>
                /// <para>The number of times you can change domain names that are bound to the DNS instance. It can be specified by the user who uses Alibaba Cloud DNS of the custom version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("BindCount")]
                [Validation(Required=false)]
                public long? BindCount { get; set; }

                /// <summary>
                /// <para>The number of domain names that can be bound to the DNS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("BindDomainCount")]
                [Validation(Required=false)]
                public long? BindDomainCount { get; set; }

                /// <summary>
                /// <para>The number of domain names that have been bound to the DNS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("BindDomainUsedCount")]
                [Validation(Required=false)]
                public long? BindDomainUsedCount { get; set; }

                /// <summary>
                /// <para>The number of times you have changed domain names that are bound to the DNS instance. It can be specified by the user who uses Alibaba Cloud DNS of the custom version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BindUsedCount")]
                [Validation(Required=false)]
                public long? BindUsedCount { get; set; }

                /// <summary>
                /// <para>The DDoS protection traffic. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("DDosDefendFlow")]
                [Validation(Required=false)]
                public long? DDosDefendFlow { get; set; }

                /// <summary>
                /// <para>The DDoS protection frequency. Unit: 10,000 QPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("DDosDefendQuery")]
                [Validation(Required=false)]
                public long? DDosDefendQuery { get; set; }

                /// <summary>
                /// <para>The number of IP addresses supported by a domain name or line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("DnsSLBCount")]
                [Validation(Required=false)]
                public long? DnsSLBCount { get; set; }

                /// <summary>
                /// <para>The level of DNS protection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>no: No DNS protection is provided.</description></item>
                /// <item><description>basic: Basic DNS protection is provided.</description></item>
                /// <item><description>advanced: Advanced DNS protection is provided.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>no</para>
                /// </summary>
                [NameInMap("DnsSecurity")]
                [Validation(Required=false)]
                public string DnsSecurity { get; set; }

                /// <summary>
                /// <para>The bound domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The time at which the instance expired.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-12T00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp representing the expiration time of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1474335170000</para>
                /// </summary>
                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// <para>Indicates whether global server load balancing (GSLB) is supported.</para>
                /// <list type="bullet">
                /// <item><description>true: GSLB is supported.</description></item>
                /// <item><description>false: GSLB is not supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Gslb")]
                [Validation(Required=false)]
                public bool? Gslb { get; set; }

                /// <summary>
                /// <para>The ISP resolution lines.</para>
                /// <list type="bullet">
                /// <item><description>China Telecom</description></item>
                /// <item><description>China Mobile</description></item>
                /// <item><description>China Unicom</description></item>
                /// <item><description>CERNET</description></item>
                /// <item><description>China Broadcasting Network (CBN)</description></item>
                /// <item><description>Dr Peng Telecom &amp; Media Group</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>China Mobile,China Unicom,China Telecom,China Edu</para>
                /// </summary>
                [NameInMap("ISPLines")]
                [Validation(Required=false)]
                public string ISPLines { get; set; }

                /// <summary>
                /// <para>The regional ISP resolution lines. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>China Telecom (province)</description></item>
                /// <item><description>China Mobile (province)</description></item>
                /// <item><description>China Unicom (province)</description></item>
                /// <item><description>China Education and Research Network (CERNET) (province)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Telecom (Province), Mobile (Province), Unicom (Province), Education Network (Province)</para>
                /// </summary>
                [NameInMap("ISPRegionLines")]
                [Validation(Required=false)]
                public string ISPRegionLines { get; set; }

                /// <summary>
                /// <para>Indicates whether the Domain Name System (DNS) servers stopped responding to all requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The DNS servers stopped responding to all requests.</description></item>
                /// <item><description>false: The DNS servers did not stop responding to all requests.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InBlackHole")]
                [Validation(Required=false)]
                public bool? InBlackHole { get; set; }

                /// <summary>
                /// <para>Indicates whether the request for domain name resolution was being cleared.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InClean")]
                [Validation(Required=false)]
                public bool? InClean { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud DNS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-8fj</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The monitoring frequency. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("MonitorFrequency")]
                [Validation(Required=false)]
                public long? MonitorFrequency { get; set; }

                /// <summary>
                /// <para>The number of monitored nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MonitorNodeCount")]
                [Validation(Required=false)]
                public long? MonitorNodeCount { get; set; }

                /// <summary>
                /// <para>The number of monitoring tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MonitorTaskCount")]
                [Validation(Required=false)]
                public long? MonitorTaskCount { get; set; }

                /// <summary>
                /// <para>DDoS protection traffic outside China. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OverseaDDosDefendFlow")]
                [Validation(Required=false)]
                public long? OverseaDDosDefendFlow { get; set; }

                /// <summary>
                /// <para>The type of the overseas line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Countries</para>
                /// </summary>
                [NameInMap("OverseaLine")]
                [Validation(Required=false)]
                public string OverseaLine { get; set; }

                /// <summary>
                /// <para>The billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Subscription</para>
                /// </summary>
                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                /// <summary>
                /// <para>Indicates whether the DNS request lines are regional lines.</para>
                /// <list type="bullet">
                /// <item><description>true: The DNS request lines are regional lines.</description></item>
                /// <item><description>false: The DNS request lines are not regional lines.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RegionLines")]
                [Validation(Required=false)]
                public bool? RegionLines { get; set; }

                /// <summary>
                /// <para>The search engine resolution lines. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Google</description></item>
                /// <item><description>Baidu</description></item>
                /// <item><description>Bing</description></item>
                /// <item><description>Youdao</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Search Engine Robots,Google Robots,Baidu Robots,Bing Robots</para>
                /// </summary>
                [NameInMap("SearchEngineLines")]
                [Validation(Required=false)]
                public string SearchEngineLines { get; set; }

                /// <summary>
                /// <para>The time when the DNS instance was purchased.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-11-12T09:23Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp representing when the DNS instance was purchased.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1474335170000</para>
                /// </summary>
                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// <para>The number of subdomain name levels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("SubDomainLevel")]
                [Validation(Required=false)]
                public long? SubDomainLevel { get; set; }

                /// <summary>
                /// <para>The minimum TTL. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TTLMinValue")]
                [Validation(Required=false)]
                public long? TTLMinValue { get; set; }

                /// <summary>
                /// <para>The URL forwarding quantity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("URLForwardCount")]
                [Validation(Required=false)]
                public long? URLForwardCount { get; set; }

                /// <summary>
                /// <para>The version code of the Alibaba Cloud DNS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>version1</para>
                /// </summary>
                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

                /// <summary>
                /// <para>The version name of the Alibaba Cloud DNS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud DNS</para>
                /// </summary>
                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

        }

        /// <summary>
        /// <para>The type of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC (default): hosted public domain name</description></item>
        /// <item><description>CACHE: cached public domain name</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
