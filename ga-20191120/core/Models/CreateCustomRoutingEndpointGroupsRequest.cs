// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointGroupsRequest : TeaModel {
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurations : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsDestinationConfigurations> DestinationConfigurations { get; set; }
            public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsDestinationConfigurations : TeaModel {
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("PolicyConfigurations")]
                [Validation(Required=false)]
                public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
                public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations : TeaModel {
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("PortRanges")]
                    [Validation(Required=false)]
                    public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                    public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
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

            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
