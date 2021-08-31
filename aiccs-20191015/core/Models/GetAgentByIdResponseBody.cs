// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAgentByIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentByIdResponseBodyData Data { get; set; }
        public class GetAgentByIdResponseBodyData : TeaModel {
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }
            [NameInMap("ForeignKey")]
            [Validation(Required=false)]
            public string ForeignKey { get; set; }
            [NameInMap("ServicerType")]
            [Validation(Required=false)]
            public int? ServicerType { get; set; }
            [NameInMap("RealName")]
            [Validation(Required=false)]
            public string RealName { get; set; }
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public int? AgentId { get; set; }
            [NameInMap("ForeignNick")]
            [Validation(Required=false)]
            public string ForeignNick { get; set; }
        };

    }

}
