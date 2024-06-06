// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCampaignsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCampaignsResponseBodyData Data { get; set; }
        public class ListCampaignsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCampaignsResponseBodyDataList> List { get; set; }
            public class ListCampaignsResponseBodyDataList : TeaModel {
                [NameInMap("ActualEndTime")]
                [Validation(Required=false)]
                public long? ActualEndTime { get; set; }

                [NameInMap("ActualStartTime")]
                [Validation(Required=false)]
                public long? ActualStartTime { get; set; }

                [NameInMap("CampaignId")]
                [Validation(Required=false)]
                public string CampaignId { get; set; }

                [NameInMap("CasesAborted")]
                [Validation(Required=false)]
                public long? CasesAborted { get; set; }

                [NameInMap("CasesConnected")]
                [Validation(Required=false)]
                public long? CasesConnected { get; set; }

                [NameInMap("CasesUncompleted")]
                [Validation(Required=false)]
                public long? CasesUncompleted { get; set; }

                [NameInMap("CompletionRate")]
                [Validation(Required=false)]
                public float? CompletionRate { get; set; }

                [NameInMap("ContactFlowId")]
                [Validation(Required=false)]
                public string ContactFlowId { get; set; }

                [NameInMap("MaxAttemptCount")]
                [Validation(Required=false)]
                public long? MaxAttemptCount { get; set; }

                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public long? MinAttemptInterval { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PlanedEndTime")]
                [Validation(Required=false)]
                public long? PlanedEndTime { get; set; }

                [NameInMap("PlanedStartTime")]
                [Validation(Required=false)]
                public long? PlanedStartTime { get; set; }

                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                [NameInMap("Simulation")]
                [Validation(Required=false)]
                public bool? Simulation { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("StrategyParameters")]
                [Validation(Required=false)]
                public string StrategyParameters { get; set; }

                [NameInMap("StrategyType")]
                [Validation(Required=false)]
                public string StrategyType { get; set; }

                [NameInMap("TotalCases")]
                [Validation(Required=false)]
                public long? TotalCases { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

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
