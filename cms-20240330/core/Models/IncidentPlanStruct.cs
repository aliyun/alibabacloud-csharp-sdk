// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentPlanStruct : TeaModel {
        /// <summary>
        /// <para>自动恢复等待时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public int? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <para>事件关闭超时时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400000</para>
        /// </summary>
        [NameInMap("closeExpire")]
        [Validation(Required=false)]
        public long? CloseExpire { get; set; }

        /// <summary>
        /// <para>参与协作的团队或角色列表。</para>
        /// </summary>
        [NameInMap("corporation")]
        [Validation(Required=false)]
        public List<IncidentPlanCorporationStruct> Corporation { get; set; }

        /// <summary>
        /// <para>预案描述。</para>
        /// 
        /// <b>Example:</b>
        /// <para>针对数据库连接数过高的应急处理方案</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>升级策略 ID的列表。</para>
        /// </summary>
        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        /// <summary>
        /// <para>创建时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>最后修改时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>分组字段路径</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<IncidentPlanFieldPath> GroupBy { get; set; }

        /// <summary>
        /// <para>事件预案 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan-001</para>
        /// </summary>
        [NameInMap("incidentPlanId")]
        [Validation(Required=false)]
        public string IncidentPlanId { get; set; }

        /// <summary>
        /// <para>预案名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据库连接数告警预案</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>资源字段映射路径的列表。</para>
        /// </summary>
        [NameInMap("resourceFiled")]
        [Validation(Required=false)]
        public List<IncidentPlanFieldPath> ResourceFiled { get; set; }

        /// <summary>
        /// <para>状态。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>用户 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>uesr-12345</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// <para>工作空间名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
