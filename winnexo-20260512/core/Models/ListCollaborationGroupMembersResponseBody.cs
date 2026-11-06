// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListCollaborationGroupMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>公共业务状态码，由后端Code字段映射；错误时用于识别失败原因。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERR.Robject.Auth.TenantAccessDenied</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>当前页记录列表；没有匹配记录时返回空数组。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;userId&quot;:&quot;5&quot;,&quot;displayName&quot;:&quot;张三&quot;,&quot;role&quot;:&quot;OWNER&quot;,&quot;isActive&quot;:true}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListCollaborationGroupMembersResponseBodyItems> Items { get; set; }
        public class ListCollaborationGroupMembersResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>成员显示名称；未设置时为空。</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEST001</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>租户账号是否启用。本接口只返回有效且账号启用的成员，值为true；不代表HR在职状态。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            /// <summary>
            /// <para>成员在空间内的角色：ADMIN为管理员，MEMBER为普通成员。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADMIN</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>平台用户ID，字符串形式，可用作转交待办的目标用户ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>公共错误说明，由后端Message字段映射；错误时描述失败原因。</para>
        /// 
        /// <b>Example:</b>
        /// <para>无权访问租户 2147483647，用户不属于该租户</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>当前返回页的页码，从1开始。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>当前分页设置的每页记录数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>请求追踪ID，由后端RequestId字段映射，用于排查调用失败。</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9cf6cb3-3f5c-4994-a8a1-c93379a6f5cf</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>满足查询条件的记录总数，不是当前页记录数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
