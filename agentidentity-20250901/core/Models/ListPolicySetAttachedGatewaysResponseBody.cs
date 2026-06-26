// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListPolicySetAttachedGatewaysResponseBody : TeaModel {
        [NameInMap("AttachedGateways")]
        [Validation(Required=false)]
        public List<ListPolicySetAttachedGatewaysResponseBodyAttachedGateways> AttachedGateways { get; set; }
        public class ListPolicySetAttachedGatewaysResponseBodyAttachedGateways : TeaModel {
            [NameInMap("AttachedPolicySetName")]
            [Validation(Required=false)]
            public string AttachedPolicySetName { get; set; }

            [NameInMap("AttachedTime")]
            [Validation(Required=false)]
            public string AttachedTime { get; set; }

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

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
