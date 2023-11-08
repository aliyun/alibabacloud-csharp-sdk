// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GrantUserPermissionsRequest : TeaModel {
        /// <summary>
        /// The permissions that are granted to an entity. The content is a string that consists of JSON arrays. You must specify all permissions that you want to grant to an entity. You can add or remove permissions by modifying the content. Field definition of the sample code:
        /// 
        /// *   `IsCustom`: a parameter that is required by the system. Set the value to `true`.
        /// *   `Cluster`: the ID of the Service Mesh (ASM) instance.
        /// *   `RoleName`: the name of the permissions. Valid values: `istio-admin`, `istio-ops`, and `istio-readonly`. A value of istio-admin indicates the permissions of ASM administrators. A value of istio-ops indicates the permissions of ASM restricted users. A value of istio-readonly indicates the read-only permissions.
        /// *   `IsRamRole`: the entity to which you want to grant the permissions. To grant the permissions to a RAM role, set the value to `true`. Otherwise, set the value to `false`.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// The ID of the RAM user or RAM role.
        /// </summary>
        [NameInMap("SubAccountUserId")]
        [Validation(Required=false)]
        public string SubAccountUserId { get; set; }

        /// <summary>
        /// The IDs of RAM users or RAM roles. You can grant permissions to multiple users at a time.
        /// </summary>
        [NameInMap("SubAccountUserIds")]
        [Validation(Required=false)]
        public List<string> SubAccountUserIds { get; set; }

    }

}
