// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateEndpointGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the endpoint group.
        /// 
        /// The description can be up to 200 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The configurations of endpoints in the endpoint group.
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<CreateEndpointGroupRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class CreateEndpointGroupRequestEndpointConfigurations : TeaModel {
            /// <summary>
            /// Specifies whether to preserve client IP addresses by using the TCP Option Address (TOA) module. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// </summary>
            [NameInMap("EnableClientIPPreservation")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservation { get; set; }

            /// <summary>
            /// Specifies whether to use the proxy protocol to preserve client IP addresses. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// </summary>
            [NameInMap("EnableProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableProxyProtocol { get; set; }

            /// <summary>
            /// Enter the IP address, domain name, or instance ID based on the value of the Type parameter.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The private IP address of the ENI.
            /// 
            /// >  This parameter is available only when you set the endpoint type to **ENI**. If you leave this parameter empty, the primary private IP address of the ENI is used.
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
            /// *   **SLB:** a Classic Load Balancer (CLB) instance.
            /// *   **ALB:** an Application Load Balancer (ALB) instance.
            /// *   **OSS:** an Object Storage Service (OSS) bucket.
            /// *   **ENI:** an elastic network interface (ENI).
            /// *   **NLB:** a Network Load Balancer (NLB) instance.
            /// 
            /// > 
            /// 
            /// *   If you set this parameter to **ECS**, **ENI**, **SLB**, **ALB**, or **NLB** and the AliyunServiceRoleForGaVpcEndpoint service-linked role does not exist, the system automatically creates the service-linked role.
            /// 
            /// *   If you set this parameter to **ALB** and the AliyunServiceRoleForGaAlb service-linked role does not exist, the system automatically creates the role.
            /// 
            /// *   If you set this parameter to **OSS** and the AliyunServiceRoleForGaOss service-linked role does not exist, the system automatically creates the role.
            /// 
            /// *   If you set this parameter to **NLB** and the AliyunServiceRoleForGaNlb service-linked role does not exist, the system automatically creates the role.
            /// 
            /// For more information, see [Service-linked roles](https://help.aliyun.com/document_detail/178360.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The weight of the endpoint.
            /// 
            /// Valid values: **0** to **255**.
            /// 
            /// >  If you set the weight of an endpoint to 0, GA stops distributing traffic to the endpoint. Proceed with caution.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The ID of the region in which to create the endpoint group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointGroupRegion")]
        [Validation(Required=false)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// The type of the endpoint group. Valid values:
        /// 
        /// *   **default** (default): a default endpoint group.
        /// *   **virtual**: a virtual endpoint group.
        /// 
        /// >  When you call this operation to create a virtual endpoint group for a Layer 4 listener, make sure that a default endpoint group is created.
        /// </summary>
        [NameInMap("EndpointGroupType")]
        [Validation(Required=false)]
        public string EndpointGroupType { get; set; }

        /// <summary>
        /// The version of the protocol that is used by the backend service. Valid values:
        /// 
        /// - **HTTP1.1** (default)
        /// - **HTTP2**
        /// 
        /// >  This parameter is required only when you set the **EndpointRequestProtocol** parameter to **HTTPS**.
        /// </summary>
        [NameInMap("EndpointProtocolVersion")]
        [Validation(Required=false)]
        public string EndpointProtocolVersion { get; set; }

        /// <summary>
        /// The protocol that is used by the backend service. Default value: HTTP. Valid values:
        /// 
        /// *   **HTTP**
        /// *   **HTTPS**
        /// 
        /// > *   You can set this parameter only when the listener that is associated with the endpoint group uses **HTTP** or **HTTPS**.
        /// >*   For an **HTTP** listener, the backend service protocol must be **HTTP**.
        /// </summary>
        [NameInMap("EndpointRequestProtocol")]
        [Validation(Required=false)]
        public string EndpointRequestProtocol { get; set; }

        /// <summary>
        /// Specifies whether to enable the health check feature. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
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
        /// The path to which to send health check requests.
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
        /// The protocol over which to send health check requests. Valid values:
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The name of the endpoint group.
        /// 
        /// The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The mappings between ports.
        /// </summary>
        [NameInMap("PortOverrides")]
        [Validation(Required=false)]
        public List<CreateEndpointGroupRequestPortOverrides> PortOverrides { get; set; }
        public class CreateEndpointGroupRequestPortOverrides : TeaModel {
            /// <summary>
            /// The endpoint port that is mapped to the listener port.
            /// </summary>
            [NameInMap("EndpointPort")]
            [Validation(Required=false)]
            public int? EndpointPort { get; set; }

            /// <summary>
            /// The listener port that is mapped to the endpoint port.
            /// 
            /// > *   Only HTTP and HTTPS listeners support port mappings.
            /// >*   The listener port must be the one used by the current listener.
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

        }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Tags of GA instances.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEndpointGroupRequestTag> Tag { get; set; }
        public class CreateEndpointGroupRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the GA instance. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify up to 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the GA instance. The tag value cannot be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify up to 20 tag values.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of consecutive health check failures that must occur before a healthy endpoint group is considered unhealthy, or the number of consecutive health check successes that must occur before an unhealthy endpoint group is considered healthy.
        /// 
        /// Valid values: **2** to **10**. Default value: **3**.
        /// </summary>
        [NameInMap("ThresholdCount")]
        [Validation(Required=false)]
        public int? ThresholdCount { get; set; }

        /// <summary>
        /// The traffic ratio for the endpoint group when the specified listener is associated with multiple endpoint groups.
        /// 
        /// Valid values: **1** to **100**.
        /// </summary>
        [NameInMap("TrafficPercentage")]
        [Validation(Required=false)]
        public int? TrafficPercentage { get; set; }

    }

}
