// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateDiskRequest : TeaModel {
        /// <summary>
        /// The category of the disk. Valid values:
        /// 
        /// *   cloud_efficiency: ultra disk.
        /// *   cloud_ssd: all-flash disk.
        /// *   local_hdd: local HDD.
        /// *   local_ssd: local SSD.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The name of the disk.
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// Specifies whether to encrypt the new system disk. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The ID of the edge node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   PrePaid: subscription.
        /// *   PostPaid: pay-as-you-go.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The ID of the Key Management Service (KMS) key that is used by the cloud disk.
        /// 
        /// >  If you set the **Encrypted** parameter to **true**, the default service key is used when the **KMSKeyId** parameter is empty.
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// The size of the disk. Unit: GiB.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        /// <summary>
        /// The ID of the snapshot that you want to use to create the disk.
        /// 
        /// The following limits apply to the **SnapshotId** and **Size** parameters:
        /// 
        /// *   If the size of the snapshot specified by **SnapshotId** is greater than the specified **Size** value, the size of the created disk is equal to the specified snapshot size.
        /// *   If the size of the snapshot specified by **SnapshotId** is smaller than the specified **Size** value, the size of the created disk is equal to the specified **Size** value.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
