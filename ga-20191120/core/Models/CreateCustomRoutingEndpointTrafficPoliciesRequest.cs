// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointTrafficPoliciesRequest : TeaModel {
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
        /// The ID of the endpoint for which you want to create traffic destinations.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The configurations of the traffic destinations.
        /// 
        /// You can specify up to 500 traffic destinations for each endpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations> PolicyConfigurations { get; set; }
        public class CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations : TeaModel {
            /// <summary>
            /// The IP address of the destination to which traffic is forwarded.
            /// 
            /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
            /// 
            /// You can specify up to 500 destination IP addresses for each endpoint.
            /// 
            /// > This parameter is required.
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
            /// You can specify port ranges for up to 500 traffic destinations in each endpoint and specify up to 10 port ranges for each traffic destination.
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges> PortRanges { get; set; }
            public class CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges : TeaModel {
                /// <summary>
                /// The first port of the destination port range. The value of this parameter must fall within the port range of the endpoint group.
                /// 
                /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                /// 
                /// If the first port and the last port are not specified, traffic on all ports of the destination is allowed.
                /// 
                /// You can specify port ranges for up to 500 destinations in each endpoint and specify up to 10 first ports for each destination.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// The last port of the destination port range. The value of this parameter must fall within the port range of the endpoint group.
                /// 
                /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**.
                /// 
                /// If the first port and the last port are not specified, traffic on all ports of the destination is allowed.
                /// 
                /// You can specify port ranges for up to 500 destinations in each endpoint and specify up to 10 last ports for each destination.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

        }

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
