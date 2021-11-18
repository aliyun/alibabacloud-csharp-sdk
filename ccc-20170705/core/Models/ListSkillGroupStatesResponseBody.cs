// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
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
            public ListSkillGroupStatesResponseBodyDataList List { get; set; }
            public class ListSkillGroupStatesResponseBodyDataList : TeaModel {
                [NameInMap("RealTimeSkillGroupState")]
                [Validation(Required=false)]
                public List<ListSkillGroupStatesResponseBodyDataListRealTimeSkillGroupState> RealTimeSkillGroupState { get; set; }
                public class ListSkillGroupStatesResponseBodyDataListRealTimeSkillGroupState : TeaModel {
                    [NameInMap("BreakingAgents")]
                    [Validation(Required=false)]
                    public long? BreakingAgents { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("LoggedInAgents")]
                    [Validation(Required=false)]
                    public long? LoggedInAgents { get; set; }

                    [NameInMap("LongestCall")]
                    [Validation(Required=false)]
                    public long? LongestCall { get; set; }

                    [NameInMap("ReadyAgents")]
                    [Validation(Required=false)]
                    public long? ReadyAgents { get; set; }

                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    [NameInMap("SkillGroupName")]
                    [Validation(Required=false)]
                    public string SkillGroupName { get; set; }

                    [NameInMap("TalkingAgents")]
                    [Validation(Required=false)]
                    public long? TalkingAgents { get; set; }

                    [NameInMap("WaitingCalls")]
                    [Validation(Required=false)]
                    public long? WaitingCalls { get; set; }

                    [NameInMap("WorkingAgents")]
                    [Validation(Required=false)]
                    public long? WorkingAgents { get; set; }

                }

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
