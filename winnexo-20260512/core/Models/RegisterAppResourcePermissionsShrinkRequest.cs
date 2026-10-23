// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RegisterAppResourcePermissionsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The batch authorization items.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public string ItemsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the tenant to which the resource belongs. If not specified, the current tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("resourceTenantId")]
        [Validation(Required=false)]
        public string ResourceTenantId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
