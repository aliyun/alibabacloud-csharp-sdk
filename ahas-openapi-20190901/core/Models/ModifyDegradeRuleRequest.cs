// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ModifyDegradeRuleRequest : TeaModel {
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public int? Strategy { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        [NameInMap("RecoveryTimeoutMs")]
        [Validation(Required=false)]
        public int? RecoveryTimeoutMs { get; set; }

        [NameInMap("StatDurationMs")]
        [Validation(Required=false)]
        public int? StatDurationMs { get; set; }

        [NameInMap("SlowRtMs")]
        [Validation(Required=false)]
        public int? SlowRtMs { get; set; }

        [NameInMap("MinRequestAmount")]
        [Validation(Required=false)]
        public int? MinRequestAmount { get; set; }

        [NameInMap("HalfOpenBaseAmountPerStep")]
        [Validation(Required=false)]
        public int? HalfOpenBaseAmountPerStep { get; set; }

        [NameInMap("HalfOpenRecoveryStepNum")]
        [Validation(Required=false)]
        public int? HalfOpenRecoveryStepNum { get; set; }

        [NameInMap("AhasRegionId")]
        [Validation(Required=false)]
        public string AhasRegionId { get; set; }

    }

}
