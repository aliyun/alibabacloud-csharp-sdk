// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class SkipTrialPolicyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SkipTrialPolicyResponseBodyData Data { get; set; }
        public class SkipTrialPolicyResponseBodyData : TeaModel {
            [NameInMap("SkipResult")]
            [Validation(Required=false)]
            public int? SkipResult { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
