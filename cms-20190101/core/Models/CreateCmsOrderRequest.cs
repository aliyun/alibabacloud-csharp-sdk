// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateCmsOrderRequest : TeaModel {
        [NameInMap("ApiCount")]
        [Validation(Required=false)]
        public string ApiCount { get; set; }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        [NameInMap("CustomTimeSeries")]
        [Validation(Required=false)]
        public string CustomTimeSeries { get; set; }

        [NameInMap("EventStoreNum")]
        [Validation(Required=false)]
        public string EventStoreNum { get; set; }

        [NameInMap("EventStoreTime")]
        [Validation(Required=false)]
        public string EventStoreTime { get; set; }

        [NameInMap("LogMonitorStream")]
        [Validation(Required=false)]
        public string LogMonitorStream { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("PhoneCount")]
        [Validation(Required=false)]
        public string PhoneCount { get; set; }

        [NameInMap("SiteEcsNum")]
        [Validation(Required=false)]
        public string SiteEcsNum { get; set; }

        [NameInMap("SiteOperatorNum")]
        [Validation(Required=false)]
        public string SiteOperatorNum { get; set; }

        [NameInMap("SiteTaskNum")]
        [Validation(Required=false)]
        public string SiteTaskNum { get; set; }

        [NameInMap("SmsCount")]
        [Validation(Required=false)]
        public string SmsCount { get; set; }

        [NameInMap("SuggestType")]
        [Validation(Required=false)]
        public string SuggestType { get; set; }

    }

}
