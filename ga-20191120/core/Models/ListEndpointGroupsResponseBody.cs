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
            /// The configurations of endpoints in the endpoint group.
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsEndpointConfigurations : TeaModel {
                /// <summary>
                /// Indicates whether the client IP address preservation feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
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
                /// The protocol that is used to monitor latency.
                /// 
                /// *   **icmp**
                /// *   **tcp**
                /// </summary>
                [NameInMap("ProbeProtocol")]
                [Validation(Required=false)]
                public string ProbeProtocol { get; set; }

                /// <summary>
                /// The private IP address of the ENI.
                /// </summary>
                [NameInMap("SubAddress")]
                [Validation(Required=false)]
                public string SubAddress { get; set; }

                /// <summary>
                /// The type of the endpoint. Valid values:
                /// 
                /// *   **Domain:** a custom domain name.
                /// *   **Ip:** a custom IP address.
                /// *   **PublicIp:** a public IP address provided by Alibaba Cloud.
                /// *   **ECS:** an Elastic Compute Service (ECS) instance.
                /// *   **SLB:** a Classic Load Balancer (SLB) instance.
                /// *   **ALB:** an Application Load Balancer (ALB) instance.
                /// *   **OSS:** an Object Storage Service (OSS) bucket.
                /// *   **ENI:** an elastic network interface (ENI).
                /// *   **NLB:** a Network Load Balancer (NLB) instance.
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
            /// The ID of the endpoint group.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The endpoint group IP addresses.
            /// </summary>
            [NameInMap("EndpointGroupIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupIpList { get; set; }

            /// <summary>
            /// The ID of the region where the endpoint group is created.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The type of the endpoint group. Valid values:
            /// 
            /// *   **default**: a default endpoint group
            /// *   **virtual:** a virtual endpoint group.
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
            /// The protocol version that is used by the backend server.
            /// 
            /// *   **HTTP1.1**
            /// *   **HTTP2**
            /// </summary>
            [NameInMap("EndpointProtocolVersion")]
            [Validation(Required=false)]
            public string EndpointProtocolVersion { get; set; }

            /// <summary>
            /// The protocol that is used by the backend server.
            /// 
            /// *   **HTTP**
            /// *   **HTTPS**
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// The IDs of the forwarding rules that are associated with the endpoint group.
            /// </summary>
            [NameInMap("ForwardingRuleIds")]
            [Validation(Required=false)]
            public List<string> ForwardingRuleIds { get; set; }

            /// <summary>
            /// Indicates whether the health check feature is enabled.
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// The interval at which you want to perform health checks. Unit: seconds.
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public int? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// The path that is used for health checks.
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
            /// *   **tcp** or **TCP**
            /// *   **http** or **HTTP**
            /// *   **https** or **HTTPS**
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
            /// The port mapping.
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
            /// The service that manages the instance.
            /// 
            /// >  This parameter takes effect only if the value of **Service managed** is **true**.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// Indicates whether the GA instance is managed. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// The actions that users can perform on the managed instance.
            /// 
            /// > 
            /// 
            /// *   This parameter takes effect only if the value of **ServiceManaged** is **true**.
            /// 
            /// *   Users can perform only specific actions on a managed instance.
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos : TeaModel {
                /// <summary>
                /// The name of the action that was performed on the managed instance. Valid values:
                /// 
                /// *   **Create:** Create an instance.
                /// *   **Update:** Update the current instance.
                /// *   **Delete:** Delete the current instance.
                /// *   **Associate:** Reference the current instance.
                /// *   **UserUnmanaged:** Unmanage the instance.
                /// *   **CreateChild:** Create a child resource in the current instance.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The type of the child resource. Valid values:
                /// 
                /// *   **Listener:** listener.
                /// *   **IpSet:** acceleration region.
                /// *   **EndpointGroup:** endpoint group.
                /// *   **ForwardingRule:** forwarding rule.
                /// *   **Endpoint:** endpoint.
                /// *   **EndpointGroupDestination:** the protocol mapping of an endpoint group associated with a custom routing listener.
                /// *   **EndpointPolicy:** the traffic policy of an endpoint associated with a custom routing listener.
                /// 
                /// >  This parameter takes effect only if you set **Action** to **CreateChild**.
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// Indicates whether the specified actions are managed. Valid values:
                /// 
                /// *   **true**: The specified actions are managed, and users cannot perform the specified actions on the managed instance.
                /// *   **false**: The specified actions are not managed, and users can perform the specified actions on the managed instance.
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

            /// <summary>
            /// The status of the endpoint group. Valid values:
            /// 
            /// *   **init:** The endpoint group is being initialized.
            /// *   **active:** The endpoint group is running normally.
            /// *   **updating:**The endpoint group is being updated.
            /// *   **deleteing:** The endpoint group is being deleted.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The tag of the endpoint group.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsTags> Tags { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsTags : TeaModel {
                /// <summary>
                /// The tag key of the endpoint group.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the endpoint group.
                /// </summary>
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
            /// The value of the traffic distribution ratio. If a listener is associated with multiple endpoint groups, you can set this parameter to distribute different percentages of traffic to the endpoint groups.
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
