// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListABTestMetricsResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListABTestMetricsResponseBodyResult> Result { get; set; }
        public class ListABTestMetricsResponseBodyResult : TeaModel {
            [NameInMap("ctr")]
            [Validation(Required=false)]
            public float? Ctr { get; set; }

            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("experimentName")]
            [Validation(Required=false)]
            public string ExperimentName { get; set; }

            [NameInMap("ipv")]
            [Validation(Required=false)]
            public int? Ipv { get; set; }

            [NameInMap("ipvUv")]
            [Validation(Required=false)]
            public int? IpvUv { get; set; }

            [NameInMap("pv")]
            [Validation(Required=false)]
            public int? Pv { get; set; }

            [NameInMap("uv")]
            [Validation(Required=false)]
            public int? Uv { get; set; }

            [NameInMap("zeroHitRate")]
            [Validation(Required=false)]
            public float? ZeroHitRate { get; set; }

        }

    }

}
