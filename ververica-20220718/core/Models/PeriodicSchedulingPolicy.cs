// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class PeriodicSchedulingPolicy : TeaModel {
        [NameInMap("isFinished")]
        [Validation(Required=false)]
        public bool? IsFinished { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1723195800000</para>
        /// </summary>
        [NameInMap("onlyOnceTriggerTime")]
        [Validation(Required=false)]
        public long? OnlyOnceTriggerTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("onlyOnceTriggerTimeIsExpired")]
        [Validation(Required=false)]
        public bool? OnlyOnceTriggerTimeIsExpired { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("periodicSchedulingLevel")]
        [Validation(Required=false)]
        public string PeriodicSchedulingLevel { get; set; }

        [NameInMap("periodicSchedulingValues")]
        [Validation(Required=false)]
        public List<int?> PeriodicSchedulingValues { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1723199340000</para>
        /// </summary>
        [NameInMap("periodicTriggerTime")]
        [Validation(Required=false)]
        public long? PeriodicTriggerTime { get; set; }

        [NameInMap("resourceSetting")]
        [Validation(Required=false)]
        public BriefResourceSetting ResourceSetting { get; set; }

    }

}
