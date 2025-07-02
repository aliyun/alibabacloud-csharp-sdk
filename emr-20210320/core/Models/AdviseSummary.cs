// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AdviseSummary : TeaModel {
        [NameInMap("MemoryUtilizationRate")]
        [Validation(Required=false)]
        public DoubleMetric MemoryUtilizationRate { get; set; }

        [NameInMap("VcoreUtilizationRate")]
        [Validation(Required=false)]
        public DoubleMetric VcoreUtilizationRate { get; set; }

    }

}
