// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class DeleteAppResourcePermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The scope of permission revocation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DeleteAppResourcePermissionsRequestItems> Items { get; set; }
        public class DeleteAppResourcePermissionsRequestItems : TeaModel {
            /// <summary>
            /// <para>The list of grantee principal IDs.</para>
            /// </summary>
            [NameInMap("granteeIds")]
            [Validation(Required=false)]
            public List<string> GranteeIds { get; set; }

            /// <summary>
            /// <para>The tenant to which the grantee user belongs. This parameter can be omitted if the user belongs to the same tenant as the resource, and is required for cross-tenant users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("granteeTenantId")]
            [Validation(Required=false)]
            public string GranteeTenantId { get; set; }

            /// <summary>
            /// <para>The type of the grantee principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("granteeType")]
            [Validation(Required=false)]
            public string GranteeType { get; set; }

            /// <summary>
            /// <para>Specifies whether the resource includes dot-separated descendant resources. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("includeDescendants")]
            [Validation(Required=false)]
            public bool? IncludeDescendants { get; set; }

            /// <summary>
            /// <para>The dot-separated resource key whose first segment is the APP application key.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app.demo.resource_1</para>
            /// </summary>
            [NameInMap("resourceKey")]
            [Validation(Required=false)]
            public string ResourceKey { get; set; }

            /// <summary>
            /// <para>The resource type. Fixed to APP_RESOURCE.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APP_RESOURCE</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The deletion scope: by resource or by principal.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RESOURCE</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

        }

        /// <summary>
        /// <para>The scope of permission revocation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("resourceTenantId")]
        [Validation(Required=false)]
        public string ResourceTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant to which the resource belongs. If omitted, the current tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
