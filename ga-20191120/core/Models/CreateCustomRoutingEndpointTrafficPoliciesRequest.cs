// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointTrafficPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of a request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> value as the <b>ClientToken</b> value. The <b>RequestId</b> value is different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint for which you want to create traffic policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-2zewuzypq5e6r3pfh****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The traffic policy configurations.</para>
        /// <para>You can specify up to 500 traffic policies for each endpoint.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PolicyConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations> PolicyConfigurations { get; set; }
        public class CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations : TeaModel {
            /// <summary>
            /// <para>The IP address of the traffic destination that is allowed to receive traffic.</para>
            /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
            /// <para>You can specify up to 500 traffic destination IP addresses for each endpoint.</para>
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
            /// <para>The port range of the traffic destination that is allowed to receive traffic. The port range must fall within the backend service port range of the endpoint group.</para>
            /// <para>If you leave this parameter empty, all ports of the traffic destination are supported.</para>
            /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
            /// <para>You can specify up to 500 port ranges for each endpoint, and up to 10 port ranges for each traffic destination.</para>
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges> PortRanges { get; set; }
            public class CreateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges : TeaModel {
                /// <summary>
                /// <para>The start port of the traffic destination that is allowed to receive traffic. The port value must fall within the backend service port range of the endpoint group.</para>
                /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                /// <para>If you leave both the start port and end port empty, all ports of the traffic destination are supported.</para>
                /// <para>You can specify up to 500 port ranges for each endpoint, and up to 10 start ports for each traffic destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// <para>The end port of the traffic destination that is allowed to receive traffic. The port value must fall within the backend service port range of the endpoint group.</para>
                /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                /// <para>If you leave both the start port and end port empty, all ports of the traffic destination are supported.</para>
                /// <para>You can specify up to 500 port ranges for each endpoint, and up to 10 end ports for each traffic destination.</para>
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
        /// <para>The region ID of the Global Accelerator instance. Set the value to <b>ap-southeast-1</b>.</para>
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
