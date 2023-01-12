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
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the endpoint for which you want to modify the access policies of traffic.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        [NameInMap("PolicyConfigurations")]
        [Validation(Required=false)]
        public List<UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations> PolicyConfigurations { get; set; }
        public class UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations : TeaModel {
            /// <summary>
            /// The IP address of the destination to which to allow traffic.
            /// 
            /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](~~449386~~) operation to query the access policy of traffic for the specified endpoint.
            /// 
            /// You can specify up to 500 destination IP addresses for each endpoint.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The ID of the access policy of traffic that you want to modify.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges> PortRanges { get; set; }
            public class UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges : TeaModel {
                /// <summary>
                /// The start port of the port range in the destination to which to allow traffic. The specified port must fall within the port range of the specified endpoint group.
                /// 
                /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](~~449386~~) operation to query the access policy of traffic for the specified endpoint.
                /// 
                /// If the start port and end port values are empty, traffic on all ports in destinations are allowed.
                /// 
                /// You can specify port ranges for up to 500 destinations for each endpoint and specify up to 10 start ports for each destination.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// The end port of the port range in the destination to which to allow traffic. The specified port must fall within the port range of the specified endpoint group.
                /// 
                /// This parameter takes effect only when **TrafficToEndpointPolicy** is set to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](~~449386~~) operation to query the access policy of traffic for the specified endpoint.
                /// 
                /// If the start port and end port values are empty, traffic on all ports in destinations are allowed.
                /// 
                /// You can specify port ranges for up to 500 destinations for each endpoint and specify up to 10 end ports for each destination.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

        }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
