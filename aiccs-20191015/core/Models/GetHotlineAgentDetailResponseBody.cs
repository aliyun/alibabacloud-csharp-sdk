// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineAgentDetailResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotlineAgentDetailResponseBodyData Data { get; set; }
        public class GetHotlineAgentDetailResponseBodyData : TeaModel {
            [NameInMap("AgentStatusCode")]
            [Validation(Required=false)]
            public string AgentStatusCode { get; set; }
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }
            [NameInMap("Assigned")]
            [Validation(Required=false)]
            public bool? Assigned { get; set; }
            [NameInMap("RestType")]
            [Validation(Required=false)]
            public int? RestType { get; set; }
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public int? AgentStatus { get; set; }
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
