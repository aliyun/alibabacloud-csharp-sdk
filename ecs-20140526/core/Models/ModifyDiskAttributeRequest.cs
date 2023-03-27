// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the performance burst feature for disk N. Valid values:
        /// 
        /// *   true: enables the performance burst feature.
        /// *   false: disables the performance burst feature.
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// Specifies whether to delete the automatic snapshots of the disk when the disk is released. By default, this parameter is left empty, which specifies that the current value remains unchanged.
        /// </summary>
        [NameInMap("DeleteAutoSnapshot")]
        [Validation(Required=false)]
        public bool? DeleteAutoSnapshot { get; set; }

        /// <summary>
        /// Specifies whether to release the disk together with the associated instance. By default, this parameter is left empty, which specifies that the current value remains unchanged.
        /// 
        /// If you set the `DeleteWithInstance` parameter to `false` in one of the following cases, an error is returned:
        /// 
        /// *   The disk is a local disk.
        /// *   The disk is a basic disk and not removable. If the Portable attribute of a disk is set to false, the disk is not removable.
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// The description of the disk. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the disk.
        /// 
        /// >  You can specify the `DiskId` parameter or the `DiskIds.N` parameter, but you cannot specify both parameters at the same time.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The IDs of the disks whose attributes you want to modify. Valid values of N: 0 to 100.
        /// 
        /// >  You can specify the `DiskId` parameter or the `DiskIds.N` parameter, but you cannot specify both parameters at the same time.
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public List<string> DiskIds { get; set; }

        /// <summary>
        /// The name of the disk. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// Specifies whether to enable the automatic snapshot policy feature for the disk.
        /// 
        /// *   true: enables the automatic snapshot policy feature for the disk.
        /// *   false: disables the automatic snapshot policy feature for the disk.
        /// 
        /// By default, this parameter is left empty, which specifies that the current value remains unchanged.
        /// 
        /// > : By default, the automatic snapshot policy feature is enabled for new disks. You need to only apply an automatic snapshot policy to a disk for the policy to take effect.
        /// </summary>
        [NameInMap("EnableAutoSnapshot")]
        [Validation(Required=false)]
        public bool? EnableAutoSnapshot { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
