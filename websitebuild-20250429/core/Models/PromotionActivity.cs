// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class PromotionActivity : TeaModel {
        [NameInMap("ActivityCode")]
        [Validation(Required=false)]
        public string ActivityCode { get; set; }

        [NameInMap("ActivityName")]
        [Validation(Required=false)]
        public string ActivityName { get; set; }

        [NameInMap("ActivityType")]
        [Validation(Required=false)]
        public string ActivityType { get; set; }

        [NameInMap("ConsumedQuota")]
        [Validation(Required=false)]
        public long? ConsumedQuota { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("EligibilityConfig")]
        [Validation(Required=false)]
        public string EligibilityConfig { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("OfferConfig")]
        [Validation(Required=false)]
        public string OfferConfig { get; set; }

        [NameInMap("OfferConfigSummary")]
        [Validation(Required=false)]
        public string OfferConfigSummary { get; set; }

        [NameInMap("RemainingQuota")]
        [Validation(Required=false)]
        public long? RemainingQuota { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TotalQuota")]
        [Validation(Required=false)]
        public long? TotalQuota { get; set; }

        [NameInMap("TouchpointConfig")]
        [Validation(Required=false)]
        public string TouchpointConfig { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UpdatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

        [NameInMap("WarningThreshold")]
        [Validation(Required=false)]
        public int? WarningThreshold { get; set; }

    }

}
