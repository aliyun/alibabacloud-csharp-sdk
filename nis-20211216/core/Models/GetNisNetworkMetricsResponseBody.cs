// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNisNetworkMetricsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNisNetworkMetricsResponseBodyData Data { get; set; }
        public class GetNisNetworkMetricsResponseBodyData : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<GetNisNetworkMetricsResponseBodyDataMetrics> Metrics { get; set; }
            public class GetNisNetworkMetricsResponseBodyDataMetrics : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public long? TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
