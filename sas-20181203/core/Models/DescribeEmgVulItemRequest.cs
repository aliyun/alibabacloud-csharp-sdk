// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEmgVulItemRequest : TeaModel {
        /// <summary>
        /// The check method. Valid values:
        /// 
        /// *   **0**: proof of concept (POC) verification
        /// *   **1**: version comparison
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies whether the vulnerability poses risks.\\
        /// If you do not specify this parameter, all vulnerabilities are queried regardless of whether the vulnerabilities pose risks. Valid values:
        /// 
        /// *   **y**: yes
        /// *   **n**: no
        /// </summary>
        [NameInMap("RiskStatus")]
        [Validation(Required=false)]
        public string RiskStatus { get; set; }

        /// <summary>
        /// The method that is used to detect the vulnerability.\\
        /// If you do not specify this parameter, all vulnerabilities are queried regardless of which method is used. Valid values:
        /// 
        /// *   **python**: The Version method is used. Security Center checks the software versions of your server to check whether disclosed vulnerabilities exist on your server.
        /// *   **scan**: The Network Scan method is used. Security Center analyzes the access traffic to your server over the Internet to check whether vulnerabilities exist on your server.
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// The name of the urgent vulnerability.
        /// </summary>
        [NameInMap("VulName")]
        [Validation(Required=false)]
        public string VulName { get; set; }

    }

}
