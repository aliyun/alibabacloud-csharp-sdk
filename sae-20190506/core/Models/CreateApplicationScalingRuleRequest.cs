// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationScalingRuleRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        [NameInMap("ScalingRuleEnable")]
        [Validation(Required=false)]
        public bool? ScalingRuleEnable { get; set; }

        [NameInMap("ScalingRuleMetric")]
        [Validation(Required=false)]
        public string ScalingRuleMetric { get; set; }

        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        [NameInMap("ScalingRuleTimer")]
        [Validation(Required=false)]
        public string ScalingRuleTimer { get; set; }

        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

    }

}
