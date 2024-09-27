// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsProductInstanceResponseBody : TeaModel {
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
        /// <para>The number of times that you can change the domain names that are bound to the paid Alibaba Cloud DNS instance. This parameter applies to Alibaba Cloud DNS instances of the custom edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public long? BindCount { get; set; }

        /// <summary>
        /// <para>The number of domain names that can be bound to the paid Alibaba Cloud DNS instance. This parameter applies to Alibaba Cloud DNS instances of Personal Edition, Enterprise Standard Edition, and Enterprise Ultimate Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("BindDomainCount")]
        [Validation(Required=false)]
        public long? BindDomainCount { get; set; }

        /// <summary>
        /// <para>The number of domain names that are bound to the paid Alibaba Cloud DNS instance. This parameter applies to Alibaba Cloud DNS instances of Personal Edition, Enterprise Standard Edition, and Enterprise Ultimate Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BindDomainUsedCount")]
        [Validation(Required=false)]
        public long? BindDomainUsedCount { get; set; }

        /// <summary>
        /// <para>The number of times that you have changed the domain names that are bound to the paid Alibaba Cloud DNS instance. This parameter applies to Alibaba Cloud DNS instances of the custom edition.</para>
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
        /// <para>The DDoS protection frequency. Unit: 10,000 QPS. This parameter applies to Alibaba Cloud DNS instances of the custom edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DDosDefendQuery")]
        [Validation(Required=false)]
        public long? DDosDefendQuery { get; set; }

        /// <summary>
        /// <para>The maximum number of IP addresses that are used for load balancing in a single line of a domain name.</para>
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
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("DnsSecurity")]
        [Validation(Required=false)]
        public string DnsSecurity { get; set; }

        /// <summary>
        /// <para>The DNS servers configured for the domain names.</para>
        /// </summary>
        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public DescribeDnsProductInstanceResponseBodyDnsServers DnsServers { get; set; }
        public class DescribeDnsProductInstanceResponseBodyDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }

        }

        /// <summary>
        /// <para>The domain name that is bound to the paid instance.</para>
        /// <para>If no value is returned for this parameter, no domain name is bound to the paid instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: authoritative domain name</description></item>
        /// <item><description>CACHE: cache-accelerated domain name</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The time when the instance expired. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-12T09:23Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time when the instance expired. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1474335170000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>Indicates whether global server load balancing (GSLB) is supported. Valid values:</para>
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
        /// <para>The ISP resolution lines. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>China Telecom</description></item>
        /// <item><description>China Mobile</description></item>
        /// <item><description>China Unicom</description></item>
        /// <item><description>China Education and Research Network (CERNET)</description></item>
        /// <item><description>China Broadcasting Network (CBN)</description></item>
        /// <item><description>Dr Peng Telecom &amp; Media Group</description></item>
        /// </list>
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
        /// <item><description>CERNET (province)</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ISPRegionLines")]
        [Validation(Required=false)]
        public string ISPRegionLines { get; set; }

        /// <summary>
        /// <para>Indicates whether the Domain Name System (DNS) servers stopped responding to all DNS requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The DNS servers stopped responding to all DNS requests.</description></item>
        /// <item><description>false: The DNS servers did not stop responding to all DNS requests.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InBlackHole")]
        [Validation(Required=false)]
        public bool? InBlackHole { get; set; }

        /// <summary>
        /// <para>Indicates whether the DNS servers stopped responding to abnormal requests sent to the domain names.</para>
        /// <list type="bullet">
        /// <item><description>true: The DNS servers stopped responding to abnormal requests sent to the domain names.</description></item>
        /// <item><description>false: The DNS servers did not stop responding to abnormal requests sent to the domain names.</description></item>
        /// </list>
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
        /// <para>i-8fxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The interval at which the instance is monitored. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MonitorFrequency")]
        [Validation(Required=false)]
        public long? MonitorFrequency { get; set; }

        /// <summary>
        /// <para>The number of monitoring nodes.</para>
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
        /// <para>The DDoS protection traffic outside the Chinese mainland. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OverseaDDosDefendFlow")]
        [Validation(Required=false)]
        public long? OverseaDDosDefendFlow { get; set; }

        /// <summary>
        /// <para>The line outside the Chinese mainland.</para>
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
        /// <para>Indicates whether the DNS request lines are regional lines. Valid values:</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The search engine resolution lines. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Google</description></item>
        /// <item><description>Baidu</description></item>
        /// <item><description>Bing</description></item>
        /// <item><description>Youdao</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SearchEngineLines")]
        [Validation(Required=false)]
        public string SearchEngineLines { get; set; }

        /// <summary>
        /// <para>The time when the instance was purchased. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-12T09:23Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time when the instance was purchased. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
        /// <para>The minimum time-to-live (TTL) period. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TTLMinValue")]
        [Validation(Required=false)]
        public long? TTLMinValue { get; set; }

        /// <summary>
        /// <para>The number of the forwarded URLs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("URLForwardCount")]
        [Validation(Required=false)]
        public long? URLForwardCount { get; set; }

        /// <summary>
        /// <para>The version code of Alibaba Cloud DNS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version1</para>
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

        /// <summary>
        /// <para>The edition of Alibaba Cloud DNS.</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
