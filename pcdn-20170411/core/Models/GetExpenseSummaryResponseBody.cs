// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetExpenseSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetExpenseSummaryResponseBodyData Data { get; set; }
        public class GetExpenseSummaryResponseBodyData : TeaModel {
            [NameInMap("ForecastFluency")]
            [Validation(Required=false)]
            public float? ForecastFluency { get; set; }
            [NameInMap("TopBandwidth")]
            [Validation(Required=false)]
            public long? TopBandwidth { get; set; }
            [NameInMap("TotalTraffic")]
            [Validation(Required=false)]
            public long? TotalTraffic { get; set; }
            [NameInMap("CoverRate")]
            [Validation(Required=false)]
            public float? CoverRate { get; set; }
            [NameInMap("ShareRate")]
            [Validation(Required=false)]
            public float? ShareRate { get; set; }
            [NameInMap("TotalUV")]
            [Validation(Required=false)]
            public int? TotalUV { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
