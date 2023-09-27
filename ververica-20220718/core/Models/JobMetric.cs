// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobMetric : TeaModel {
        [NameInMap("totalCpu")]
        [Validation(Required=false)]
        public double? TotalCpu { get; set; }

        [NameInMap("totalMemoryByte")]
        [Validation(Required=false)]
        public long? TotalMemoryByte { get; set; }

    }

}
