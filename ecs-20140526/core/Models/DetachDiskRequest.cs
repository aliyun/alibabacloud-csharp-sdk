// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachDiskRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically release the system disk when the instance from which the system disk is to be detached is released. Valid values:
        /// 
        /// *   true: The system disk is released when the instance is released.
        /// *   false: The system disk is not released when the instance is released. The system disk is retained as a pay-as-you-go data disk.
        /// 
        /// Default value: true.
        /// 
        /// Take note of the following items:
        /// 
        /// *   This parameter cannot be set for disks for which the multi-attach feature is enabled.
        /// *   If a data disk is to be detached, the default value is `false`.
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// The ID of the disk to be detached.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The ID of the ECS instance from which the disk is to be detached.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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

    }

}
