// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListAgentStateLogsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("AgentStateLogPage")]
        [Validation(Required=false)]
        public ListAgentStateLogsResponseBodyAgentStateLogPage AgentStateLogPage { get; set; }
        public class ListAgentStateLogsResponseBodyAgentStateLogPage : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListAgentStateLogsResponseBodyAgentStateLogPageList> List { get; set; }
            public class ListAgentStateLogsResponseBodyAgentStateLogPageList : TeaModel {
                public string StateCode { get; set; }
                public string ContactId { get; set; }
                public string State { get; set; }
                public string ConnectId { get; set; }
                public long? StateTime { get; set; }
                public string InstanceId { get; set; }
                public long? RamId { get; set; }
                public string SkillGroupIds { get; set; }
                public string CounterParty { get; set; }
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

    }

}
