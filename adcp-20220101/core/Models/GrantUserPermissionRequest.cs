// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class GrantUserPermissionRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The entity to which the permissions are granted. A value of `true` indicates that the permissions are granted to a RAM user. A value of `false` indicates that the permissions are granted to a RAM role.
        /// </summary>
        [NameInMap("IsRamRole")]
        [Validation(Required=false)]
        public bool? IsRamRole { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// *   If **RoleType** is set to **cluster**, you do not need to specify this parameter.
        /// *   This parameter is required if **RoleType** is set to **namespace**.
        /// *   If **RoleType** is set to **namespace** and **RoleName** is set to **gitops-dev**, this parameter is required and must be set to **argocd**.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The predefined role. Valid values:
        /// 
        /// *   admin: administrator
        /// *   dev: developer
        /// *   gitops-dev: GitOps developer. The parameter is available only for Fleet instances.
        /// 
        /// The value of RoleName and that of RoleType must meet the following requirements:
        /// 
        /// *   If **RoleType** is set to **cluster**, this parameter must be set to **admin**.
        /// *   If **RoleType** is set to **namespace**, this parameter must be set to **dev** or **gitops-dev**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// The authorization type. Valid values:
        /// 
        /// *   cluster: The permissions are granted to a cluster.
        /// *   namespace: The permissions are granted to a namespace of a cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// The ID of the RAM user or RAM role.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
