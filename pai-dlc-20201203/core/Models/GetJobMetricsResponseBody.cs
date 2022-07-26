// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobMetricsResponseBody : TeaModel {
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("PodMetrics")]
        [Validation(Required=false)]
        public List<PodMetric> PodMetrics { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
