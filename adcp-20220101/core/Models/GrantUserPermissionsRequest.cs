// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class GrantUserPermissionsRequest : TeaModel {
        /// <summary>
        /// The list of permissions that you want to grant to the RAM user.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<GrantUserPermissionsRequestPermissions> Permissions { get; set; }
        public class GrantUserPermissionsRequestPermissions : TeaModel {
            /// <summary>
            /// The master instance ID.
            /// 
            /// *   When the role_type parameter is set to all-clusters, set the parameter to an empty string.
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
            /// The namespace to which the permissions are scoped. By default, this parameter is empty when you set RoleType to cluster.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The predefined role that you want to assign. Valid values:
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
            /// *   all-clusters: specifies that the permissions are scoped to all master instances.
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        /// <summary>
        /// The ID of the RAM user.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
