// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateLogstashChargeTypeRequest : TeaModel {
        [NameInMap("paymentInfo")]
        [Validation(Required=false)]
        public UpdateLogstashChargeTypeRequestPaymentInfo PaymentInfo { get; set; }
        public class UpdateLogstashChargeTypeRequestPaymentInfo : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }
            [NameInMap("pricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }
        };

        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
