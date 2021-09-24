// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceStatusCountResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("StatusCount")]
        [Validation(Required=true)]
        public GetInstanceStatusCountResponseStatusCount StatusCount { get; set; }
        public class GetInstanceStatusCountResponseStatusCount : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("NotRunCount")]
            [Validation(Required=true)]
            public int? NotRunCount { get; set; }
            [NameInMap("WaitTimeCount")]
            [Validation(Required=true)]
            public int? WaitTimeCount { get; set; }
            [NameInMap("WaitResCount")]
            [Validation(Required=true)]
            public int? WaitResCount { get; set; }
            [NameInMap("RunningCount")]
            [Validation(Required=true)]
            public int? RunningCount { get; set; }
            [NameInMap("FailureCount")]
            [Validation(Required=true)]
            public int? FailureCount { get; set; }
            [NameInMap("SuccessCount")]
            [Validation(Required=true)]
            public int? SuccessCount { get; set; }
        };

    }

}
