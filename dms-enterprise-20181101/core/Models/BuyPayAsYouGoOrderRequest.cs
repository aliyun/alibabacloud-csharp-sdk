// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class BuyPayAsYouGoOrderRequest : TeaModel {
        /// <summary>
        /// The type of the resource that you want to purchase.
        /// 
        /// *   **VersionType**: DMS that supports control modes
        /// *   **SensitiveDataProtection**: DMS that supports sensitive data protection
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CommodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

        /// <summary>
        /// The number of database instances that you want to use DMS to manage.
        /// 
        /// > A quota can be used for only one database instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InsNum")]
        [Validation(Required=false)]
        public int? InsNum { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](https://help.aliyun.com/document_detail/181330.html).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The control mode of DMS. Valid values:
        /// 
        /// *   **stand**: Stable Change
        /// *   **safety**: Security Collaboration
        /// </summary>
        [NameInMap("VersionType")]
        [Validation(Required=false)]
        public string VersionType { get; set; }

    }

}
