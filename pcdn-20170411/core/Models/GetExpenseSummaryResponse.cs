// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetExpenseSummaryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetExpenseSummaryResponseData Data { get; set; }
        public class GetExpenseSummaryResponseData : TeaModel {
            [NameInMap("TotalTraffic")]
            [Validation(Required=true)]
            public long TotalTraffic { get; set; }
            [NameInMap("TotalUV")]
            [Validation(Required=true)]
            public int? TotalUV { get; set; }
            [NameInMap("ShareRate")]
            [Validation(Required=true)]
            public float? ShareRate { get; set; }
            [NameInMap("CoverRate")]
            [Validation(Required=true)]
            public float? CoverRate { get; set; }
            [NameInMap("ForecastFluency")]
            [Validation(Required=true)]
            public float? ForecastFluency { get; set; }
            [NameInMap("TopBandwidth")]
            [Validation(Required=true)]
            public long TopBandwidth { get; set; }
        };

    }

}
