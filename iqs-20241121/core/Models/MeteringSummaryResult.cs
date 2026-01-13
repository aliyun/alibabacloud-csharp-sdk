// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class MeteringSummaryResult : TeaModel {
        [NameInMap("meteringSummaryList")]
        [Validation(Required=false)]
        public List<MeteringSummaryResultMeteringSummaryList> MeteringSummaryList { get; set; }
        public class MeteringSummaryResultMeteringSummaryList : TeaModel {
            [NameInMap("billingFunctionItem")]
            [Validation(Required=false)]
            public string BillingFunctionItem { get; set; }

            [NameInMap("billingItem")]
            [Validation(Required=false)]
            public string BillingItem { get; set; }

            [NameInMap("failCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            [NameInMap("successCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

        }

    }

}
