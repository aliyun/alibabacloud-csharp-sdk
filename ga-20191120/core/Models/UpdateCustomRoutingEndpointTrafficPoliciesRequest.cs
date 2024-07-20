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
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the endpoint for which you want to modify the traffic policies.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The access policies.
        /// 
        /// You can specify a maximum of 500 traffic policies for each endpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyConfigurations")]
        [Validation(Required=false)]
        public List<UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations> PolicyConfigurations { get; set; }
        public class UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations : TeaModel {
            /// <summary>
            /// The IP address of the destination which to allow traffic.
            /// 
            /// This parameter takes effect only when you set the **TrafficToEndpointPolicy** parameter to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](https://help.aliyun.com/document_detail/449386.html) operation to query the traffic policy of an endpoint.
            /// 
            /// You can specify a maximum of 500 traffic policies for each endpoint.
            /// 
            /// >  This parameter is required.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The ID of the traffic policy that you want to modify.
            /// 
            /// >  This parameter is required.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The port range of the destination to which traffic is forwarded. The value of this parameter must fall within the port range of the endpoint group.
            /// 
            /// If you do not specify object, traffic is forwarded to all ports.
            /// 
            /// This parameter takes effect only when you set the **TrafficToEndpointPolicy** parameter to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](https://help.aliyun.com/document_detail/449386.html) operation to query the traffic policy of an endpoint.
            /// 
            /// You can specify a maximum of 500 port ranges for each endpoint and a maximum of 10 port ranges for each traffic policy.
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges> PortRanges { get; set; }
            public class UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges : TeaModel {
                /// <summary>
                /// The first port of the destination port range. The value of this parameter must fall within the port range of the backend service.
                /// 
                /// This parameter takes effect only when you set the **TrafficToEndpointPolicy** parameter to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](https://help.aliyun.com/document_detail/449386.html) operation to query the traffic policy of an endpoint.
                /// 
                /// If the start port and end port values are empty, traffic on all ports of the destination is allowed.
                /// 
                /// You can specify a maximum of 500 port ranges for each endpoint and a maximum of 10 port ranges for each traffic policy.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// The last port of the destination port range. The value of this parameter must fall within the port range of the backend service.
                /// 
                /// This parameter takes effect only when you set the **TrafficToEndpointPolicy** parameter to **AllowCustom**. You can call the [DescribeCustomRoutingEndpoint](https://help.aliyun.com/document_detail/449386.html) operation to query the traffic policy of an endpoint.
                /// 
                /// If the start port and end port values are empty, traffic on all ports of the destination is allowed.
                /// 
                /// You can specify a maximum of 500 port ranges for each endpoint and a maximum of 10 port ranges for each traffic policy.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

        }

        /// <summary>
        /// The region ID of the Global Accelerator (GA) instance. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
