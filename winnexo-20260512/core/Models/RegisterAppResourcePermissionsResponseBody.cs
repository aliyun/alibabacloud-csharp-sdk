// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RegisterAppResourcePermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码；成功为 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>错误描述；成功时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>新建或幂等命中的权限记录</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<RegisterAppResourcePermissionsResponseBodyRecords> Records { get; set; }
        public class RegisterAppResourcePermissionsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-16T10:30:00+08:00</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>到期时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-12-31T23:59:59+08:00</para>
            /// </summary>
            [NameInMap("expireAt")]
            [Validation(Required=false)]
            public string ExpireAt { get; set; }

            /// <summary>
            /// <para>授权人平台用户 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10086</para>
            /// </summary>
            [NameInMap("grantedBy")]
            [Validation(Required=false)]
            public string GrantedBy { get; set; }

            /// <summary>
            /// <para>主体 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10086</para>
            /// </summary>
            [NameInMap("granteeId")]
            [Validation(Required=false)]
            public string GranteeId { get; set; }

            /// <summary>
            /// <para>主体名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("granteeName")]
            [Validation(Required=false)]
            public string GranteeName { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("granteeType")]
            [Validation(Required=false)]
            public string GranteeType { get; set; }

            /// <summary>
            /// <para>权限点</para>
            /// 
            /// <b>Example:</b>
            /// <para>APP/VIEW</para>
            /// </summary>
            [NameInMap("permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            /// <summary>
            /// <para>权限记录 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("permissionId")]
            [Validation(Required=false)]
            public long? PermissionId { get; set; }

            /// <summary>
            /// <para>资源键</para>
            /// 
            /// <b>Example:</b>
            /// <para>app.demo.resource_1</para>
            /// </summary>
            [NameInMap("resourceKey")]
            [Validation(Required=false)]
            public string ResourceKey { get; set; }

            /// <summary>
            /// <para>资源类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>APP_RESOURCE</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>更新时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-16T10:30:00+08:00</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
