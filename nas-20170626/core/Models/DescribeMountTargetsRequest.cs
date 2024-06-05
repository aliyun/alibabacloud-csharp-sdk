// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeMountTargetsRequest : TeaModel {
        /// <summary>
        /// The dual-stack (IPv4 and IPv6) domain name of the mount target.
        /// 
        /// > Only Extreme NAS file systems that reside in the Chinese mainland support IPv6.
        /// </summary>
        [NameInMap("DualStackMountTargetDomain")]
        [Validation(Required=false)]
        public string DualStackMountTargetDomain { get; set; }

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
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
