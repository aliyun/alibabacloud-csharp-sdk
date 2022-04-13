// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachKeyPairResponseBody : TeaModel {
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public string FailCount { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public DetachKeyPairResponseBodyResults Results { get; set; }
        public class DetachKeyPairResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DetachKeyPairResponseBodyResultsResult> Result { get; set; }
            public class DetachKeyPairResponseBodyResultsResult : TeaModel {
                public string Code { get; set; }
                public string InstanceId { get; set; }
                public string Message { get; set; }
                public string Success { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
