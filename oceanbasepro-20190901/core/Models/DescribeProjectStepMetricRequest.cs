// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProjectStepMetricRequest : TeaModel {
        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public string Aggregator { get; set; }

        [NameInMap("BeginTimestamp")]
        [Validation(Required=false)]
        public long? BeginTimestamp { get; set; }

        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        [NameInMap("MaxPointNum")]
        [Validation(Required=false)]
        public int? MaxPointNum { get; set; }

        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

    }

}
