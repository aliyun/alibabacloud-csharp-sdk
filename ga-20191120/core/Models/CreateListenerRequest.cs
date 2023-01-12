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
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCertificates> Certificates { get; set; }
        public class CreateListenerRequestCertificates : TeaModel {
            /// <summary>
            /// The ID of the SSL certificate.
            /// 
            /// >  This parameter is required only if an HTTPS listener is created.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable client affinity for the listener.
        /// 
        /// *   If this parameter is left empty, client affinity is disabled. If client affinity is disabled, requests from the same client are not always forwarded to the same endpoint.
        /// *   To enable client affinity, set this parameter to **SOURCE_IP**. In this case, when a client accesses stateful applications, requests from the same client are always forwarded to the same endpoint regardless of the source port or protocol.
        /// </summary>
        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among all requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CustomRoutingEndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurations> CustomRoutingEndpointGroupConfigurations { get; set; }
        public class CreateListenerRequestCustomRoutingEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// The description of the endpoint group that is associated with the custom routing listener.
            /// 
            /// The description cannot exceed 256 characters in length and cannot contain `http://` or `https://`.
            /// 
            /// You can enter the descriptions of at most five endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsDestinationConfigurations> DestinationConfigurations { get; set; }
            public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsDestinationConfigurations : TeaModel {
                /// <summary>
                /// The first port of the backend service of the endpoint group that is associated with the custom routing listener.
                /// 
                /// Valid values: **1** to **65499**. The value of **FromPort** must be equal to or smaller than the value of **ToPort**.
                /// 
                /// You can specify at most 20 first ports of backend services for an endpoint group of a custom routing listener.
                /// 
                /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

                /// <summary>
                /// The last port of the backend service of the endpoint group that is associated with the custom routing listener.
                /// 
                /// Valid values: **1** to **65499**. The value of **FromPort** must be equal to or smaller than the value of **ToPort**.
                /// 
                /// You can specify at most 20 last ports of backend services for an endpoint group of a custom routing listener.
                /// 
                /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// The name of the endpoint vSwitch of the custom routing listener.
                /// 
                /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("PolicyConfigurations")]
                [Validation(Required=false)]
                public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
                public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations : TeaModel {
                    /// <summary>
                    /// The IP address of the destination that allows traffic.
                    /// 
                    /// This parameter takes effect only if **TrafficToEndpointPolicy** is set to **AllowCustom**.
                    /// 
                    /// You can specify up to 20 destination IP addresses for each endpoint of a custom routing listener.
                    /// 
                    /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                    /// </summary>
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("PortRanges")]
                    [Validation(Required=false)]
                    public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                    public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                        /// <summary>
                        /// The first port of the port range of the destination that allows traffic. The value of this parameter must fall within the port range of the backend service.
                        /// 
                        /// This parameter takes effect only if **TrafficToEndpointPolicy** is set to **AllowCustom**.
                        /// 
                        /// You can specify up to 20 destination port ranges for each endpoint of a custom routing listener. You can specify up to five first ports for each destination.
                        /// 
                        /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                        /// </summary>
                        [NameInMap("FromPort")]
                        [Validation(Required=false)]
                        public int? FromPort { get; set; }

                        /// <summary>
                        /// The last port of the port range of the destination that allows traffic. The value of this parameter must fall within the port range of the backend service.
                        /// 
                        /// This parameter takes effect only if **TrafficToEndpointPolicy** is set to **AllowCustom**.
                        /// 
                        /// You can specify up to 20 destination port ranges for each endpoint of a custom routing listener. You can specify up to five last ports for each destination.
                        /// 
                        /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                        /// </summary>
                        [NameInMap("ToPort")]
                        [Validation(Required=false)]
                        public int? ToPort { get; set; }

                    }

                }

                /// <summary>
                /// The traffic policy of the backend service of the endpoint that is associated with the custom routing listener. Valid values:
                /// 
                /// *   **DenyAll** (default): denies all traffic to the specified backend service.
                /// 
                /// *   **AllowAll**: allows all traffic to the specified backend service.
                /// 
                /// *   **AllowCustom**: allows traffic to a specified destination.
                /// 
                ///     You must specify the IP address and port range of the destination. If the port range is empty, all ports are available.
                /// 
                /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("TrafficToEndpointPolicy")]
                [Validation(Required=false)]
                public string TrafficToEndpointPolicy { get; set; }

                /// <summary>
                /// The backend service type of the endpoint that is associated with the custom routing listener. Set the value to
                /// 
                /// **PrivateSubNet**, which specifies a private CIDR block.
                /// 
                /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The region ID of the endpoint group that is associated with the custom routing listener.
            /// 
            /// You can enter the region IDs of at most five endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The name of the endpoint group that is associated with the custom routing listener.
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
            /// 
            /// You can enter the names of at most five endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for a custom routing listener only if the **Type** parameter is set to **CustomRouting**.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The description of the listener.
        /// 
        /// The description can be at most 200 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateListenerRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateListenerRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// Specifies whether to use the proxy protocol to preserve client IP addresses. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// You can set this parameter for at most 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("EnableClientIPPreservationProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationProxyProtocol { get; set; }

            /// <summary>
            /// Specifies whether to obtain and preserve the IP addresses of clients that access the endpoint by using the TCP Option Address (TOA) module. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// You can set this parameter for at most 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("EnableClientIPPreservationToa")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationToa { get; set; }

            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateListenerRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// The IP address or domain name of the endpoint that is associated with the intelligent routing listener.
                /// 
                /// You can specify at most 100 endpoint IP addresses or domain names for an endpoint group of an intelligent routing listener.
                /// 
                /// >  If the **Type** parameter is set to **Standard**, you can configure endpoint groups and endpoints for an intelligent routing listener, and this parameter is required.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The endpoint type of the intelligent routing listener. Valid values:
                /// 
                /// *   **Domain**: a custom domain name
                /// *   **Ip**: a custom IP address
                /// *   **PublicIp**: a public IP address provided by Alibaba Cloud
                /// *   **ECS**: an Elastic Compute Service (ECS) instance
                /// *   **SLB**: a Server Load Balancer (SLB) instance
                /// *   **ALB**: an Application Load Balancer (ALB) instance
                /// *   **OSS**: an Object Storage Service (OSS) bucket
                /// 
                /// You can specify at most 100 endpoint types for an endpoint group of an intelligent routing listener.
                /// 
                /// > 
                /// *   If the **Type** parameter is set to **Standard**, you can configure endpoint groups and endpoints for an intelligent routing listener, and this parameter is required.
                /// *   If you set this parameter to **ECS** or **SLB** and the service-linked role AliyunServiceRoleForGaVpcEndpoint does not exist, the system automatically creates the service-linked role.
                /// *   If you set this parameter to **ALB** and the service-linked role AliyunServiceRoleForGaAlb does not exist, the system automatically creates the service-linked role.
                /// *   If you set this parameter to **OSS** and the service-linked role AliyunServiceRoleForGaOss does not exist, the system automatically creates the service-linked role.
                /// 
                /// For more information, see [Service-linked roles](~~178360~~).
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The weight of the endpoint that is associated with the intelligent routing listener.
                /// 
                /// Valid values: **0** to **255**.
                /// 
                /// You can set the weights of at most 100 endpoints for an endpoint group of an intelligent routing listener.
                /// 
                /// > 
                /// *   If the **Type** parameter is set to **Standard**, you can configure endpoint groups and endpoints for an intelligent routing listener, and this parameter is required.
                /// *   If the weight of an endpoint is set to 0, GA stops distributing network traffic to the endpoint. Proceed with caution.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            /// <summary>
            /// The description of the endpoint group that is associated with the intelligent routing listener.
            /// 
            /// The description cannot exceed 256 characters in length and cannot contain `http://` or `https://`.
            /// 
            /// You can enter the descriptions of at most 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("EndpointGroupDescription")]
            [Validation(Required=false)]
            public string EndpointGroupDescription { get; set; }

            /// <summary>
            /// The name of the endpoint group that is associated with the intelligent routing listener.
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
            /// 
            /// You can enter the names of at most 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("EndpointGroupName")]
            [Validation(Required=false)]
            public string EndpointGroupName { get; set; }

            /// <summary>
            /// The region ID of the endpoint group that is associated with the intelligent routing listener.
            /// 
            /// You can enter the region IDs of at most 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The endpoint group type of the intelligent routing listener. Valid values:
            /// 
            /// *   **default**: a default endpoint group. This is the default value.
            /// *   **virtual**: a virtual endpoint group.
            /// 
            /// You can specify the types of at most 10 endpoint groups.
            /// 
            /// > 
            /// *   You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// *   Only HTTP and HTTPS intelligent routing listeners support virtual endpoint groups.
            /// </summary>
            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            /// <summary>
            /// The backend service protocol of the endpoint that is associated with the intelligent routing listener. Valid values:
            /// 
            /// *   **HTTP** (default): HTTP
            /// *   **HTTPS**: HTTPS
            /// 
            /// You can specify at most 10 backend service protocols.
            /// 
            /// > 
            /// *   You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// *   You can set this parameter only for HTTP and HTTPS intelligent routing listeners.
            /// *   For an HTTP listener, the backend service protocol must be **HTTP**.
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// Specifies whether to enable health checks for the endpoint group. Valid values:
            /// 
            /// *   **true**: enables the health check feature.
            /// *   **false** (default): disables the health check feature.
            /// 
            /// You can enable the health check feature for at most 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// The interval at which health checks are performed. Unit: seconds.
            /// 
            /// You can specify at most 10 health check intervals.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public long? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// The path based on which the system performs health checks.
            /// 
            /// You can specify at most 10 health check paths.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// The port that is used for health checks. Valid values: **1** to **65535**.
            /// 
            /// You can specify at most 10 ports for health checks.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public long? HealthCheckPort { get; set; }

            /// <summary>
            /// The protocol over which health check requests are sent. Valid values:
            /// 
            /// *   **tcp**: TCP
            /// *   **http**: HTTP
            /// *   **https**: HTTPS
            /// 
            /// You can specify at most 10 health check protocols.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<CreateListenerRequestEndpointGroupConfigurationsPortOverrides> PortOverrides { get; set; }
            public class CreateListenerRequestEndpointGroupConfigurationsPortOverrides : TeaModel {
                /// <summary>
                /// The endpoint port that is mapped to the listening port.
                /// 
                /// You can specify endpoint ports in at most five port mappings.
                /// 
                /// > 
                /// *   You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
                /// *   Only HTTP and HTTPS intelligent routing listeners support port mappings.
                /// </summary>
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public long? EndpointPort { get; set; }

                /// <summary>
                /// The listening port that is mapped to the endpoint port.
                /// 
                /// You can specify listening ports in at most five port mappings.
                /// 
                /// > 
                /// *   You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
                /// *   Only HTTP and HTTPS intelligent routing listeners support port mappings.
                /// *   The listening port in a port mapping must be the one used by the current listener.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

            }

            /// <summary>
            /// The number of consecutive health check failures that must occur before a healthy endpoint group is considered unhealthy, or the number of consecutive health check successes that must occur before an unhealthy endpoint group is considered healthy.
            /// 
            /// Valid values: **2** to **10**. Default value: **3**.
            /// 
            /// You can specify the number of consecutive health check successes or failures for at most 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public long? ThresholdCount { get; set; }

            /// <summary>
            /// The traffic distribution ratio. If an intelligent routing listener is associated with multiple endpoint groups, you can set this parameter to distribute traffic to the endpoint groups based on ratios.
            /// 
            /// Valid values: **1** to **100**. Default value: **100**.
            /// 
            /// You can specify the traffic distribution ratios for at most 10 endpoint groups.
            /// 
            /// >  You can configure endpoint groups and endpoints for an intelligent routing listener only if the **Type** parameter is set to **Standard**.
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public long? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// The name of the listener.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<CreateListenerRequestPortRanges> PortRanges { get; set; }
        public class CreateListenerRequestPortRanges : TeaModel {
            /// <summary>
            /// The first port in the range of listening ports that are used to receive and forward requests to endpoints.
            /// 
            /// Valid values: **1** to **65499**. The value of **FromPort** must be smaller than or equal to the value of **ToPort**.
            /// 
            /// The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see [Listening ports](~~153216~~).
            /// 
            /// >  You can configure only one listening port for an HTTP or HTTPS listener. In this case, the first port also serves as the last port.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The last port in the range of listening ports that are used to receive and forward requests to endpoints.
            /// 
            /// Valid values: **1** to **65499**. The value of **FromPort** must be smaller than or equal to the value of **ToPort**.
            /// 
            /// The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see [Listening ports](~~153216~~).
            /// 
            /// >  You can configure only one listening port for an HTTP or HTTPS listener. In this case, the first port also serves as the last port.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// The network transmission protocol that is used by the listener. Valid values:
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
        /// Specifies whether to reserve client IP addresses. Valid values:
        /// 
        /// *   **true**: enables the feature. After client IP addresses are reserved, you can view the source IP addresses of clients over the backend service.
        /// *   **false** (default): disables the feature.
        /// 
        /// >  This parameter will be deprecated from the API operations that are used to configure listeners. We recommend that you set this parameter when you call API operations to configure endpoint groups. For more information about the **ProxyProtocol** parameter, see [CreateEndpointGroup](~~153259~~) and [UpdateEndpointGroup](~~153262~~).
        /// </summary>
        [NameInMap("ProxyProtocol")]
        [Validation(Required=false)]
        public bool? ProxyProtocol { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the security policy. Valid values:
        /// 
        /// *   **tls_cipher_policy\_1\_0**
        /// 
        ///     *   Supported Transport Layer Security (TLS) versions: TLS 1.0, TLS 1.1, and TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy\_1\_1**
        /// 
        ///     *   Supported TLS versions: TLS 1.1 and TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy\_1\_2**
        /// 
        ///     *   Supported TLS version: TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy\_1\_2\_strict**
        /// 
        ///     *   Supported TLS version: TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
        /// 
        /// *   **tls_cipher_policy\_1\_2\_strict_with\_1\_3**
        /// 
        ///     *   Supported TLS versions: TLS 1.2 and TLS 1.3
        ///     *   Supported cipher suites: TLS_AES\_128\_GCM_SHA256, TLS_AES\_256\_GCM_SHA384, TLS_CHACHA20\_POLY1305\_SHA256, TLS_AES\_128\_CCM_SHA256, TLS_AES\_128\_CCM\_8\_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
        /// 
        /// >  You can set this parameter only for HTTPS listeners.
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
        /// > 
        /// *   Custom routing listeners are in invitational preview. To use custom routing listeners, [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.11182188.console-base-top.dworkorder.18ae4882n3v6ZW#/ticket/createIndex).
        /// *   You cannot configure listeners of both types for the same GA instance at the same time. After you create the listener, you cannot change the routing type. For more information, see [Listener overview](~~153216~~).
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The configurations of the `XForward` headers.
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
            /// >  You can set this parameter only for HTTP and HTTPS listeners.
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
            /// >  You can set this parameter only for HTTP and HTTPS listeners.
            /// </summary>
            [NameInMap("XForwardedForGaIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaIdEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `GA-X-Forward-Port` header to retrieve the listening ports of the GA instance. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// >  You can set this parameter only for HTTP and HTTPS listeners.
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
            /// >  You can set this parameter only for HTTP and HTTPS listeners.
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
            /// >  You can set this parameter only for HTTP and HTTPS listeners.
            /// </summary>
            [NameInMap("XRealIpEnabled")]
            [Validation(Required=false)]
            public bool? XRealIpEnabled { get; set; }

        }

    }

}
