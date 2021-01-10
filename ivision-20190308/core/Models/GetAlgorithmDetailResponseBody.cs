// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class GetAlgorithmDetailResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlgorithmDetailResponseBodyData Data { get; set; }
        public class GetAlgorithmDetailResponseBodyData : TeaModel {
            [NameInMap("AlgorithmName")]
            [Validation(Required=false)]
            public string AlgorithmName { get; set; }
            [NameInMap("DeployRegion")]
            [Validation(Required=false)]
            public string DeployRegion { get; set; }
            [NameInMap("CurrentMonthCount")]
            [Validation(Required=false)]
            public int? CurrentMonthCount { get; set; }
            [NameInMap("AlgorithmCode")]
            [Validation(Required=false)]
            public string AlgorithmCode { get; set; }
            [NameInMap("ApiDocUrl")]
            [Validation(Required=false)]
            public string ApiDocUrl { get; set; }
            [NameInMap("CurrentMonthSuccessCount")]
            [Validation(Required=false)]
            public int? CurrentMonthSuccessCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
