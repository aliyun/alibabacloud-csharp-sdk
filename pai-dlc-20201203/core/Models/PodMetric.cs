// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class PodMetric : TeaModel {
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<Metric> Metrics { get; set; }

        [NameInMap("PodId")]
        [Validation(Required=false)]
        public string PodId { get; set; }

    }

}
