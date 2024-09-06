// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ResizeDiskRequest : TeaModel {
        /// <summary>
        /// The ID of the order.
        /// 
        /// > This parameter is returned only when you resize subscription disks.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the disk. You can call the [DescribeDisks](https://help.aliyun.com/document_detail/25514.html) operation to query available disk IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The new disk capacity. Unit: GiB. Valid values:
        /// 
        /// *   System disk:
        /// 
        ///     *   Basic disk (cloud): 20 to 500.
        /// 
        ///     *   ESSD (cloud_essd): Valid values vary based on the performance level of the ESSD. To query the performance level of an ESSD, call the DescribeDisks operation to query disk information and check the PerformanceLevel value in the response.
        /// 
        ///         *   PL0 ESSD: 1 to 2048.
        ///         *   PL1 ESSD: 20 to 2048.
        ///         *   PL2 ESSD: 461 to 2048.
        ///         *   PL3 ESSD: 1261 to 2048.
        /// 
        ///     *   ESSD AutoPL disk (cloud_auto): 1 to 2048.
        /// 
        ///     *   Other disk categories: 20 to 2048.
        /// 
        /// *   Data disk:
        /// 
        ///     *   Ultra disk (cloud_efficiency): 20 to 32768.
        /// 
        ///     *   Standard SSD (cloud_ssd): 20 to 32768.
        /// 
        ///     *   ESSD (cloud_essd): Valid values vary based on the performance level of the ESSD.`` To query the performance level of an ESSD, call the [DescribeDisks](https://help.aliyun.com/document_detail/25514.html) operation to query disk information and check the `PerformanceLevel` value in the response.
        /// 
        ///         *   PL0 ESSD: 1 to 32768.
        ///         *   PL1 ESSD: 20 to 32768.
        ///         *   PL2 ESSD: 461 to 32768.
        ///         *   PL3 ESSD: 1261 to 32768.
        /// 
        ///     *   Basic disk (cloud): 5 to 2000.
        /// 
        ///     *   ESSD AutoPL disk (cloud_auto): 1 to 32768.
        /// 
        ///     *   Standard elastic ephemeral disk (elastic_ephemeral_disk_standard): 64 to 8192.
        /// 
        ///     *   Premium elastic ephemeral disk (elastic_ephemeral_disk_premium): 64 to 8192.
        /// 
        /// >  The new disk capacity must be larger than the original disk capacity.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewSize")]
        [Validation(Required=false)]
        public int? NewSize { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The method that you want to use to resize the disk. Valid values:
        /// 
        /// *   offline (default): resizes the disk offline. After you resize a disk offline, you must restart the associated instance in the ECS console or by calling the [RebootInstance](https://help.aliyun.com/document_detail/25502.html) operation for the resizing operation to take effect. For information about how to restart an ECS instance in the ECS console, see [Restart an instance](https://help.aliyun.com/document_detail/25440.html).
        /// *   online: resizes the disk online. After you resize a disk online, the resizing operation immediately takes effect. You do not need to restart the associated instance. You can resize ultra disks, standard SSDs, Enterprise SSDs (ESSDs), and elastic ephemeral disks online.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
