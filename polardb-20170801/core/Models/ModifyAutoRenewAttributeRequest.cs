// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// The cluster ID. If you need to specify multiple cluster IDs, separate the cluster IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// The automatic renewal period.
        /// 
        ///  
        /// *   Valid values when **PeriodUnit** is set to **Month**: `1, 2, 3, 6, and 12`.
        /// *   Valid values when **PeriodUnit** is set to **Year**: `1, 2, and 3`.
        ///  
        /// Default value: **1**.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The unit of the renewal period. Valid values:
        ///  
        /// *   **Year**
        /// *   **Month**
        ///  
        /// Default value: **Month**.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The ID of the region. The region ID can be up to 50 characters in length.
        /// cn-hangzhou
        ///  
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/98041.html) operation to query the available regions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The auto-renewal state of the cluster. Valid values:
        ///  
        /// *   **AutoRenewal:** The cluster are automatically renewed.
        /// *   **Normal**: The cluster is manually renewed.
        /// *   **NotRenewal:** The cluster is not renewed after expiration.
        ///  
        /// Default value: **AutoRenewal**.
        ///  
        /// >  If this parameter is set to **NotRenewal**, the system does not send a text message for the cluster expiration, but only sends a message three days before the cluster expires to remind you that the cluster is not renewed.
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
