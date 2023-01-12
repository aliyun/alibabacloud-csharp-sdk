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
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
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
        /// *   **false**: sends the request. After the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// The description of the endpoint group.
            /// 
            /// The description cannot exceed 256 characters in length and cannot contain `http://` or `https://`.
            /// 
            /// You can specify up to five endpoint group descriptions.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsDestinationConfigurations> DestinationConfigurations { get; set; }
            public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsDestinationConfigurations : TeaModel {
                /// <summary>
                /// The start port of the backend service port range of the endpoint group.
                /// 
                /// Valid values: **1** to **65499**. The **FromPort** value must be smaller than or equal to the **ToPort** value.
                /// 
                /// You can specify up to 20 start ports of backend service port ranges for each endpoint group.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

                /// <summary>
                /// The end port of the backend service port range of the endpoint group.
                /// 
                /// Valid values: **1** to **65499**. The **FromPort** value must be smaller than or equal to the **ToPort** value.
                /// 
                /// You can specify up to 20 end ports of backend service port ranges for each endpoint group.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// The name of the endpoint (vSwitch).
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("PolicyConfigurations")]
                [Validation(Required=false)]
                public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
                public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations : TeaModel {
                    /// <summary>
                    /// The IP address of the destination to which to allow traffic.
                    /// 
                    /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                    /// 
                    /// You can specify up to 20 destination IP addresses for each endpoint.
                    /// </summary>
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("PortRanges")]
                    [Validation(Required=false)]
                    public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                    public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                        /// <summary>
                        /// The start port of the port range in the destination to which to allow traffic. The specified port must fall within the port range of the specified endpoint group.
                        /// 
                        /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                        /// 
                        /// You can specify port ranges for up to 20 destinations for each endpoint and specify up to 5 start ports for each destination.
                        /// </summary>
                        [NameInMap("FromPort")]
                        [Validation(Required=false)]
                        public int? FromPort { get; set; }

                        /// <summary>
                        /// The end port of the port range in the destination to which to allow traffic. The specified port must fall within the port range of the specified endpoint group.
                        /// 
                        /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                        /// 
                        /// You can specify port ranges for up to 20 destinations for each endpoint and specify up to 5 end ports for each destination.
                        /// </summary>
                        [NameInMap("ToPort")]
                        [Validation(Required=false)]
                        public int? ToPort { get; set; }

                    }

                }

                /// <summary>
                /// The access policy of traffic to the specified vSwitches. Default value: DenyAll. Valid values:
                /// 
                /// *   **AllowAll**: allows all traffic to the vSwitch.
                /// 
                /// *   **DenyAll**: denies all traffic to the vSwitch.
                /// 
                /// *   **AllowCustom**: allows traffic only to specified destinations in the vSwitch.
                /// 
                ///     If you set this parameter to AllowCustom, you must specify IP addresses and port ranges of destinations to which to allow traffic. If you specify only IP addresses and do not specify port ranges, GA can forward traffic to the specified IP addresses over all ports in the destinations.
                /// </summary>
                [NameInMap("TrafficToEndpointPolicy")]
                [Validation(Required=false)]
                public string TrafficToEndpointPolicy { get; set; }

                /// <summary>
                /// The backend service type of the endpoint. Default value: PrivateSubNet.
                /// 
                /// Set the value to **PrivateSubNet**, which indicates private CIDR blocks.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The ID of the region in which to create the endpoint group.
            /// 
            /// You can specify up to five region IDs.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The name of the endpoint group.
            /// 
            /// The name must be 2 to 128 characters in length and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
            /// 
            /// You can specify up to five endpoint group names.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the custom routing listener.
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
