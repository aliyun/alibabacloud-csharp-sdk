// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorMetricResult : TeaModel {
        [NameInMap("measureData")]
        [Validation(Required=false)]
        public List<MonitorMetricMeasureData> MeasureData { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
