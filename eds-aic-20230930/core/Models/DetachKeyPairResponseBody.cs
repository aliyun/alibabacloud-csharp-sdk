// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DetachKeyPairResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetachKeyPairResponseBodyData Data { get; set; }
        public class DetachKeyPairResponseBodyData : TeaModel {
            [NameInMap("DetachedInstanceIds")]
            [Validation(Required=false)]
            public List<string> DetachedInstanceIds { get; set; }

            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            [NameInMap("KeyPairId")]
            [Validation(Required=false)]
            public string KeyPairId { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
