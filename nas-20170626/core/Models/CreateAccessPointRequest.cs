// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAccessPointRequest : TeaModel {
        /// <summary>
        /// The name of the permission group.
        /// 
        /// This parameter is required for a General-purpose Apsara File Storage NAS (NAS) file system.
        /// 
        /// The default permission group for virtual private clouds (VPCs) is named DEFAULT_VPC_GROUP_NAME.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccessGroup")]
        [Validation(Required=false)]
        public string AccessGroup { get; set; }

        /// <summary>
        /// The name of the access point.
        /// </summary>
        [NameInMap("AccessPointName")]
        [Validation(Required=false)]
        public string AccessPointName { get; set; }

        /// <summary>
        /// Specifies whether to enable the RAM policy. Valid values:
        /// 
        /// *   true: The RAM policy is enabled.
        /// *   false (default): The RAM policy is disabled.
        /// 
        /// >  After the RAM policy is enabled for access points, no RAM user is allowed to use access points to mount and access data by default. To use access points to mount and access data as a RAM user, you must grant the related access permissions to the RAM user. If the RAM policy is disabled, access points can be anonymously mounted.
        /// </summary>
        [NameInMap("EnabledRam")]
        [Validation(Required=false)]
        public bool? EnabledRam { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The ID of the owner group.
        /// 
        /// This parameter is required if the RootDirectory directory does not exist.
        /// </summary>
        [NameInMap("OwnerGroupId")]
        [Validation(Required=false)]
        public int? OwnerGroupId { get; set; }

        /// <summary>
        /// The owner ID.
        /// 
        /// This parameter is required if the RootDirectory directory does not exist.
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// The Portable Operating System Interface for UNIX (POSIX) permission. Default value: 0777.
        /// 
        /// This field takes effect only if you specify the OwnerUserId and OwnerGroupId parameters.
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// The ID of the POSIX user group.
        /// </summary>
        [NameInMap("PosixGroupId")]
        [Validation(Required=false)]
        public int? PosixGroupId { get; set; }

        /// <summary>
        /// The secondary user group. Separate multiple user group IDs with commas (,).
        /// </summary>
        [NameInMap("PosixSecondaryGroupIds")]
        [Validation(Required=false)]
        public string PosixSecondaryGroupIds { get; set; }

        /// <summary>
        /// The ID of the POSIX user.
        /// </summary>
        [NameInMap("PosixUserId")]
        [Validation(Required=false)]
        public int? PosixUserId { get; set; }

        /// <summary>
        /// The root directory of the access point. The default value is /. If the directory does not exist, you must also specify the OwnerUserId and OwnerGroupId parameters.
        /// </summary>
        [NameInMap("RootDirectory")]
        [Validation(Required=false)]
        public string RootDirectory { get; set; }

        /// <summary>
        /// The VPC ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The vSwitch ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VswId")]
        [Validation(Required=false)]
        public string VswId { get; set; }

    }

}
