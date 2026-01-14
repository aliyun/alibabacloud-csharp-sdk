// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointTrafficPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among all requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not set this parameter, <b>ClientToken</b> is set to the value of <b>RequestId</b>. The value of <b>RequestId</b> for each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint for which you want to create traffic destinations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-2zewuzypq5e6r3pfh****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The configurations of the traffic destinations.</para>
        /// <para>You can specify up to 500 traffic destinations for each endpoint.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PolicyConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations> PolicyConfigurations { get; set; }
        public class CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations : TeaModel {
            /// <summary>
            /// <para>The IP address of the destination to which traffic is forwarded.</para>
            /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
            /// <para>You can specify up to 500 destination IP addresses for each endpoint.</para>
            /// <remarks>
            /// <para>This parameter is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The port range of the destination to which traffic is forwarded. The value of this parameter must fall within the port range of the endpoint group.</para>
            /// <para>If you leave this parameter empty, traffic is forwarded to all destination ports.</para>
            /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
            /// <para>You can specify port ranges for up to 500 traffic destinations in each endpoint and specify up to 10 port ranges for each traffic destination.</para>
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges> PortRanges { get; set; }
            public class CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges : TeaModel {
                /// <summary>
                /// <para>The first port of the destination port range. The value of this parameter must fall within the port range of the endpoint group.</para>
                /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                /// <para>If the first port and the last port are not specified, traffic on all ports of the destination is allowed.</para>
                /// <para>You can specify port ranges for up to 500 destinations in each endpoint and specify up to 10 first ports for each destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// <para>The last port of the destination port range. The value of this parameter must fall within the port range of the endpoint group.</para>
                /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                /// <para>If the first port and the last port are not specified, traffic on all ports of the destination is allowed.</para>
                /// <para>You can specify port ranges for up to 500 destinations in each endpoint and specify up to 10 last ports for each destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the region where the GA instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
