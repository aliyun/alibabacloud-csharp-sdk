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
        /// <item><description><b>RiskDomain</b>: Risky domain category.</description></item>
        /// <item><description><b>RiskIP</b>: Risky IP category.</description></item>
        /// <item><description><b>AliYun</b>: Alibaba Cloud product category.</description></item>
        /// <item><description><b>NotAliYun</b>: Non-Alibaba Cloud product category.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The page number of the results to return in a paged query.</para>
        /// <para>Default value: 1, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The source of the traffic statistics. Default value: Internet firewall. Valid values:</para>
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
        /// <para>The domain name of outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds.</para>
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
        /// <para>The language type of the request message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: ascending order.</description></item>
        /// <item><description><b>desc</b> (default): descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// <para>Default value: 6. Maximum value: 100.</para>
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
        /// <para>The field by which to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SessionCount</b> (default): the number of requests.</description></item>
        /// <item><description><b>TotalBytes</b>: the total traffic volume.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SessionCount</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656664560</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The intelligence tags label ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AliYun</b>: Alibaba Cloud product.</description></item>
        /// <item><description><b>RiskDomain</b>: Risky domain.</description></item>
        /// <item><description><b>RiskIP</b>: Risky IP.</description></item>
        /// <item><description><b>TrustedDomain</b>: Trusted website.</description></item>
        /// <item><description><b>AliPay</b>: Alipay.</description></item>
        /// <item><description><b>DingDing</b>: DingTalk.</description></item>
        /// <item><description><b>WeChat</b>: WeChat.</description></item>
        /// <item><description><b>QQ</b>: Tencent QQ.</description></item>
        /// <item><description><b>SecurityService</b>: Security service.</description></item>
        /// <item><description><b>Microsoft</b>: Microsoft.</description></item>
        /// <item><description><b>Amazon</b>: Amazon.</description></item>
        /// <item><description><b>Pan</b>: Cloud drive.</description></item>
        /// <item><description><b>Map</b>: Map.</description></item>
        /// <item><description><b>Code</b>: Code hosting.</description></item>
        /// <item><description><b>SystemService</b>: System service.</description></item>
        /// <item><description><b>Taobao</b>: Taobao.</description></item>
        /// <item><description><b>Google</b>: Google.</description></item>
        /// <item><description><b>ThirdPartyService</b>: Third-party platform service.</description></item>
        /// <item><description><b>FirstFlow</b>: First Visit.</description></item>
        /// <item><description><b>Downloader</b>: Malicious download.</description></item>
        /// <item><description><b>Alexa Top1M</b>: Popular website.</description></item>
        /// <item><description><b>Miner</b>: Miner Pool.</description></item>
        /// <item><description><b>Intelligence</b>: Threat intelligence.</description></item>
        /// <item><description><b>DDoS</b>: DDoS Trojan.</description></item>
        /// <item><description><b>Ransomware</b>: Ransomware.</description></item>
        /// <item><description><b>Spyware</b>: Spyware.</description></item>
        /// <item><description><b>Rogue</b>: Rogue software.</description></item>
        /// <item><description><b>Botnet</b>: Botnets.</description></item>
        /// <item><description><b>Suspicious</b>: Suspicious website.</description></item>
        /// <item><description><b>C&amp;C</b>: Remote control.</description></item>
        /// <item><description><b>Gang</b>: Gang.</description></item>
        /// <item><description><b>CVE</b>: CVE vulnerability.</description></item>
        /// <item><description><b>Backdoor</b>: Backdoor Trojan.</description></item>
        /// <item><description><b>Phishing</b>: Phishing website.</description></item>
        /// <item><description><b>APT</b>: APT attack.</description></item>
        /// <item><description><b>Supply Chain Attack</b>: Supply chain attack.</description></item>
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
