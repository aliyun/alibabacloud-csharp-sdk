// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetPolicySetResponseBody : TeaModel {
        [NameInMap("PolicySet")]
        [Validation(Required=false)]
        public GetPolicySetResponseBodyPolicySet PolicySet { get; set; }
        public class GetPolicySetResponseBodyPolicySet : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("PolicySetArn")]
            [Validation(Required=false)]
            public string PolicySetArn { get; set; }

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
