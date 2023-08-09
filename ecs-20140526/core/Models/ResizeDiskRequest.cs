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
        /// 32768
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
        /// The new disk capacity. Unit: GiB. Valid values:
        /// 
        /// *   System disk: 20 to 500.
        /// 
        /// *   Data disk:
        /// 
        ///     *   Ultra disk (cloud_efficiency): 20 to 32768.
        /// 
        ///     *   Standard SSD (cloud_ssd): 20 to 32768.
        /// 
        ///     *   ESSD (cloud_essd): Valid values when the NewSize parameter is set to cloud_essd depend on the `PerformanceLevel` value. You can call the [DescribeDisks](~~25514~~) operation to query disk information and check the `PerformanceLevel` value in the response.
        /// 
        ///         *   Valid values when PerformanceLevel is set to PL0: 40 to 32768.
        ///         *   Valid values when PerformanceLevel is set to PL1: 20 to 32768.
        ///         *   Valid values when PerformanceLevel is set to PL2: 461 to 32768.
        ///         *   Valid values when PerformanceLevel is set to PL3: 1261 to 32768.
        /// 
        ///     *   Basic disk (cloud): 5 to 2000.
        /// 
        /// The new disk capacity must be greater than the original disk capacity.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
