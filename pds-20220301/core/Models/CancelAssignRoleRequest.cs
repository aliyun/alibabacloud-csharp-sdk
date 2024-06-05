// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CancelAssignRoleRequest : TeaModel {
        /// <summary>
        /// The unique identifier. You can cancel only the role assigned to a user.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("identity")]
        [Validation(Required=false)]
        public Identity Identity { get; set; }

        /// <summary>
        /// The ID of the resource that the role manages. Set the value to a group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("manage_resource_id")]
        [Validation(Required=false)]
        public string ManageResourceId { get; set; }

        /// <summary>
        /// The type of the resource that the role manages. Set the value to RT_Group, which specifies group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("manage_resource_type")]
        [Validation(Required=false)]
        public string ManageResourceType { get; set; }

        /// <summary>
        /// The ID of the role to be canceled. Set the value to SystemGroupAdmin, which is the ID of the group administrator role.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("role_id")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

    }

}
