// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeUserPermissionResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeUserPermissionResponseBody> Body { get; set; }
        public class DescribeUserPermissionResponseBody : TeaModel {
            /// <summary>
            /// The authorization setting. Valid values:
            /// 
            /// *   `{cluster_id}` is returned if the permissions are scoped to a cluster.
            /// *   `{cluster_id}/{namespace}` is returned if the permissions are scoped to a namespace of a cluster.
            /// *   `all-clusters` is returned if the permissions are scoped to all clusters.
            /// </summary>
            [NameInMap("resource_id")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The authorization type. Valid values:
            /// 
            /// *   `cluster`: indicates that the permissions are scoped to a cluster.
            /// *   `namespace`: indicates that the permissions are scoped to a namespace of a cluster.
            /// *   `console`: indicates that the permissions are scoped to all clusters. This value was displayed only in the console.
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The name of the custom role. If a custom role is assigned, the value is the name of the assigned custom role.
            /// </summary>
            [NameInMap("role_name")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// The type of predefined role. Valid values:
            /// 
            /// *   `admin`: administrator
            /// *   `ops`: O\&M engineer
            /// *   `dev`: developer
            /// *   `restricted`: restricted user
            /// *   `custom`: custom role
            /// </summary>
            [NameInMap("role_type")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// Indicates whether the permissions are granted to the cluster owner.
            /// 
            /// *   `0`: indicates that the permissions are not granted to the cluster owner.
            /// *   `1`: indicates that the permissions are granted to the cluster owner. The cluster owner is the administrator.
            /// </summary>
            [NameInMap("is_owner")]
            [Validation(Required=false)]
            public long? IsOwner { get; set; }

            /// <summary>
            /// Indicates whether the permissions are granted to the RAM role. Valid values:
            /// 
            /// *   `0`: indicates that the permissions are not granted to the RAM role.
            /// *   `1`: indicates that the permissions are granted to the RAM role.
            /// </summary>
            [NameInMap("is_ram_role")]
            [Validation(Required=false)]
            public long? IsRamRole { get; set; }

        }

    }

}
