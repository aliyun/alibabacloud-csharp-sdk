// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointsRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointsRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class CreateCustomRoutingEndpointsRequestEndpointConfigurations : TeaModel {
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("PolicyConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
            public class CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                public class CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                    [NameInMap("FromPort")]
                    [Validation(Required=false)]
                    public int? FromPort { get; set; }

                    [NameInMap("ToPort")]
                    [Validation(Required=false)]
                    public int? ToPort { get; set; }

                }

            }

            [NameInMap("TrafficToEndpointPolicy")]
            [Validation(Required=false)]
            public string TrafficToEndpointPolicy { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
