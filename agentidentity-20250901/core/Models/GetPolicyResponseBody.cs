// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetPolicyResponseBody : TeaModel {
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetPolicyResponseBodyPolicy Policy { get; set; }
        public class GetPolicyResponseBodyPolicy : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Definition")]
            [Validation(Required=false)]
            public Definition Definition { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("PolicyArn")]
            [Validation(Required=false)]
            public string PolicyArn { get; set; }

            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("PolicySetName")]
            [Validation(Required=false)]
            public string PolicySetName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
