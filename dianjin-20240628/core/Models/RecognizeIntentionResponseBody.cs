// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RecognizeIntentionResponseBody : TeaModel {
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RecognizeIntentionResponseBodyData Data { get; set; }
        public class RecognizeIntentionResponseBodyData : TeaModel {
            [NameInMap("analysisProcess")]
            [Validation(Required=false)]
            public string AnalysisProcess { get; set; }

            [NameInMap("intentionCode")]
            [Validation(Required=false)]
            public string IntentionCode { get; set; }

            [NameInMap("intentionName")]
            [Validation(Required=false)]
            public string IntentionName { get; set; }

            [NameInMap("recommendIntention")]
            [Validation(Required=false)]
            public string RecommendIntention { get; set; }

            [NameInMap("recommendScript")]
            [Validation(Required=false)]
            public string RecommendScript { get; set; }

        }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
