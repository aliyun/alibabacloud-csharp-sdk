// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RegisterAppResourcePermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The batch authorization items.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<RegisterAppResourcePermissionsRequestItems> Items { get; set; }
        public class RegisterAppResourcePermissionsRequestItems : TeaModel {
            /// <summary>
            /// <para>The expiration time with the time zone. If not specified, the permissions never expire.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-12-31T23:59:59+08:00</para>
            /// </summary>
            [NameInMap("expireAt")]
            [Validation(Required=false)]
            public string ExpireAt { get; set; }

            /// <summary>
            /// <para>The authorized principals.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("grantees")]
            [Validation(Required=false)]
            public List<RegisterAppResourcePermissionsRequestItemsGrantees> Grantees { get; set; }
            public class RegisterAppResourcePermissionsRequestItemsGrantees : TeaModel {
                /// <summary>
                /// <para>The principal ID. Omit this parameter for ALL_USERS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10086</para>
                /// </summary>
                [NameInMap("granteeId")]
                [Validation(Required=false)]
                public string GranteeId { get; set; }

                /// <summary>
                /// <para>The tenant to which the cross-tenant USER belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("granteeTenantId")]
                [Validation(Required=false)]
                public string GranteeTenantId { get; set; }

                /// <summary>
                /// <para>The principal type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("granteeType")]
                [Validation(Required=false)]
                public string GranteeType { get; set; }

            }

            /// <summary>
            /// <para>The granted permissions.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("permissions")]
            [Validation(Required=false)]
            public List<string> Permissions { get; set; }

            /// <summary>
            /// <para>The dot-separated resource key, where the first segment is the APP application key.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app.demo.resource_1</para>
            /// </summary>
            [NameInMap("resourceKey")]
            [Validation(Required=false)]
            public string ResourceKey { get; set; }

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

        }

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
