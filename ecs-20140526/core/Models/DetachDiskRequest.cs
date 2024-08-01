// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachDiskRequest : TeaModel {
        /// <summary>
        /// Specifies whether to release the system disk or data disk when the instance from which you want to detach the disk is released. Valid values:
        /// 
        /// *   true: releases the disk when the instance is released.
        /// *   false: does not release the disk when the instance is released. The disk is retained as a pay-as-you-go data disk.
        /// 
        /// Default value: true.
        /// 
        /// Take note of the following items:
        /// 
        /// *   You cannot specify this parameter for disks for which the multi-attach feature is enabled.
        /// *   If a data disk is to be detached, the default value is `false`.
        /// *   If you want to detach an `elastic ephemeral disk`, you must set `DeleteWithInstance` to `true`.
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// The ID of the disk that you want to detach.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The ID of the ECS instance from which you want to detach the disk.
        /// 
        /// This parameter is required.
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
