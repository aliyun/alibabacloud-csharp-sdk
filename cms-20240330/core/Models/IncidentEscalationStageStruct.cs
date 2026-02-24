// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEscalationStageStruct : TeaModel {
        /// <summary>
        /// <para>Contact list.</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public List<IncidentContactStruct> Contact { get; set; }

        /// <summary>
        /// <para>Number of recurring notification attempts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("cycleNotifyCount")]
        [Validation(Required=false)]
        public int? CycleNotifyCount { get; set; }

        /// <summary>
        /// <para>Recurring notification interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("cycleNotifyTime")]
        [Validation(Required=false)]
        public int? CycleNotifyTime { get; set; }

        /// <summary>
        /// <para>Description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Primary owner responsible for handling production environment alerts.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Effective time period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-05T00:00:00Z</para>
        /// </summary>
        [NameInMap("effectTime")]
        [Validation(Required=false)]
        public string EffectTime { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operations team.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Phase index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("stageIndex")]
        [Validation(Required=false)]
        public int? StageIndex { get; set; }

        /// <summary>
        /// <para>Time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>Time to wait before proceeding to the next phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("waitToNextStageTime")]
        [Validation(Required=false)]
        public int? WaitToNextStageTime { get; set; }

    }

}
