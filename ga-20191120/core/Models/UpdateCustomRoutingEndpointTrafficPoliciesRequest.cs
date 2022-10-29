// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateCustomRoutingEndpointTrafficPoliciesRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        [NameInMap("PolicyConfigurations")]
        [Validation(Required=false)]
        public List<UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations> PolicyConfigurations { get; set; }
        public class UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges> PortRanges { get; set; }
            public class UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges : TeaModel {
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
