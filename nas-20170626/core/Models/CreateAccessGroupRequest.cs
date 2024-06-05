// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAccessGroupRequest : TeaModel {
        /// <summary>
        /// The name of the permission group.
        /// 
        /// Limits:
        /// 
        /// *   The name must be 3 to 64 characters in length.
        /// *   The name must start with a letter and can contain letters, digits, underscores (_), and hyphens (-).
        /// *   The name must be different from the name of the default permission group.
        /// 
        /// The default permission group for virtual private clouds (VPCs) is named DEFAULT_VPC_GROUP_NAME.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// The network type of the permission group. Valid value: **Vpc**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccessGroupType")]
        [Validation(Required=false)]
        public string AccessGroupType { get; set; }

        /// <summary>
        /// The description of the permission group.
        /// 
        /// Limits:
        /// 
        /// *   By default, the description of a permission group is the same as the name of the permission group. The description must be 2 to 128 characters in length.
        /// *   The name must start with a letter and cannot start with `http://` or `https://`.
        /// *   The description can contain digits, colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The type of the file system.
        /// 
        /// Valid values:
        /// 
        /// *   standard (default): General-purpose NAS file system
        /// *   extreme: Extreme NAS file system
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

    }

}
