// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetEmonMonitorDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetEmonMonitorDataResponseBodyResult> Result { get; set; }
        public class GetEmonMonitorDataResponseBodyResult : TeaModel {
            [NameInMap("integrity")]
            [Validation(Required=false)]
            public float? Integrity { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public float? Summary { get; set; }

            [NameInMap("messageWatermark")]
            [Validation(Required=false)]
            public long? MessageWatermark { get; set; }

            [NameInMap("dps")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dps { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            [NameInMap("metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

        }

    }

}
