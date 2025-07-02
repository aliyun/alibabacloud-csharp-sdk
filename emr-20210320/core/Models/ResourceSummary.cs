// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ResourceSummary : TeaModel {
        [NameInMap("InefficientTaskRate")]
        [Validation(Required=false)]
        public DoubleMetric InefficientTaskRate { get; set; }

        [NameInMap("MemoryUtilizationRate")]
        [Validation(Required=false)]
        public DoubleMetric MemoryUtilizationRate { get; set; }

        [NameInMap("OriginalTotalVcore")]
        [Validation(Required=false)]
        public IntegerMetric OriginalTotalVcore { get; set; }

        [NameInMap("VcoreUtilizationRate")]
        [Validation(Required=false)]
        public DoubleMetric VcoreUtilizationRate { get; set; }

    }

}
