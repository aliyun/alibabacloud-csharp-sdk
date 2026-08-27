// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID. This is a common parameter. In winnexo-cli, pass this parameter explicitly by using <c>--tenant-id</c>.</para>
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

    }

}
