// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceAutoScalerRequest : TeaModel {
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
