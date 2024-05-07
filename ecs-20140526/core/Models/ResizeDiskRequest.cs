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
        /// The method that you want to use to resize the disk. Default value: offline. Valid values:
        /// 
        /// *   offline: resizes the disk offline. After you resize a disk offline, you must restart its associated instance by using the Elastic Compute Service (ECS) console or by calling the [RebootInstance](~~25502~~) operation to make the resizing operation take effect. For information about how to restart an ECS instance in the ECS console, see [Restart an instance](~~25440~~).
        /// *   online: resizes the disk online. After you resize a disk online, the resizing operation takes effect immediately and you do not need to restart the instance. Ultra disks, standard SSDs, and ESSDs can be resized online.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The new disk capacity. Unit: GiB. Valid values:
        /// 
        /// *   For a system disk:
        /// 
        ///     *   Basic disk (cloud): 20 to 500.
        ///     *   Other disk categories: 20 to 2048.
        /// 
        /// *   For a data disk:
        /// 
        ///     *   Ultra disk (cloud_efficiency): 20 to 32768.
        /// 
        ///     *   Standard SSD (cloud_ssd): 20 to 32768.
        /// 
        ///     *   ESSD (cloud_essd): Valid values depend on the `PerformanceLevel` value. You can call the [DescribeDisks](~~25514~~) operation to query disk information and check the `PerformanceLevel` value in the response.
        /// 
        ///         *   Valid values when the PerformanceLevel value is PL0: 1 to 32768.
        ///         *   Valid values when the PerformanceLevel value is PL1: 20 to 32768.
        ///         *   Valid values when the PerformanceLevel value is PL2: 461 to 32768.
        ///         *   Valid values when the PerformanceLevel value is PL3: 1261 to 32768.
        /// 
        ///     *   Basic disk (cloud): 5 to 2000.
        /// 
        ///     *   ESSD AutoPL disk (cloud_auto): 1 to 32768.
        /// 
        /// The new disk capacity must be larger than the original disk capacity.
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
        /// *   offline (default): resizes the disk offline. After you resize a disk offline, you must restart its associated instance by using the ECS console or by calling the [RebootInstance](~~25502~~) operation to make the resizing operation take effect. For information about how to restart an ECS instance in the ECS console, see [Restart an instance](~~25440~~).
        /// *   online: resizes the disk online. After you resize a disk online, the resizing operation takes effect immediately and you do not need to restart the instance. You can resize ultra disks, standard SSDs, and ESSDs online.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
