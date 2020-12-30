// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListAgentEventsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AgentEventList")]
        [Validation(Required=false)]
        public ListAgentEventsResponseBodyAgentEventList AgentEventList { get; set; }
        public class ListAgentEventsResponseBodyAgentEventList : TeaModel {
            [NameInMap("AgentEvent")]
            [Validation(Required=false)]
            public List<ListAgentEventsResponseBodyAgentEventListAgentEvent> AgentEvent { get; set; }
            public class ListAgentEventsResponseBodyAgentEventListAgentEvent : TeaModel {
                public long? EventTime { get; set; }
                public string LoginName { get; set; }
                public string Event { get; set; }
                public string InstanceId { get; set; }
                public long? RamId { get; set; }
                public ListAgentEventsResponseBodyAgentEventListAgentEventSkillGroupIds SkillGroupIds { get; set; }
                public class ListAgentEventsResponseBodyAgentEventListAgentEventSkillGroupIds : TeaModel {
                    [NameInMap("SkillGroup")]
                    [Validation(Required=false)]
                    public List<ListAgentEventsResponseBodyAgentEventListAgentEventSkillGroupIdsSkillGroup> SkillGroup { get; set; }
                    public class ListAgentEventsResponseBodyAgentEventListAgentEventSkillGroupIdsSkillGroup : TeaModel {
                        [NameInMap("SkillGroupName")]
                        [Validation(Required=false)]
                        public string SkillGroupName { get; set; }

                        [NameInMap("SkillGroupId")]
                        [Validation(Required=false)]
                        public string SkillGroupId { get; set; }

                    }

                }
            }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
