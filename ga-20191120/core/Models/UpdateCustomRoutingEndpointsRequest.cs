// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateCustomRoutingEndpointsRequest : TeaModel {
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
        /// The configurations of the endpoint.
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<UpdateCustomRoutingEndpointsRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class UpdateCustomRoutingEndpointsRequestEndpointConfigurations : TeaModel {
            /// <summary>
            /// The ID of the endpoint.
            /// 
            /// You can specify up to 20 endpoint IDs.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The configurations of the policy.
            /// </summary>
            [NameInMap("PolicyConfigurations")]
            [Validation(Required=false)]
            public List<UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
            public class UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations : TeaModel {
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
                public List<UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                public class UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                    /// <summary>
                    /// The start port of the port range in the destination to which to allow traffic. The specified port must fall within the port range of the specified endpoint group.
                    /// 
                    /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                    /// 
                    /// You can specify port ranges for up to 20 destinations for each endpoint and specify up to 20 start ports for each destination.
                    /// </summary>
                    [NameInMap("FromPort")]
                    [Validation(Required=false)]
                    public string FromPort { get; set; }

                    /// <summary>
                    /// The end port of the port range in the destination to which to allow traffic. The specified port must fall within the port range of the specified endpoint group.
                    /// 
                    /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                    /// 
                    /// You can specify port ranges for up to 20 destinations for each endpoint and specify up to 20 end ports for each destination.
                    /// </summary>
                    [NameInMap("ToPort")]
                    [Validation(Required=false)]
                    public string ToPort { get; set; }

                }

            }

            /// <summary>
            /// The access policy of traffic for the specified endpoint. Default value: DenyAll. Valid values:
            /// 
            /// *   **DenyAll**: denies all traffic to the endpoint.
            /// 
            /// *   **AllowAll**: allows all traffic to the endpoint.
            /// 
            /// *   **AllowCustom**: allows traffic only to specified destinations.
            /// 
            ///     If you set this parameter to AllowCustom, you must specify IP addresses and port ranges of destinations to which to allow traffic. If you specify only IP addresses and do not specify port ranges, GA can forward traffic to all ports and the specified IP addresses in the destinations.
            /// 
            /// You can specify up to 20 access policies of traffic for the specified endpoint.
            /// </summary>
            [NameInMap("TrafficToEndpointPolicy")]
            [Validation(Required=false)]
            public string TrafficToEndpointPolicy { get; set; }

        }

        /// <summary>
        /// The ID of the endpoint group to which the endpoints that you want to modify belong.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
