// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskCheckResultRequest : TeaModel {
        /// <summary>
        /// The type of the cloud service whose configuration assessment result you want to query. For more information about the description of the cloud service specified by this parameter, see the check item table in the "Response parameters" section of this topic.
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The type of the check item that you want to query. Valid values:
        /// 
        /// *   **1**: identity authentication and permissions
        /// *   **2**: network access control
        /// *   **3**: log audit
        /// *   **4**: data security
        /// *   **5**: monitoring and alerting
        /// *   **6**: basic security protection
        /// 
        /// >  If you do not specify this parameter, all types of check items are queried by default.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public List<string> ItemIds { get; set; }

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
        /// The name of the check item. For more information about the description of the check item name, see the check item table in the "Response parameters" section of this topic.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies whether the check item is supported by the cloud service. Valid values:
        /// 
        /// *   **enabled**: The check item is supported by the cloud service.
        /// *   **disabled**: The check item is not supported by the cloud service.
        /// </summary>
        [NameInMap("QueryFlag")]
        [Validation(Required=false)]
        public string QueryFlag { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The risk level of the check item that you want to query. Valid values:
        /// 
        /// *   **high**
        /// *   **medium**
        /// *   **low**
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The status of the check result. Valid values:
        /// 
        /// *   **pass**
        /// *   **failed**
        /// *   **running**
        /// *   **waiting**
        /// *   **ignored**
        /// *   **falsePositive**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
