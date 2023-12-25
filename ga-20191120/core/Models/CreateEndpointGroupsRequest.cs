// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateEndpointGroupsRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
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
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The configurations of the endpoint groups.
        /// </summary>
        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateEndpointGroupsRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateEndpointGroupsRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// Specifies whether to use the proxy protocol to preserve client IP addresses. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// You can specify this parameter for up to 10 endpoint groups.
            /// </summary>
            [NameInMap("EnableClientIPPreservationProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationProxyProtocol { get; set; }

            /// <summary>
            /// Specifies whether to preserve the IP addresses of clients that access the endpoint by using the TCP Option Address (TOA) module. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// You can specify this parameter for up to 10 endpoint groups.
            /// </summary>
            [NameInMap("EnableClientIPPreservationToa")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationToa { get; set; }

            /// <summary>
            /// The configurations of the endpoints.
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// The IP address, domain name, or instance ID based on the value of Type.
                /// 
                /// You can specify up to 100 endpoint IP addresses or domain names in an endpoint group.
                /// 
                /// >  This parameter is required.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The private IP address of the ENI.
                /// 
                /// >  If you set Type to ENI, you can specify this parameter. If you do not specify this parameter, the primary private IP address of the ENI is used.
                /// </summary>
                [NameInMap("SubAddress")]
                [Validation(Required=false)]
                public string SubAddress { get; set; }

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
                /// *   **ENI**: an elastic network interface (ENI)
                /// *   **NLB**: a Network Load Balancer (NLB) instance
                /// 
                /// > 
                /// 
                /// *   If you set this parameter to **ECS** or **SLB** and the service-linked role AliyunServiceRoleForGaVpcEndpoint does not exist, the system automatically creates the service-linked role.
                /// 
                /// *   If you set this parameter to **ALB** and the service-linked role AliyunServiceRoleForGaAlb does not exist, the system automatically creates the service-linked role.
                /// 
                /// *   If you set this parameter to **OSS** and the service-linked role AliyunServiceRoleForGaOss does not exist, the system automatically creates the service-linked role.
                /// 
                /// For more information, see [Service linked roles](~~178360~~).
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The weight of the endpoint.
                /// 
                /// Valid values: **0** to **255**.
                /// 
                /// You can set the weights of up to 100 endpoints in an endpoint group.
                /// 
                /// > *   This parameter is required.
                /// > *   If you set the weight of an endpoint to 0, GA does not route network traffic to the endpoint. Make sure that you are aware of the impact on your business before you set the endpoint weight to 0.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            /// <summary>
            /// The description of the endpoint group.
            /// 
            /// The description can be up to 256 characters in length and cannot contain `http://` or `https://`.
            /// 
            /// You can enter the descriptions of up to 10 endpoint groups.
            /// </summary>
            [NameInMap("EndpointGroupDescription")]
            [Validation(Required=false)]
            public string EndpointGroupDescription { get; set; }

            /// <summary>
            /// The name of the endpoint group.
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
            /// 
            /// You can specify the names of up to 10 endpoint groups.
            /// </summary>
            [NameInMap("EndpointGroupName")]
            [Validation(Required=false)]
            public string EndpointGroupName { get; set; }

            /// <summary>
            /// The ID of the region where you want to create the endpoint group.
            /// 
            /// You can enter the region IDs of up to 10 endpoint groups.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The type of the endpoint group. Valid values:
            /// 
            /// *   **default** (default)
            /// *   **virtual**
            /// 
            /// You can specify the types of up to 10 endpoint groups.
            /// 
            /// >  Only HTTP and HTTPS listeners support virtual endpoint groups.
            /// </summary>
            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            /// <summary>
            /// The protocol that is used by the backend service. Valid values:
            /// 
            /// *   **HTTP** (default)
            /// *   **HTTPS**
            /// 
            /// You can specify up to 10 backend service protocols.
            /// 
            /// > *   You can specify this parameter only if the listener that is associated with the endpoint group uses **HTTP** or **HTTPS**.
            /// > *   For an **HTTP** listener, the backend service protocol must be **HTTP**.
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// Specifies whether to enable the health check feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// You can enable the health check feature for up to 10 endpoint groups.
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// The interval at which health checks are performed. Unit: seconds.
            /// 
            /// You can specify up to 10 health check intervals.
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public long? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// The path to which health check requests are sent.
            /// 
            /// You can specify up to 10 health check paths.
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// The port that is used for health checks. Valid values: **1** to **65535**.
            /// 
            /// You can specify up to 10 ports for health checks.
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
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// The port mapping.
            /// </summary>
            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<CreateEndpointGroupsRequestEndpointGroupConfigurationsPortOverrides> PortOverrides { get; set; }
            public class CreateEndpointGroupsRequestEndpointGroupConfigurationsPortOverrides : TeaModel {
                /// <summary>
                /// The endpoint port that is mapped to the listener port.
                /// 
                /// You can specify up to five endpoint ports.
                /// </summary>
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public long? EndpointPort { get; set; }

                /// <summary>
                /// The listener port that is mapped to the endpoint port.
                /// 
                /// You can specify up to five listener ports.
                /// 
                /// > *   Only HTTP and HTTPS listeners support port mappings.
                /// > *   The listener port in a port mapping must be the port that is used by the current listener.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

            }

            /// <summary>
            /// The system tag.
            /// </summary>
            [NameInMap("SystemTag")]
            [Validation(Required=false)]
            public List<CreateEndpointGroupsRequestEndpointGroupConfigurationsSystemTag> SystemTag { get; set; }
            public class CreateEndpointGroupsRequestEndpointGroupConfigurationsSystemTag : TeaModel {
                /// <summary>
                /// The key of the system tag.
                /// 
                /// You can enter up to 20 system tags.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The visibility of the system tag. Valid values:
                /// 
                /// *   **public** (default): The system tag is visible and can be used for filtering.
                /// *   **private**: The system tag is invisible.
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// The value of the system tag.
                /// 
                /// You can enter up to 20 system tags.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateEndpointGroupsRequestEndpointGroupConfigurationsTag> Tag { get; set; }
            public class CreateEndpointGroupsRequestEndpointGroupConfigurationsTag : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// 
                /// You can enter up to 20 tags.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
                /// 
                /// You can enter up to 20 tags.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The number of consecutive health check failures that must occur before a healthy endpoint group is considered unhealthy, or the number of consecutive health check successes that must occur before an unhealthy endpoint group is considered healthy. Valid values: **2** to **10**. Default value: **3**.
            /// 
            /// You can specify the number of successful consecutive health checks or failed consecutive health checks for up to 10 endpoint groups.
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public long? ThresholdCount { get; set; }

            /// <summary>
            /// The traffic distribution ratio. If a listener is associated with multiple endpoint groups, you can specify this parameter to distribute traffic to the endpoint groups based on ratios.
            /// 
            /// Valid values: **1** to **100**. Default value: **100**.
            /// 
            /// You can specify traffic distribution ratios for up to 10 endpoint groups.
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public long? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// The ID of the listener.
        /// 
        /// >  If the listener protocol is **HTTP** or **HTTPS**, you can call the **CreateEndpointGroups** operation to create only one endpoint group.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
