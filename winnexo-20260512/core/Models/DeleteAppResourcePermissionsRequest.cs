// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class DeleteAppResourcePermissionsRequest : TeaModel {
        /// <summary>
        /// <para>撤权范围</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DeleteAppResourcePermissionsRequestItems> Items { get; set; }
        public class DeleteAppResourcePermissionsRequestItems : TeaModel {
            /// <summary>
            /// <para>GRANTEE 主体 ID 列表</para>
            /// </summary>
            [NameInMap("granteeIds")]
            [Validation(Required=false)]
            public List<string> GranteeIds { get; set; }

            /// <summary>
            /// <para>GRANTEE USER 所属租户；同资源租户可省略，跨租户 USER 必填</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("granteeTenantId")]
            [Validation(Required=false)]
            public string GranteeTenantId { get; set; }

            /// <summary>
            /// <para>GRANTEE 主体类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("granteeType")]
            [Validation(Required=false)]
            public string GranteeType { get; set; }

            /// <summary>
            /// <para>RESOURCE 是否包含点分后代资源；省略为 false</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("includeDescendants")]
            [Validation(Required=false)]
            public bool? IncludeDescendants { get; set; }

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

            /// <summary>
            /// <para>删除范围：按资源或按主体</para>
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
