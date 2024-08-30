// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateListenerRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The SSL certificates.
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCertificates> Certificates { get; set; }
        public class CreateListenerRequestCertificates : TeaModel {
            /// <summary>
            /// The ID of the SSL certificate.
            /// 
            /// > This parameter is required only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable client affinity for the listener.
        /// 
        /// *   If this parameter is left empty, client affinity is disabled. After client affinity is disabled, requests from a specific client IP address may be forwarded to different endpoints.
        /// *   To enable client affinity, set this parameter to **SOURCE_IP**. In this case, when a client accesses stateful applications, requests from the same client are forwarded to the same endpoint regardless of the source port or protocol.
        /// </summary>
        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** is different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The endpoint group that is associated with the custom routing listener.
        /// 
        /// You can configure at most five endpoint groups for a custom routing listener.
        /// 
        /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
        /// </summary>
        [NameInMap("CustomRoutingEndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurations> CustomRoutingEndpointGroupConfigurations { get; set; }
        public class CreateListenerRequestCustomRoutingEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// The description of the endpoint group that is associated with the custom routing listener.
            /// 
            /// The description cannot exceed 256 characters in length and cannot contain `http://` or `https://`.
            /// 
            /// You can specify at most five endpoint group descriptions.
            /// 
            /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The mapping configurations of the endpoint group that is associated with the custom routing listener.
            /// 
            /// You need to specify the port ranges and protocols used by the endpoint group. The ports are mapped to listener ports.
            /// 
            /// You can specify at most 20 mapping configurations for an endpoint group of a custom routing listener.
            /// 
            /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
            /// </summary>
            [NameInMap("DestinationConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsDestinationConfigurations> DestinationConfigurations { get; set; }
            public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsDestinationConfigurations : TeaModel {
                /// <summary>
                /// The first port used by the endpoint group that is associated with the custom routing listener.
                /// 
                /// Valid values: **1** to **65499**. The value of **FromPort** must be equal to or smaller than the value of **ToPort**.
                /// 
                /// You can specify up to 20 first ports for an endpoint group of a custom routing listener.
                /// 
                /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// The protocol used by the endpoint group that is associated with the custom routing listener.
                /// 
                /// You can specify up to four protocols in each mapping configuration for an endpoint group of a custom routing listener.
                /// 
                /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

                /// <summary>
                /// The last port used by the endpoint group that is associated with the custom routing listener.
                /// 
                /// Valid values: **1** to **65499**. The value of **FromPort** must be equal to or smaller than the value of **ToPort**.
                /// 
                /// You can specify up to 20 last ports for an endpoint group of a custom routing listener.
                /// 
                /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            /// <summary>
            /// The endpoint that is associated with the custom routing listener.
            /// 
            /// You can configure at most 10 endpoints for an endpoint group of a custom routing listener.
            /// 
            /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// The name of the vSwitch that is specified as an endpoint.
                /// 
                /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The destination in the endpoint that is associated with the custom routing listener.
                /// 
                /// You can specify at most 20 destinations in each endpoint of a custom routing listener.
                /// 
                /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("PolicyConfigurations")]
                [Validation(Required=false)]
                public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
                public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations : TeaModel {
                    /// <summary>
                    /// The IP address of the destination to which traffic is forwarded.
                    /// 
                    /// This parameter takes effect only if **TrafficToEndpointPolicy** is set to **AllowCustom**.
                    /// 
                    /// You can specify up to 20 destination IP addresses for each endpoint of a custom routing listener.
                    /// 
                    /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                    /// </summary>
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// The port range of the destination to which traffic is forwarded. The value of this parameter must fall within the port range of the endpoint group.
                    /// 
                    /// If you leave this parameter empty, traffic is distributed to all destination ports.
                    /// 
                    /// This parameter takes effect only if **TrafficToEndpointPolicy** is set to **AllowCustom**.
                    /// 
                    /// You can specify port ranges for up to 20 destinations in each endpoint of a custom routing listener. You can specify up to five port ranges for each destination.
                    /// 
                    /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                    /// </summary>
                    [NameInMap("PortRanges")]
                    [Validation(Required=false)]
                    public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                    public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                        /// <summary>
                        /// The first port of the destination port range. The value of this parameter must be in the port range of the endpoint group.
                        /// 
                        /// This parameter takes effect only if **TrafficToEndpointPolicy** is set to **AllowCustom**.
                        /// 
                        /// You can specify port ranges for up to 20 destinations in each endpoint of a custom routing listener. You can specify up to five first ports for each destination.
                        /// 
                        /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                        /// </summary>
                        [NameInMap("FromPort")]
                        [Validation(Required=false)]
                        public int? FromPort { get; set; }

                        /// <summary>
                        /// The last port of the destination port range. The value of this parameter must be in the port range of the endpoint group.
                        /// 
                        /// This parameter takes effect only if **TrafficToEndpointPolicy** is set to **AllowCustom**.
                        /// 
                        /// You can specify port ranges for up to 20 destinations in each endpoint of a custom routing listener. You can specify up to five end ports for each destination.
                        /// 
                        /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                        /// </summary>
                        [NameInMap("ToPort")]
                        [Validation(Required=false)]
                        public int? ToPort { get; set; }

                    }

                }

                /// <summary>
                /// The traffic policy for the endpoint that is associated with the custom routing listener. Valid values:
                /// 
                /// *   **DenyAll** (default): denies all traffic to the endpoint.
                /// *   **AllowAll**: allows all traffic to the endpoint.
                /// *   **AllowCustom**: allows traffic only to specified destinations in the endpoint.
                /// 
                /// If you set this parameter to AllowCustom, you must specify IP addresses and port ranges as the destinations to which traffic is distributed. If you specify only IP addresses and do not specify port ranges, GA can forward traffic to the specified IP addresses over all destination ports.
                /// 
                /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("TrafficToEndpointPolicy")]
                [Validation(Required=false)]
                public string TrafficToEndpointPolicy { get; set; }

                /// <summary>
                /// The service type of the endpoint that is associated with the custom routing listener.
                /// 
                /// Set the value to **PrivateSubNet**, which specifies a private CIDR block.
                /// 
                /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The region ID of the endpoint group that is associated with the custom routing listener.
            /// 
            /// You can enter the region IDs of up to five endpoint groups.
            /// 
            /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The name of the endpoint group that is associated with the custom routing listener.
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.
            /// 
            /// You can specify at most five endpoint group names.
            /// 
            /// > You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The description of the listener. The description can be at most 200 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The endpoint groups that are associated with the intelligent routing listener.
        /// 
        /// You can configure up to 10 endpoint groups for an intelligent routing listener.
        /// 
        /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
        /// </summary>
        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateListenerRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateListenerRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// Specifies whether to use the proxy protocol to preserve client IP addresses. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// You can specify this parameter for up to 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("EnableClientIPPreservationProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationProxyProtocol { get; set; }

            /// <summary>
            /// Specifies whether to preserve client IP addresses by using the TCP Option Address (TOA) module. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// You can specify this parameter for up to 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("EnableClientIPPreservationToa")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationToa { get; set; }

            /// <summary>
            /// The endpoint that is associated with the intelligent routing listener.
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateListenerRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// The IP address or domain name of the endpoint that is associated with the intelligent routing listener.
                /// 
                /// You can specify up to 100 endpoint IP addresses or domain names for an endpoint group of an intelligent routing listener.
                /// 
                /// >  If you set **Type** to **Standard**, you can configure endpoint groups and endpoints, and this parameter is required.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The private IP address of the elastic network interface (ENI).
                /// 
                /// >  If the endpoint type is **ENI**, you can specify this parameter. If you do not specify this parameter, the primary private IP address of the ENI is used.
                /// </summary>
                [NameInMap("SubAddress")]
                [Validation(Required=false)]
                public string SubAddress { get; set; }

                /// <summary>
                /// The type of the endpoint that is associated with the intelligent routing listener. Valid values:
                /// 
                /// *   **Domain**: a custom domain name
                /// *   **Ip**: a custom IP address
                /// *   **PublicIp**: a public IP address provided by Alibaba Cloud
                /// *   **ECS**: an Elastic Compute Service (ECS) instance
                /// *   **SLB**: a Server Load Balancer (SLB) instance
                /// *   **ALB**: an Application Load Balancer (ALB) instance
                /// *   **OSS**: an Object Storage Service (OSS) bucket
                /// 
                /// You can specify up to 100 endpoint types for an endpoint group of an intelligent routing listener.
                /// 
                /// > *   If you set **Type** to **Standard**, you can configure endpoint groups and endpoints for an intelligent routing listener, and this parameter is required.
                /// >*   If you set this parameter to **ECS** or **SLB** and the service-linked role AliyunServiceRoleForGaVpcEndpoint does not exist, the system automatically creates the service-linked role.
                /// >*   If you set this parameter to **ALB** and the service-linked role AliyunServiceRoleForGaAlb does not exist, the system automatically creates the service-linked role.
                /// >*   If you set this parameter to **OSS** and the service-linked role AliyunServiceRoleForGaOss does not exist, the system automatically creates the service-linked role.  
                /// > For more information, see [Service linked roles](https://help.aliyun.com/document_detail/178360.html).
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The weight of the endpoint that is associated with the intelligent routing listener.
                /// 
                /// Valid values: **0** to **255**.
                /// 
                /// You can specify the weights of up to 100 endpoints for an endpoint group of an intelligent routing listener.
                /// 
                /// > *   If you set **Type** to **Standard**, you can configure endpoint groups and endpoints for an intelligent routing listener, and this parameter is required.
                /// >*   If you set the weight of an endpoint to 0, GA does not route network traffic to the endpoint. Make sure that you are aware of the impact on your business before you set the endpoint weight to 0.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            /// <summary>
            /// The description of the endpoint group that is associated with the intelligent routing listener.
            /// 
            /// The description can be up to 256 characters in length and cannot contain `http://` or `https://`.
            /// 
            /// You can enter the descriptions of up to 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("EndpointGroupDescription")]
            [Validation(Required=false)]
            public string EndpointGroupDescription { get; set; }

            /// <summary>
            /// The name of the endpoint group that is associated with the intelligent routing listener.
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.
            /// 
            /// You can enter the names of up to 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("EndpointGroupName")]
            [Validation(Required=false)]
            public string EndpointGroupName { get; set; }

            /// <summary>
            /// The region ID of the endpoint group that is associated with the intelligent routing listener.
            /// 
            /// You can enter the region IDs of up to 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The type of the endpoint group associated with the intelligent routing listener. Valid values:
            /// 
            /// *   **default** (default)
            /// *   **virtual**
            /// 
            /// You can specify up to 10 endpoint group types.
            /// 
            /// > *   You can configure endpoint groups and endpoints for an intelligent routing listener only if you set **Type** to **Standard**.
            /// >*   Only HTTP intelligent routing listeners and HTTPS intelligent routing listeners support virtual endpoint groups.
            /// </summary>
            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            /// <summary>
            /// The backend service protocol version of the endpoint that is associated with the intelligent routing listener. Valid values:
            /// 
            /// *   **HTTP1.1** (default)
            /// *   **HTTP2**
            /// 
            /// >*   You can specify this parameter only for **HTTPS** endpoint request protocol.
            /// </summary>
            [NameInMap("EndpointProtocolVersion")]
            [Validation(Required=false)]
            public string EndpointProtocolVersion { get; set; }

            /// <summary>
            /// The backend service protocol of the endpoint that is associated with the intelligent routing listener. Valid values:
            /// 
            /// *   **HTTP** (default)
            /// *   **HTTPS**
            /// 
            /// You can specify up to 10 backend service protocols.
            /// 
            /// > *   You can configure endpoint groups and endpoints for an intelligent routing listener only if you set **Type** to **Standard**.
            /// >*   You can specify this parameter only for HTTP and HTTPS intelligent routing listeners.
            /// >*   For an HTTP listener, the protocol must be **HTTP**.
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// Specifies whether to enable health checks for the endpoint group. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// You can enable the health check feature for up to 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// The interval at which health checks are performed. Unit: seconds.
            /// 
            /// You can specify up to 10 health check intervals.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public long? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// The path to which health check requests are sent.
            /// 
            /// You can specify up to 10 health check paths.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// The port that is used for health checks. Valid values: **1** to **65535**.
            /// 
            /// You can specify up to 10 health check ports.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public long? HealthCheckPort { get; set; }

            /// <summary>
            /// The protocol over which health check requests are sent. Valid values:
            /// 
            /// *   **tcp**
            /// *   **http**
            /// *   **https**
            /// 
            /// You can specify up to 10 health check protocols.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// The port mapping.
            /// </summary>
            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<CreateListenerRequestEndpointGroupConfigurationsPortOverrides> PortOverrides { get; set; }
            public class CreateListenerRequestEndpointGroupConfigurationsPortOverrides : TeaModel {
                /// <summary>
                /// The endpoint port that is mapped to the listener port.
                /// 
                /// You can specify up to five endpoint ports.
                /// 
                /// >*   You can configure endpoint groups and endpoints for an intelligent routing listener only if you set **Type** to **Standard**.
                /// >*   Only HTTP and HTTPS intelligent routing listeners support port mappings.
                /// </summary>
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public long? EndpointPort { get; set; }

                /// <summary>
                /// The listener port that is mapped to the endpoint port.
                /// 
                /// You can specify up to five listener ports.
                /// 
                /// > *   You can configure endpoint groups and endpoints for an intelligent routing listener only if you set **Type** to **Standard**.
                /// >*   Only HTTP and HTTPS intelligent routing listeners support port mappings.
                /// >*   The listener port in a port mapping must be the port that is used by the current listener.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

            }

            /// <summary>
            /// The number of consecutive health check failures that must occur before a healthy endpoint group is considered unhealthy, or the number of consecutive health check successes that must occur before an unhealthy endpoint group is considered healthy. Valid values: **2** to **10**. Default value: **3**.
            /// 
            /// You can specify the number of successful consecutive health checks or failed consecutive health checks for up to 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public long? ThresholdCount { get; set; }

            /// <summary>
            /// The traffic distribution ratio. If an intelligent routing listener is associated with multiple endpoint groups, you can configure this parameter to specify the ratio of traffic distributed to each endpoint group.
            /// 
            /// Valid values: **1** to **100**. Default value: **100**.
            /// 
            /// You can specify traffic distribution ratios for up to 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints only if you set **Type** to **Standard**.
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public long? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// The maximum version of the HTTP protocol. Valid values:
        /// 
        /// *   **http3**
        /// *   **http2** (default)
        /// *   **http1.1**
        /// 
        /// >  Only HTTPS listeners support this parameter.
        /// </summary>
        [NameInMap("HttpVersion")]
        [Validation(Required=false)]
        public string HttpVersion { get; set; }

        /// <summary>
        /// The timeout period of idle connections. Unit: seconds.
        /// 
        /// *   TCP: 10-900. Default value: 900. Unit: seconds.
        /// *   UDP: 10-20. Default value: 20. Unit: seconds.
        /// *   HTTP/HTTPS: 1-60. Default value: 15. Unit: seconds.
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// The name of the listener.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The listener ports. Valid values: **1** to **65499**. The maximum number of ports that can be configured depends on the routing type and protocol of the listener. For more information, see [Listener overview](https://help.aliyun.com/document_detail/153216.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<CreateListenerRequestPortRanges> PortRanges { get; set; }
        public class CreateListenerRequestPortRanges : TeaModel {
            /// <summary>
            /// The first port of the listener port range that you want to use to receive and forward requests to endpoints.
            /// 
            /// Valid values: **1** to **65499**. The value of **FromPort** must be smaller than or equal to the value of **ToPort**.
            /// 
            /// The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see [Listener overview](https://help.aliyun.com/document_detail/153216.html).
            /// 
            /// > You can configure only one listener port for an HTTP or HTTPS listener. In this case, the first port is the same as the last port.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The last port of the listener port range that you want to use to receive and forward requests to endpoints.
            /// 
            /// Valid values: **1** to **65499**. The value of **FromPort** must be smaller than or equal to the value of **ToPort**.
            /// 
            /// The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see [Listener overview](https://help.aliyun.com/document_detail/153216.html).
            /// 
            /// > You can configure only one listener port for an HTTP or HTTPS listener. In this case, the first port is the same as the last port.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// The network transmission protocol that you want to use for the listener. Valid values:
        /// 
        /// *   **tcp**: TCP
        /// *   **udp**: UDP
        /// *   **http**: HTTP
        /// *   **https**: HTTPS
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Specifies whether to preserve client IP addresses. Valid values:
        /// 
        /// *   **true**: enables the feature. After client IP addresses are preserved, you can view client IP addresses on the endpoints.
        /// *   **false** (default): disables the feature.
        /// 
        /// > This parameter will be deprecated in the API operations that are used to configure listeners. We recommend that you set this parameter when you call API operations to configure endpoint groups. For more information about the **ProxyProtocol** parameter, see [CreateEndpointGroup](https://help.aliyun.com/document_detail/153259.html) and [UpdateEndpointGroup](https://help.aliyun.com/document_detail/153262.html).
        /// </summary>
        [NameInMap("ProxyProtocol")]
        [Validation(Required=false)]
        public bool? ProxyProtocol { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The timeout period for HTTP or HTTPS requests. Unit: seconds.
        /// 
        /// Valid values: 1 to 180. Default value: 60. Unit: seconds.
        /// 
        /// >  This parameter takes effect only for HTTP or HTTPS listeners. If the backend server does not respond within the timeout period, GA returns an HTTP 504 error code to the client.
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// The ID of the security policy. Valid values:
        /// 
        /// *   **tls_cipher_policy_1_0**
        /// 
        ///     *   Supported Transport Layer Security (TLS) versions: TLS 1.0, TLS 1.1, and TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.
        /// 
        /// *   **tls_cipher_policy_1_1**
        /// 
        ///     *   Supported TLS versions: TLS 1.1 and TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.
        /// 
        /// *   **tls_cipher_policy_1_2**
        /// 
        ///     *   Supported TLS version: TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.
        /// 
        /// *   **tls_cipher_policy_1_2_strict**
        /// 
        ///     *   Supported TLS version: TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
        /// 
        /// *   **tls_cipher_policy_1_2_strict_with_1_3**
        /// 
        ///     *   Supported TLS versions: TLS 1.2 and TLS 1.3
        ///     *   Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
        /// 
        /// > This parameter is available only when you create an HTTPS listener.
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// The routing type of the listener. Valid values:
        /// 
        /// *   **Standard** (default): intelligent routing
        /// *   **CustomRouting**: custom routing
        /// 
        /// > *   Custom routing listeners are in invitational preview. To use custom routing listeners, contact your account manager.
        /// > *   You can create only listeners of the same routing type for a standard GA instance. You cannot change the routing types of listeners. For more information, see [Listener overview](https://help.aliyun.com/document_detail/153216.html).
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The `XForward` headers.
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class CreateListenerRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// Specifies whether to use the `GA-AP` header to retrieve the information about acceleration regions. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// > This parameter is available only when you create an HTTPS or HTTP listener.
            /// </summary>
            [NameInMap("XForwardedForGaApEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaApEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `GA-ID` header to retrieve the ID of the GA instance. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// > This parameter is available only when you create an HTTPS or HTTP listener.
            /// </summary>
            [NameInMap("XForwardedForGaIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaIdEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `GA-X-Forward-Port` header to retrieve the listener ports of the GA instance. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// > This parameter is available only when you create an HTTPS or HTTP listener.
            /// </summary>
            [NameInMap("XForwardedForPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForPortEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `GA-X-Forward-Proto` header to retrieve the listener protocol of the GA instance. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// > This parameter is available only when you create an HTTPS or HTTP listener.
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Real-IP` header to retrieve client IP addresses. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// > This parameter is available only when you create an HTTPS or HTTP listener.
            /// </summary>
            [NameInMap("XRealIpEnabled")]
            [Validation(Required=false)]
            public bool? XRealIpEnabled { get; set; }

        }

    }

}
