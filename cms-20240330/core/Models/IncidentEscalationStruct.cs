// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEscalationStruct : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1794984055029</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Notify the O&amp;M team, on-call manager, and CTO sequentially when an alert is not responded to</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The incident escalation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52631388567</para>
        /// </summary>
        [NameInMap("incidentEscalationId")]
        [Validation(Required=false)]
        public string IncidentEscalationId { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1794984055029</para>
        /// </summary>
        [NameInMap("modifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production environment alert escalation policy</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The stage.</para>
        /// </summary>
        [NameInMap("stage")]
        [Validation(Required=false)]
        public List<IncidentEscalationStageStruct> Stage { get; set; }

        /// <summary>
        /// <para>The workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
