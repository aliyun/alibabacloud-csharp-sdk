// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointsRequest : TeaModel {
        /// <summary>
        /// The ID of the endpoint group in which to create endpoints.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The information about the endpoints.
        /// 
        /// You can specify information for up to 20 endpoints.
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointsRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class CreateCustomRoutingEndpointsRequestEndpointConfigurations : TeaModel {
            /// <summary>
            /// The traffic policy that is used to process traffic to the endpoint. Valid values:
            /// 
            /// *   **DenyAll** (default): denies all traffic to the endpoint.
            /// *   **AllowAll**: allows all traffic to the endpoint.
            /// *   **AllowCustom**: allows traffic only to specified destinations in the endpoint.
            /// 
            /// If you set this parameter to AllowCustom, you must specify IP addresses and port ranges as the destinations to which traffic is distributed. If you specify only IP addresses and do not specify port ranges, GA can forward traffic to the specified IP addresses over all destination ports.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The destination to which traffic is forwarded.
            /// 
            /// You can specify up to 20 destinations for each endpoint.
            /// </summary>
            [NameInMap("PolicyConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
            public class CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations : TeaModel {
                /// <summary>
                /// The port range of the destination to which traffic is forwarded. The value of this parameter must fall within the port range of the endpoint group.
                /// 
                /// If you leave this parameter empty, traffic is forwarded to all destination ports.
                /// 
                /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                /// 
                /// You can specify port ranges for up to 20 destinations for each endpoint and specify up to 20 port ranges for each destination.
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
                /// You can specify port ranges for up to 20 destinations for each endpoint and specify up to 20 port ranges for each destination.
                /// </summary>
                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                public class CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                    /// <summary>
                    /// The last port of the destination port range. The value of this parameter must fall within the port range of the endpoint group.
                    /// 
                    /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                    /// 
                    /// You can specify port ranges for up to 20 destinations for each endpoint and specify up to 20 last ports for each destination.
                    /// </summary>
                    [NameInMap("FromPort")]
                    [Validation(Required=false)]
                    public int? FromPort { get; set; }

                    /// <summary>
                    /// The returned information.
                    /// </summary>
                    [NameInMap("ToPort")]
                    [Validation(Required=false)]
                    public int? ToPort { get; set; }

                }

            }

            /// <summary>
            /// The destination to which traffic is forwarded.
            /// 
            /// You can specify up to 20 destinations for each endpoint.
            /// </summary>
            [NameInMap("TrafficToEndpointPolicy")]
            [Validation(Required=false)]
            public string TrafficToEndpointPolicy { get; set; }

            /// <summary>
            /// The ID of the vSwitch that is specified as an endpoint.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The information about the endpoints.
        /// 
        /// You can specify information for up to 20 endpoints.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request is different.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
