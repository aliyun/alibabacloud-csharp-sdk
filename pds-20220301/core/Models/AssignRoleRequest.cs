// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AssignRoleRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of a user. The group administrator role can only be assigned to a user.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("identity")]
        [Validation(Required=false)]
        public Identity Identity { get; set; }

        /// <summary>
        /// <para>The ID of the resource that the role can manage. You can only set this parameter to the ID of a group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>105***b82</para>
        /// </summary>
        [NameInMap("manage_resource_id")]
        [Validation(Required=false)]
        public string ManageResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource that the role can manage. Valid value: RT_Group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RT_Group</para>
        /// </summary>
        [NameInMap("manage_resource_type")]
        [Validation(Required=false)]
        public string ManageResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the role that is assigned to a user. Valid value: SystemGroupAdmin.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SystemGroupAdmin</para>
        /// </summary>
        [NameInMap("role_id")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

    }

}
