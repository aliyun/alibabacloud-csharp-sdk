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
                public long? ActualEndTime { get; set; }
                public long? ActualStartTime { get; set; }
                public string CampaignId { get; set; }
                public long? CasesAborted { get; set; }
                public long? CasesConnected { get; set; }
                public long? CasesUncompleted { get; set; }
                public long? MaxAttemptCount { get; set; }
                public long? MinAttemptInterval { get; set; }
                public string Name { get; set; }
                public long? PlanedEndTime { get; set; }
                public long? PlanedStartTime { get; set; }
                public string QueueId { get; set; }
                public string QueueName { get; set; }
                public bool? Simulation { get; set; }
                public string State { get; set; }
                public string StrategyParameters { get; set; }
                public string StrategyType { get; set; }
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
        };

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
