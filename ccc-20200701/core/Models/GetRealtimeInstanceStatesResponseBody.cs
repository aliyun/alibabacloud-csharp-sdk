// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetRealtimeInstanceStatesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRealtimeInstanceStatesResponseBodyData Data { get; set; }
        public class GetRealtimeInstanceStatesResponseBodyData : TeaModel {
            [NameInMap("BreakingAgents")]
            [Validation(Required=false)]
            public long? BreakingAgents { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InteractiveCalls")]
            [Validation(Required=false)]
            public long? InteractiveCalls { get; set; }

            [NameInMap("LoggedInAgents")]
            [Validation(Required=false)]
            public long? LoggedInAgents { get; set; }

            [NameInMap("LongestWaitingTime")]
            [Validation(Required=false)]
            public long? LongestWaitingTime { get; set; }

            [NameInMap("ReadyAgents")]
            [Validation(Required=false)]
            public long? ReadyAgents { get; set; }

            [NameInMap("TalkingAgents")]
            [Validation(Required=false)]
            public long? TalkingAgents { get; set; }

            [NameInMap("TotalAgents")]
            [Validation(Required=false)]
            public long? TotalAgents { get; set; }

            [NameInMap("WaitingCalls")]
            [Validation(Required=false)]
            public long? WaitingCalls { get; set; }

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
