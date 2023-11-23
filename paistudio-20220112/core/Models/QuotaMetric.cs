// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaMetric : TeaModel {
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<Metric> Metrics { get; set; }

    }

}
