// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetWorkerStatsSummaryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkerStatsSummaryResponseBodyData Data { get; set; }
        public class GetWorkerStatsSummaryResponseBodyData : TeaModel {
            [NameInMap("OtherWorkers")]
            [Validation(Required=false)]
            public int? OtherWorkers { get; set; }

            [NameInMap("RunningWorkers")]
            [Validation(Required=false)]
            public int? RunningWorkers { get; set; }

            [NameInMap("StoppedWorkers")]
            [Validation(Required=false)]
            public int? StoppedWorkers { get; set; }

            [NameInMap("TotalWorkers")]
            [Validation(Required=false)]
            public int? TotalWorkers { get; set; }

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
