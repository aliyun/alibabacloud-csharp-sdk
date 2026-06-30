// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointsRequest : TeaModel {
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
        /// <para>The endpoint configurations.</para>
        /// <para>You can specify up to 20 endpoint configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointsRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class CreateCustomRoutingEndpointsRequestEndpointConfigurations : TeaModel {
            /// <summary>
            /// <para>The instance ID of the endpoint vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-test01</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The traffic destination configurations.</para>
            /// <para>You can specify up to 20 traffic destinations for each endpoint.</para>
            /// </summary>
            [NameInMap("PolicyConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
            public class CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurations : TeaModel {
                /// <summary>
                /// <para>The IP address of the traffic destination that can receive traffic.</para>
                /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                /// <para>You can specify up to 20 traffic destination IP addresses for each endpoint.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.XX.XX</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The port range of the traffic destination that can receive traffic. The port range must fall within the backend service port range of the endpoint group.</para>
                /// <para>If this parameter is left empty, all ports of the traffic destination are supported.</para>
                /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                /// <para>You can specify up to 20 port ranges for each endpoint, and up to 20 port ranges for each traffic destination.</para>
                /// </summary>
                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                public class CreateCustomRoutingEndpointsRequestEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                    /// <summary>
                    /// <para>The start port of the traffic destination that can receive traffic. The port value must fall within the backend service port range of the endpoint group.</para>
                    /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify up to 20 port ranges for each endpoint, and up to 20 start ports for each traffic destination.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("FromPort")]
                    [Validation(Required=false)]
                    public int? FromPort { get; set; }

                    /// <summary>
                    /// <para>The end port of the traffic destination that can receive traffic. The port value must fall within the backend service port range of the endpoint group.</para>
                    /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify up to 20 port ranges for each endpoint, and up to 20 end ports for each traffic destination.</para>
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
            /// <para>The traffic policy for the backend service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DenyAll</b> (default): denies all traffic to the specified backend service.</description></item>
            /// <item><description><b>AllowAll</b>: allows all traffic to the specified backend service.</description></item>
            /// <item><description><b>AllowCustom</b>: allows traffic only to specified destinations.
            /// You must specify the IP address and port range of the destination. If the port range is left empty, all ports of the destination are supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DenyAll</para>
            /// </summary>
            [NameInMap("TrafficToEndpointPolicy")]
            [Validation(Required=false)]
            public string TrafficToEndpointPolicy { get; set; }

            /// <summary>
            /// <para>The backend service type of the endpoint. Valid values:</para>
            /// <para> <b>PrivateSubNet</b> (default): private CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrivateSubNet</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the endpoint group in which you want to create an endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp1bpn0kn908w4nb****</para>
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// <para>The region ID of the Alibaba Cloud Global Accelerator (GA) instance. Set the value to <b>cn-hangzhou</b>.</para>
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
