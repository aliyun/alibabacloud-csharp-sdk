// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRealtimeAgentStatesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRealtimeAgentStatesResponseBodyData Data { get; set; }
        public class ListRealtimeAgentStatesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListRealtimeAgentStatesResponseBodyDataList> List { get; set; }
            public class ListRealtimeAgentStatesResponseBodyDataList : TeaModel {
                public string Extension { get; set; }
                public string StateCode { get; set; }
                public string State { get; set; }
                public string AgentId { get; set; }
                public long? StateTime { get; set; }
                public string AgentName { get; set; }
                public string InstanceId { get; set; }
                public string CounterParty { get; set; }
                public List<string> SkillGroupIdList { get; set; }
            }
        };

    }

}
