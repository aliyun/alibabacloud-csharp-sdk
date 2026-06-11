// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEscalationStageStruct : TeaModel {
        /// <summary>
        /// <para>The list of contacts.</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public List<IncidentContactStruct> Contact { get; set; }

        /// <summary>
        /// <para>The number of notifications sent per cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("cycleNotifyCount")]
        [Validation(Required=false)]
        public int? CycleNotifyCount { get; set; }

        /// <summary>
        /// <para>The notification interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("cycleNotifyTime")]
        [Validation(Required=false)]
        public int? CycleNotifyTime { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>负责处理生产环境告警的主负责人</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The effective time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-05T00:00:00Z</para>
        /// </summary>
        [NameInMap("effectTime")]
        [Validation(Required=false)]
        public string EffectTime { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>运维团队</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The stage index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("stageIndex")]
        [Validation(Required=false)]
        public int? StageIndex { get; set; }

        /// <summary>
        /// <para>The time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>The waiting time before the next stage begins.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("waitToNextStageTime")]
        [Validation(Required=false)]
        public int? WaitToNextStageTime { get; set; }

    }

}
