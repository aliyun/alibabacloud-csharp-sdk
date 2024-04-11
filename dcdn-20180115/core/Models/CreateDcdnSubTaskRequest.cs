// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnSubTaskRequest : TeaModel {
        /// <summary>
        /// The domain names to be tracked. Separate multiple domain names with commas (,). You can specify up to 500 domain names. If you want to specify more than 500 domain names, [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex).
        /// 
        /// > If you do not specify a domain name, the tracking task is created for all domain names that belong to your Alibaba Cloud account.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The IDs of the metrics that you want to include in the report. Separate multiple IDs with commas (,). Valid values:
        /// 
        /// *   **2**: Popular URLs by Request
        /// *   **4**: Popular URLs by Traffic
        /// *   **6**: Popular Referer by Request
        /// *   **8**: Popular Referer by Traffic
        /// *   **10**: Popular Back-to-origin URLs by Request
        /// *   **12**: Popular Back-to-origin URLs by Traffic
        /// *   **14**: Top Client IPs by Request
        /// *   **16**: Top Client IPs by Traffic
        /// *   **18**: Popular Domain Names by Traffic
        /// *   **20**: PV/UV
        /// *   **22**: Visit Distribution by Region
        /// *   **24**: Distribution of ISPs
        /// *   **26**: Peak IPv4/IPv6 Bandwidth
        /// *   **27**: Back-to-origin bandwidth
        /// </summary>
        [NameInMap("ReportIds")]
        [Validation(Required=false)]
        public string ReportIds { get; set; }

    }

}
