// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateGatewayPolicyConfigResponseBody : TeaModel {
        [NameInMap("GatewayPolicyConfig")]
        [Validation(Required=false)]
        public UpdateGatewayPolicyConfigResponseBodyGatewayPolicyConfig GatewayPolicyConfig { get; set; }
        public class UpdateGatewayPolicyConfigResponseBodyGatewayPolicyConfig : TeaModel {
            [NameInMap("EnforcementMode")]
            [Validation(Required=false)]
            public string EnforcementMode { get; set; }

            [NameInMap("PolicySetArn")]
            [Validation(Required=false)]
            public string PolicySetArn { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
