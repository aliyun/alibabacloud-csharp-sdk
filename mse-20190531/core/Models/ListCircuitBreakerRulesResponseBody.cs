// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListCircuitBreakerRulesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCircuitBreakerRulesResponseBodyData Data { get; set; }
        public class ListCircuitBreakerRulesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListCircuitBreakerRulesResponseBodyDataResult> Result { get; set; }
            public class ListCircuitBreakerRulesResponseBodyDataResult : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("FallbackObject")]
                [Validation(Required=false)]
                public string FallbackObject { get; set; }

                [NameInMap("HalfOpenBaseAmountPerStep")]
                [Validation(Required=false)]
                public int? HalfOpenBaseAmountPerStep { get; set; }

                [NameInMap("HalfOpenRecoveryStepNum")]
                [Validation(Required=false)]
                public int? HalfOpenRecoveryStepNum { get; set; }

                [NameInMap("MaxAllowedRtMs")]
                [Validation(Required=false)]
                public int? MaxAllowedRtMs { get; set; }

                [NameInMap("MinRequestAmount")]
                [Validation(Required=false)]
                public int? MinRequestAmount { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                [NameInMap("RetryTimeoutMs")]
                [Validation(Required=false)]
                public int? RetryTimeoutMs { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                [NameInMap("StatIntervalMs")]
                [Validation(Required=false)]
                public int? StatIntervalMs { get; set; }

                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public int? Strategy { get; set; }

                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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