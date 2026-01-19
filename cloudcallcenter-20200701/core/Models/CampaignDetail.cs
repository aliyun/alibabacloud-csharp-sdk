// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudCallCenter20200701.Models
{
    public class CampaignDetail : TeaModel {
        [NameInMap("ActualEndTime")]
        [Validation(Required=false)]
        public long? ActualEndTime { get; set; }

        [NameInMap("ActualStartTime")]
        [Validation(Required=false)]
        public long? ActualStartTime { get; set; }

        [NameInMap("CasesAborted")]
        [Validation(Required=false)]
        public long? CasesAborted { get; set; }

        [NameInMap("CasesConnected")]
        [Validation(Required=false)]
        public long? CasesConnected { get; set; }

        [NameInMap("CasesUncompleted")]
        [Validation(Required=false)]
        public long? CasesUncompleted { get; set; }

        [NameInMap("CompletedRate")]
        [Validation(Required=false)]
        public long? CompletedRate { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

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

        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("TotalCases")]
        [Validation(Required=false)]
        public long? TotalCases { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
