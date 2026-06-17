// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationIPRequest : TeaModel {
        /// <summary>
        /// <para>The application type supported by the access control policy.</para>
        /// <list type="bullet">
        /// <item><description><para><b>FTP</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTP</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b></para>
        /// </description></item>
        /// <item><description><para><b>Memcache</b></para>
        /// </description></item>
        /// <item><description><para><b>MongoDB</b></para>
        /// </description></item>
        /// <item><description><para><b>MQTT</b></para>
        /// </description></item>
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>RDP</b></para>
        /// </description></item>
        /// <item><description><para><b>Redis</b></para>
        /// </description></item>
        /// <item><description><para><b>SMTP</b></para>
        /// </description></item>
        /// <item><description><para><b>SMTPS</b></para>
        /// </description></item>
        /// <item><description><para><b>SSH</b></para>
        /// </description></item>
        /// <item><description><para><b>SSL_No_Cert</b></para>
        /// </description></item>
        /// <item><description><para><b>SSL</b></para>
        /// </description></item>
        /// <item><description><para><b>VNC</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The supported application types depend on the protocol type specified in the Proto parameter. If Proto is set to TCP, all application types listed above are supported. If both ApplicationName and ApplicationNameList are specified, the value of ApplicationNameList takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FTP</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The ID of the service category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>All</b>: all categories</para>
        /// </description></item>
        /// <item><description><para><b>RiskDomain</b>: risk domains</para>
        /// </description></item>
        /// <item><description><para><b>RiskIP</b>: risk IPs</para>
        /// </description></item>
        /// <item><description><para><b>AliYun</b>: Alibaba Cloud services</para>
        /// </description></item>
        /// <item><description><para><b>NotAliYun</b>: services other than Alibaba Cloud services</para>
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
        /// <para>The destination IP address of the outbound connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX</para>
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a timestamp in seconds.</para>
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
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
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
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>asc</b>: ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>desc</b> (default): descending order.</para>
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
        /// <para>Default value: 6. Maximum value: 10.</para>
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
        /// <item><description><para><b>SessionCount</b> (default): request count.</para>
        /// </description></item>
        /// <item><description><para><b>TotalBytes</b>: total traffic.</para>
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
        /// <para>The start of the time range to query. The value is a timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656837360</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the threat intelligence tag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AliYun</b>: Alibaba Cloud service</para>
        /// </description></item>
        /// <item><description><para><b>RiskDomain</b>: risk domain</para>
        /// </description></item>
        /// <item><description><para><b>RiskIP</b>: risk IP</para>
        /// </description></item>
        /// <item><description><para><b>TrustedDomain</b>: trusted website</para>
        /// </description></item>
        /// <item><description><para><b>AliPay</b>: Alipay</para>
        /// </description></item>
        /// <item><description><para><b>DingDing</b>: DingTalk</para>
        /// </description></item>
        /// <item><description><para><b>WeChat</b>: WeChat</para>
        /// </description></item>
        /// <item><description><para><b>QQ</b>: Tencent QQ</para>
        /// </description></item>
        /// <item><description><para><b>SecurityService</b>: security service</para>
        /// </description></item>
        /// <item><description><para><b>Microsoft</b>: Microsoft</para>
        /// </description></item>
        /// <item><description><para><b>Amazon</b>: Amazon</para>
        /// </description></item>
        /// <item><description><para><b>Pan</b>: cloud drive</para>
        /// </description></item>
        /// <item><description><para><b>Map</b>: map</para>
        /// </description></item>
        /// <item><description><para><b>Code</b>: code hosting</para>
        /// </description></item>
        /// <item><description><para><b>SystemService</b>: system service</para>
        /// </description></item>
        /// <item><description><para><b>Taobao</b>: Taobao</para>
        /// </description></item>
        /// <item><description><para><b>Google</b>: Google</para>
        /// </description></item>
        /// <item><description><para><b>ThirdPartyService</b>: third-party service</para>
        /// </description></item>
        /// <item><description><para><b>FirstFlow</b>: first access</para>
        /// </description></item>
        /// <item><description><para><b>Downloader</b>: malicious downloader</para>
        /// </description></item>
        /// <item><description><para><b>Alexa Top1M</b>: popular website</para>
        /// </description></item>
        /// <item><description><para><b>Miner</b>: mining pool</para>
        /// </description></item>
        /// <item><description><para><b>Intelligence</b>: threat intelligence</para>
        /// </description></item>
        /// <item><description><para><b>DDoS</b>: DDoS trojan</para>
        /// </description></item>
        /// <item><description><para><b>Ransomware</b>: ransomware</para>
        /// </description></item>
        /// <item><description><para><b>Spyware</b>: spyware</para>
        /// </description></item>
        /// <item><description><para><b>Rogue</b>: rogue software</para>
        /// </description></item>
        /// <item><description><para><b>Botnet</b>: botnet</para>
        /// </description></item>
        /// <item><description><para><b>Suspicious</b>: suspicious website</para>
        /// </description></item>
        /// <item><description><para><b>C\&amp;C</b>: command and control (C\&amp;C)</para>
        /// </description></item>
        /// <item><description><para><b>Gang</b>: threat actor group</para>
        /// </description></item>
        /// <item><description><para><b>CVE</b>: CVE</para>
        /// </description></item>
        /// <item><description><para><b>Backdoor</b>: backdoor</para>
        /// </description></item>
        /// <item><description><para><b>Phishing</b>: phishing website</para>
        /// </description></item>
        /// <item><description><para><b>APT</b>: APT attack</para>
        /// </description></item>
        /// <item><description><para><b>Supply Chain Attack</b>: supply chain attack</para>
        /// </description></item>
        /// <item><description><para><b>Malicious software</b>: malware</para>
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
