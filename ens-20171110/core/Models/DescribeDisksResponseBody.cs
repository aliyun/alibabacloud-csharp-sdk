// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDisksResponseBody : TeaModel {
        /// <summary>
        /// The returned service code. 0 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the disks.
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeDisksResponseBodyDisks Disks { get; set; }
        public class DescribeDisksResponseBodyDisks : TeaModel {
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeDisksResponseBodyDisksDisks> Disks { get; set; }
            public class DescribeDisksResponseBodyDisksDisks : TeaModel {
                /// <summary>
                /// The category of the disk.
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
                /// The time when the disk was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The billing method of the cloud disk or local disk. Valid values:
                /// 
                /// *   **prepaid**: subscription.
                /// *   **postpaid**: pay-as-you-go.
                /// </summary>
                [NameInMap("DiskChargeType")]
                [Validation(Required=false)]
                public string DiskChargeType { get; set; }

                /// <summary>
                /// The ID of the disk.
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// The name of the disk.
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// Indicates whether the cloud disk is encrypted. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// The ID of the Key Management Service (KMS) key that is used for the cloud disk.
                /// </summary>
                [NameInMap("EncryptedKeyId")]
                [Validation(Required=false)]
                public string EncryptedKeyId { get; set; }

                /// <summary>
                /// The ID of the edge node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Indicates whether the cloud disk or local disk is removable. Valid values:
                /// 
                /// *   true: The disk is removable. A removable disk can independently exist and can be attached to or detached from an instance within the same zone.
                /// *   false: The disk is not removable. A disk that is not removable cannot independently exist or be attached to or detached from an instance within the same zone.
                /// 
                /// If disks are of the following categories or types, the **Portable** value is **false** and the disks have the same lifecycle as their attached instances:
                /// 
                /// *   Local HDDs
                /// *   Local SSDs
                /// *   Data disks that use the subscription billing method
                /// </summary>
                [NameInMap("Portable")]
                [Validation(Required=false)]
                public bool? Portable { get; set; }

                /// <summary>
                /// The serial number.
                /// </summary>
                [NameInMap("SerialId")]
                [Validation(Required=false)]
                public string SerialId { get; set; }

                /// <summary>
                /// The size of the disk. Unit: MiB.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// The ID of the snapshot.
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                /// <summary>
                /// The status of the disk. Valid values:
                /// 
                /// *   In-use: The disk is in use.
                /// *   Available: The disk can be attached.
                /// *   Attaching: The disk is being attached.
                /// *   Detaching: The disk is being detached.
                /// *   Creating: The disk is being created.
                /// *   ReIniting: The disk is being reset.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the cloud disk or local disk. Valid values:
                /// 
                /// *   1: system disk.
                /// *   2: data disk.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned pages.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
