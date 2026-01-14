// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateCustomRoutingEndpointTrafficPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint for which you want to modify the traffic policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-2zewuzypq5e6r3pfh****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The access policies.</para>
        /// <para>You can specify a maximum of 500 traffic policies for each endpoint.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PolicyConfigurations")]
        [Validation(Required=false)]
        public List<UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations> PolicyConfigurations { get; set; }
        public class UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurations : TeaModel {
            /// <summary>
            /// <para>The IP address of the destination which to allow traffic.</para>
            /// <para>This parameter takes effect only when you set the <b>TrafficToEndpointPolicy</b> parameter to <b>AllowCustom</b>. You can call the <a href="https://help.aliyun.com/document_detail/449386.html">DescribeCustomRoutingEndpoint</a> operation to query the traffic policy of an endpoint.</para>
            /// <para>You can specify a maximum of 500 traffic policies for each endpoint.</para>
            /// <remarks>
            /// <para> This parameter is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The ID of the traffic policy that you want to modify.</para>
            /// <remarks>
            /// <para> This parameter is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ply-bptest2****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The port range of the destination to which traffic is forwarded. The value of this parameter must fall within the port range of the endpoint group.</para>
            /// <para>If you do not specify object, traffic is forwarded to all ports.</para>
            /// <para>This parameter takes effect only when you set the <b>TrafficToEndpointPolicy</b> parameter to <b>AllowCustom</b>. You can call the <a href="https://help.aliyun.com/document_detail/449386.html">DescribeCustomRoutingEndpoint</a> operation to query the traffic policy of an endpoint.</para>
            /// <para>You can specify a maximum of 500 port ranges for each endpoint and a maximum of 10 port ranges for each traffic policy.</para>
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges> PortRanges { get; set; }
            public class UpdateCustomRoutingEndpointTrafficPoliciesRequestPolicyConfigurationsPortRanges : TeaModel {
                /// <summary>
                /// <para>The first port of the destination port range. The value of this parameter must fall within the port range of the backend service.</para>
                /// <para>This parameter takes effect only when you set the <b>TrafficToEndpointPolicy</b> parameter to <b>AllowCustom</b>. You can call the <a href="https://help.aliyun.com/document_detail/449386.html">DescribeCustomRoutingEndpoint</a> operation to query the traffic policy of an endpoint.</para>
                /// <para>If the start port and end port values are empty, traffic on all ports of the destination is allowed.</para>
                /// <para>You can specify a maximum of 500 port ranges for each endpoint and a maximum of 10 port ranges for each traffic policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// <para>The last port of the destination port range. The value of this parameter must fall within the port range of the backend service.</para>
                /// <para>This parameter takes effect only when you set the <b>TrafficToEndpointPolicy</b> parameter to <b>AllowCustom</b>. You can call the <a href="https://help.aliyun.com/document_detail/449386.html">DescribeCustomRoutingEndpoint</a> operation to query the traffic policy of an endpoint.</para>
                /// <para>If the start port and end port values are empty, traffic on all ports of the destination is allowed.</para>
                /// <para>You can specify a maximum of 500 port ranges for each endpoint and a maximum of 10 port ranges for each traffic policy.</para>
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
        /// <para>The region ID of the Global Accelerator (GA) instance. Set the value to <b>cn-hangzhou</b>.</para>
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
