// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAgentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentResponseBodyData Data { get; set; }
        public class GetAgentResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }
            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyDataGroupList> GroupList { get; set; }
            public class GetAgentResponseBodyDataGroupList : TeaModel {
                public string DisplayName { get; set; }
                public string Description { get; set; }
                public int? ChannelType { get; set; }
                public long? SkillGroupId { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

    }

}
