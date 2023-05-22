// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class GrantUserPermissionRequest : TeaModel {
        /// <summary>
        /// The ID of the master instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("IsRamRole")]
        [Validation(Required=false)]
        public bool? IsRamRole { get; set; }

        /// <summary>
        /// The namespace to which the permissions are scoped. By default, this parameter is empty when you set role_type to cluster.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Specifies the predefined role that you want to assign. Valid values:
        /// 
        /// *   admin: the administrator role.
        /// *   dev: the developer role.
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// The authorization type. Valid values:
        /// 
        /// *   cluster: specifies that the permissions are scoped to a master instance.
        /// *   namespace: specifies that the permissions are scoped to a namespace of a cluster.
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// The ID of the RAM user.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
