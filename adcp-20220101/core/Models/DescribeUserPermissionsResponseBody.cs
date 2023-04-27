// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeUserPermissionsResponseBody : TeaModel {
        /// <summary>
        /// The details about the permissions of the RAM user.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<DescribeUserPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class DescribeUserPermissionsResponseBodyPermissions : TeaModel {
            /// <summary>
            /// The authorization setting. Valid values:
            /// 
            /// *   {cluster_id} is returned if the permissions are scoped to a cluster.
            /// *   {cluster_id}/{namespace} is returned if the permissions are scoped to a namespace of a cluster.
            /// *   all-clusters is returned if the permissions are scoped to all clusters.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The authorization type. Valid values:
            /// 
            /// *   cluster: indicates that the permissions are scoped to a cluster.
            /// *   namespace: indicates that the permissions are scoped to a namespace of a cluster.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The name of the custom role. If a custom role is assigned, the value is the name of the assigned custom role.
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// The type of predefined role. Valid values:
            /// 
            /// *   admin: administrator
            /// *   dev: developer
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
