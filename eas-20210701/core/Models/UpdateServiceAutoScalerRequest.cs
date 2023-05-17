// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceAutoScalerRequest : TeaModel {
        [NameInMap("behavior")]
        [Validation(Required=false)]
        public UpdateServiceAutoScalerRequestBehavior Behavior { get; set; }
        public class UpdateServiceAutoScalerRequestBehavior : TeaModel {
            [NameInMap("onZero")]
            [Validation(Required=false)]
            public UpdateServiceAutoScalerRequestBehaviorOnZero OnZero { get; set; }
            public class UpdateServiceAutoScalerRequestBehaviorOnZero : TeaModel {
                [NameInMap("scaleDownGracePeriodSeconds")]
                [Validation(Required=false)]
                public int? ScaleDownGracePeriodSeconds { get; set; }

                [NameInMap("scaleUpActivationReplicas")]
                [Validation(Required=false)]
                public int? ScaleUpActivationReplicas { get; set; }

            }

            [NameInMap("scaleDown")]
            [Validation(Required=false)]
            public UpdateServiceAutoScalerRequestBehaviorScaleDown ScaleDown { get; set; }
            public class UpdateServiceAutoScalerRequestBehaviorScaleDown : TeaModel {
                [NameInMap("stabilizationWindowSeconds")]
                [Validation(Required=false)]
                public int? StabilizationWindowSeconds { get; set; }

            }

            [NameInMap("scaleUp")]
            [Validation(Required=false)]
            public UpdateServiceAutoScalerRequestBehaviorScaleUp ScaleUp { get; set; }
            public class UpdateServiceAutoScalerRequestBehaviorScaleUp : TeaModel {
                [NameInMap("stabilizationWindowSeconds")]
                [Validation(Required=false)]
                public int? StabilizationWindowSeconds { get; set; }

            }

        }

        [NameInMap("max")]
        [Validation(Required=false)]
        public int? Max { get; set; }

        [NameInMap("min")]
        [Validation(Required=false)]
        public int? Min { get; set; }

        [NameInMap("scaleStrategies")]
        [Validation(Required=false)]
        public List<UpdateServiceAutoScalerRequestScaleStrategies> ScaleStrategies { get; set; }
        public class UpdateServiceAutoScalerRequestScaleStrategies : TeaModel {
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

    }

}
