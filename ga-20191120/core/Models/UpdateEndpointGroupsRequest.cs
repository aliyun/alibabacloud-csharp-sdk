// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateEndpointGroupsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to only precheck the request. Default value: false. Valid values:
        /// 
        /// *   **true**: prechecks the request without performing the operation. The system checks the required parameters, request syntax, and limits. If the request fails the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the request. If the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<UpdateEndpointGroupsRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class UpdateEndpointGroupsRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// Specifies whether to use the proxy protocol to preserve client IP addresses. Valid values:
            /// 
            /// *   **true**: uses the proxy protocol to preserve client IP addresses.
            /// *   **false**: does not use the proxy protocol to preserve client IP addresses.
            /// </summary>
            [NameInMap("EnableClientIPPreservationProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationProxyProtocol { get; set; }

            /// <summary>
            /// Specifies whether to preserve client IP addresses by using the TCP Option Address (TOA) module. Valid values:
            /// 
            /// *   **true**: preserves client IP addresses by using the TOA module.
            /// *   **false**: does not preserve client IP addresses by using the TOA module.
            /// </summary>
            [NameInMap("EnableClientIPPreservationToa")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationToa { get; set; }

            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<UpdateEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class UpdateEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// The IP address or domain name of the endpoint.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

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
                /// 
                /// > 
                /// *   If you set this parameter to **ECS** or **SLB** and the service-linked role AliyunServiceRoleForGaVpcEndpoint does not exist, the system creates the service-linked role.
                /// *   If you set this parameter to **ALB** and the service-linked role AliyunServiceRoleForGaAlb does not exist, the system creates the service-linked role.
                /// *   If you set this parameter to **OSS** and the service-linked role AliyunServiceRoleForGaOss does not exist, the system creates the service-linked role.
                /// 
                ///     For more information, see [Service-linked roles](~~178360~~).
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
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            /// <summary>
            /// The description of the endpoint group.
            /// 
            /// The description cannot exceed 256 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("EndpointGroupDescription")]
            [Validation(Required=false)]
            public string EndpointGroupDescription { get; set; }

            /// <summary>
            /// The ID of the endpoint.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The name of the endpoint group.
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
            /// </summary>
            [NameInMap("EndpointGroupName")]
            [Validation(Required=false)]
            public string EndpointGroupName { get; set; }

            /// <summary>
            /// The protocol that is used by the backend service. Valid values:
            /// 
            /// *   **HTTP**: HTTP
            /// *   **HTTPS**: HTTPS
            /// 
            /// > 
            /// *   You can set this property only if the listener that is associated with the endpoint group uses the HTTP or HTTPS protocol.
            /// *   For an HTTP listener, the backend service protocol must be HTTP.
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// Specifies whether to enable the health check feature. Default value: false. Valid values:
            /// 
            /// *   **true**: enables the health check feature.
            /// *   **false**: disables the health check feature.
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// The interval at which health checks are performed. Unit: seconds. Valid values: **1** to **50**.
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public long? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// The path to which health check requests are sent.
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// The port that is used for health checks.
            /// 
            /// Valid values: **1** to **65535**.
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public long? HealthCheckPort { get; set; }

            /// <summary>
            /// The protocol over which health check requests are sent.
            /// 
            /// *   **tcp**: TCP
            /// *   **http**: HTTP
            /// *   **https**: HTTPS
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<UpdateEndpointGroupsRequestEndpointGroupConfigurationsPortOverrides> PortOverrides { get; set; }
            public class UpdateEndpointGroupsRequestEndpointGroupConfigurationsPortOverrides : TeaModel {
                /// <summary>
                /// The endpoint port.
                /// 
                /// Valid values: **1** to **65499**.
                /// </summary>
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public long? EndpointPort { get; set; }

                /// <summary>
                /// The listening port.
                /// 
                /// Valid values: **1** to **65499**.
                /// 
                /// > 
                /// *   Only HTTP and HTTPS listeners support port mapping.
                /// *   The listener port in a port mapping must be the one used by the current listener.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

            }

            /// <summary>
            /// The number of consecutive health check failures that must occur before a healthy endpoint group is considered unhealthy, or the number of consecutive health check successes that must occur before an unhealthy endpoint group is considered healthy.
            /// 
            /// Valid values: **2** to **10**.
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public long? ThresholdCount { get; set; }

            /// <summary>
            /// The traffic ratio for the endpoint group when the specified listener is associated with multiple endpoint groups.
            /// 
            /// Valid values: **1** to **100**.
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public long? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// The ID of the listener.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
