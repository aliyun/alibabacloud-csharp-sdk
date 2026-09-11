// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateGraphInfoRequest : TeaModel {
        /// <summary>
        /// <para>业务说明（可选；传空串表示清空；与 displayName 至少传其一）</para>
        /// 
        /// <b>Example:</b>
        /// <para>客户域语义图谱</para>
        /// </summary>
        [NameInMap("businessProfile")]
        [Validation(Required=false)]
        public string BusinessProfile { get; set; }

        /// <summary>
        /// <para>图谱展示名（可选，最多200字；传空串或纯空白会被拒绝；与 businessProfile 至少传其一）</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRM 图谱</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>图谱名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_graph</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

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
