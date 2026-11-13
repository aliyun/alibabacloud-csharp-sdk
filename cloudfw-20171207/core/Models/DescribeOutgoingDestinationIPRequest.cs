// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationIPRequest : TeaModel {
        /// <summary>
        /// <para>The Protocol Type supported by the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FTP</b></description></item>
        /// <item><description><b>HTTP</b></description></item>
        /// <item><description><b>HTTPS</b></description></item>
        /// <item><description><b>Memcache</b></description></item>
        /// <item><description><b>MongoDB</b></description></item>
        /// <item><description><b>MQTT</b></description></item>
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>RDP</b></description></item>
        /// <item><description><b>Redis</b></description></item>
        /// <item><description><b>SMTP</b></description></item>
        /// <item><description><b>SMTPS</b></description></item>
        /// <item><description><b>SSH</b></description></item>
        /// <item><description><b>SSL_No_Cert</b></description></item>
        /// <item><description><b>SSL</b></description></item>
        /// <item><description><b>VNC</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>The valid values of this parameter depend on the value of the Proto parameter. If Proto is set to TCP, ApplicationNameList supports all the preceding Protocol Types. If both ApplicationNameList and ApplicationName are specified, ApplicationNameList takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FTP</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The category ID. Default value: null. Valid values:</para>
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
        /// <para>Sets the paging settings to specify the page number to return for a paged query.</para>
        /// <para>Default value: 1, which means the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The destination IP address of the domain name for outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX</para>
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp accurate to seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656923760</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
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
        /// <para>The sort order. Valid values:</para>
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
        /// <para>Sets the paging settings to specify the number of entries to return on each page for a paged query.</para>
        /// <para>Default value: 6, which means 6 entries are returned on each page. Maximum value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The private IP address of the ECS instance that initiates the outbound connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIP")]
        [Validation(Required=false)]
        public string PrivateIP { get; set; }

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
        /// <item><description><b>SessionCount</b> (default): The number of requests.</description></item>
        /// <item><description><b>TotalBytes</b>: The total volume of traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SessionCount</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp accurate to seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656837360</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The intelligence tag ID. Valid values:</para>
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
        /// <item><description><b>Pan</b>: Cloud disks.</description></item>
        /// <item><description><b>Map</b>: Maps.</description></item>
        /// <item><description><b>Code</b>: Code hosting.</description></item>
        /// <item><description><b>SystemService</b>: System services.</description></item>
        /// <item><description><b>Taobao</b>: Taobao.</description></item>
        /// <item><description><b>Google</b>: Google.</description></item>
        /// <item><description><b>ThirdPartyService</b>: Third-party platform services.</description></item>
        /// <item><description><b>FirstFlow</b>: First visit.</description></item>
        /// <item><description><b>Downloader</b>: Malicious download.</description></item>
        /// <item><description><b>Alexa Top1M</b>: Popular website.</description></item>
        /// <item><description><b>Miner</b>: Miner Pool.</description></item>
        /// <item><description><b>Intelligence</b>: Threat intelligence.</description></item>
        /// <item><description><b>DDoS</b>: DDoS Trojan.</description></item>
        /// <item><description><b>Ransomware</b>: Ransomware.</description></item>
        /// <item><description><b>Spyware</b>: Spyware.</description></item>
        /// <item><description><b>Rogue</b>: Rogue software.</description></item>
        /// <item><description><b>Botnet</b>: Botnets.</description></item>
        /// <item><description><b>Suspicious</b>: Suspicious websites.</description></item>
        /// <item><description><b>C&amp;C</b>: Remote control.</description></item>
        /// <item><description><b>Gang</b>: Gangs.</description></item>
        /// <item><description><b>CVE</b>: CVE vulnerabilities.</description></item>
        /// <item><description><b>Backdoor</b>: Backdoor Trojans.</description></item>
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
