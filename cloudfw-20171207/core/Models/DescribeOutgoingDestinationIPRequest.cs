// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationIPRequest : TeaModel {
        /// <summary>
        /// <para>The application type in the access control policy. Valid values:</para>
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
        /// <para> The value of this parameter depends on the value of Proto. If you set Proto to TCP, you can set ApplicationNameList to any valid value. If you specify both ApplicationNameList and ApplicationName, only the value of ApplicationNameList is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FTP</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The ID of the service to which the destination IP address belongs. This parameter is left empty by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: all services</description></item>
        /// <item><description><b>RiskDomain</b>: risky domain names</description></item>
        /// <item><description><b>RiskIP</b>: risky IP addresses</description></item>
        /// <item><description><b>AliYun</b>: Alibaba Cloud services</description></item>
        /// <item><description><b>NotAliYun</b>: third-party services</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The destination IP address in the outbound connection that is initiated to access a domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX</para>
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656923760</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default)</description></item>
        /// <item><description><b>en</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The method that you want to use to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b></description></item>
        /// <item><description><b>desc</b> (default)</description></item>
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
        /// <para>The public IP address of the Elastic Compute Service (ECS) instance that initiates the outbound connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// <para>The field based on which you want to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SessionCount</b> (default): the number of requests.</description></item>
        /// <item><description><b>TotalBytes</b>: the total volume of traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SessionCount</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656837360</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the tag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AliYun</b>: Alibaba Cloud service</description></item>
        /// <item><description><b>RiskDomain</b>: risky domain name</description></item>
        /// <item><description><b>RiskIP</b>: risky IP address</description></item>
        /// <item><description><b>TrustedDomain</b>: trusted website</description></item>
        /// <item><description><b>AliPay</b>: Alipay</description></item>
        /// <item><description><b>DingDing</b>: DingTalk</description></item>
        /// <item><description><b>WeChat</b>: WeChat</description></item>
        /// <item><description><b>QQ</b>: Tencent QQ</description></item>
        /// <item><description><b>SecurityService</b>: security service</description></item>
        /// <item><description><b>Microsoft</b>: Microsoft</description></item>
        /// <item><description><b>Amazon</b>: Amazon Web Services (AWS)</description></item>
        /// <item><description><b>Pan</b>: cloud disk</description></item>
        /// <item><description><b>Map</b>: map</description></item>
        /// <item><description><b>Code</b>: code hosting</description></item>
        /// <item><description><b>SystemService</b>: system service</description></item>
        /// <item><description><b>Taobao</b>: Taobao</description></item>
        /// <item><description><b>Google</b>: Google</description></item>
        /// <item><description><b>ThirdPartyService</b>: third-party service</description></item>
        /// <item><description><b>FirstFlow</b>: the first time</description></item>
        /// <item><description><b>Downloader</b>: malicious download</description></item>
        /// <item><description><b>Alexa Top1M</b>: popular website</description></item>
        /// <item><description><b>Miner</b>: mining pool</description></item>
        /// <item><description><b>Intelligence</b>: threat intelligence</description></item>
        /// <item><description><b>DDoS</b>: DDoS trojan</description></item>
        /// <item><description><b>Ransomware</b>: ransomware</description></item>
        /// <item><description><b>Spyware</b>: spyware</description></item>
        /// <item><description><b>Rogue</b>: rogue software</description></item>
        /// <item><description><b>Botnet</b>: botnet</description></item>
        /// <item><description><b>Suspicious</b>: suspicious website</description></item>
        /// <item><description><b>C\&amp;C</b>: command and control (C\&amp;C)</description></item>
        /// <item><description><b>Gang</b>: gang</description></item>
        /// <item><description><b>CVE</b>: Common Vulnerabilities and Exposures (CVE)</description></item>
        /// <item><description><b>Backdoor</b>: webshell</description></item>
        /// <item><description><b>Phishing</b>: phishing website</description></item>
        /// <item><description><b>APT</b>: advanced persistent threat (APT) attack</description></item>
        /// <item><description><b>Supply Chain Attack</b>: supply chain attack</description></item>
        /// <item><description><b>Malicious software</b>: malware</description></item>
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
