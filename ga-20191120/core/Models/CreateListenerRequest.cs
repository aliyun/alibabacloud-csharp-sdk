// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateListenerRequest : TeaModel {
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCertificates> Certificates { get; set; }
        public class CreateListenerRequestCertificates : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CustomRoutingEndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurations> CustomRoutingEndpointGroupConfigurations { get; set; }
        public class CreateListenerRequestCustomRoutingEndpointGroupConfigurations : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsDestinationConfigurations> DestinationConfigurations { get; set; }
            public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsDestinationConfigurations : TeaModel {
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
            public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("PolicyConfigurations")]
                [Validation(Required=false)]
                public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
                public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations : TeaModel {
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("PortRanges")]
                    [Validation(Required=false)]
                    public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                    public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
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

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateListenerRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateListenerRequestEndpointGroupConfigurations : TeaModel {
            [NameInMap("EnableClientIPPreservationProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationProxyProtocol { get; set; }

            [NameInMap("EnableClientIPPreservationToa")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationToa { get; set; }

            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateListenerRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            [NameInMap("EndpointGroupDescription")]
            [Validation(Required=false)]
            public string EndpointGroupDescription { get; set; }

            [NameInMap("EndpointGroupName")]
            [Validation(Required=false)]
            public string EndpointGroupName { get; set; }

            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public long? HealthCheckIntervalSeconds { get; set; }

            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public long? HealthCheckPort { get; set; }

            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<CreateListenerRequestEndpointGroupConfigurationsPortOverrides> PortOverrides { get; set; }
            public class CreateListenerRequestEndpointGroupConfigurationsPortOverrides : TeaModel {
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public long? EndpointPort { get; set; }

                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

            }

            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public long? ThresholdCount { get; set; }

            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public long? TrafficPercentage { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<CreateListenerRequestPortRanges> PortRanges { get; set; }
        public class CreateListenerRequestPortRanges : TeaModel {
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("ProxyProtocol")]
        [Validation(Required=false)]
        public bool? ProxyProtocol { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class CreateListenerRequestXForwardedForConfig : TeaModel {
            [NameInMap("XForwardedForGaApEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaApEnabled { get; set; }

            [NameInMap("XForwardedForGaIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaIdEnabled { get; set; }

            [NameInMap("XForwardedForPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForPortEnabled { get; set; }

            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            [NameInMap("XRealIpEnabled")]
            [Validation(Required=false)]
            public bool? XRealIpEnabled { get; set; }

        }

    }

}
