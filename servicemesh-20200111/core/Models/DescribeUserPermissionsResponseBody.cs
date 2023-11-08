// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeUserPermissionsResponseBody : TeaModel {
        /// <summary>
        /// The permissions that are granted to an entity.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<DescribeUserPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class DescribeUserPermissionsResponseBodyPermissions : TeaModel {
            /// <summary>
            /// The entity to which the permissions are granted. A value of `true` indicates that the permissions are granted to a RAM user. A value of `false` indicates that the permissions are granted to a RAM role.
            /// </summary>
            [NameInMap("IsRamRole")]
            [Validation(Required=false)]
            public string IsRamRole { get; set; }

            /// <summary>
            /// The value is fixed as `0`.
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// The ID of the ASM instance.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The value is fixed as `cluster`.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The name of the permissions. Valid values:
            /// 
            /// *   `istio-admin`: the permissions of ASM administrators.
            /// *   `istio-ops`: the permissions of ASM restricted users.
            /// *   `istio-readonly`: the read-only permissions.
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// The value is fixed as `custom`.
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
