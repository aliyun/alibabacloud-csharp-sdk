// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales organization</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the parent user group. If this parameter is not specified, a root node is created.</para>
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
        /// <para>The name of the user group. The name must be unique under the same parent node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>East China Sales</para>
        /// </summary>
        [NameInMap("userGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

    }

}
