// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class QuerySlotMetricsResponseBody : TeaModel {
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<Metric> Metrics { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
