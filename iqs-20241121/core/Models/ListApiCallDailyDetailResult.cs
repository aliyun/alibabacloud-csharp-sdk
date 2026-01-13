// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class ListApiCallDailyDetailResult : TeaModel {
        [NameInMap("details")]
        [Validation(Required=false)]
        public List<ListApiCallDailyDetailResultDetails> Details { get; set; }
        public class ListApiCallDailyDetailResultDetails : TeaModel {
            [NameInMap("apiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            [NameInMap("avgLatency")]
            [Validation(Required=false)]
            public int? AvgLatency { get; set; }

            [NameInMap("billDate")]
            [Validation(Required=false)]
            public string BillDate { get; set; }

            [NameInMap("engineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            [NameInMap("failedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            [NameInMap("p90Latency")]
            [Validation(Required=false)]
            public int? P90Latency { get; set; }

            [NameInMap("p95Latency")]
            [Validation(Required=false)]
            public int? P95Latency { get; set; }

            [NameInMap("requestMaxQps")]
            [Validation(Required=false)]
            public int? RequestMaxQps { get; set; }

            [NameInMap("subAccountId")]
            [Validation(Required=false)]
            public string SubAccountId { get; set; }

            [NameInMap("successCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

        }

    }

}
