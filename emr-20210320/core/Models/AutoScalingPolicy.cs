// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AutoScalingPolicy : TeaModel {
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public AutoScalingPolicyConstraints Constraints { get; set; }
        public class AutoScalingPolicyConstraints : TeaModel {
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public int? MaxCapacity { get; set; }

            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public int? MinCapacity { get; set; }

        }

        [NameInMap("ScalingRules")]
        [Validation(Required=false)]
        public List<ScalingRule> ScalingRules { get; set; }

    }

}
