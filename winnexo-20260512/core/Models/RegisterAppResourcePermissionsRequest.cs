// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RegisterAppResourcePermissionsRequest : TeaModel {
        /// <summary>
        /// <para>批量授权项</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<RegisterAppResourcePermissionsRequestItems> Items { get; set; }
        public class RegisterAppResourcePermissionsRequestItems : TeaModel {
            /// <summary>
            /// <para>带时区的到期时间；省略表示永久</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-12-31T23:59:59+08:00</para>
            /// </summary>
            [NameInMap("expireAt")]
            [Validation(Required=false)]
            public string ExpireAt { get; set; }

            /// <summary>
            /// <para>被授权主体</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("grantees")]
            [Validation(Required=false)]
            public List<RegisterAppResourcePermissionsRequestItemsGrantees> Grantees { get; set; }
            public class RegisterAppResourcePermissionsRequestItemsGrantees : TeaModel {
                /// <summary>
                /// <para>主体 ID；ALL_USERS 省略</para>
                /// 
                /// <b>Example:</b>
                /// <para>10086</para>
                /// </summary>
                [NameInMap("granteeId")]
                [Validation(Required=false)]
                public string GranteeId { get; set; }

                /// <summary>
                /// <para>跨租户 USER 所属租户</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("granteeTenantId")]
                [Validation(Required=false)]
                public string GranteeTenantId { get; set; }

                /// <summary>
                /// <para>主体类型</para>
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
            /// <para>授权权限点</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("permissions")]
            [Validation(Required=false)]
            public List<string> Permissions { get; set; }

            /// <summary>
            /// <para>首段为 APP 应用键的点分资源键</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app.demo.resource_1</para>
            /// </summary>
            [NameInMap("resourceKey")]
            [Validation(Required=false)]
            public string ResourceKey { get; set; }

            /// <summary>
            /// <para>固定为 APP_RESOURCE</para>
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
        /// <para>资源所属租户 ID；省略为调用人当前租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("resourceTenantId")]
        [Validation(Required=false)]
        public string ResourceTenantId { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
