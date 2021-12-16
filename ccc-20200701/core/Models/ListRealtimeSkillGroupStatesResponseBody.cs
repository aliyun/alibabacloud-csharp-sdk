// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRealtimeSkillGroupStatesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRealtimeSkillGroupStatesResponseBodyData Data { get; set; }
        public class ListRealtimeSkillGroupStatesResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListRealtimeSkillGroupStatesResponseBodyDataList> List { get; set; }
            public class ListRealtimeSkillGroupStatesResponseBodyDataList : TeaModel {
                public long? BreakingAgents { get; set; }
                public string InstanceId { get; set; }
                public long? LoggedInAgents { get; set; }
                public long? LongestWaitingTime { get; set; }
                public long? ReadyAgents { get; set; }
                public string SkillGroupId { get; set; }
                public string SkillGroupName { get; set; }
                public long? TalkingAgents { get; set; }
                public long? WaitingCalls { get; set; }
                public long? WorkingAgents { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

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
