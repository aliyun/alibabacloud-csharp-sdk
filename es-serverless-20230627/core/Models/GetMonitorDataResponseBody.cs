// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetMonitorDataResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetMonitorDataResponseBodyResult> Result { get; set; }
        public class GetMonitorDataResponseBodyResult : TeaModel {
            [NameInMap("dps")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dps { get; set; }

            [NameInMap("integrity")]
            [Validation(Required=false)]
            public float? Integrity { get; set; }

            [NameInMap("messageWatermark")]
            [Validation(Required=false)]
            public long? MessageWatermark { get; set; }

            [NameInMap("metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public float? Summary { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
