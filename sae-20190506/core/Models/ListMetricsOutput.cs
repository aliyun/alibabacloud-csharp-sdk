// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListMetricsOutput : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("metrics")]
        [Validation(Required=false)]
        public Dictionary<string, List<MetricInfo>> Metrics { get; set; }

    }

}
