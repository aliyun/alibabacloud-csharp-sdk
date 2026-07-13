// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsProductInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled for the instance.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Auto-renewal is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The number of times the domain name can be changed for the paid DNS instance. This parameter is available for the Custom Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public long? BindCount { get; set; }

        /// <summary>
        /// <para>The number of domain names that can be attached to the paid DNS instance. This parameter is available for the Personal and Ultimate editions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("BindDomainCount")]
        [Validation(Required=false)]
        public long? BindDomainCount { get; set; }

        /// <summary>
        /// <para>The number of domain names that are attached to the paid DNS instance. This parameter is available for the Personal and Ultimate editions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BindDomainUsedCount")]
        [Validation(Required=false)]
        public long? BindDomainUsedCount { get; set; }

        /// <summary>
        /// <para>The number of times the domain name has been changed for the paid DNS instance. This parameter is available for the Custom Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BindUsedCount")]
        [Validation(Required=false)]
        public long? BindUsedCount { get; set; }

        /// <summary>
        /// <para>The DDoS protection bandwidth. Unit: Gbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DDosDefendFlow")]
        [Validation(Required=false)]
        public long? DDosDefendFlow { get; set; }

        /// <summary>
        /// <para>The DDoS protection capacity in queries per second (QPS). The unit is 10,000 QPS. This parameter is available for the Custom Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DDosDefendQuery")]
        [Validation(Required=false)]
        public long? DDosDefendQuery { get; set; }

        /// <summary>
        /// <para>The Server Load Balancer (SLB) capacity. This is the number of IP addresses that can be configured for a domain name on a single line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("DnsSLBCount")]
        [Validation(Required=false)]
        public long? DnsSLBCount { get; set; }

        /// <summary>
        /// <para>The DNS security level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>no: Not required</para>
        /// </description></item>
        /// <item><description><para>basic: Basic DNS attack protection</para>
        /// </description></item>
        /// <item><description><para>advanced: Advanced DNS attack protection</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("DnsSecurity")]
        [Validation(Required=false)]
        public string DnsSecurity { get; set; }

        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public DescribeDnsProductInstanceResponseBodyDnsServers DnsServers { get; set; }
        public class DescribeDnsProductInstanceResponseBodyDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }

        }

        /// <summary>
        /// <para>The attached domain name.</para>
        /// <para>If this parameter is empty, no domain name is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The type of the instance:</para>
        /// <list type="bullet">
        /// <item><description><para>PUBLIC: An instance for an authoritative domain name.</para>
        /// </description></item>
        /// <item><description><para>CACHE: An instance for a recursive DNS proxy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The time when the instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-12T09:23Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time when the instance expires. This is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1474335170000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>Indicates whether Global Server Load Balancer (GSLB) is allowed.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Allowed</para>
        /// </description></item>
        /// <item><description><para>false: Not allowed</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Gslb")]
        [Validation(Required=false)]
        public bool? Gslb { get; set; }

        /// <summary>
        /// <para>The carrier line from which the DNS request was initiated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>China Telecom</para>
        /// </description></item>
        /// <item><description><para>China Mobile</para>
        /// </description></item>
        /// <item><description><para>China Unicom</para>
        /// </description></item>
        /// <item><description><para>China Education and Research Network</para>
        /// </description></item>
        /// <item><description><para>China Broadcasting Network</para>
        /// </description></item>
        /// <item><description><para>Dr. Peng Group</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>中国电信</para>
        /// </summary>
        [NameInMap("ISPLines")]
        [Validation(Required=false)]
        public string ISPLines { get; set; }

        /// <summary>
        /// <para>The carrier line and province from which the DNS request was initiated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>China Telecom (by province)</para>
        /// </description></item>
        /// <item><description><para>China Mobile (by province)</para>
        /// </description></item>
        /// <item><description><para>China Unicom (by province)</para>
        /// </description></item>
        /// <item><description><para>China Education and Research Network (by province)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>电信_浙江</para>
        /// </summary>
        [NameInMap("ISPRegionLines")]
        [Validation(Required=false)]
        public string ISPRegionLines { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain name is in a blackhole filtering status.</para>
        /// <list type="bullet">
        /// <item><description><para>true: The domain name is in a blackhole filtering status.</para>
        /// </description></item>
        /// <item><description><para>false: The domain name is not in a blackhole filtering status.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InBlackHole")]
        [Validation(Required=false)]
        public bool? InBlackHole { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain name is undergoing traffic scrubbing.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Traffic scrubbing is in progress.</para>
        /// </description></item>
        /// <item><description><para>false: Traffic scrubbing is not in progress.</para>
        /// </description></item>
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
        /// <para>The monitoring frequency. Unit: minutes.</para>
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
        /// <para>The number of monitoring jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MonitorTaskCount")]
        [Validation(Required=false)]
        public long? MonitorTaskCount { get; set; }

        /// <summary>
        /// <para>The DDoS protection bandwidth for regions outside China. Unit: Gbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OverseaDDosDefendFlow")]
        [Validation(Required=false)]
        public long? OverseaDDosDefendFlow { get; set; }

        /// <summary>
        /// <para>The line for regions outside China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>海外大洲</para>
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
        /// <para>Indicates whether regional lines are used.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Regional lines are used.</para>
        /// </description></item>
        /// <item><description><para>false: Regional lines are not used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RegionLines")]
        [Validation(Required=false)]
        public bool? RegionLines { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-xxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The search engine line. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Google</para>
        /// </description></item>
        /// <item><description><para>Baidu</para>
        /// </description></item>
        /// <item><description><para>Bing</para>
        /// </description></item>
        /// <item><description><para>Youdao</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>谷歌</para>
        /// </summary>
        [NameInMap("SearchEngineLines")]
        [Validation(Required=false)]
        public string SearchEngineLines { get; set; }

        /// <summary>
        /// <para>The time when the instance was purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-12T09:23Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time when the instance was purchased. This is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1474335170000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// <para>The number of subdomain levels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("SubDomainLevel")]
        [Validation(Required=false)]
        public long? SubDomainLevel { get; set; }

        /// <summary>
        /// <para>The minimum Time to Live (TTL) value. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TTLMinValue")]
        [Validation(Required=false)]
        public long? TTLMinValue { get; set; }

        /// <summary>
        /// <para>The number of URL forwards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("URLForwardCount")]
        [Validation(Required=false)]
        public long? URLForwardCount { get; set; }

        /// <summary>
        /// <para>The code of the Alibaba Cloud DNS edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version1</para>
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud DNS edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业旗舰版</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
