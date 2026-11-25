// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchUndeployHttpApiRoutesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchUndeployHttpApiRoutesResponseBodyData Data { get; set; }
        public class BatchUndeployHttpApiRoutesResponseBodyData : TeaModel {
            [NameInMap("failedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            [NameInMap("results")]
            [Validation(Required=false)]
            public Dictionary<string, DataResultsValue> Results { get; set; }

            [NameInMap("skippedCount")]
            [Validation(Required=false)]
            public int? SkippedCount { get; set; }

            [NameInMap("successCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
