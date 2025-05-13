// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEscalationStageStruct : TeaModel {
        [NameInMap("contact")]
        [Validation(Required=false)]
        public List<IncidentContactStruct> Contact { get; set; }

        [NameInMap("cycleNotifyCount")]
        [Validation(Required=false)]
        public int? CycleNotifyCount { get; set; }

        [NameInMap("cycleNotifyTime")]
        [Validation(Required=false)]
        public int? CycleNotifyTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("effectTime")]
        [Validation(Required=false)]
        public string EffectTime { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("stageIndex")]
        [Validation(Required=false)]
        public int? StageIndex { get; set; }

        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        [NameInMap("waitToNextStageTime")]
        [Validation(Required=false)]
        public int? WaitToNextStageTime { get; set; }

    }

}
