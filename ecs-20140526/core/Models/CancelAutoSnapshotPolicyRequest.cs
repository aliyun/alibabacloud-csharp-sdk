// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CancelAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// RAM用户的虚拟账号ID。
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// 资源主账号的账号名称。
        /// </summary>
        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// 资源主账号的ID，亦即UID。
        /// </summary>
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The IDs of the disks for which you want to disable the automatic snapshot policy. To disable the automatic snapshot policy for multiple disks, you can set this parameter to a JSON array that consists of multiple disk IDs, such as ["dxxxxxxxxx", "dyyyyyyyyy", … "dzzzzzzzzz"]. Separate the disk IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("diskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        /// <summary>
        /// The region ID of the automatic snapshot policy and the disks. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
