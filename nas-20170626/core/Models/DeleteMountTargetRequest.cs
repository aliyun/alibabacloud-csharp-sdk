// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DeleteMountTargetRequest : TeaModel {
        /// <summary>
        /// The ID of the file system.
        /// 
        /// *   Sample ID of a General-purpose NAS file system: 31a8e4\\*\\*\\*\\*.
        /// *   The IDs of Extreme NAS file systems must start with `extreme-`, for example, extreme-0015\\*\\*\\*\\*.
        /// *   The IDs of Cloud Parallel File Storage (CPFS) file systems must start with `cpfs-`, for example, cpfs-125487\\*\\*\\*\\*.
        /// 
        /// > CPFS file systems are available only on the China site (aliyun.com).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The domain name of the mount target.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

    }

}
