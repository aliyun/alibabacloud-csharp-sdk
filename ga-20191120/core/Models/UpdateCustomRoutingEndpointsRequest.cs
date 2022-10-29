// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateCustomRoutingEndpointsRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<UpdateCustomRoutingEndpointsRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class UpdateCustomRoutingEndpointsRequestEndpointConfigurations : TeaModel {
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("PolicyConfigurations")]
            [Validation(Required=false)]
            public List<UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
            public class UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                public class UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                    [NameInMap("FromPort")]
                    [Validation(Required=false)]
                    public string FromPort { get; set; }

                    [NameInMap("ToPort")]
                    [Validation(Required=false)]
                    public string ToPort { get; set; }

                }

            }

            [NameInMap("TrafficToEndpointPolicy")]
            [Validation(Required=false)]
            public string TrafficToEndpointPolicy { get; set; }

        }

        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
