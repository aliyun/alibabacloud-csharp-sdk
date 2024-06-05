// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyMountTargetRequest : TeaModel {
        /// <summary>
        /// The name of the permission group that is attached to the mount target.
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// The dual-stack (IPv4 and IPv6) domain name of the mount target.
        /// 
        /// >  Only Extreme NAS file systems that reside in the Chinese mainland support IPv6.
        /// </summary>
        [NameInMap("DualStackMountTargetDomain")]
        [Validation(Required=false)]
        public string DualStackMountTargetDomain { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// *   Sample ID of a General-purpose NAS file system: `31a8e4****`.
        /// *   The IDs of Extreme NAS file systems must start with `extreme-`, for example, `extreme-0015****`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The IPv4 domain name of the mount target.
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        /// <summary>
        /// The status of the mount target.
        /// 
        /// Valid values:
        /// 
        /// *   Active: The mount target is available.
        /// *   Inactive: The mount target is unavailable.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
