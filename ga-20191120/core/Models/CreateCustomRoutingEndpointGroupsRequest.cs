// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the GA instance.</para>
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
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The information about the endpoint groups.</para>
        /// <para>You can specify at most five endpoint groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// <para>The description of the endpoint group.</para>
            /// <para>The description cannot exceed 256 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most five endpoint group descriptions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mapping configuration of the endpoint group.</para>
            /// <para>You need to specify the backend service ports and protocols for the endpoint group. The ports are mapped to listener ports.</para>
            /// <para>You can specify at most 20 mapping configurations for each endpoint group.</para>
            /// </summary>
            [NameInMap("DestinationConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsDestinationConfigurations> DestinationConfigurations { get; set; }
            public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsDestinationConfigurations : TeaModel {
                /// <summary>
                /// <para>The first backend service port for the endpoint group.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be smaller than or equal to the value of <b>ToPort</b>.</para>
                /// <para>You can specify at most 20 first backend service ports for each endpoint group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// <para>The backend service protocol.</para>
                /// <para>You can specify up to four backend service protocols in each mapping configuration.</para>
                /// </summary>
                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

                /// <summary>
                /// <para>The last backend service port for the endpoint group.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be smaller than or equal to the value of <b>ToPort</b>.</para>
                /// <para>You can specify at most 20 last backend service ports for each endpoint group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            /// <summary>
            /// <para>The information about the endpoints.</para>
            /// <para>You can specify at most 10 endpoints for each endpoint group.</para>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// <para>The name of the vSwitch that is specified as an endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-test01</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The destination to which traffic is forwarded.</para>
                /// <para>You can specify at most 20 destinations for each endpoint.</para>
                /// </summary>
                [NameInMap("PolicyConfigurations")]
                [Validation(Required=false)]
                public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
                public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations : TeaModel {
                    /// <summary>
                    /// <para>The IP address of the destination to which traffic is forwarded.</para>
                    /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify at most 20 destination IP addresses for each endpoint.</para>
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
                    /// <para>You can specify port ranges for at most 20 destinations in each endpoint and specify at most five port ranges for each destination.</para>
                    /// </summary>
                    [NameInMap("PortRanges")]
                    [Validation(Required=false)]
                    public List<CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                    public class CreateCustomRoutingEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                        /// <summary>
                        /// <para>The first port of the destination port range. The value of this parameter must fall within the port range of the endpoint group.</para>
                        /// <para>This parameter takes effect only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                        /// <para>You can specify port ranges for at most 20 destinations in each endpoint and specify at most five first ports for each destination.</para>
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
                        /// <para>You can specify port ranges for at most 20 destinations in each endpoint and specify at most five last ports for each destination.</para>
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
                /// <item><description><b>AllowAll</b>: allows all traffic to the endpoint.</description></item>
                /// <item><description><b>DenyAll</b> (default): denies all traffic to the endpoint.</description></item>
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
            /// <para>The ID of the region in which the endpoint group resides.</para>
            /// <para>You can specify at most five region IDs.</para>
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
            /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.</para>
            /// <para>You can specify at most five endpoint group names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of the custom routing listener.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

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
