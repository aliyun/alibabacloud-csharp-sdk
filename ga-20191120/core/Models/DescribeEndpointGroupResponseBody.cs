// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeEndpointGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// Indicates the binding status between the Simple Log Service project and the endpoint group. Valid values:
        /// 
        /// *   **on:** The endpoint group is bound to the Simple Log Service project.
        /// *   **off:** The endpoint group is not bound to the Simple Log Service project.
        /// *   **binding:** The endpoint group is being bound to the Simple Log Service project.
        /// *   **unbinding:** The endpoint group is being unbound from the Simple Log Service project.
        /// </summary>
        [NameInMap("AccessLogSwitch")]
        [Validation(Required=false)]
        public string AccessLogSwitch { get; set; }

        /// <summary>
        /// The description of the endpoint group.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether the access log feature is enabled. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("EnableAccessLog")]
        [Validation(Required=false)]
        public bool? EnableAccessLog { get; set; }

        /// <summary>
        /// The configurations of endpoints in the endpoint group.
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyEndpointConfigurations> EndpointConfigurations { get; set; }
        public class DescribeEndpointGroupResponseBodyEndpointConfigurations : TeaModel {
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
            /// Indicates whether the proxy protocol is used to preserve client IP addresses.
            /// </summary>
            [NameInMap("EnableProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableProxyProtocol { get; set; }

            /// <summary>
            /// The IP address, domain name, or ID of the endpoint.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The port that is used to monitor latency.
            /// </summary>
            [NameInMap("ProbePort")]
            [Validation(Required=false)]
            public int? ProbePort { get; set; }

            /// <summary>
            /// The protocol that is used to monitor latency. Valid values:
            /// 
            /// *   **tcp**
            /// *   **icmp**
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
            /// *   **SLB:**: a Server Load Balancer (SLB) instance.
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
        /// The active endpoint IP addresses of the endpoint group.
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
        /// The type of endpoint group. Valid values:
        /// 
        /// *   **default**: a default endpoint group
        /// *   **virtual**: a virtual endpoint group
        /// </summary>
        [NameInMap("EndpointGroupType")]
        [Validation(Required=false)]
        public string EndpointGroupType { get; set; }

        /// <summary>
        /// The endpoint group IP addresses to be confirmed. After the GA instance is upgraded, the IP addresses that are added to the endpoint group need to be confirmed.
        /// </summary>
        [NameInMap("EndpointGroupUnconfirmedIpList")]
        [Validation(Required=false)]
        public List<string> EndpointGroupUnconfirmedIpList { get; set; }

        /// <summary>
        /// The version of the protocol that is used by the backend service.
        /// 
        /// *   **HTTP1.1**
        /// *   **HTTP2**
        /// </summary>
        [NameInMap("EndpointProtocolVersion")]
        [Validation(Required=false)]
        public string EndpointProtocolVersion { get; set; }

        /// <summary>
        /// The protocol that is used by the backend service.
        /// 
        /// *   **HTTP**
        /// *   **HTTPS**
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
        /// *   **true**: enabled
        /// *   **false**: disabled
        /// </summary>
        [NameInMap("HealthCheckEnabled")]
        [Validation(Required=false)]
        public bool? HealthCheckEnabled { get; set; }

        /// <summary>
        /// The interval between two consecutive health checks. Unit: seconds.
        /// </summary>
        [NameInMap("HealthCheckIntervalSeconds")]
        [Validation(Required=false)]
        public int? HealthCheckIntervalSeconds { get; set; }

        /// <summary>
        /// The path to which health check probes are sent.
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
        /// The mappings between ports.
        /// </summary>
        [NameInMap("PortOverrides")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyPortOverrides> PortOverrides { get; set; }
        public class DescribeEndpointGroupResponseBodyPortOverrides : TeaModel {
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the service that manages the GA instance.
        /// 
        /// >  This parameter takes effect only if **ServiceManaged** is set to **True**.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Indicates whether the instance is managed.
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// The actions that users can perform on the managed instance.
        /// >*   This parameter takes effect only if the value of **ServiceManaged** is **true**.
        /// >*   Users can perform only specific actions on a managed instance.
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeEndpointGroupResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// The name of the action on the managed instance.
            /// 
            /// *   **Create**
            /// *   **Update**
            /// *   **Delete**
            /// *   **Associate**
            /// *   **UserUnmanaged**
            /// *   **CreateChild**
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The type of the child resource.
            /// 
            /// *   **Listener:** listener.
            /// *   **IpSet:** acceleration region.
            /// *   **EndpointGroup:** endpoint group.
            /// *   **ForwardingRule:** forwarding rule.
            /// *   **Endpoint:** endpoint.
            /// *   **EndpointGroupDestination:** protocol mapping of an endpoint group associated with a custom routing listener.
            /// *   **EndpointPolicy:** traffic policy of an endpoint associated with a custom routing listener.
            /// 
            /// >  This parameter takes effect only if the value of **Action** is **CreateChild**.
            /// </summary>
            [NameInMap("ChildType")]
            [Validation(Required=false)]
            public string ChildType { get; set; }

            /// <summary>
            /// Indicates whether the specified actions are managed.
            /// 
            /// *   **true:** The specified actions are managed. Users cannot perform the specified actions on the managed instance.****
            /// *   **false:** The specified actions are not managed. Users can perform the specified actions on the managed instance.
            /// </summary>
            [NameInMap("IsManaged")]
            [Validation(Required=false)]
            public bool? IsManaged { get; set; }

        }

        /// <summary>
        /// The name of the Logstore.
        /// </summary>
        [NameInMap("SlsLogStoreName")]
        [Validation(Required=false)]
        public string SlsLogStoreName { get; set; }

        /// <summary>
        /// The name of the Log Service project.
        /// </summary>
        [NameInMap("SlsProjectName")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

        /// <summary>
        /// The region of the Log Service project.
        /// </summary>
        [NameInMap("SlsRegion")]
        [Validation(Required=false)]
        public string SlsRegion { get; set; }

        /// <summary>
        /// The status of the endpoint group. Valid values:
        /// 
        /// *   **init**: The endpoint group is being initialized.
        /// *   **active**: The endpoint group is running as expected.
        /// *   **updating**: The endpoint group is being updated.
        /// *   **deleting**: The endpoint group is being deleted.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The tag of the endpoint group.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyTags> Tags { get; set; }
        public class DescribeEndpointGroupResponseBodyTags : TeaModel {
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
        /// The traffic ratio of the endpoint group when the specified listener is associated with multiple endpoint groups.
        /// </summary>
        [NameInMap("TrafficPercentage")]
        [Validation(Required=false)]
        public int? TrafficPercentage { get; set; }

    }

}
