// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointGroupsRequest : TeaModel {
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
        /// You can use the client to generate the token, but you must make sure that the token is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request is different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The information about the endpoint groups.
        /// 
        /// You can specify at most five endpoint groups.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// The description of the endpoint group.
            /// 
            /// The description cannot exceed 256 characters in length and cannot contain `http://` or `https://`.
            /// 
            /// You can specify at most five endpoint group descriptions.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The mapping configuration of the endpoint group.
            /// 
            /// You need to specify the backend service ports and protocols for the endpoint group. The ports are mapped to listener ports.
            /// 
            /// You can specify at most 20 mapping configurations for each endpoint group.
            /// </summary>
            [NameInMap("DestinationConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsDestinationConfigurations> DestinationConfigurations { get; set; }
            public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsDestinationConfigurations : TeaModel {
                /// <summary>
                /// The first backend service port for the endpoint group.
                /// 
                /// Valid values: **1** to **65499**. The value of **FromPort** must be smaller than or equal to the value of **ToPort**.
                /// 
                /// You can specify at most 20 first backend service ports for each endpoint group.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// The backend service protocol.
                /// 
                /// You can specify up to four backend service protocols in each mapping configuration.
                /// </summary>
                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

                /// <summary>
                /// The last backend service port for the endpoint group.
                /// 
                /// Valid values: **1** to **65499**. The value of **FromPort** must be smaller than or equal to the value of **ToPort**.
                /// 
                /// You can specify at most 20 last backend service ports for each endpoint group.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            /// <summary>
            /// The information about the endpoints.
            /// 
            /// You can specify at most 10 endpoints for each endpoint group.
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// The name of the vSwitch that is specified as an endpoint.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The destination to which traffic is forwarded.
                /// 
                /// You can specify at most 20 destinations for each endpoint.
                /// </summary>
                [NameInMap("PolicyConfigurations")]
                [Validation(Required=false)]
                public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
                public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations : TeaModel {
                    /// <summary>
                    /// The IP address of the destination to which traffic is forwarded.
                    /// 
                    /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                    /// 
                    /// You can specify at most 20 destination IP addresses for each endpoint.
                    /// </summary>
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// The port range of the destination to which traffic is forwarded. The value of this parameter must fall within the port range of the endpoint group.
                    /// 
                    /// If you leave this parameter empty, traffic is forwarded to all destination ports.
                    /// 
                    /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                    /// 
                    /// You can specify port ranges for at most 20 destinations in each endpoint and specify at most five port ranges for each destination.
                    /// </summary>
                    [NameInMap("PortRanges")]
                    [Validation(Required=false)]
                    public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                    public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                        /// <summary>
                        /// The first port of the destination port range. The value of this parameter must fall within the port range of the endpoint group.
                        /// 
                        /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                        /// 
                        /// You can specify port ranges for at most 20 destinations in each endpoint and specify at most five first ports for each destination.
                        /// </summary>
                        [NameInMap("FromPort")]
                        [Validation(Required=false)]
                        public int? FromPort { get; set; }

                        /// <summary>
                        /// The last port of the destination port range. The value of this parameter must fall within the port range of the endpoint group.
                        /// 
                        /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                        /// 
                        /// You can specify port ranges for at most 20 destinations in each endpoint and specify at most five last ports for each destination.
                        /// </summary>
                        [NameInMap("ToPort")]
                        [Validation(Required=false)]
                        public int? ToPort { get; set; }

                    }

                }

                /// <summary>
                /// The traffic policy that is used to process traffic to the endpoint. Valid values:
                /// 
                /// *   **AllowAll**: allows all traffic to the endpoint.
                /// *   **DenyAll** (default): denies all traffic to the endpoint.
                /// *   **AllowCustom**: allows traffic only to specified destinations in the endpoint.
                /// 
                /// If you set this parameter to AllowCustom, you must specify IP addresses and port ranges as the destinations to which traffic is distributed. If you specify only IP addresses and do not specify port ranges, GA can forward traffic to the specified IP addresses over all destination ports.
                /// </summary>
                [NameInMap("TrafficToEndpointPolicy")]
                [Validation(Required=false)]
                public string TrafficToEndpointPolicy { get; set; }

                /// <summary>
                /// The type of endpoint.
                /// 
                /// Set the value to **PrivateSubNet**, which specifies a private CIDR block. This is the default value.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The ID of the region in which the endpoint group resides.
            /// 
            /// You can specify at most five region IDs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The name of the endpoint group.
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.
            /// 
            /// You can specify at most five endpoint group names.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the custom routing listener.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
