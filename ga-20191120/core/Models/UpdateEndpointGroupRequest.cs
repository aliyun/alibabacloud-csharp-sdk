// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateEndpointGroupRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the endpoint group.
        /// 
        /// The description cannot exceed 256 characters in length and cannot contain `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The information about the endpoints.
        /// 
        /// You can specify information for up to 20 endpoints.
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<UpdateEndpointGroupRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class UpdateEndpointGroupRequestEndpointConfigurations : TeaModel {
            /// <summary>
            /// Specifies whether to reserve client IP addresses. Default value: false. Valid values:
            /// 
            /// *   **true**: reserves client IP addresses.
            /// *   **false**: does not reserve client IP addresses.
            /// </summary>
            [NameInMap("EnableClientIPPreservation")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservation { get; set; }

            /// <summary>
            /// Specifies whether to preserve client IP addresses by using the ProxyProtocol module. Default value: false. Valid values:
            /// 
            /// *   **true**: preserves client IP addresses by using the ProxyProtocol module.
            /// *   **false**: does not preserve client IP addresses by using the ProxyProtocol module.
            /// </summary>
            [NameInMap("EnableProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableProxyProtocol { get; set; }

            /// <summary>
            /// The IP address or domain name of the endpoint.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The private IP address of the ENI.
            /// 
            /// > - When the Endpoint type is ENI, this parameter can be configured. If not configured, it defaults to the primary private IP address of ENI.
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
            /// *   **ECS:** Elastic Compute Service (ECS) instance.
            /// *   **SLB:** Server Load Balancer (SLB) instance.
            /// *   **ALB:** Application Load Balancer (ALB) instance.
            /// *   **OSS:** Object Storage Service (OSS) bucket.
            /// *   **ENI:** Elastic Network interface (ENI).
            /// *   **NLB:** Network Load Balancer (NLB) instance.
            /// 
            /// > *   If you set this parameter to **ECS** or **SLB** and the service-linked role AliyunServiceRoleForGaVpcEndpoint does not exist, the system automatically creates the service-linked role.
            /// > *   If you set this parameter to **ALB** and the service-linked role AliyunServiceRoleForGaAlb does not exist, the system automatically creates the service-linked role.
            /// > *   If you set this parameter to **OSS** and the service-linked role AliyunServiceRoleForGaOss does not exist, the system automatically creates the service-linked role.
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
            /// >  If the weight of an endpoint is set to 0, GA stops distributing network traffic to the endpoint. Proceed with caution.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The ID of the endpoint group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The ID of the region where the endpoint group is created.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointGroupRegion")]
        [Validation(Required=false)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// The protocol version that is used by the backend service. Valid values:
        /// 
        /// *   **HTTP1.1**
        /// *   **HTTP2**
        /// 
        /// > *   You can set this parameter only when the endpoint request protocol  uses **HTTPS** protocol.
        /// </summary>
        [NameInMap("EndpointProtocolVersion")]
        [Validation(Required=false)]
        public string EndpointProtocolVersion { get; set; }

        /// <summary>
        /// The protocol that is used by the backend service. Valid values:
        /// 
        /// *   **HTTP**
        /// *   **HTTPS**
        /// 
        /// > *   You can set this parameter only when the listener that is associated with the endpoint group uses the HTTP or HTTPS protocol.
        /// > *   For an HTTP listener, the backend service protocol must be HTTP.
        /// </summary>
        [NameInMap("EndpointRequestProtocol")]
        [Validation(Required=false)]
        public string EndpointRequestProtocol { get; set; }

        /// <summary>
        /// Specifies whether to enable the health check feature. Default value: true. Valid values:
        /// 
        /// *   **true**: enables the health check feature.
        /// *   **false**: disables the health check feature.
        /// </summary>
        [NameInMap("HealthCheckEnabled")]
        [Validation(Required=false)]
        public bool? HealthCheckEnabled { get; set; }

        /// <summary>
        /// The interval between two consecutive health checks. Unit: seconds. Valid values: **1** to **50**.
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
        /// The port that is used for health checks. Valid values: **1** to **65535**.
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
        /// The name of the endpoint group.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The mappings between ports.
        /// </summary>
        [NameInMap("PortOverrides")]
        [Validation(Required=false)]
        public List<UpdateEndpointGroupRequestPortOverrides> PortOverrides { get; set; }
        public class UpdateEndpointGroupRequestPortOverrides : TeaModel {
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
            /// > *   The listener port in a port mapping must be the one used by the current listener.
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
        /// The number of consecutive health check failures that must occur before a healthy endpoint group is considered unhealthy, or the number of consecutive health check successes that must occur before an unhealthy endpoint group is considered healthy.
        /// 
        /// Valid values: **2** to **10**.
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

}
