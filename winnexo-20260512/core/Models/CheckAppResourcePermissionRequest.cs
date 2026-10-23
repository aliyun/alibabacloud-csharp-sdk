// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CheckAppResourcePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The permission to check.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP/VIEW</para>
        /// </summary>
        [NameInMap("permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>The dot-separated resource key. The first segment is the APP application key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app.demo.resource_1</para>
        /// </summary>
        [NameInMap("resourceKey")]
        [Validation(Required=false)]
        public string ResourceKey { get; set; }

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
        /// <para>The resource type. Set the value to APP_RESOURCE.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP_RESOURCE</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the target platform user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10086</para>
        /// </summary>
        [NameInMap("targetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant to which the target user belongs. This parameter is required for cross-tenant targets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("targetUserTenantId")]
        [Validation(Required=false)]
        public string TargetUserTenantId { get; set; }

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
