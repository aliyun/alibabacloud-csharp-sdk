// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateGraphRequest : TeaModel {
        /// <summary>
        /// <para>业务说明（可选）</para>
        /// 
        /// <b>Example:</b>
        /// <para>客户域语义图谱</para>
        /// </summary>
        [NameInMap("businessProfile")]
        [Validation(Required=false)]
        public string BusinessProfile { get; set; }

        /// <summary>
        /// <para>绑定的数据源 ID（控制台已创建的 RDB 类数据源）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>198001</para>
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>图谱展示名（可选，租户内大小写不敏感唯一，最多200字）</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRM 图谱</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>图谱名称，字母开头+字母/数字/下划线，长度不超过64，租户内唯一</para>
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
