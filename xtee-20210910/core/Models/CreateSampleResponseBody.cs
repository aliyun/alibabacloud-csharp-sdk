// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateSampleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public CreateSampleResponseBodyResultObject ResultObject { get; set; }
        public class CreateSampleResponseBodyResultObject : TeaModel {
            [NameInMap("communityCount")]
            [Validation(Required=false)]
            public int? CommunityCount { get; set; }

            [NameInMap("failCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            [NameInMap("recallProbability")]
            [Validation(Required=false)]
            public string RecallProbability { get; set; }

            [NameInMap("riskDensity")]
            [Validation(Required=false)]
            public string RiskDensity { get; set; }

            [NameInMap("sampleCount")]
            [Validation(Required=false)]
            public int? SampleCount { get; set; }

            [NameInMap("successCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

        }

    }

}
