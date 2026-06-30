// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateListenerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Global Accelerator instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The SSL certificates for an HTTPS listener.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCertificates> Certificates { get; set; }
        public class CreateListenerRequestCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the SSL certificate.</para>
            /// <remarks>
            /// <para>This parameter is required only for HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>449****-cn-hangzhou</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>The client affinity for the listener.</para>
        /// <list type="bullet">
        /// <item><description><para>By default, client affinity is disabled, and requests from the same client may be routed to different endpoints.</para>
        /// </description></item>
        /// <item><description><para>Set to <b>SOURCE_IP</b> to enable client affinity. This setting directs all requests from the same client to the same endpoint, regardless of the source port or protocol.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SOURCE_IP</para>
        /// </summary>
        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        /// <summary>
        /// <para>A client token that ensures the idempotence of the request.</para>
        /// <para>Generate a unique token on your client for each request. The token must contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you omit this parameter, the system uses the request\&quot;s <b>RequestId</b> as the <b>ClientToken</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configurations of the endpoint groups for a custom routing listener.</para>
        /// <para>You can specify up to five endpoint groups.</para>
        /// <remarks>
        /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomRoutingEndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurations> CustomRoutingEndpointGroupConfigurations { get; set; }
        public class CreateListenerRequestCustomRoutingEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// <para>The description of the endpoint group.</para>
            /// <para>The description can be up to 200 characters long and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can enter up to 5 endpoint group descriptions.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mapping configurations for the endpoint group.</para>
            /// <para>You must specify the port ranges and protocols for the backend service. The settings are mapped to the associated listener port ranges.</para>
            /// <para>You can specify up to 20 mapping configurations for each endpoint group.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DestinationConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsDestinationConfigurations> DestinationConfigurations { get; set; }
            public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsDestinationConfigurations : TeaModel {
                /// <summary>
                /// <para>The first port of the backend service.</para>
                /// <para>The valid port range is <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be less than or equal to the value of <b>ToPort</b>.</para>
                /// <para>In each endpoint group for a custom routing type listener, you can enter up to 20 backend service starting ports.</para>
                /// <remarks>
                /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// <para>The protocols of the backend service.</para>
                /// <para>You can specify up to four backend service protocols for each mapping configuration.</para>
                /// <remarks>
                /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

                /// <summary>
                /// <para>The last port of the backend service.</para>
                /// <para>The valid port range is <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be less than or equal to the value of <b>ToPort</b>.</para>
                /// <para>In each endpoint group of a listener of the custom routing type, you can enter a maximum of 20 backend service ports.</para>
                /// <remarks>
                /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                /// </remarks>
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
            /// <para>You can specify up to 10 endpoints for each endpoint group.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// <para>The vSwitch of the custom routing listener.</para>
                /// <remarks>
                /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-test01</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The destination configurations for a custom routing listener.</para>
                /// <para>You can specify up to 20 destinations for each endpoint.</para>
                /// <remarks>
                /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("PolicyConfigurations")]
                [Validation(Required=false)]
                public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
                public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations : TeaModel {
                    /// <summary>
                    /// <para>The IP address of the destination that is allowed to receive traffic.</para>
                    /// <para>This parameter is required only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify up to 20 destination IP addresses for each endpoint.</para>
                    /// <remarks>
                    /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.XX.XX</para>
                    /// </summary>
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>The port range of the destination that is allowed to receive traffic. The port range must be within the port range of the backend service.</para>
                    /// <para>If you leave this parameter empty, all ports of the destination are allowed.</para>
                    /// <para>This parameter is required only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify up to 20 port ranges for each endpoint, and up to 5 port ranges for each destination.</para>
                    /// <remarks>
                    /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("PortRanges")]
                    [Validation(Required=false)]
                    public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                    public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                        /// <summary>
                        /// <para>The first port of the destination that is allowed to receive traffic. The port must be within the port range of the backend service.</para>
                        /// <para>This parameter is required only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                        /// <para>You can specify up to 20 port ranges for each endpoint, and up to 5 first ports for each destination.</para>
                        /// <remarks>
                        /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("FromPort")]
                        [Validation(Required=false)]
                        public int? FromPort { get; set; }

                        /// <summary>
                        /// <para>The last port of the destination that is allowed to receive traffic. The port must be within the port range of the backend service.</para>
                        /// <para>This parameter is required only when <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                        /// <para>You can specify up to 20 port ranges for each endpoint, and up to 5 last ports for each destination.</para>
                        /// <remarks>
                        /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                        /// </remarks>
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
                /// <para>The traffic policy for the backend service of a custom routing listener. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>DenyAll</b> (default): Denies all traffic to the specified backend service.</para>
                /// </description></item>
                /// <item><description><para><b>AllowAll</b>: Allows all traffic to the specified backend service.</para>
                /// </description></item>
                /// <item><description><para><b>AllowCustom</b>: Allows traffic to specific destinations.
                /// You must specify the IP addresses and port ranges of the allowed destinations. If no port range is specified, all ports of the destination are allowed.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>DenyAll</para>
                /// </summary>
                [NameInMap("TrafficToEndpointPolicy")]
                [Validation(Required=false)]
                public string TrafficToEndpointPolicy { get; set; }

                /// <summary>
                /// <para>The type of the backend service for a custom routing listener. Valid value:</para>
                /// <para><b>PrivateSubNet</b> (default): a private CIDR block.</para>
                /// <remarks>
                /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateSubNet</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The ID of the region where the endpoint group is created.</para>
            /// <para>You can enter up to 5 endpoint group region IDs.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// <para>The name of the endpoint group.</para>
            /// <para>The name must be 1 to 128 characters long, start with a letter or a Chinese character, and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
            /// <para>You can enter up to 5 endpoint group names.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>CustomRouting</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The description of the listener.</para>
        /// <para>The description can be up to 200 characters long and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Listener</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configurations of the endpoint groups for a standard listener.</para>
        /// <para>You can specify up to 10 endpoint groups.</para>
        /// <remarks>
        /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateListenerRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateListenerRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// <para>The endpoint configurations.</para>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateListenerRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                [NameInMap("ApiKeys")]
                [Validation(Required=false)]
                public List<string> ApiKeys { get; set; }

                /// <summary>
                /// <para>Specifies whether to preserve client source IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: enables the feature.</para>
                /// </description></item>
                /// <item><description><para><b>false</b> (default): disables the feature.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This feature is disabled by default for endpoint groups of TCP or UDP listeners. You can enable it as needed.</para>
                /// </description></item>
                /// <item><description><para>This feature is enabled by default for endpoint groups of HTTP or HTTPS listeners. Client source IP addresses are retrieved from the <c>X-Forwarded-For</c> header. You cannot disable this feature.</para>
                /// </description></item>
                /// <item><description><para>You cannot set both <c>EnableClientIPPreservation</c> and <c>EnableProxyProtocol</c> to <c>true</c>.</para>
                /// </description></item>
                /// <item><description><para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">Preserve client source IP addresses</a>.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("EnableClientIPPreservation")]
                [Validation(Required=false)]
                public bool? EnableClientIPPreservation { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the proxy protocol to preserve client source IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: enables the feature.</para>
                /// </description></item>
                /// <item><description><para><b>false</b> (default): disables the feature.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>You can configure this parameter only for endpoint groups of TCP listeners.</para>
                /// </description></item>
                /// <item><description><para>You cannot set both <c>EnableClientIPPreservation</c> and <c>EnableProxyProtocol</c> to <c>true</c>.</para>
                /// </description></item>
                /// <item><description><para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">Preserve client source IP addresses</a>.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("EnableProxyProtocol")]
                [Validation(Required=false)]
                public bool? EnableProxyProtocol { get; set; }

                /// <summary>
                /// <para>The IP address or domain name of the endpoint.</para>
                /// <para>In an endpoint group of an intelligent routing listener, you can enter up to 100 IP addresses or domain names of endpoints.</para>
                /// <remarks>
                /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>47.0.XX.XX</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BAILIAN</para>
                /// </summary>
                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                /// <summary>
                /// <para>The private IP address of the ENI.</para>
                /// <remarks>
                /// <para>If the endpoint type is <b>ENI</b>, you can specify this parameter. If you do not specify this parameter, the primary private IP address of the ENI is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>172.168.XX.XX</para>
                /// </summary>
                [NameInMap("SubAddress")]
                [Validation(Required=false)]
                public string SubAddress { get; set; }

                /// <summary>
                /// <para>The type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Domain</b>: a custom domain name.</para>
                /// </description></item>
                /// <item><description><para><b>Ip</b>: a custom IP address.</para>
                /// </description></item>
                /// <item><description><para><b>PublicIp</b>: a public IP address of an Alibaba Cloud service.</para>
                /// </description></item>
                /// <item><description><para><b>ECS</b>: an Elastic Compute Service (ECS) instance.</para>
                /// </description></item>
                /// <item><description><para><b>SLB</b>: a Server Load Balancer (SLB) instance.</para>
                /// </description></item>
                /// <item><description><para><b>ALB</b>: an Application Load Balancer (ALB) instance.</para>
                /// </description></item>
                /// <item><description><para><b>OSS</b>: an Object Storage Service (OSS) bucket.</para>
                /// </description></item>
                /// <item><description><para><b>ENI</b>: an elastic network interface (ENI).</para>
                /// </description></item>
                /// <item><description><para><b>NLB</b>: a Network Load Balancer (NLB) instance.</para>
                /// </description></item>
                /// <item><description><para><b>IpTarget</b>: a custom private IP address.</para>
                /// </description></item>
                /// </list>
                /// <para>You can specify up to 100 endpoints in an endpoint group.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
                /// </description></item>
                /// <item><description><para>When you add endpoints, Global Accelerator may create service-linked roles to access your resources. The role created depends on the endpoint type:</para>
                /// </description></item>
                /// <item><description></description></item>
                /// <item><description></description></item>
                /// <item><description></description></item>
                /// </list>
                /// <remarks>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178360.html">Service-linked roles</a>.</para>
                /// </remarks>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Ip</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The list of vSwitches in the VPC. You can specify up to two vSwitch IDs.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The ID of the Virtual Private Cloud (VPC).</para>
                /// <para>In an endpoint group of an intelligent routing listener, you can enter a maximum of 1 VPC ID.</para>
                /// <remarks>
                /// <para>This parameter is required only for <b>IpTarget</b> endpoints.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp13r1kpr2lel****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The weight of the endpoint.</para>
                /// <para>Valid values: <b>0</b> to <b>255</b>.</para>
                /// <para>In an endpoint group for an intelligent routing type listener, you can enter weights for up to 100 endpoints.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
                /// </description></item>
                /// <item><description><para>If an endpoint\&quot;s weight is set to 0, Global Accelerator stops sending traffic to it. Use this setting with caution.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            /// <summary>
            /// <para>The description of the endpoint group.</para>
            /// <para>The description can be up to 200 characters long and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can enter up to 10 endpoint group descriptions.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EndpointGroupDescription")]
            [Validation(Required=false)]
            public string EndpointGroupDescription { get; set; }

            /// <summary>
            /// <para>The name of the endpoint group.</para>
            /// <para>The name must be 1 to 128 characters long, start with a letter or a Chinese character, and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
            /// <para>You can enter up to 10 endpoint group names.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EndpointGroupName")]
            [Validation(Required=false)]
            public string EndpointGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the region where the endpoint group is created.</para>
            /// <para>You can enter up to 10 endpoint group region IDs.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// <para>The type of the endpoint group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>default</b> (default): a default endpoint group.</para>
            /// </description></item>
            /// <item><description><para><b>virtual</b>: a virtual endpoint group.</para>
            /// </description></item>
            /// </list>
            /// <para>You can enter up to 10 endpoint group types.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </description></item>
            /// <item><description><para>You can create virtual endpoint groups only for HTTP or HTTPS listeners.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            /// <summary>
            /// <para>The IP version used by the backend service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>IPv4</b> (default): GA uses only IPv4 addresses to communicate with backend services.</para>
            /// </description></item>
            /// <item><description><para><b>IPv6</b>: GA uses only IPv6 addresses to communicate with backend services.</para>
            /// </description></item>
            /// <item><description><para><b>ProtocolAffinity</b>: GA uses the same IP version as the client request to communicate with backend services.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("EndpointIpVersion")]
            [Validation(Required=false)]
            public string EndpointIpVersion { get; set; }

            /// <summary>
            /// <para>The protocol version of the backend service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP1.1</b> (default): HTTP/1.1</para>
            /// </description></item>
            /// <item><description><para><b>HTTP2</b>: HTTP/2</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when EndpointRequestProtocol is set to HTTPS.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP1.1</para>
            /// </summary>
            [NameInMap("EndpointProtocolVersion")]
            [Validation(Required=false)]
            public string EndpointProtocolVersion { get; set; }

            /// <summary>
            /// <para>The protocol used by the backend service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP</b> (default)</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b></para>
            /// </description></item>
            /// </list>
            /// <para>You can enter up to 10 backend service protocols.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </description></item>
            /// <item><description><para>You can configure this parameter only for endpoint groups of HTTP or HTTPS listeners.</para>
            /// </description></item>
            /// <item><description><para>For an HTTP listener, the backend service protocol must be <b>HTTP</b>.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable health checks for the endpoint group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enables health checks.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (Default): Disables health checks.</para>
            /// </description></item>
            /// </list>
            /// <para>You can enable health checks for up to 10 endpoint groups.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// <para>The domain name that is used for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.taobao.com">www.taobao.com</a></para>
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The health check interval, in seconds.</para>
            /// <para>You can enter up to 10 health check intervals.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public long? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// <para>The path to which health check requests are sent.</para>
            /// <para>You can enter up to 10 health check paths.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/healthcheck</para>
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// <para>The port that is used for health checks. Valid values: <b>1</b> to <b>65535</b>.</para>
            /// <para>You can enter a maximum of 10 ports for health checks.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public long? HealthCheckPort { get; set; }

            /// <summary>
            /// <para>The protocol over which health check requests are sent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>tcp</b> or <b>TCP</b>: TCP</para>
            /// </description></item>
            /// <item><description><para><b>http</b> or <b>HTTP</b>: HTTP</para>
            /// </description></item>
            /// <item><description><para><b>https</b> or <b>HTTPS</b>: HTTPS</para>
            /// </description></item>
            /// </list>
            /// <para>You can enter up to 10 health check protocols.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// <para>The port mapping. You can specify up to five port mappings.</para>
            /// </summary>
            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<CreateListenerRequestEndpointGroupConfigurationsPortOverrides> PortOverrides { get; set; }
            public class CreateListenerRequestEndpointGroupConfigurationsPortOverrides : TeaModel {
                /// <summary>
                /// <para>The endpoint port that is specified in the port mapping.</para>
                /// <para>You can enter a maximum of 5 endpoint ports for port mapping.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
                /// </description></item>
                /// <item><description><para>For TCP listeners, you cannot configure a port mapping for a virtual endpoint group. If a virtual endpoint group already exists for the listener, you cannot configure a port mapping for the default endpoint group. If a port mapping is configured for the default endpoint group, you cannot add a virtual endpoint group to the listener.</para>
                /// </description></item>
                /// <item><description><para>After you configure a port mapping, you cannot modify the listener protocol, except for switching between HTTP and HTTPS.</para>
                /// </description></item>
                /// <item><description><para>When you modify the listener port range, make sure that the new port range includes all listener ports that are specified in the port mapping. For example, if the listener port range is 80-82 and the listener ports are mapped to the endpoint ports 100-102, you cannot change the listener port range to 80-81.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public long? EndpointPort { get; set; }

                /// <summary>
                /// <para>The listener port that is specified in the port mapping.</para>
                /// <para>You can enter up to 5 listener ports for port mappings.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
                /// </description></item>
                /// <item><description><para>For TCP listeners, you cannot configure a port mapping for a virtual endpoint group. If a virtual endpoint group already exists for the listener, you cannot configure a port mapping for the default endpoint group. If a port mapping is configured for the default endpoint group, you cannot add a virtual endpoint group to the listener.</para>
                /// </description></item>
                /// <item><description><para>After you configure a port mapping, you cannot modify the listener protocol, except for switching between HTTP and HTTPS.</para>
                /// </description></item>
                /// <item><description><para>When you modify the listener port range, make sure that the new port range includes all listener ports that are specified in the port mapping. For example, if the listener port range is 80-82 and the listener ports are mapped to the endpoint ports 100-102, you cannot change the listener port range to 80-81.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

            }

            /// <summary>
            /// <para>The number of consecutive successful health checks required to mark an endpoint as healthy, or consecutive failed health checks to mark an endpoint as unhealthy.
            /// Valid values: <b>2</b> to <b>10</b>. Default value: <b>3</b>.</para>
            /// <para>You can enter up to 10 values for the number of consecutive health checks required to trigger a health status change.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public long? ThresholdCount { get; set; }

            /// <summary>
            /// <para>The traffic distribution ratio. If a standard listener is associated with multiple endpoint groups, this parameter specifies the percentage of traffic that is distributed to each endpoint group.</para>
            /// <para>Valid values: <b>1</b> to <b>100</b>. Default value: <b>100</b>.</para>
            /// <para>You can enter traffic distribution values for up to 10 endpoint groups.</para>
            /// <remarks>
            /// <para>This parameter applies only when the listener\&quot;s routing type (<b>Type</b>) is <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public long? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// <para>The maximum HTTP version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>http3</b>: HTTP/3</para>
        /// </description></item>
        /// <item><description><para><b>http2</b> (default): HTTP/2</para>
        /// </description></item>
        /// <item><description><para><b>http1.1</b>: HTTP/1.1</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only to HTTPS listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>http2</para>
        /// </summary>
        [NameInMap("HttpVersion")]
        [Validation(Required=false)]
        public string HttpVersion { get; set; }

        /// <summary>
        /// <para>The connection idle timeout, in seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>TCP: 10–900 seconds. Default: 900 seconds.</para>
        /// </description></item>
        /// <item><description><para>UDP: 10–20 seconds. Default: 20 seconds.</para>
        /// </description></item>
        /// <item><description><para>HTTP/HTTPS: 1–60 seconds. Default: 15 seconds.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
        /// <para>The name must be 1 to 128 characters long, start with a letter or a Chinese character, and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Listener</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The listener port range. The port numbers must be within the range of <b>1</b> to <b>65499</b>. The maximum number of allowed ports depends on the listener\&quot;s routing type and protocol. For more information, see <a href="https://help.aliyun.com/document_detail/153216.html">Listener ports</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<CreateListenerRequestPortRanges> PortRanges { get; set; }
        public class CreateListenerRequestPortRanges : TeaModel {
            /// <summary>
            /// <para>The first port in the listener range used to receive and forward requests to endpoints.</para>
            /// <para>The port number must be in the range of <b>1</b> to <b>65499</b>, and the value of <b>FromPort</b> must be less than or equal to the value of <b>ToPort</b>.</para>
            /// <remarks>
            /// <para>For HTTP or HTTPS listeners, you can specify only one listener port. In this case, the value of <b>FromPort</b> must be the same as the value of <b>ToPort</b>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// <para>The last port in the listener range used to receive and forward requests to endpoints.</para>
            /// <para>The port number must be in the range of <b>1</b> to <b>65499</b>, and the value of <b>FromPort</b> must be less than or equal to the value of <b>ToPort</b>.</para>
            /// <remarks>
            /// <para>For HTTP or HTTPS listeners, you can specify only one listener port. In this case, the value of <b>FromPort</b> must be the same as the value of <b>ToPort</b>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// <para>The listener\&quot;s network protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tcp</b>: TCP.</para>
        /// </description></item>
        /// <item><description><para><b>udp</b>: UDP.</para>
        /// </description></item>
        /// <item><description><para><b>http</b>: HTTP.</para>
        /// </description></item>
        /// <item><description><para><b>https</b>: HTTPS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region ID of the Global Accelerator instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request timeout for HTTP/HTTPS connections, in seconds.</para>
        /// <para>Valid values: 1–180 seconds. Default: 60 seconds.</para>
        /// <remarks>
        /// <para>This parameter applies only to HTTP or HTTPS listeners. If the backend server does not respond within the timeout period, Global Accelerator returns an HTTP 504 error to the client.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The ID of the security policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tls_cipher_policy_1_0</b></para>
        /// <list type="bullet">
        /// <item><description><para>Supported TLS versions: TLS 1.0, TLS 1.1, and TLS 1.2.</para>
        /// </description></item>
        /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_1</b></para>
        /// <list type="bullet">
        /// <item><description><para>Supported TLS versions: TLS 1.1 and TLS 1.2.</para>
        /// </description></item>
        /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2</b></para>
        /// <list type="bullet">
        /// <item><description><para>Supported TLS version: TLS 1.2.</para>
        /// </description></item>
        /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2_strict</b></para>
        /// <list type="bullet">
        /// <item><description><para>Supported TLS version: TLS 1.2.</para>
        /// </description></item>
        /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2_strict_with_1_3</b></para>
        /// <list type="bullet">
        /// <item><description><para>Supported TLS versions: TLS 1.2 and TLS 1.3.</para>
        /// </description></item>
        /// <item><description><para>Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only to HTTPS listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_0</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The routing type of the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Standard</b> (default): standard routing.</para>
        /// </description></item>
        /// <item><description><para><b>CustomRouting</b>: custom routing.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Custom routing is in invitation-only preview. To use this feature, contact your Alibaba Cloud account manager.</para>
        /// </description></item>
        /// <item><description><para>A standard Global Accelerator instance supports only one routing type for all of its listeners. The routing type cannot be changed after the listener is created. For more information, see <a href="https://help.aliyun.com/document_detail/153216.html">Listener overview</a>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Settings for <c>X-Forwarded-For</c> related headers.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class CreateListenerRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use the <c>GA-AP</c> header to pass information about the acceleration region to the backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b> (Default)</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter applies only to HTTP and HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForGaApEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaApEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>GA-ID</c> header to pass the Global Accelerator instance ID to the backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b> (Default)</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter applies only to HTTP and HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForGaIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>GA-X-Forward-Port</c> header to pass the listener port of the Global Accelerator instance to the backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b> (Default)</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter applies only to HTTP and HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForPortEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>GA-X-Forward-Proto</c> header to pass the listener protocol of the Global Accelerator instance to the backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b> (Default)</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter applies only to HTTP and HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Real-IP</c> header to pass the client\&quot;s real IP address to the backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b> (Default)</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter applies only to HTTP and HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XRealIpEnabled")]
            [Validation(Required=false)]
            public bool? XRealIpEnabled { get; set; }

        }

    }

}
