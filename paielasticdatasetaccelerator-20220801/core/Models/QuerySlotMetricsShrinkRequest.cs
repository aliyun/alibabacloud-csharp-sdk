// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class QuerySlotMetricsShrinkRequest : TeaModel {
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string DimensionsShrink { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TimeStep")]
        [Validation(Required=false)]
        public string TimeStep { get; set; }

    }

}
