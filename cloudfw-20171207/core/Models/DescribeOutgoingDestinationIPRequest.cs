// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationIPRequest : TeaModel {
        /// <summary>
        /// The application type in the access control policy. Valid values:
        /// 
        /// *   **FTP**
        /// *   **HTTP**
        /// *   **HTTPS**
        /// *   **Memcache**
        /// *   **MongoDB**
        /// *   **MQTT**
        /// *   **MySQL**
        /// *   **RDP**
        /// *   **Redis**
        /// *   **SMTP**
        /// *   **SMTPS**
        /// *   **SSH**
        /// *   **SSL_No_Cert**
        /// *   **SSL**
        /// *   **VNC**
        /// 
        /// >  The value of this parameter depends on the value of Proto. If you set Proto to TCP, you can set ApplicationNameList to any valid value. If you specify both ApplicationNameList and ApplicationName, only the value of ApplicationNameList is used.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The ID of the service to which the destination IP address belongs. This parameter is left empty by default. Valid values:
        /// 
        /// *   **All**: all services
        /// *   **RiskDomain**: risky domain names
        /// *   **RiskIP**: risky IP addresses
        /// *   **AliYun**: Alibaba Cloud services
        /// *   **NotAliYun**: third-party services
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The destination IP address in the outbound connection that is initiated to access a domain name.
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The method that is used to sort the results. Valid values:
        /// 
        /// *   **asc**: the ascending order.
        /// *   **desc** (default): the descending order.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 6. Maximum value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The port number.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The private IP address of the ECS instance that initiates the outbound connection.
        /// </summary>
        [NameInMap("PrivateIP")]
        [Validation(Required=false)]
        public string PrivateIP { get; set; }

        /// <summary>
        /// The public IP address of the Elastic Compute Service (ECS) instance that initiates the outbound connection.
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// The field based on which you want to sort the query results. Valid values:
        /// 
        /// *   **SessionCount** (default): the number of requests.
        /// *   **TotalBytes**: the total volume of traffic.
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the tag. Valid values:
        /// 
        /// *   **AliYun**: Alibaba Cloud service
        /// *   **RiskDomain**: risky domain name
        /// *   **RiskIP**: risky IP address
        /// *   **TrustedDomain**: trusted website
        /// *   **AliPay**: Alipay
        /// *   **DingDing**: DingTalk
        /// *   **WeChat**: WeChat
        /// *   **QQ**: Tencent QQ
        /// *   **SecurityService**: security service
        /// *   **Microsoft**: Microsoft
        /// *   **Amazon**: Amazon Web Services (AWS)
        /// *   **Pan**: cloud disk
        /// *   **Map**: map
        /// *   **Code**: code hosting
        /// *   **SystemService**: system service
        /// *   **Taobao**: Taobao
        /// *   **Google**: Google
        /// *   **ThirdPartyService**: third-party service
        /// *   **FirstFlow**: the first time
        /// *   **Downloader**: malicious download
        /// *   **Alexa Top1M**: popular website
        /// *   **Miner**: mining pool
        /// *   **Intelligence**: threat intelligence
        /// *   **DDoS**: DDoS trojan
        /// *   **Ransomware**: ransomware
        /// *   **Spyware**: spyware
        /// *   **Rogue**: rogue software
        /// *   **Botnet**: botnet
        /// *   **Suspicious**: suspicious website
        /// *   **C\&C**: command and control (C\&C)
        /// *   **Gang**: gang
        /// *   **CVE**: Common Vulnerabilities and Exposures (CVE)
        /// *   **Backdoor**: webshell
        /// *   **Phishing**: phishing website
        /// *   **APT**: advanced persistent threat (APT) attack
        /// *   **Supply Chain Attack**: supply chain attack
        /// *   **Malicious software**: malware
        /// </summary>
        [NameInMap("TagIdNew")]
        [Validation(Required=false)]
        public string TagIdNew { get; set; }

    }

}
