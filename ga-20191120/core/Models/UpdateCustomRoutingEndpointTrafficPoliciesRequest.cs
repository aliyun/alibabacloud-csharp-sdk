// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateCustomRoutingEndpointTrafficPoliciesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the endpoint for which you want to modify the traffic policies.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The traffic policies.
        /// 
        /// You can specify up to 500 destination IP addresses for each endpoint.
        /// </summary>
        [NameInMap("PolicyConfigurations")]
        [Validation(Required=false)]
        public List<UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations> PolicyConfigurations { get; set; }
        public class UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations : TeaModel {
            /// <summary>
            /// The IP address of the destination to which traffic is allowed.
            /// 
            /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](~~449386~~) operation to query the traffic policy for the specified endpoint.
            /// 
            /// You can specify up to 500 destination IP addresses for each endpoint.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The ID of the traffic policy to modify.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The port range of the destination to which traffic is allowed. The value of this parameter must fall within the port range of the backend service.
            /// 
            /// If you do not specify array, traffic is forwarded to all ports.
            /// 
            /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](~~449386~~) operation to query the traffic policy for the specified endpoint.
            /// 
            /// You can specify port ranges for up to 500 traffic destinations in each endpoint and specify up to 10 port ranges for each traffic destination.
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges> PortRanges { get; set; }
            public class UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges : TeaModel {
                /// <summary>
                /// The first port of the destination port range. The specified port must fall within the port range of the specified endpoint group.
                /// 
                /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](~~449386~~) operation to query the access policy of traffic for the specified endpoint.
                /// 
                /// If you do not specify FromPort and ToPort, traffic is forwarded to all ports of the destination.
                /// 
                /// You can specify port ranges for up to 500 destinations for each endpoint and specify up to 10 start ports for each destination.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// The last port of the destination port range. The specified port must fall within the port range of the specified endpoint group.
                /// 
                /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](~~449386~~) operation to query the traffic policy for the specified endpoint.
                /// 
                /// If you do not specify FromPort and ToPort, traffic is forwarded to all ports of the destination.
                /// 
                /// You can specify port ranges for up to 500 destinations in each endpoint and specify up to 10 last ports for each destination.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

        }

        /// <summary>
        /// The region ID of the Global Accelerator (GA) instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
