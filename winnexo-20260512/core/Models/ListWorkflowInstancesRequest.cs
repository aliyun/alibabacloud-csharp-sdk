// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListWorkflowInstancesRequest : TeaModel {
        /// <summary>
        /// <para>精确需求编号</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQ-1001</para>
        /// </summary>
        [NameInMap("businessId")]
        [Validation(Required=false)]
        public string BusinessId { get; set; }

        /// <summary>
        /// <para>协作空间 ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_20261016_abc123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>精确外部发起人标签</para>
        /// 
        /// <b>Example:</b>
        /// <para>外部发起人张三</para>
        /// </summary>
        [NameInMap("initiator")]
        [Validation(Required=false)]
        public string Initiator { get; set; }

        /// <summary>
        /// <para>标题或需求编号关键词</para>
        /// 
        /// <b>Example:</b>
        /// <para>季度报告</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>页码，从 1 开始</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>每页数量 1-100</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>排序字段</para>
        /// 
        /// <b>Example:</b>
        /// <para>GMT_CREATE</para>
        /// </summary>
        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>排序方向</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("sortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>Running/Completed/Failed/Terminated 筛选</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；winnexo-cli 通过 --tenant-id 显式传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
