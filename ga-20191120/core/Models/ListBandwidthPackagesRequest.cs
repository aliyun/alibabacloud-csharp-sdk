// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBandwidthPackagesRequest : TeaModel {
        /// <summary>
        /// The ID of the bandwidth plan.
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **100**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The state of the bandwidth plan. Valid values:
        /// 
        /// *   **init**: The bandwidth plan is being initialized.
        /// *   **active**: The bandwidth plan is available.
        /// *   **binded**: The bandwidth plan is associated with a GA instance.
        /// *   **binding**: The bandwidth plan is being associated.
        /// *   **unbinding**: The bandwidth plan is being disassociated.
        /// *   **updating**: The bandwidth plan is being updated.
        /// *   **finacialLocked**: The bandwidth plan is locked due to overdue payments.
        /// *   **Locked**: The bandwidth plan is locked.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListBandwidthPackagesRequestTag> Tag { get; set; }
        public class ListBandwidthPackagesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the bandwidth plan. Valid values:
        /// 
        /// *   **Basic**: a basic bandwidth plan
        /// *   **CrossDomain**: a cross-region acceleration bandwidth plan
        /// 
        /// If you call this operation on the Alibaba Cloud China Site (aliyun.com), you can only set Type to **Basic**.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
