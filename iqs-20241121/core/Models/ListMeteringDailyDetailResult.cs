// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class ListMeteringDailyDetailResult : TeaModel {
        [NameInMap("meteringDailyDetailList")]
        [Validation(Required=false)]
        public List<ListMeteringDailyDetailResultMeteringDailyDetailList> MeteringDailyDetailList { get; set; }
        public class ListMeteringDailyDetailResultMeteringDailyDetailList : TeaModel {
            [NameInMap("billDate")]
            [Validation(Required=false)]
            public string BillDate { get; set; }

            [NameInMap("billPeriod")]
            [Validation(Required=false)]
            public string BillPeriod { get; set; }

            [NameInMap("billingFunctionItem")]
            [Validation(Required=false)]
            public string BillingFunctionItem { get; set; }

            [NameInMap("billingItem")]
            [Validation(Required=false)]
            public string BillingItem { get; set; }

            [NameInMap("billingQps")]
            [Validation(Required=false)]
            public int? BillingQps { get; set; }

            [NameInMap("failedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            [NameInMap("ladderTypeCode")]
            [Validation(Required=false)]
            public int? LadderTypeCode { get; set; }

            [NameInMap("subAccountId")]
            [Validation(Required=false)]
            public string SubAccountId { get; set; }

            [NameInMap("successCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

        }

    }

}
