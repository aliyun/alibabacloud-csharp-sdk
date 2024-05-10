// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedInstancesRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The name of the group to which the assets belong. Fuzzy search is supported.
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// The filter condition that you want to use to query the assets. Valid values:
        /// 
        /// *   **groupId**: the group to which the assets belong
        /// *   **regionId**: the region in which the assets reside
        /// *   **vpcInstanceId**: the virtual private cloud (VPC) in which the assets reside
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupField")]
        [Validation(Required=false)]
        public string GroupField { get; set; }

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
        /// The type of the assets that you want to query. Set the value to **ecs**, which indicates Elastic Compute Service (ECS) instances.
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// Specifies whether to enable paged query. Default value: **true**. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("NoPage")]
        [Validation(Required=false)]
        public bool? NoPage { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The edition of Security Center that protects the asset. Valid values:
        /// 
        /// * **sas_gte_advanced**: the Advanced edition or higher
        /// * **sas_gte_enterprise**: the Enterprise edition or higher
        /// * **sas_gt_basic:** a paid edition
        /// * **sas_eq_advanced:** the Advanced edition
        /// * **sas_gt_anti_virus:** an edition higher than the Anti-virus edition
        /// </summary>
        [NameInMap("SaleVersionCheckCode")]
        [Validation(Required=false)]
        public string SaleVersionCheckCode { get; set; }

        /// <summary>
        /// The source of the server. Valid values:
        /// 
        /// *   **0**: an asset provided by Alibaba Cloud.
        /// *   **1**: a third-party cloud server
        /// *   **2**: a server in a data center
        /// *   **3**, **4**, **5**, and **7**: other cloud asset
        /// *   **8**: a lightweight asset
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

        /// <summary>
        /// The source of the server. Separate multiple sources with commas (,).Valid values:
        /// 
        /// *   **0**: an asset provided by Alibaba Cloud.
        /// *   **1**: a third-party cloud server
        /// *   **2**: a server in a data center
        /// *   **3**, **4**, **5**, and **7**: other cloud asset
        /// *   **8**: a lightweight asset
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public string Vendors { get; set; }

    }

}
