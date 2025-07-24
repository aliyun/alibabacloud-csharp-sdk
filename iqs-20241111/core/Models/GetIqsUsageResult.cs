// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GetIqsUsageResult : TeaModel {
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<GetIqsUsageResultRecords> Records { get; set; }
        public class GetIqsUsageResultRecords : TeaModel {
            [NameInMap("api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            [NameInMap("billingQps")]
            [Validation(Required=false)]
            public int? BillingQps { get; set; }

            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("engineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            [NameInMap("failedCalls")]
            [Validation(Required=false)]
            public int? FailedCalls { get; set; }

            [NameInMap("ladderType")]
            [Validation(Required=false)]
            public string LadderType { get; set; }

            [NameInMap("mainAccountId")]
            [Validation(Required=false)]
            public string MainAccountId { get; set; }

            [NameInMap("subAccountId")]
            [Validation(Required=false)]
            public string SubAccountId { get; set; }

            [NameInMap("successCalls")]
            [Validation(Required=false)]
            public int? SuccessCalls { get; set; }

            [NameInMap("totalCalls")]
            [Validation(Required=false)]
            public int? TotalCalls { get; set; }

            [NameInMap("valueAddedAdvanced")]
            [Validation(Required=false)]
            public int? ValueAddedAdvanced { get; set; }

            [NameInMap("valueAddedSummary")]
            [Validation(Required=false)]
            public int? ValueAddedSummary { get; set; }

        }

    }

}
