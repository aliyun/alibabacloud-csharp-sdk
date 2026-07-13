// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetTaskStatsSummaryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTaskStatsSummaryResponseBodyData Data { get; set; }
        public class GetTaskStatsSummaryResponseBodyData : TeaModel {
            [NameInMap("AverageTaskDuration")]
            [Validation(Required=false)]
            public double? AverageTaskDuration { get; set; }

            [NameInMap("StatusDistribution")]
            [Validation(Required=false)]
            public List<GetTaskStatsSummaryResponseBodyDataStatusDistribution> StatusDistribution { get; set; }
            public class GetTaskStatsSummaryResponseBodyDataStatusDistribution : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("TaskTokenConsumption")]
            [Validation(Required=false)]
            public long? TaskTokenConsumption { get; set; }

            [NameInMap("TotalTasks")]
            [Validation(Required=false)]
            public int? TotalTasks { get; set; }

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
