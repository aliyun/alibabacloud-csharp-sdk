// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCustomizeRuleCountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCustomizeRuleCountResponseBodyData Data { get; set; }
        public class DescribeCustomizeRuleCountResponseBodyData : TeaModel {
            [NameInMap("HighRuleNum")]
            [Validation(Required=false)]
            public int? HighRuleNum { get; set; }

            [NameInMap("InUseRuleNum")]
            [Validation(Required=false)]
            public int? InUseRuleNum { get; set; }

            [NameInMap("LowRuleNum")]
            [Validation(Required=false)]
            public int? LowRuleNum { get; set; }

            [NameInMap("MediumRuleNum")]
            [Validation(Required=false)]
            public int? MediumRuleNum { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
