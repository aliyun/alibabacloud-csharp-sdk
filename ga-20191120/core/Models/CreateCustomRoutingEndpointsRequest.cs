// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointsRequest : TeaModel {
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
        /// <para>The information about the endpoints.</para>
        /// <para>You can specify information for up to 20 endpoints.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointsRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class CreateCustomRoutingEndpointsRequestEndpointConfigurations : TeaModel {
            /// <summary>
            /// <para>The ID of the vSwitch that is specified as an endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-test01</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The destination to which traffic is forwarded.</para>
            /// <para>You can specify up to 20 destinations for each endpoint.</para>
            /// </summary>
            [NameInMap("PolicyConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
            public class CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations : TeaModel {
                /// <summary>
                /// <para>The IP address of the destination to which traffic is forwarded.</para>
                /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                /// <para>You can specify up to 20 destination IP addresses for each endpoint.</para>
                /// <para>This parameter is required.</para>
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
                public List<CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                public class CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                    /// <summary>
                    /// <para>The first port of the destination port range. The value of this parameter must fall within the port range of the endpoint group.</para>
                    /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify port ranges for up to 20 destinations for each endpoint and specify up to 20 first ports for each destination.</para>
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
                    /// <para>You can specify port ranges for up to 20 destinations for each endpoint and specify up to 20 last ports for each destination.</para>
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
            /// <para>The traffic policy that is used to process traffic to the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DenyAll</b> (default): denies all traffic to the endpoint.</description></item>
            /// <item><description><b>AllowAll</b>: allows all traffic to the endpoint.</description></item>
            /// <item><description><b>AllowCustom</b>: allows traffic only to specified destinations in the endpoint.</description></item>
            /// </list>
            /// <para>If you set this parameter to AllowCustom, you must specify IP addresses and port ranges as the destinations to which traffic is distributed. If you specify only IP addresses and do not specify port ranges, GA can forward traffic to the specified IP addresses over all destination ports.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DenyAll</para>
            /// </summary>
            [NameInMap("TrafficToEndpointPolicy")]
            [Validation(Required=false)]
            public string TrafficToEndpointPolicy { get; set; }

            /// <summary>
            /// <para>The type of endpoint.</para>
            /// <para>Set the value to <b>PrivateSubNet</b>, which specifies a private CIDR block. This is the default value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrivateSubNet</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the endpoint group in which to create endpoints.</para>
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
