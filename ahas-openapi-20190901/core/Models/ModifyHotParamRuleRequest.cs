// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ModifyHotParamRuleRequest : TeaModel {
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public int? MetricType { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        [NameInMap("ParamIdx")]
        [Validation(Required=false)]
        public int? ParamIdx { get; set; }

        [NameInMap("StatDurationSec")]
        [Validation(Required=false)]
        public long? StatDurationSec { get; set; }

        [NameInMap("ControlBehavior")]
        [Validation(Required=false)]
        public int? ControlBehavior { get; set; }

        [NameInMap("BurstCount")]
        [Validation(Required=false)]
        public int? BurstCount { get; set; }

        [NameInMap("MaxQueueingTimeMs")]
        [Validation(Required=false)]
        public int? MaxQueueingTimeMs { get; set; }

        [NameInMap("AhasRegionId")]
        [Validation(Required=false)]
        public string AhasRegionId { get; set; }

    }

}
