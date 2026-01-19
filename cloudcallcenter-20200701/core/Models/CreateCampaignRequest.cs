// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudCallCenter20200701.Models
{
    public class CreateCampaignRequest : TeaModel {
        [NameInMap("CallableTime")]
        [Validation(Required=false)]
        public string CallableTime { get; set; }

        [NameInMap("CaseFileKey")]
        [Validation(Required=false)]
        public string CaseFileKey { get; set; }

        [NameInMap("CaseList")]
        [Validation(Required=false)]
        public List<CreateCampaignRequestCaseList> CaseList { get; set; }
        public class CreateCampaignRequestCaseList : TeaModel {
            [NameInMap("CustomVariables")]
            [Validation(Required=false)]
            public string CustomVariables { get; set; }

            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

        }

        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ExecutingUntilTimeout")]
        [Validation(Required=false)]
        public bool? ExecutingUntilTimeout { get; set; }

        [NameInMap("FlashSmsParameters")]
        [Validation(Required=false)]
        public string FlashSmsParameters { get; set; }

        [NameInMap("InstGroupId")]
        [Validation(Required=false)]
        public string InstGroupId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaxAttemptCount")]
        [Validation(Required=false)]
        public long? MaxAttemptCount { get; set; }

        [NameInMap("MinAttemptInterval")]
        [Validation(Required=false)]
        public long? MinAttemptInterval { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public List<string> NumberList { get; set; }

        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        [NameInMap("Simulation")]
        [Validation(Required=false)]
        public bool? Simulation { get; set; }

        [NameInMap("SimulationParameters")]
        [Validation(Required=false)]
        public string SimulationParameters { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("StrategyParameters")]
        [Validation(Required=false)]
        public string StrategyParameters { get; set; }

        [NameInMap("StrategyType")]
        [Validation(Required=false)]
        public string StrategyType { get; set; }

    }

}
