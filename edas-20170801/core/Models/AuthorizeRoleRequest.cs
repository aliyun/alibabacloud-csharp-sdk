// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AuthorizeRoleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the role to be assigned. If you want to assign multiple roles to the specified RAM user, separate the IDs of the roles with semicolons (;). If you leave this parameter empty, the roles assigned to the specified RAM user are revoked.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1;2</para>
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user to which you want to assign the roles.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test@133******</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
