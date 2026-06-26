// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListPolicySetAttachedGatewaysRequest : TeaModel {
        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PolicySetName")]
        [Validation(Required=false)]
        public string PolicySetName { get; set; }

    }

}
