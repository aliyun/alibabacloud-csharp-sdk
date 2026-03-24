// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEscalationStruct : TeaModel {
        /// <summary>
        /// <para>创建时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>描述。</para>
        /// 
        /// <b>Example:</b>
        /// <para>当告警未响应时，依次通知运维团队、值班经理、CTO</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>事件升级ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>52631388567</para>
        /// </summary>
        [NameInMap("incidentEscalationId")]
        [Validation(Required=false)]
        public string IncidentEscalationId { get; set; }

        /// <summary>
        /// <para>修改时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("modifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>生产环境告警升级策略</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>地域 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>阶段。</para>
        /// </summary>
        [NameInMap("stage")]
        [Validation(Required=false)]
        public List<IncidentEscalationStageStruct> Stage { get; set; }

        /// <summary>
        /// <para>工作空间</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
