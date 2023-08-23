// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudCallCenter20200701.Models
{
    public class GetRealtimeCampaignStatsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRealtimeCampaignStatsResponseBodyData Data { get; set; }
        public class GetRealtimeCampaignStatsResponseBodyData : TeaModel {
            [NameInMap("BreakingAgents")]
            [Validation(Required=false)]
            public long? BreakingAgents { get; set; }

            [NameInMap("Caps")]
            [Validation(Required=false)]
            public long? Caps { get; set; }

            [NameInMap("LoggedInAgents")]
            [Validation(Required=false)]
            public long? LoggedInAgents { get; set; }

            [NameInMap("OutboundScenarioBreakingAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioBreakingAgents { get; set; }

            [NameInMap("OutboundScenarioReadyAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioReadyAgents { get; set; }

            [NameInMap("OutboundScenarioTalkingAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioTalkingAgents { get; set; }

            [NameInMap("OutboundScenarioWorkingAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioWorkingAgents { get; set; }

            [NameInMap("ReadyAgents")]
            [Validation(Required=false)]
            public long? ReadyAgents { get; set; }

            [NameInMap("TalkingAgents")]
            [Validation(Required=false)]
            public long? TalkingAgents { get; set; }

            [NameInMap("TotalAgents")]
            [Validation(Required=false)]
            public long? TotalAgents { get; set; }

            [NameInMap("WorkingAgents")]
            [Validation(Required=false)]
            public long? WorkingAgents { get; set; }

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

    }

}
