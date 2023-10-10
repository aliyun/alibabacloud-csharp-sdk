// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GrantPermissionsRequest : TeaModel {
        /// <summary>
        /// The request body.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GrantPermissionsRequestBody> Body { get; set; }
        public class GrantPermissionsRequestBody : TeaModel {
            /// <summary>
            /// The ID of the cluster that you want to manage.
            /// 
            /// *   When the `role_type` parameter is set to `all-clusters`, this parameter is set to an empty string.
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// Specifies whether to perform a custom authorization. To perform a custom authorization, set `role_name` to a custom cluster role.
            /// </summary>
            [NameInMap("is_custom")]
            [Validation(Required=false)]
            public bool? IsCustom { get; set; }

            /// <summary>
            /// Specifies whether the permissions are granted to a RAM role.
            /// </summary>
            [NameInMap("is_ram_role")]
            [Validation(Required=false)]
            public bool? IsRamRole { get; set; }

            /// <summary>
            /// The namespace to which the permissions are scoped. This parameter is required only if you set role_type to namespace.
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The predefined role name. Valid values:
            /// 
            /// *   `admin`: administrator
            /// *   `ops`: O\&M engineer
            /// *   `dev`: developer
            /// *   `restricted`: restricted user
            /// *   The custom cluster role.
            /// </summary>
            [NameInMap("role_name")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// The authorization type. Valid values:
            /// 
            /// *   `cluster`: indicates that the permissions are scoped to a cluster.
            /// *   `namespace`: specifies that the permissions are scoped to a namespace of a cluster.
            /// *   `all-clusters`: specifies that the permissions are scoped to all clusters.
            /// </summary>
            [NameInMap("role_type")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

    }

}
