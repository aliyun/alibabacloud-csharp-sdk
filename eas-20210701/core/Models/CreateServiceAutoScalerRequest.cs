// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceAutoScalerRequest : TeaModel {
        [NameInMap("behavior")]
        [Validation(Required=false)]
        public CreateServiceAutoScalerRequestBehavior Behavior { get; set; }
        public class CreateServiceAutoScalerRequestBehavior : TeaModel {
            [NameInMap("onZero")]
            [Validation(Required=false)]
            public CreateServiceAutoScalerRequestBehaviorOnZero OnZero { get; set; }
            public class CreateServiceAutoScalerRequestBehaviorOnZero : TeaModel {
                [NameInMap("scaleDownGracePeriodSeconds")]
                [Validation(Required=false)]
                public int? ScaleDownGracePeriodSeconds { get; set; }

                [NameInMap("scaleUpActivationReplicas")]
                [Validation(Required=false)]
                public int? ScaleUpActivationReplicas { get; set; }

            }

            [NameInMap("scaleDown")]
            [Validation(Required=false)]
            public CreateServiceAutoScalerRequestBehaviorScaleDown ScaleDown { get; set; }
            public class CreateServiceAutoScalerRequestBehaviorScaleDown : TeaModel {
                [NameInMap("stabilizationWindowSeconds")]
                [Validation(Required=false)]
                public int? StabilizationWindowSeconds { get; set; }

            }

            [NameInMap("scaleUp")]
            [Validation(Required=false)]
            public CreateServiceAutoScalerRequestBehaviorScaleUp ScaleUp { get; set; }
            public class CreateServiceAutoScalerRequestBehaviorScaleUp : TeaModel {
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
        public List<CreateServiceAutoScalerRequestScaleStrategies> ScaleStrategies { get; set; }
        public class CreateServiceAutoScalerRequestScaleStrategies : TeaModel {
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
