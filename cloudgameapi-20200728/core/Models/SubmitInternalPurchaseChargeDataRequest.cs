// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class SubmitInternalPurchaseChargeDataRequest : TeaModel {
        [NameInMap("ActiveUserRetentionRateOneDay")]
        [Validation(Required=false)]
        public float? ActiveUserRetentionRateOneDay { get; set; }

        [NameInMap("ActiveUserRetentionRateSevenDay")]
        [Validation(Required=false)]
        public float? ActiveUserRetentionRateSevenDay { get; set; }

        [NameInMap("ActiveUserRetentionRateThirtyDay")]
        [Validation(Required=false)]
        public float? ActiveUserRetentionRateThirtyDay { get; set; }

        [NameInMap("Arpu")]
        [Validation(Required=false)]
        public float? Arpu { get; set; }

        [NameInMap("ChargeDate")]
        [Validation(Required=false)]
        public string ChargeDate { get; set; }

        [NameInMap("Dau")]
        [Validation(Required=false)]
        public long? Dau { get; set; }

        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

        [NameInMap("Mau")]
        [Validation(Required=false)]
        public long? Mau { get; set; }

        [NameInMap("NewUserRetentionRateOneDay")]
        [Validation(Required=false)]
        public float? NewUserRetentionRateOneDay { get; set; }

        [NameInMap("NewUserRetentionRateSevenDay")]
        [Validation(Required=false)]
        public float? NewUserRetentionRateSevenDay { get; set; }

        [NameInMap("NewUserRetentionRateThirtyDay")]
        [Validation(Required=false)]
        public float? NewUserRetentionRateThirtyDay { get; set; }

        [NameInMap("PaymentConversionRate")]
        [Validation(Required=false)]
        public float? PaymentConversionRate { get; set; }

        [NameInMap("PlayTimeAverageOneDay")]
        [Validation(Required=false)]
        public float? PlayTimeAverageOneDay { get; set; }

        [NameInMap("PlayTimeAverageThirtyDay")]
        [Validation(Required=false)]
        public float? PlayTimeAverageThirtyDay { get; set; }

        [NameInMap("PlayTimeNinetyPointsOneDay")]
        [Validation(Required=false)]
        public float? PlayTimeNinetyPointsOneDay { get; set; }

        [NameInMap("PlayTimeNinetyPointsThirtyDay")]
        [Validation(Required=false)]
        public float? PlayTimeNinetyPointsThirtyDay { get; set; }

        [NameInMap("PlayTimeRangeOneDay")]
        [Validation(Required=false)]
        public string PlayTimeRangeOneDay { get; set; }

        [NameInMap("PlayTimeRangeThirtyDay")]
        [Validation(Required=false)]
        public string PlayTimeRangeThirtyDay { get; set; }

        [NameInMap("UserActivationRate")]
        [Validation(Required=false)]
        public float? UserActivationRate { get; set; }

    }

}
