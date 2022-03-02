// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListSkillGroupStatesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSkillGroupStatesResponseBodyData Data { get; set; }
        public class ListSkillGroupStatesResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListSkillGroupStatesResponseBodyDataList> List { get; set; }
            public class ListSkillGroupStatesResponseBodyDataList : TeaModel {
                public long? BreakingAgents { get; set; }
                public string InstanceId { get; set; }
                public long? LoggedInAgents { get; set; }
                public long? LongestCall { get; set; }
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
