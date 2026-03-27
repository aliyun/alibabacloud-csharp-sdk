// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEscalationStageForView : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("cycleNotifyCount")]
        [Validation(Required=false)]
        public int? CycleNotifyCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("cycleNotifyInterval")]
        [Validation(Required=false)]
        public int? CycleNotifyInterval { get; set; }

        [NameInMap("effectTimeRange")]
        [Validation(Required=false)]
        public EffectTimeRange EffectTimeRange { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        [NameInMap("notifyChannels")]
        [Validation(Required=false)]
        public List<NotifyChannel> NotifyChannels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Open&quot;</para>
        /// </summary>
        [NameInMap("targetIncidentState")]
        [Validation(Required=false)]
        public string TargetIncidentState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("triggerDelay")]
        [Validation(Required=false)]
        public int? TriggerDelay { get; set; }

    }

}
