// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEscalationStruct : TeaModel {
        /// <summary>
        /// <para>Creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>When an alert is not acknowledged, notify the operations team, on-duty manager, and CTO sequentially.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Event Escalation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52631388567</para>
        /// </summary>
        [NameInMap("incidentEscalationId")]
        [Validation(Required=false)]
        public string IncidentEscalationId { get; set; }

        /// <summary>
        /// <para>Modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("modifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production Environment Alert Escalation Policy.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Phase.</para>
        /// </summary>
        [NameInMap("stage")]
        [Validation(Required=false)]
        public List<IncidentEscalationStageStruct> Stage { get; set; }

        /// <summary>
        /// <para>Workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
