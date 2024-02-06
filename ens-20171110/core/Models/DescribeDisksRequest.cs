// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDisksRequest : TeaModel {
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
        /// The billing method.
        /// 
        /// *   prePay: subscription.
        /// *   postpay: pay-as-you-go.
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
        /// The ID of the disk.
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        /// <summary>
        /// The name of the disk.
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// The purchase method of the disk. Valid values:
        /// 
        /// *   ServiceDisk: The disk is purchased when ENS is activated.
        /// *   ResoureDisk: The disk is purchased when the instance is created.
        /// *   PostPayDisk: The disk is separately purchased.
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// The ID of the edge node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The node information.
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIds { get; set; }

        /// <summary>
        /// The instance to which the disk is attached.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The order in which you want to sort the returned data. Example: {"EnsRegionId":"desc"}. By default, the nodes are sorted by IDs in descending order.
        /// </summary>
        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page **1**.
        /// 
        /// Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **50**.
        /// 
        /// Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

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
        /// *   Creating: The image is being created.
        /// *   ReIniting: The disk is being reset.
        /// *   Deleting: The disk is being released.
        /// *   Deleted: The disk is released.
        /// *   Expiring: The disk is about to expire.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The type of the disk. Valid values:
        /// 
        /// *   system: system disk.
        /// *   data: data disk.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
