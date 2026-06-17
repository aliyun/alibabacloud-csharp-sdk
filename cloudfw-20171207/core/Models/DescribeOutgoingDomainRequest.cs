// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDomainRequest : TeaModel {
        /// <summary>
        /// <para>The asset category. If you leave this parameter empty, assets in all categories are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>All</b>: all categories</para>
        /// </description></item>
        /// <item><description><para><b>RiskDomain</b>: risky domain names</para>
        /// </description></item>
        /// <item><description><para><b>RiskIP</b>: risky IP addresses</para>
        /// </description></item>
        /// <item><description><para><b>AliYun</b>: Alibaba Cloud services</para>
        /// </description></item>
        /// <item><description><para><b>NotAliYun</b>: third-party services</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The page number to return.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The source of traffic statistics. The default value is \<c>internet\\</c>, which indicates Internet Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>internet</b>: Internet Firewall</para>
        /// </description></item>
        /// <item><description><para><b>nat</b>: NAT Firewall</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nat</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The outbound domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656750960</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to count only traffic from accessing AI services. The default value is \<c>false\\</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: no</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAITraffic")]
        [Validation(Required=false)]
        public string IsAITraffic { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>asc</b>: ascending</para>
        /// </description></item>
        /// <item><description><para><b>desc</b> (default): descending</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Default value: 6. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The public IP address of the Elastic Compute Service (ECS) instance that initiates the outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// <para>The field to sort by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SessionCount</b> (default): the number of requests</para>
        /// </description></item>
        /// <item><description><para><b>TotalBytes</b>: the total traffic</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SessionCount</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656664560</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the intelligence tag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AliYun</b>: Alibaba Cloud service</para>
        /// </description></item>
        /// <item><description><para><b>RiskDomain</b>: Risky domain name</para>
        /// </description></item>
        /// <item><description><para><b>RiskIP</b>: Risky IP address</para>
        /// </description></item>
        /// <item><description><para><b>TrustedDomain</b>: Trusted website</para>
        /// </description></item>
        /// <item><description><para><b>AliPay</b>: Alipay</para>
        /// </description></item>
        /// <item><description><para><b>DingDing</b>: DingTalk</para>
        /// </description></item>
        /// <item><description><para><b>WeChat</b>: WeChat</para>
        /// </description></item>
        /// <item><description><para><b>QQ</b>: Tencent QQ</para>
        /// </description></item>
        /// <item><description><para><b>SecurityService</b>: Security service</para>
        /// </description></item>
        /// <item><description><para><b>Microsoft</b>: Microsoft</para>
        /// </description></item>
        /// <item><description><para><b>Amazon</b>: Amazon</para>
        /// </description></item>
        /// <item><description><para><b>Pan</b>: Cloud storage service</para>
        /// </description></item>
        /// <item><description><para><b>Map</b>: Map service</para>
        /// </description></item>
        /// <item><description><para><b>Code</b>: Code hosting service</para>
        /// </description></item>
        /// <item><description><para><b>SystemService</b>: System service</para>
        /// </description></item>
        /// <item><description><para><b>Taobao</b>: Taobao</para>
        /// </description></item>
        /// <item><description><para><b>Google</b>: Google</para>
        /// </description></item>
        /// <item><description><para><b>ThirdPartyService</b>: Third-party service</para>
        /// </description></item>
        /// <item><description><para><b>FirstFlow</b>: First-time access</para>
        /// </description></item>
        /// <item><description><para><b>Downloader</b>: Malicious downloader</para>
        /// </description></item>
        /// <item><description><para><b>Alexa Top 1M</b>: Popular website</para>
        /// </description></item>
        /// <item><description><para><b>Miner</b>: Mining pool</para>
        /// </description></item>
        /// <item><description><para><b>Intelligence</b>: Threat intelligence</para>
        /// </description></item>
        /// <item><description><para><b>DDoS</b>: DDoS trojan</para>
        /// </description></item>
        /// <item><description><para><b>Ransomware</b>: Ransomware</para>
        /// </description></item>
        /// <item><description><para><b>Spyware</b>: Spyware</para>
        /// </description></item>
        /// <item><description><para><b>Rogue</b>: Rogue software</para>
        /// </description></item>
        /// <item><description><para><b>Botnet</b>: Botnet</para>
        /// </description></item>
        /// <item><description><para><b>Suspicious</b>: Suspicious website</para>
        /// </description></item>
        /// <item><description><para><b>C\&amp;C</b>: Command and control (C\&amp;C)</para>
        /// </description></item>
        /// <item><description><para><b>Gang</b>: Gang-related activity</para>
        /// </description></item>
        /// <item><description><para><b>CVE</b>: CVE vulnerability</para>
        /// </description></item>
        /// <item><description><para><b>Backdoor</b>: Backdoor</para>
        /// </description></item>
        /// <item><description><para><b>Phishing</b>: Phishing website</para>
        /// </description></item>
        /// <item><description><para><b>APT</b>: Advanced Persistent Threat (APT) attack</para>
        /// </description></item>
        /// <item><description><para><b>Supply Chain Attack</b>: Supply chain attack</para>
        /// </description></item>
        /// <item><description><para><b>Malware</b>: Malicious software</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AliYun</para>
        /// </summary>
        [NameInMap("TagIdNew")]
        [Validation(Required=false)]
        public string TagIdNew { get; set; }

    }

}
