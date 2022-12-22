// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDomainRequest : TeaModel {
        /// <summary>
        /// The ID of the product category. Default value: empty. Valid values:
        /// 
        /// -  **All**: All categories.
        /// - **RiskDomain**: Risk domain name category.
        /// - **RiskIP**: Risk IP category.
        /// - **AliYun**: Cloud product category.
        /// - **NotAliYun**: Non-Cloud products.
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The domain name in outbound connections.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The language of the content within the request. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The order in which you want to sort the queried information. Valid values:
        /// 
        /// *   **asc**: the ascending order
        /// *   **desc**: the descending order. This is the default value.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 6. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The public IP address of the Elastic Compute Service (ECS) instance that initiates the outbound connection.
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// The field based on which you want to sort the queried information. Valid values:
        /// 
        /// *   **SessionCount**: the number of requests. This is the default value.
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
        /// 情报标签ID。取值：
        /// 
        /// - **AliYun**：Alibaba cloud products.
        /// - **RiskDomain**：The risk domain.
        /// - **RiskIP**: The risk IP.
        /// - **TrustedDomain**：The trusted domain.
        /// - **AliPay**：Alipay
        /// - **DingDing**：Ding talk.
        /// - **WeChat**：Wechat.
        /// - **QQ**：Tencent QQ.
        /// - **SecurityService**：The security service.
        /// - **Microsoft**：The Microsoft.
        /// - **Amazon**：Amazon.
        /// - **Pan**：Pan.
        /// - **Map**：Map.
        /// - **Code**：Code hosting
        /// - **SystemService**：System service.
        /// - **Taobao**：Taobao.
        /// - **Google**：Google.
        /// - **ThirdPartyService**：The third party service.
        /// - **FirstFlow**：首次
        /// - **Downloader**：恶意下载
        /// - **Alexa Top1M**：热门网站
        /// - **Miner**：矿池
        /// - **Intelligence**：威胁情报
        /// - **DDoS**：DDoS木马
        /// - **Ransomware**：勒索软件
        /// - **Spyware**：间谍软件
        /// - **Rogue**：流氓软件
        /// - **Botnet**：僵尸网络
        /// - **Suspicious**：可疑网站
        /// - **C&C**：远控
        /// - **Gang**：团伙
        /// - **CVE**：漏洞CVE
        /// - **Backdoor**：木马后门
        /// - **Phishing**：钓鱼网站
        /// - **APT**：APT攻击
        /// - **Supply Chain Attack**：供应链攻击
        /// - **Malicious software**：恶意软件
        /// </summary>
        [NameInMap("TagIdNew")]
        [Validation(Required=false)]
        public string TagIdNew { get; set; }

    }

}
