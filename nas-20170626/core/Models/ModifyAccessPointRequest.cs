// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyAccessPointRequest : TeaModel {
        /// <summary>
        /// The name of the permission group.
        /// 
        /// This parameter is required for a General-purpose Apsara File Storage NAS (NAS) file system.
        /// 
        /// The default permission group for virtual private clouds (VPCs) is named DEFAULT_VPC_GROUP_NAME.
        /// </summary>
        [NameInMap("AccessGroup")]
        [Validation(Required=false)]
        public string AccessGroup { get; set; }

        /// <summary>
        /// The ID of the access point.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// The name of the access point.
        /// </summary>
        [NameInMap("AccessPointName")]
        [Validation(Required=false)]
        public string AccessPointName { get; set; }

        /// <summary>
        /// Specifies whether to enable the Resource Access Management (RAM) policy. Valid values:
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

    }

}
