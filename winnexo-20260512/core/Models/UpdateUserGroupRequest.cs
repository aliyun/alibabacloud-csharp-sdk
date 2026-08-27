// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the user group. If not specified, the description is not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>South China Sales Organization</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to move the user group to the root node. This parameter cannot be set together with parentId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("moveToRoot")]
        [Validation(Required=false)]
        public bool? MoveToRoot { get; set; }

        /// <summary>
        /// <para>The ID of the new parent user group. If not specified, the user group is not moved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ea8973f-7a5c-4e8a-956b-4fe0e7e2eb11</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the target user group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ea8973f-7a5c-4e8a-956b-4fe0e7e2eb11</para>
        /// </summary>
        [NameInMap("userGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// <para>The new name of the user group. If not specified, the name is not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>South China Sales</para>
        /// </summary>
        [NameInMap("userGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

    }

}
