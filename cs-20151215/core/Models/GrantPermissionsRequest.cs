// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GrantPermissionsRequest : TeaModel {
        /// <summary>
        /// The request parameters.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GrantPermissionsRequestBody> Body { get; set; }
        public class GrantPermissionsRequestBody : TeaModel {
            /// <summary>
            /// The ID of the cluster on which you want to grant permissions to the RAM role or RAM role.
            /// 
            /// *   Set this parameter to an empty string if `role_type` is set to `all-clusters`.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// Specifies whether to assign a custom role to the RAM user or RAM role. If you want to assign a custom role to the RAM user or RAM role, set `role_name` to the name of the custom role.
            /// </summary>
            [NameInMap("is_custom")]
            [Validation(Required=false)]
            public bool? IsCustom { get; set; }

            /// <summary>
            /// Specifies whether to use a RAM role to grant permissions.
            /// </summary>
            [NameInMap("is_ram_role")]
            [Validation(Required=false)]
            public bool? IsRamRole { get; set; }

            /// <summary>
            /// The namespace that you want to authorize the RAM user or RAM role to manage. This parameter is required only if you set role_type to namespace.
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The predefined role. Valid values:
            /// 
            /// *   `admin`: administrator
            /// *   `ops`: O\\&M engineer
            /// *   `dev`: developer
            /// *   `restricted`: restricted user
            /// *   Custom role
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("role_name")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// The authorization type. Valid values:
            /// 
            /// *   `cluster`: authorizes the RAM user or RAM role to manage the specified clusters.
            /// *   `namespace`: authorizes the RAM user or RAM role to manage the specified namepsaces.
            /// *   `all-clusters`: authorizes the RAM user or RAM role to manage all clusters.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("role_type")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

    }

}
