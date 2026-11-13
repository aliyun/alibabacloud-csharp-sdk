// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDomainRequest : TeaModel {
        /// <summary>
        /// <para>The product category. Default value: empty. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: All categories.</description></item>
        /// <item><description><b>RiskDomain</b>: Risky domain names.</description></item>
        /// <item><description><b>RiskIP</b>: Risky IP addresses.</description></item>
        /// <item><description><b>AliYun</b>: Alibaba Cloud services.</description></item>
        /// <item><description><b>NotAliYun</b>: Non-Alibaba Cloud services.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>Settings for the page number to return for a paging query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The source of the traffic statistics. Default value: internet. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet</b>: Internet firewall.</description></item>
        /// <item><description><b>nat</b>: NAT firewall.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nat</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The domain name for outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Specifies the end time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656750960</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to collect statistics only on traffic that accesses AI services. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAITraffic")]
        [Validation(Required=false)]
        public string IsAITraffic { get; set; }

        /// <summary>
        /// <para>The language of the request message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies the sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: Ascending order.</description></item>
        /// <item><description><b>desc</b> (default): Descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>Settings for the number of entries to return on each page for a paging query. Default value: 6. Maximum value: 100. If the specified value exceeds 100, the value 100 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The public IP address of the ECS instance that initiates the outbound connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// <para>Specifies the field by which to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SessionCount</b> (default): Number of requests.</description></item>
        /// <item><description><b>TotalBytes</b>: Total traffic volume.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SessionCount</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>Specifies the start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656664560</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the intelligence label. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AliYun</b>: Alibaba Cloud services.</description></item>
        /// <item><description><b>RiskDomain</b>: Risky domain names.</description></item>
        /// <item><description><b>RiskIP</b>: Risky IP addresses.</description></item>
        /// <item><description><b>TrustedDomain</b>: Trusted websites.</description></item>
        /// <item><description><b>AliPay</b>: Alipay.</description></item>
        /// <item><description><b>DingDing</b>: DingTalk.</description></item>
        /// <item><description><b>WeChat</b>: WeChat.</description></item>
        /// <item><description><b>QQ</b>: Tencent QQ.</description></item>
        /// <item><description><b>SecurityService</b>: Security services.</description></item>
        /// <item><description><b>Microsoft</b>: Microsoft.</description></item>
        /// <item><description><b>Amazon</b>: Amazon.</description></item>
        /// <item><description><b>Pan</b>: Cloud storage.</description></item>
        /// <item><description><b>Map</b>: Maps.</description></item>
        /// <item><description><b>Code</b>: Code hosting.</description></item>
        /// <item><description><b>SystemService</b>: System services.</description></item>
        /// <item><description><b>Taobao</b>: Taobao.</description></item>
        /// <item><description><b>Google</b>: Google.</description></item>
        /// <item><description><b>ThirdPartyService</b>: Third-party platform services.</description></item>
        /// <item><description><b>FirstFlow</b>: First visit.</description></item>
        /// <item><description><b>Downloader</b>: Malicious downloads.</description></item>
        /// <item><description><b>Alexa Top1M</b>: Popular websites.</description></item>
        /// <item><description><b>Miner</b>: Miner pools.</description></item>
        /// <item><description><b>Intelligence</b>: Threat intelligence.</description></item>
        /// <item><description><b>DDoS</b>: DDoS trojans.</description></item>
        /// <item><description><b>Ransomware</b>: Ransomware.</description></item>
        /// <item><description><b>Spyware</b>: Spyware.</description></item>
        /// <item><description><b>Rogue</b>: Rogue software.</description></item>
        /// <item><description><b>Botnet</b>: Botnets.</description></item>
        /// <item><description><b>Suspicious</b>: Suspicious websites.</description></item>
        /// <item><description><b>C&amp;C</b>: Remote control.</description></item>
        /// <item><description><b>Gang</b>: Gangs.</description></item>
        /// <item><description><b>CVE</b>: CVE vulnerabilities.</description></item>
        /// <item><description><b>Backdoor</b>: Backdoor trojans.</description></item>
        /// <item><description><b>Phishing</b>: Phishing websites.</description></item>
        /// <item><description><b>APT</b>: APT attacks.</description></item>
        /// <item><description><b>Supply Chain Attack</b>: Supply chain attacks.</description></item>
        /// <item><description><b>Malicious software</b>: Malware.</description></item>
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
