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

        [NameInMap("onlyOnceTriggerTime")]
        [Validation(Required=false)]
        public long? OnlyOnceTriggerTime { get; set; }

        [NameInMap("onlyOnceTriggerTimeIsExpired")]
        [Validation(Required=false)]
        public bool? OnlyOnceTriggerTimeIsExpired { get; set; }

        [NameInMap("periodicSchedulingLevel")]
        [Validation(Required=false)]
        public string PeriodicSchedulingLevel { get; set; }

        [NameInMap("periodicSchedulingValues")]
        [Validation(Required=false)]
        public List<int?> PeriodicSchedulingValues { get; set; }

        [NameInMap("periodicTriggerTime")]
        [Validation(Required=false)]
        public long? PeriodicTriggerTime { get; set; }

        [NameInMap("resourceSetting")]
        [Validation(Required=false)]
        public BriefResourceSetting ResourceSetting { get; set; }

    }

}
