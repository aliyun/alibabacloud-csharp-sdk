// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAppResourcePermissionRecordsRequest : TeaModel {
        /// <summary>
        /// <para>主体 ID 筛选</para>
        /// 
        /// <b>Example:</b>
        /// <para>10086</para>
        /// </summary>
        [NameInMap("granteeId")]
        [Validation(Required=false)]
        public string GranteeId { get; set; }

        /// <summary>
        /// <para>跨租户 USER 所属租户筛选</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("granteeTenantId")]
        [Validation(Required=false)]
        public string GranteeTenantId { get; set; }

        /// <summary>
        /// <para>主体类型筛选</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("granteeType")]
        [Validation(Required=false)]
        public string GranteeType { get; set; }

        /// <summary>
        /// <para>页码</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>每页条数</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>权限点筛选</para>
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// <para>应用键或其子路径</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app.demo</para>
        /// </summary>
        [NameInMap("resourceKeyPrefix")]
        [Validation(Required=false)]
        public string ResourceKeyPrefix { get; set; }

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
