// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class QueryWorkItemFeedShrinkRequest : TeaModel {
        /// <summary>
        /// <para>业务状态筛选（七态）</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("businessStatuses")]
        [Validation(Required=false)]
        public string BusinessStatusesShrink { get; set; }

        /// <summary>
        /// <para>协作空间 ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_example</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>翻页游标，取上次响应的 nextCursor</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <para>工作项类型筛选</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("itemTypes")]
        [Validation(Required=false)]
        public string ItemTypesShrink { get; set; }

        /// <summary>
        /// <para>标题/描述模糊搜索关键词</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>单页条数（1~100）</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>优先级筛选</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("priorities")]
        [Validation(Required=false)]
        public string PrioritiesShrink { get; set; }

        /// <summary>
        /// <para>个人范围筛选</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSIGNED_TO_ME</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>来源任务ID；指定时返回该任务平铺子项</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceTaskId")]
        [Validation(Required=false)]
        public string SourceTaskId { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>视图：FLAT 平铺 / TREE 任务分组</para>
        /// 
        /// <b>Example:</b>
        /// <para>FLAT</para>
        /// </summary>
        [NameInMap("view")]
        [Validation(Required=false)]
        public string View { get; set; }

    }

}
