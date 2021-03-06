// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class CreateDegradeRuleResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDegradeRuleResponseBodyData Data { get; set; }
        public class CreateDegradeRuleResponseBodyData : TeaModel {
            [NameInMap("SlowRtMs")]
            [Validation(Required=false)]
            public int? SlowRtMs { get; set; }
            [NameInMap("HalfOpenRecoveryStepNum")]
            [Validation(Required=false)]
            public int? HalfOpenRecoveryStepNum { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("StatDurationMs")]
            [Validation(Required=false)]
            public int? StatDurationMs { get; set; }
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public int? Strategy { get; set; }
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("HalfOpenBaseAmountPerStep")]
            [Validation(Required=false)]
            public int? HalfOpenBaseAmountPerStep { get; set; }
            [NameInMap("RecoveryTimeoutMs")]
            [Validation(Required=false)]
            public int? RecoveryTimeoutMs { get; set; }
            [NameInMap("MinRequestAmount")]
            [Validation(Required=false)]
            public int? MinRequestAmount { get; set; }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
