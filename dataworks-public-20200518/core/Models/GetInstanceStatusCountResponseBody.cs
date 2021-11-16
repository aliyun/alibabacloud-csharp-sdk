// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceStatusCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatusCount")]
        [Validation(Required=false)]
        public GetInstanceStatusCountResponseBodyStatusCount StatusCount { get; set; }
        public class GetInstanceStatusCountResponseBodyStatusCount : TeaModel {
            [NameInMap("FailureCount")]
            [Validation(Required=false)]
            public int? FailureCount { get; set; }
            [NameInMap("NotRunCount")]
            [Validation(Required=false)]
            public int? NotRunCount { get; set; }
            [NameInMap("RunningCount")]
            [Validation(Required=false)]
            public int? RunningCount { get; set; }
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("WaitResCount")]
            [Validation(Required=false)]
            public int? WaitResCount { get; set; }
            [NameInMap("WaitTimeCount")]
            [Validation(Required=false)]
            public int? WaitTimeCount { get; set; }
        };

    }

}
