// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListEndpointGroupsResponseBody : TeaModel {
        /// <summary>
        /// The configurations of the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroups")]
        [Validation(Required=false)]
        public List<ListEndpointGroupsResponseBodyEndpointGroups> EndpointGroups { get; set; }
        public class ListEndpointGroupsResponseBodyEndpointGroups : TeaModel {
            /// <summary>
            /// The ID of the GA instance.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The description of the endpoint group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The configurations of the endpoint.
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsEndpointConfigurations : TeaModel {
                /// <summary>
                /// Indicates whether the client IP address preservation feature is enabled. Valid values:
                /// 
                /// *   **true**: The client IP address preservation feature is enabled.
                /// *   **false**: The client IP address preservation feature is disabled.
                /// </summary>
                [NameInMap("EnableClientIPPreservation")]
                [Validation(Required=false)]
                public bool? EnableClientIPPreservation { get; set; }

                /// <summary>
                /// The IP address or domain name of the endpoint.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The ID of the endpoint.
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// The port that is used to monitor latency.
                /// </summary>
                [NameInMap("ProbePort")]
                [Validation(Required=false)]
                public int? ProbePort { get; set; }

                /// <summary>
                /// The protocol that is used to monitor latency. Valid values:
                /// 
                /// *   **icmp**: ICMP
                /// *   **tcp**: TCP
                /// </summary>
                [NameInMap("ProbeProtocol")]
                [Validation(Required=false)]
                public string ProbeProtocol { get; set; }

                /// <summary>
                /// The type of the endpoint. Valid values:
                /// 
                /// *   **Domain**: a custom domain name
                /// *   **Ip**: a custom IP address
                /// *   **PublicIp**: a public IP address provided by Alibaba Cloud
                /// *   **ECS**: an Elastic Compute Service (ECS) instance
                /// *   **SLB**: a Server Load Balancer (SLB) instance
                /// *   **ALB**: an Application Load Balancer (ALB) instance
                /// *   **OSS**: an Object Storage Service (OSS) bucket
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The weight of the endpoint.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// The ID of an endpoint group.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The list of endpoint group IP addresses.
            /// </summary>
            [NameInMap("EndpointGroupIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupIpList { get; set; }

            /// <summary>
            /// The ID of the region where the endpoint group is deployed.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The type of the endpoint group. Valid values:
            /// 
            /// *   **default**: a default endpoint group
            /// *   **virtual**: a virtual endpoint group
            /// </summary>
            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            /// <summary>
            /// The endpoint group IP addresses to be confirmed after the GA instance is upgraded.
            /// </summary>
            [NameInMap("EndpointGroupUnconfirmedIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupUnconfirmedIpList { get; set; }

            /// <summary>
            /// The protocol that is used by the backend service. Valid values:
            /// 
            /// *   **HTTP**: HTTP
            /// *   **HTTPS**: HTTPS
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// The ID of the forwarding rule that is associated with the endpoint group.
            /// </summary>
            [NameInMap("ForwardingRuleIds")]
            [Validation(Required=false)]
            public List<string> ForwardingRuleIds { get; set; }

            /// <summary>
            /// Indicates whether the health check feature is enabled. Valid values:
            /// 
            /// *   **true**: The health check feature is enabled.
            /// *   **false**: The health check feature is disabled.
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// The interval at which health checks are performed. Unit: seconds.
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public int? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// The path to which health check requests are sent.
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// The port that is used for health checks.
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public int? HealthCheckPort { get; set; }

            /// <summary>
            /// The protocol over which health check requests are sent. Valid values:
            /// 
            /// *   **tcp**: TCP
            /// *   **http**: HTTP
            /// *   **https**: HTTPS
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// The ID of the listener.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The name of the endpoint group.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The mappings between ports.
            /// </summary>
            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsPortOverrides> PortOverrides { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsPortOverrides : TeaModel {
                /// <summary>
                /// The endpoint port.
                /// </summary>
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public int? EndpointPort { get; set; }

                /// <summary>
                /// The listener port.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

            }

            /// <summary>
            /// The state of the endpoint group. Valid values:
            /// 
            /// *   **init**: The endpoint group is being initialized.
            /// *   **active**: The endpoint group is running normally.
            /// *   **updating**:The endpoint group is being updated.
            /// *   **deleteing**: The endpoint group is being deleted.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsTags> Tags { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The number of consecutive failed health checks that must occur before an endpoint is considered unhealthy.
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public int? ThresholdCount { get; set; }

            /// <summary>
            /// The weight of the endpoint group when the listener is associated with multiple endpoint groups.
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public int? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
