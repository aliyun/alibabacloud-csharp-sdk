// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListCollaborationGroupsResponseBody : TeaModel {
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
        /// <para>[{&quot;collaborationGroupId&quot;:&quot;cg_9401&quot;,&quot;name&quot;:&quot;产品协作空间&quot;,&quot;status&quot;:&quot;ACTIVE&quot;,&quot;currentUserRole&quot;:&quot;OWNER&quot;}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListCollaborationGroupsResponseBodyItems> Items { get; set; }
        public class ListCollaborationGroupsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>协作空间ID，可用于查询空间成员、查询节点详情及预览对话文件。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg_9401</para>
            /// </summary>
            [NameInMap("collaborationGroupId")]
            [Validation(Required=false)]
            public string CollaborationGroupId { get; set; }

            /// <summary>
            /// <para>当前调用用户在空间内的角色：ADMIN为管理员，MEMBER为普通成员。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADMIN</para>
            /// </summary>
            [NameInMap("currentUserRole")]
            [Validation(Required=false)]
            public string CurrentUserRole { get; set; }

            /// <summary>
            /// <para>协作空间显示名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>工作流待办测试</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>协作空间状态，当前接口只返回ACTIVE。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>满足查询条件的有效空间总数，不是当前页记录数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>39</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
