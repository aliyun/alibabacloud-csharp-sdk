// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class GetSimCardStateDistributionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSimCardStateDistributionResponseBodyData Data { get; set; }
        public class GetSimCardStateDistributionResponseBodyData : TeaModel {
            [NameInMap("CardCount")]
            [Validation(Required=false)]
            public long? CardCount { get; set; }

            [NameInMap("DestoryedCount")]
            [Validation(Required=false)]
            public long? DestoryedCount { get; set; }

            [NameInMap("ShutDownCount")]
            [Validation(Required=false)]
            public long? ShutDownCount { get; set; }

            [NameInMap("StopCount")]
            [Validation(Required=false)]
            public long? StopCount { get; set; }

            [NameInMap("TestCount")]
            [Validation(Required=false)]
            public long? TestCount { get; set; }

            [NameInMap("UnusedCount")]
            [Validation(Required=false)]
            public long? UnusedCount { get; set; }

            [NameInMap("UsingCount")]
            [Validation(Required=false)]
            public long? UsingCount { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
