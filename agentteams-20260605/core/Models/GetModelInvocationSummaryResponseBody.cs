// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetModelInvocationSummaryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetModelInvocationSummaryResponseBodyData Data { get; set; }
        public class GetModelInvocationSummaryResponseBodyData : TeaModel {
            [NameInMap("CallFrequency")]
            [Validation(Required=false)]
            public double? CallFrequency { get; set; }

            [NameInMap("ProviderDistribution")]
            [Validation(Required=false)]
            public List<GetModelInvocationSummaryResponseBodyDataProviderDistribution> ProviderDistribution { get; set; }
            public class GetModelInvocationSummaryResponseBodyDataProviderDistribution : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

                [NameInMap("ProviderName")]
                [Validation(Required=false)]
                public string ProviderName { get; set; }

            }

            [NameInMap("TodayCallCount")]
            [Validation(Required=false)]
            public int? TodayCallCount { get; set; }

            [NameInMap("TodayChangeRate")]
            [Validation(Required=false)]
            public double? TodayChangeRate { get; set; }

            [NameInMap("WeekCallCount")]
            [Validation(Required=false)]
            public int? WeekCallCount { get; set; }

            [NameInMap("WeekChangeRate")]
            [Validation(Required=false)]
            public double? WeekChangeRate { get; set; }

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
