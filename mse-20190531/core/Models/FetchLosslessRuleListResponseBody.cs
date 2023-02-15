// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class FetchLosslessRuleListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public FetchLosslessRuleListResponseBodyData Data { get; set; }
        public class FetchLosslessRuleListResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<FetchLosslessRuleListResponseBodyDataResults> Results { get; set; }
            public class FetchLosslessRuleListResponseBodyDataResults : TeaModel {
                [NameInMap("Aligned")]
                [Validation(Required=false)]
                public bool? Aligned { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("DelayTime")]
                [Validation(Required=false)]
                public long? DelayTime { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("FuncType")]
                [Validation(Required=false)]
                public long? FuncType { get; set; }

                [NameInMap("LossLessDetail")]
                [Validation(Required=false)]
                public bool? LossLessDetail { get; set; }

                [NameInMap("Notice")]
                [Validation(Required=false)]
                public bool? Notice { get; set; }

                [NameInMap("Related")]
                [Validation(Required=false)]
                public bool? Related { get; set; }

                [NameInMap("ShutdownWaitSeconds")]
                [Validation(Required=false)]
                public int? ShutdownWaitSeconds { get; set; }

                [NameInMap("WarmupTime")]
                [Validation(Required=false)]
                public long? WarmupTime { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
