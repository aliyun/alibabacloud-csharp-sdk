// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AutoScalingSpec : TeaModel {
        [NameInMap("AutoscalingMetricSpec")]
        [Validation(Required=false)]
        public AutoscalingMetricSpec AutoscalingMetricSpec { get; set; }

        [NameInMap("MaxReplicas")]
        [Validation(Required=false)]
        public int? MaxReplicas { get; set; }

        [NameInMap("MinReplicas")]
        [Validation(Required=false)]
        public int? MinReplicas { get; set; }

        [NameInMap("PodsToDelete")]
        [Validation(Required=false)]
        public List<string> PodsToDelete { get; set; }

        [NameInMap("ScalingStrategy")]
        [Validation(Required=false)]
        public string ScalingStrategy { get; set; }

    }

}
