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
        /// Indicates the status of the binding between the Log Service project and the endpoint group. Valid values:
        /// 
        /// *   **on**: The Log Service project is bound to the endpoint group.
        /// *   **off**: No Log Service projects are bound to the endpoint group.
        /// *   **binding**: The Log Service project is being bound to the endpoint group.
        /// *   **unbinding**: The Log Service project is being unbound from the endpoint group.
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
        /// *   **true**: enabled
        /// *   **false**: disabled
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
            /// *   **true:** The client IP address preservation feature is enabled.
            /// *   **false:** The client IP address preservation feature is disabled.
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
            /// The IP address or domain name of the endpoint.
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
            /// *   **tcp:** TCP.
            /// *   **icmp:** ICMP.
            /// </summary>
            [NameInMap("ProbeProtocol")]
            [Validation(Required=false)]
            public string ProbeProtocol { get; set; }

            /// <summary>
            /// The type of the endpoint. Valid values:
            /// 
            /// *   **Domain:** a custom domain name.
            /// *   **Ip:** a custom IP address.
            /// *   **PublicIp:** a public IP address provided by Alibaba Cloud.
            /// *   **ECS:** an Elastic Compute Service (ECS) instance.
            /// *   **SLB:** a Server Load Balancer (SLB) instance.
            /// *   **ALB:** an Application Load Balancer (ALB) instance.
            /// *   **OSS:** an Object Storage Service (OSS) bucket.
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
        public List<DescribeEndpointGroupResponseBodyPortOverrides> PortOverrides { get; set; }
        public class DescribeEndpointGroupResponseBodyPortOverrides : TeaModel {
            /// <summary>
            /// The endpoint port.
            /// </summary>
            [NameInMap("EndpointPort")]
            [Validation(Required=false)]
            public int? EndpointPort { get; set; }

            /// <summary>
            /// The listening port.
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
        /// 托管实例所属的服务方ID。
        /// > 仅在**ServiceManaged**参数为**True**时有效。
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 是否为托管实例。取值：
        /// 
        /// - **true**：是托管实例。
        /// 
        /// - **false**：不是托管实例。
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// 用户在此托管实例下可执行的动作策略列表。
        /// 
        /// > 仅在**ServiceManaged**参数为**True**时有效。
        /// > - 当实例处于托管状态时，用户对实例的操作会受到限制，某些操作行为会被禁止。
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeEndpointGroupResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// 托管策略动作名称，取值：
            /// - **Create**：创建实例。
            /// - **Update**：更新当前实例。
            /// - **Delete**：删除当前实例。
            /// - **Associate**：引用/被引用当前实例。
            /// - **UserUnmanaged**：用户解托管实例。
            /// - **CreateChild**：在当前实例下创建子资源。
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// 子资源类型，取值：
            /// 
            /// - **Listener**：监听资源。
            /// 
            /// - **IpSet**：加速地域资源。
            /// 
            /// - **EndpointGroup**：终端节点组资源。
            /// 
            /// - **ForwardingRule**：转发策略资源。
            /// 
            /// - **Endpoint**：终端节点资源。
            /// 
            /// - **EndpointGroupDestination**：自定义路由监听下的终端节点组协议映射资源。
            /// 
            /// - **EndpointPolicy**：自定义路由监听下的终端节点通行策略资源。
            /// 
            /// > 仅在**Action**参数为**CreateChild**时有效。
            /// </summary>
            [NameInMap("ChildType")]
            [Validation(Required=false)]
            public string ChildType { get; set; }

            /// <summary>
            /// 托管策略动作是否被托管，取值：
            /// - **true**：托管策略动作被托管，用户无权在托管实例下执行Action指定的操作。
            /// - **false**：托管策略动作未被托管，用户可在托管实例下执行Action指定的操作。
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
        /// Tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyTags> Tags { get; set; }
        public class DescribeEndpointGroupResponseBodyTags : TeaModel {
            /// <summary>
            /// The key of tag N that is added to the endpoint group.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that is added to the endpoint group.
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
        /// The weight of the endpoint group. If the listener is associated with multiple endpoint groups, this parameter indicates the weight of the current endpoint group.
        /// </summary>
        [NameInMap("TrafficPercentage")]
        [Validation(Required=false)]
        public int? TrafficPercentage { get; set; }

    }

}
