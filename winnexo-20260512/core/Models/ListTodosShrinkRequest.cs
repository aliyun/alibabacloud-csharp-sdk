// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListTodosShrinkRequest : TeaModel {
        /// <summary>
        /// <para>协作空间 ID（可选过滤；不传 = 全部空间）</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>标题/摘要模糊搜索关键词</para>
        /// 
        /// <b>Example:</b>
        /// <para>审批</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>单页最大返回数量（1~100）；传入时优先于 pageSize</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>翻页令牌，取上次响应返回的 nextToken；传入时优先于 page</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>页码；传入 nextToken 时忽略</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>每页条数（1~100）</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>优先级筛选（HIGH/MEDIUM/LOW）</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIGH</para>
        /// </summary>
        [NameInMap("priorities")]
        [Validation(Required=false)]
        public string PrioritiesShrink { get; set; }

        /// <summary>
        /// <para>读取状态筛选（UNREAD/READ，按处理人 readAt 判定）</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNREAD</para>
        /// </summary>
        [NameInMap("readStatus")]
        [Validation(Required=false)]
        public string ReadStatusShrink { get; set; }

        /// <summary>
        /// <para>排序方式</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>待办类型筛选（WORKFLOW/OPEN_API）</para>
        /// 
        /// <b>Example:</b>
        /// <para>WORKFLOW</para>
        /// </summary>
        [NameInMap("sourceTypes")]
        [Validation(Required=false)]
        public string SourceTypesShrink { get; set; }

        /// <summary>
        /// <para>待办状态筛选（PENDING/COMPLETED/CANCELLED）</para>
        /// 
        /// <b>Example:</b>
        /// <para>PENDING</para>
        /// </summary>
        [NameInMap("statuses")]
        [Validation(Required=false)]
        public string StatusesShrink { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
