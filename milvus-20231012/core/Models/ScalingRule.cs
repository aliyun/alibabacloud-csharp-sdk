// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class ScalingRule : TeaModel {
        [NameInMap("adjustInfos")]
        [Validation(Required=false)]
        public List<ScalingRuleAdjustInfos> AdjustInfos { get; set; }
        public class ScalingRuleAdjustInfos : TeaModel {
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("targetValue")]
            [Validation(Required=false)]
            public string TargetValue { get; set; }

        }

        [NameInMap("cronStr")]
        [Validation(Required=false)]
        public string CronStr { get; set; }

        [NameInMap("disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("scalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
