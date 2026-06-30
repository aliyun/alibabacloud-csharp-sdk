// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud Global Accelerator (GA) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
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
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating custom routing type endpoint groups. The system checks the required parameters, request format, and business limits. If the request fails the dry run, the corresponding error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request. If the request passes the check, an HTTP 2xx status code is returned and the custom routing type endpoint groups are created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The endpoint group configurations.</para>
        /// <para>You can specify up to 5 endpoint group configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// <para>The description of the endpoint group.</para>
            /// <para>The description can be up to 256 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 5 endpoint group descriptions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mapping configurations of the endpoint group.</para>
            /// <para>You must specify the backend service port range and protocol type for the endpoint group. The specified information forms a mapping relationship with the associated listener port range.</para>
            /// <para>You can specify up to 20 mapping port range and protocol type entries for each endpoint group.</para>
            /// </summary>
            [NameInMap("DestinationConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsDestinationConfigurations> DestinationConfigurations { get; set; }
            public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsDestinationConfigurations : TeaModel {
                /// <summary>
                /// <para>The start port of the backend service for the endpoint group.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be less than or equal to the value of <b>ToPort</b>.</para>
                /// <para>You can specify up to 20 start port entries for each endpoint group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// <para>The protocol types of the backend service for the endpoint group.</para>
                /// <para>You can specify up to 4 backend service protocol types in each mapping port range and protocol type entry for the endpoint group.</para>
                /// </summary>
                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

                /// <summary>
                /// <para>The end port of the backend service for the endpoint group.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be less than or equal to the value of <b>ToPort</b>.</para>
                /// <para>You can specify up to 20 end port entries for each endpoint group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            /// <summary>
            /// <para>The endpoint configurations.</para>
            /// <para>You can specify up to 10 endpoint configurations for each endpoint group.</para>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// <para>The name of the endpoint vSwitch instance.</para>
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
                public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
                public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations : TeaModel {
                    /// <summary>
                    /// <para>The IP address of the traffic destination that can receive traffic.</para>
                    /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify up to 20 traffic destination IP addresses for each endpoint.</para>
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
                    /// <para>You can specify up to 20 port ranges for traffic destinations for each endpoint, and up to 5 port ranges for each traffic destination.</para>
                    /// </summary>
                    [NameInMap("PortRanges")]
                    [Validation(Required=false)]
                    public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                    public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                        /// <summary>
                        /// <para>The start port of the traffic destination that can receive traffic. The port value must fall within the backend service port range of the endpoint group.</para>
                        /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                        /// <para>You can specify up to 20 port ranges for traffic destinations for each endpoint, and up to 5 start ports for each traffic destination.</para>
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
                        /// <para>You can specify up to 20 port ranges for traffic destinations for each endpoint, and up to 5 end ports for each traffic destination.</para>
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
                /// <item><description><para><b>AllowAll</b>: allows all traffic to access the specified backend service.</para>
                /// </description></item>
                /// <item><description><para><b>DenyAll</b> (default): denies all traffic from accessing the specified backend service.</para>
                /// </description></item>
                /// <item><description><para><b>AllowCustom</b>: allows traffic to access specified destinations.
                /// You must specify the IP address and port range of the destination. If the port range is left empty, all ports of the destination are supported.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DenyAll</para>
                /// </summary>
                [NameInMap("TrafficToEndpointPolicy")]
                [Validation(Required=false)]
                public string TrafficToEndpointPolicy { get; set; }

                /// <summary>
                /// <para>The type of the backend service for the endpoint. Valid values:</para>
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
            /// <para>The region ID of the endpoint group.</para>
            /// <para>You can specify up to 5 endpoint group region IDs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// <para>The name of the endpoint group.</para>
            /// <para>The name must be 1 to 128 characters in length and must start with a letter or Chinese character. The name can contain digits, underscores (_), and hyphens (-).</para>
            /// <para>You can specify up to 5 endpoint group names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of the custom routing type listener.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Alibaba Cloud Global Accelerator (GA) instance. Set the value to <b>ap-southeast-1</b>.</para>
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
