// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ManagedDaOrderSummaryVO : TeaModel {
        [NameInMap("availableQuota")]
        [Validation(Required=false)]
        public int? AvailableQuota { get; set; }

        [NameInMap("totalQuota")]
        [Validation(Required=false)]
        public int? TotalQuota { get; set; }

        [NameInMap("trialExpireTime")]
        [Validation(Required=false)]
        public string TrialExpireTime { get; set; }

        [NameInMap("trialUsed")]
        [Validation(Required=false)]
        public bool? TrialUsed { get; set; }

        [NameInMap("usedQuota")]
        [Validation(Required=false)]
        public int? UsedQuota { get; set; }

        [NameInMap("validOrderCount")]
        [Validation(Required=false)]
        public int? ValidOrderCount { get; set; }

    }

}
