// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAntiBruteForceRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CreateAntiBruteForceRule")]
        [Validation(Required=false)]
        public CreateAntiBruteForceRuleResponseBodyCreateAntiBruteForceRule CreateAntiBruteForceRule { get; set; }
        public class CreateAntiBruteForceRuleResponseBodyCreateAntiBruteForceRule : TeaModel {
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }
        };

    }

}
