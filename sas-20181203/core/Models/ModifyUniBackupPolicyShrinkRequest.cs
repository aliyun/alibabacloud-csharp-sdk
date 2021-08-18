// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyUniBackupPolicyShrinkRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        [NameInMap("SpeedLimiter")]
        [Validation(Required=false)]
        public long? SpeedLimiter { get; set; }

        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        [NameInMap("FullPlan")]
        [Validation(Required=false)]
        public string FullPlanShrink { get; set; }

        [NameInMap("IncPlan")]
        [Validation(Required=false)]
        public string IncPlanShrink { get; set; }

        [NameInMap("PolicyStatus")]
        [Validation(Required=false)]
        public string PolicyStatus { get; set; }

    }

}
