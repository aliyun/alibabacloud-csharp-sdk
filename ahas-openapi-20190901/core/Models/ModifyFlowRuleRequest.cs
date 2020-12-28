// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ModifyFlowRuleRequest : TeaModel {
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        [NameInMap("RelationStrategy")]
        [Validation(Required=false)]
        public int? RelationStrategy { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        [NameInMap("LimitOrigin")]
        [Validation(Required=false)]
        public string LimitOrigin { get; set; }

        [NameInMap("RefResource")]
        [Validation(Required=false)]
        public string RefResource { get; set; }

        [NameInMap("ControlBehavior")]
        [Validation(Required=false)]
        public string ControlBehavior { get; set; }

        [NameInMap("WarmUpPeriodSec")]
        [Validation(Required=false)]
        public int? WarmUpPeriodSec { get; set; }

        [NameInMap("MaxQueueingTimeMs")]
        [Validation(Required=false)]
        public int? MaxQueueingTimeMs { get; set; }

        [NameInMap("AhasRegionId")]
        [Validation(Required=false)]
        public string AhasRegionId { get; set; }

    }

}
