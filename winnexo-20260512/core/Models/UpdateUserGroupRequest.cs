// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the user group. If this parameter is not specified, the description is not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to move the user group to the root node. This parameter cannot be set at the same time as a non-null parentId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("moveToRoot")]
        [Validation(Required=false)]
        public bool? MoveToRoot { get; set; }

        /// <summary>
        /// <para>The ID of the new parent user group. If this parameter is not specified, the user group is not moved. If it is explicitly set to null, the user group is moved to the root node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. In winnexo-cli, it is explicitly passed by using --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the target user group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("userGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// <para>The new name of the user group. If this parameter is not specified, the name is not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("userGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

    }

}
