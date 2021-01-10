// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class GetAlgorithmHistogramsResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlgorithmHistogramsResponseBodyData Data { get; set; }
        public class GetAlgorithmHistogramsResponseBodyData : TeaModel {
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }
            [NameInMap("FailureCount")]
            [Validation(Required=false)]
            public int? FailureCount { get; set; }
            [NameInMap("Histograms")]
            [Validation(Required=false)]
            public List<GetAlgorithmHistogramsResponseBodyDataHistograms> Histograms { get; set; }
            public class GetAlgorithmHistogramsResponseBodyDataHistograms : TeaModel {
                public string Time { get; set; }
                public int? SuccessCount { get; set; }
                public int? FailureCount { get; set; }
            }
        };

    }

}
