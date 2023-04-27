// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class BuyPayAsYouGoOrderRequest : TeaModel {
        /// <summary>
        /// The number of database instances that you want to use DMS to manage.
        /// 
        /// > : A quota can be used for only one database instance.
        /// </summary>
        [NameInMap("CommodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

        /// <summary>
        /// The control mode of DMS. Valid values:
        /// 
        /// *   **stand**: Stable Change
        /// *   **safety**: Security Collaboration
        /// </summary>
        [NameInMap("InsNum")]
        [Validation(Required=false)]
        public int? InsNum { get; set; }

        /// <summary>
        /// The type of the resource that you want to purchase.
        /// 
        /// *   **VersionType**: DMS that supports control modes
        /// *   **SensitiveDataProtection**: DMS that supports sensitive data protection
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("VersionType")]
        [Validation(Required=false)]
        public string VersionType { get; set; }

    }

}
