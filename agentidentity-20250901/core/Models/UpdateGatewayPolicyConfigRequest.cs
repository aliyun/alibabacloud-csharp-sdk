// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateGatewayPolicyConfigRequest : TeaModel {
        [NameInMap("EnforcementMode")]
        [Validation(Required=false)]
        public string EnforcementMode { get; set; }

        [NameInMap("GatewayArn")]
        [Validation(Required=false)]
        public string GatewayArn { get; set; }

        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

    }

}
