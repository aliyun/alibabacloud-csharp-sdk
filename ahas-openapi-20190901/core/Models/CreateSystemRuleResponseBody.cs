// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class CreateSystemRuleResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSystemRuleResponseBodyData Data { get; set; }
        public class CreateSystemRuleResponseBodyData : TeaModel {
            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public int? MetricType { get; set; }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }
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
