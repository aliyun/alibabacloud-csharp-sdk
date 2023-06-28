// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class TargetTrackingPolicy : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("maxCapacity")]
        [Validation(Required=false)]
        public long? MaxCapacity { get; set; }

        [NameInMap("metricTarget")]
        [Validation(Required=false)]
        public float? MetricTarget { get; set; }

        [NameInMap("metricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("minCapacity")]
        [Validation(Required=false)]
        public long? MinCapacity { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
