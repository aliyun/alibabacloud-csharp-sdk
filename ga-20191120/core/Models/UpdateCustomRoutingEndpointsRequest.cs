// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateCustomRoutingEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, <b>ClientToken</b> is set to the value of <b>RequestId</b>. The value of <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configurations of the endpoint.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<UpdateCustomRoutingEndpointsRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class UpdateCustomRoutingEndpointsRequestEndpointConfigurations : TeaModel {
            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// <para>You can specify up to 20 endpoint IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp1dmlohjjz4kqaun****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The configurations of the policy.</para>
            /// </summary>
            [NameInMap("PolicyConfigurations")]
            [Validation(Required=false)]
            public List<UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
            public class UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations : TeaModel {
                /// <summary>
                /// <para>The IP address of the destination to which to allow traffic.</para>
                /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                /// <para>You can specify up to 20 destination IP addresses for each endpoint.</para>
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
                /// <para>You can specify port ranges for up to 20 destinations for each endpoint and specify up to 20 port ranges for each destination.</para>
                /// </summary>
                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                public class UpdateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                    /// <summary>
                    /// <para>The start port of the port range in the destination to which to allow traffic. The specified port must fall within the port range of the specified endpoint group.</para>
                    /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify port ranges for up to 20 destinations for each endpoint and specify up to 20 start ports for each destination.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("FromPort")]
                    [Validation(Required=false)]
                    public string FromPort { get; set; }

                    /// <summary>
                    /// <para>The end port of the port range in the destination to which to allow traffic. The specified port must fall within the port range of the specified endpoint group.</para>
                    /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify port ranges for up to 20 destinations for each endpoint and specify up to 20 end ports for each destination.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("ToPort")]
                    [Validation(Required=false)]
                    public string ToPort { get; set; }

                }

            }

            /// <summary>
            /// <para>The access policy of traffic for the specified endpoint. Default value: DenyAll. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>DenyAll</b>: denies all traffic to the endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>AllowAll</b>: allows all traffic to the endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>AllowCustom</b>: allows traffic only to specified destinations.</para>
            /// <para>If you set this parameter to AllowCustom, you must specify IP addresses and port ranges of destinations to which to allow traffic. If you specify only IP addresses and do not specify port ranges, GA can forward traffic to all ports and the specified IP addresses in the destinations.</para>
            /// </description></item>
            /// </list>
            /// <para>You can specify up to 20 access policies of traffic for the specified endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DenyAll</para>
            /// </summary>
            [NameInMap("TrafficToEndpointPolicy")]
            [Validation(Required=false)]
            public string TrafficToEndpointPolicy { get; set; }

        }

        /// <summary>
        /// <para>The ID of the endpoint group to which the endpoints that you want to modify belong.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp1bpn0kn908w4nb****</para>
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

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
