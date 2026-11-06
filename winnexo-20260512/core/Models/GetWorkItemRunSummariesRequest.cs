// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetWorkItemRunSummariesRequest : TeaModel {
        /// <summary>
        /// <para>协作空间ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_9401</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>可选节点key；传入后只返回该节点当前轮次的总结</para>
        /// 
        /// <b>Example:</b>
        /// <para>query.amount</para>
        /// </summary>
        [NameInMap("nodeKey")]
        [Validation(Required=false)]
        public string NodeKey { get; set; }

        /// <summary>
        /// <para>租户ID；缺省使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>工作项ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wi_0123456789ab4cde</para>
        /// </summary>
        [NameInMap("workItemId")]
        [Validation(Required=false)]
        public string WorkItemId { get; set; }

    }

}
