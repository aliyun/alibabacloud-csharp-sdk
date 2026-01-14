// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateListenerRequest : TeaModel {
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
        /// <para>The SSL certificates.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCertificates> Certificates { get; set; }
        public class CreateListenerRequestCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the SSL certificate.</para>
            /// <remarks>
            /// <para>This parameter is required only when you create an HTTPS listener.</para>
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
        /// <para>Specifies whether to enable client affinity for the listener.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, client affinity is disabled. After client affinity is disabled, requests from a specific client IP address may be forwarded to different endpoints.</description></item>
        /// <item><description>To enable client affinity, set this parameter to <b>SOURCE_IP</b>. In this case, when a client accesses stateful applications, requests from the same client are forwarded to the same endpoint regardless of the source port or protocol.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SOURCE_IP</para>
        /// </summary>
        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not set this parameter, <b>ClientToken</b> is set to the value of <b>RequestId</b>. The value of <b>RequestId</b> is different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The endpoint group that is associated with the custom routing listener.</para>
        /// <para>The endpoint groups that are associated with the custom routing listener.</para>
        /// <remarks>
        /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomRoutingEndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurations> CustomRoutingEndpointGroupConfigurations { get; set; }
        public class CreateListenerRequestCustomRoutingEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// <para>The description of the endpoint group that is associated with the custom routing listener.</para>
            /// <para>The description can be up to 200 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to five endpoint group descriptions.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mapping configurations of the endpoint group that is associated with the custom routing listener.</para>
            /// <para>You need to specify the port ranges and protocols used by the endpoint group. The ports are mapped to listener ports.</para>
            /// <para>You can specify up to 20 mapping configurations for an endpoint group of a custom routing listener.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DestinationConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsDestinationConfigurations> DestinationConfigurations { get; set; }
            public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsDestinationConfigurations : TeaModel {
                /// <summary>
                /// <para>The start port used by the endpoint group that is associated with the custom routing listener.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be equal to or smaller than the value of <b>ToPort</b>.</para>
                /// <para>You can specify up to 20 start ports for an endpoint group of a custom routing listener.</para>
                /// <remarks>
                /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// <para>The protocol used by the endpoint group that is associated with the custom routing listener.</para>
                /// <para>You can specify up to four protocol types for an endpoint group of a custom routing listener.</para>
                /// <remarks>
                /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

                /// <summary>
                /// <para>The end port used by the endpoint group that is associated with the custom routing listener.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be equal to or smaller than the value of <b>ToPort</b>.</para>
                /// <para>You can specify up to 20 end ports for an endpoint group of a custom routing listener.</para>
                /// <remarks>
                /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
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
            /// <para>The endpoints that are associated with the custom routing listener.</para>
            /// <para>You can configure up to 10 endpoints for an endpoint group of a custom routing listener.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// <para>The name of the vSwitch attached to the endpoint of the custom routing listener.</para>
                /// <remarks>
                /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-test01</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The destinations in the endpoint that is associated with the custom routing listener.</para>
                /// <para>You can specify up to 20 traffic destinations for each endpoint of a custom routing listener.</para>
                /// <remarks>
                /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("PolicyConfigurations")]
                [Validation(Required=false)]
                public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations> PolicyConfigurations { get; set; }
                public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurations : TeaModel {
                    /// <summary>
                    /// <para>The IP address of the destination.</para>
                    /// <para>This parameter takes effect only if <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify up to 20 destination IP addresses for each endpoint of a custom routing listener.</para>
                    /// <remarks>
                    /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.XX.XX</para>
                    /// </summary>
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>The port ranges of the destination to which traffic is forwarded. The value of this parameter must fall within the port range of the endpoint group.</para>
                    /// <para>If you do not specify this parameter, traffic is forwarded over all ports.</para>
                    /// <para>This parameter takes effect only if <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                    /// <para>You can specify port ranges for up to 20 destinations in each endpoint of a custom routing listener. You can specify up to five port ranges for each destination.</para>
                    /// <remarks>
                    /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("PortRanges")]
                    [Validation(Required=false)]
                    public List<CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges> PortRanges { get; set; }
                    public class CreateListenerRequestCustomRoutingEndpointGroupConfigurationsEndpointConfigurationsPolicyConfigurationsPortRanges : TeaModel {
                        /// <summary>
                        /// <para>The start port of the port range. The value of this parameter must fall within the port range of the backend service.</para>
                        /// <para>This parameter takes effect only if <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                        /// <para>You can specify port ranges for up to 20 destinations in each endpoint of a custom routing listener. You can specify up to five start ports for each destination.</para>
                        /// <remarks>
                        /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("FromPort")]
                        [Validation(Required=false)]
                        public int? FromPort { get; set; }

                        /// <summary>
                        /// <para>The end port of the destination port range. The value of this parameter must fall within the port range of the backend service.</para>
                        /// <para>This parameter takes effect only if <b>TrafficToEndpointPolicy</b> is set to <b>AllowCustom</b>.</para>
                        /// <para>You can specify port ranges for up to 20 destinations in each endpoint of a custom routing listener. You can specify up to five end ports for each destination.</para>
                        /// <remarks>
                        /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
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
                /// <para>The traffic policy for the endpoint that is associated with the custom routing listener. Default value: DenyAll. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DenyAll</b> (default): denies all traffic to the specified backend service.</description></item>
                /// <item><description><b>AllowAll</b>: allows all traffic to the specified backend service.</description></item>
                /// <item><description><b>AllowCustom</b>: allows traffic only to specified destinations in the endpoint. If you set this parameter to AllowCustom, you must specify IP addresses and port ranges as the destinations to which you want to distribute traffic. If you specify only IP addresses and do not specify port ranges, GA can forward traffic to the specified IP addresses over all destination ports.</description></item>
                /// </list>
                /// <remarks>
                /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>DenyAll</para>
                /// </summary>
                [NameInMap("TrafficToEndpointPolicy")]
                [Validation(Required=false)]
                public string TrafficToEndpointPolicy { get; set; }

                /// <summary>
                /// <para>The service type of the endpoint that is associated with the custom routing listener. Default value: PrivateSubNet. Set the value to</para>
                /// <para><b>PrivateSubNet</b>, which specifies a private CIDR block.</para>
                /// <remarks>
                /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
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
            /// <para>The region ID of the endpoint group that is associated with the custom routing listener.</para>
            /// <para>You can enter the region IDs of up to five endpoint groups.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// <para>The name of the endpoint group that is associated with the custom routing listener.</para>
            /// <para>The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
            /// <para>You can specify up to five endpoint group names.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints for a custom routing listener only if <b>Type</b> is set to <b>CustomRouting</b>.</para>
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
        /// <para>The description can be up to 200 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Listener</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The endpoint groups that are associated with the intelligent routing listener.</para>
        /// <para>You can configure up to 10 endpoint groups for an intelligent routing listener.</para>
        /// <remarks>
        /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<CreateListenerRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class CreateListenerRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// <para>The endpoints that are associated with the intelligent routing listener.</para>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<CreateListenerRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class CreateListenerRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                /// <summary>
                /// <para>Specifies whether to automatically preserve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b> (default)</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>By default, client IP address preservation is disabled for an endpoint group that is associated with a UDP or TCP listener. You can configure this parameter based on your business requirements.</description></item>
                /// <item><description>By default, client IP address preservation is enabled for an endpoint group that is associated with a HTTP or HTTPS listener. Client IP addresses are obtained by using the X-Forwarded-For header. You cannot disable the feature.</description></item>
                /// <item><description>EnableClientIPPreservation and EnableProxyProtocol cannot be set to true at the same time.<remarks>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">Preserve client IP addresses</a>.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("EnableClientIPPreservation")]
                [Validation(Required=false)]
                public bool? EnableClientIPPreservation { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the proxy protocol to preserve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b> (default)</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter is supported only by endpoint groups associated with TCP listeners.</description></item>
                /// <item><description>EnableClientIPPreservation and EnableProxyProtocol cannot be set to true at the same time.<remarks>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">Preserve client IP addresses</a>.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("EnableProxyProtocol")]
                [Validation(Required=false)]
                public bool? EnableProxyProtocol { get; set; }

                /// <summary>
                /// <para>The IP address or domain name of the endpoint that is associated with the intelligent routing listener.</para>
                /// <para>You can enter the IP addresses or domain names of up to 100 endpoints in an endpoint group that is associated with the intelligent routing listener.</para>
                /// <remarks>
                /// <para> If you set <b>Type</b> to <b>Standard</b>, you can configure endpoint groups and endpoints, and this parameter is required.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>47.0.XX.XX</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The private IP address of the ENI.</para>
                /// <remarks>
                /// <para> This parameter is available only when you set the endpoint type to <b>ENI</b>. If you leave this parameter empty, the primary private IP address of the ENI is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>172.168.XX.XX</para>
                /// </summary>
                [NameInMap("SubAddress")]
                [Validation(Required=false)]
                public string SubAddress { get; set; }

                /// <summary>
                /// <para>The type of the endpoint that is associated with the intelligent routing listener. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Domain</b>: a custom domain name.</description></item>
                /// <item><description><b>Ip</b>: a custom IP address.</description></item>
                /// <item><description><b>PublicIp</b>: a public IP address provided by Alibaba Cloud.</description></item>
                /// <item><description><b>ECS</b>: an Elastic Compute Service (ECS) instance.</description></item>
                /// <item><description><b>SLB</b>: a Server Load Balancer (SLB) instance.</description></item>
                /// <item><description><b>ALB</b>: an Application Load Balancer (ALB) instance.</description></item>
                /// <item><description><b>OSS</b>: an Object Storage Service (OSS) bucket.</description></item>
                /// <item><description><b>ENI</b>: an elastic network interface (ENI).</description></item>
                /// <item><description><b>NLB</b>: a Network Load Balancer (NLB) instance.</description></item>
                /// <item><description><b>IpTarget</b>: a custom private IP address.</description></item>
                /// </list>
                /// <para>You can specify up to 100 endpoint types in the endpoint group that is associated with the intelligent routing listener.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If you set <b>Type</b> to <b>Standard</b>, you can configure the endpoint group and endpoint that are associated with the intelligent routing listener. In addition, this parameter is required.</description></item>
                /// <item><description>If you set this parameter to <b>ECS</b>, <b>ENI</b>, <b>SLB</b>, <b>ALB</b>, <b>NLB</b>, or <b>IpTarget</b> and the AliyunServiceRoleForGaVpcEndpoint service-linked role does not exist, the system automatically creates the role.</description></item>
                /// <item><description>If you set this parameter to <b>ALB</b> and the AliyunServiceRoleForGaAlb service-linked role does not exist, the system automatically creates the role.</description></item>
                /// <item><description>If you set this parameter to <b>OSS</b> and the AliyunServiceRoleForGaOss service-linked role does not exist, the system automatically creates the role.</description></item>
                /// <item><description>If you set this parameter to <b>NLB</b> and the AliyunServiceRoleForGaNlb service-linked role does not exist, the system automatically creates the role.<remarks>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178360.html">Service-linked roles</a>.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Ip</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The IDs of vSwitches that are deployed in the VPC.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// <para>You can specify one VPC ID for an endpoint group of an intelligent routing listener.</para>
                /// <remarks>
                /// <para> This parameter is valid and required only if Type is set to <b>IpTarget</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp13r1kpr2lel****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The weight of the endpoint that is associated with the intelligent routing listener.</para>
                /// <para>Valid values: <b>0</b> to <b>255</b>.</para>
                /// <para>You can specify the weights of up to 100 endpoints for an endpoint group of an intelligent routing listener.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If you set <b>Type</b> to <b>Standard</b>, you can configure the endpoint group and endpoint that are associated with the intelligent routing listener. In addition, this parameter is required.</description></item>
                /// <item><description>If the weight of an endpoint is set to 0, GA stops distributing network traffic to the endpoint. Proceed with caution.</description></item>
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
            /// <para>The description of the endpoint group that is associated with the intelligent routing listener.</para>
            /// <para>The description can be up to 200 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can enter the descriptions of up to 10 endpoint groups.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EndpointGroupDescription")]
            [Validation(Required=false)]
            public string EndpointGroupDescription { get; set; }

            /// <summary>
            /// <para>The name of the endpoint group that is associated with the intelligent routing listener.</para>
            /// <para>The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
            /// <para>You can enter the names of up to 10 endpoint groups.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EndpointGroupName")]
            [Validation(Required=false)]
            public string EndpointGroupName { get; set; }

            /// <summary>
            /// <para>The region ID of the endpoint group that is associated with the intelligent routing listener.</para>
            /// <para>You can enter the IDs of up to 10 regions.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// <para>The type of the endpoint group associated with the intelligent routing listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b> (default): a default endpoint group.</description></item>
            /// <item><description><b>virtual</b>: a virtual endpoint group.</description></item>
            /// </list>
            /// <para>You can specify up to 10 endpoint group types.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>You can configure endpoint groups and endpoints for an intelligent routing listener only if you set <b>Type</b> to <b>Standard</b>.</description></item>
            /// <item><description>Only HTTP and HTTPS intelligent routing listeners support virtual endpoint groups.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            [NameInMap("EndpointIpVersion")]
            [Validation(Required=false)]
            public string EndpointIpVersion { get; set; }

            /// <summary>
            /// <para>The backend service protocol version of the endpoint that is associated with the intelligent routing listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP1.1</b> (default)</description></item>
            /// <item><description><b>HTTP2</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> You can specify this parameter only if EndpointRequestProtocol is set to HTTPS.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("EndpointProtocolVersion")]
            [Validation(Required=false)]
            public string EndpointProtocolVersion { get; set; }

            /// <summary>
            /// <para>The backend service protocol of the endpoint that is associated with the intelligent routing listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP</b> (default)</description></item>
            /// <item><description><b>HTTPS</b></description></item>
            /// </list>
            /// <para>You can specify up to 10 backend service protocols.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>You can configure endpoint groups and endpoints for an intelligent routing listener only if you set <b>Type</b> to <b>Standard</b>.</description></item>
            /// <item><description>You can specify this parameter only for HTTP and HTTPS intelligent routing listeners.</description></item>
            /// <item><description>For an HTTP listener, the backend service protocol must be <b>HTTP</b>.</description></item>
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
            /// <item><description><b>true</b>: enables the health check feature.</description></item>
            /// <item><description><b>false</b> (default): disables the health check feature.</description></item>
            /// </list>
            /// <para>You can enable the health check feature for up to 10 endpoint groups.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The interval at which health checks are performed. Unit: seconds.</para>
            /// <para>You can specify up to 10 health check intervals.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public long? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// <para>The health check path.</para>
            /// <para>You can specify up to 10 health check paths.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/healthcheck</para>
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// <para>The port that you want to use for health checks. Valid values: <b>1</b> to <b>65535</b>.</para>
            /// <para>You can specify up to 10 ports for health checks.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
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
            /// <item><description><b>tcp</b> or <b>TCP</b></description></item>
            /// <item><description><b>http</b> or <b>HTTP</b></description></item>
            /// <item><description><b>https</b> or <b>HTTPS</b></description></item>
            /// </list>
            /// <para>You can specify up to 10 health check protocols.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// <para>The port mappings.</para>
            /// </summary>
            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<CreateListenerRequestEndpointGroupConfigurationsPortOverrides> PortOverrides { get; set; }
            public class CreateListenerRequestEndpointGroupConfigurationsPortOverrides : TeaModel {
                /// <summary>
                /// <para>The endpoint port that is mapped to the listener port.</para>
                /// <para>You can specify endpoint ports in up to five port mappings.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>You can configure endpoint groups and endpoints for an intelligent routing listener only if you set <b>Type</b> to <b>Standard</b>.</description></item>
                /// <item><description>You cannot configure port mappings for virtual endpoint groups of TCP listeners. If a virtual endpoint group already exists on the listener, you cannot configure port mappings for the default endpoint group. If port mappings are configured for the default endpoint group, you cannot add a virtual endpoint group.</description></item>
                /// <item><description>If you configure port mappings for a listener, you cannot modify the listener protocol. You can only switch between HTTP and HTTPS.</description></item>
                /// <item><description>Listener port: When you modify the listener port range, make sure that the port range includes the ports configured in port mappings. For example, if you set the listener port range to 80 to 82 and map the listener ports to endpoint ports 100 to 102, you cannot change the listener port range to 80 to 81.</description></item>
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
                /// <para>The listener port that is mapped to the endpoint port.</para>
                /// <para>You can specify listener ports in up to five port mappings.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>You can configure endpoint groups and endpoints for an intelligent routing listener only if you set <b>Type</b> to <b>Standard</b>.</description></item>
                /// <item><description>You cannot configure port mappings for virtual endpoint groups of TCP listeners. If a virtual endpoint group already exists on the listener, you cannot configure port mappings for the default endpoint group. If port mappings are configured for the default endpoint group, you cannot add a virtual endpoint group.</description></item>
                /// <item><description>If you configure port mappings for a listener, you cannot modify the listener protocol. You can only switch between HTTP and HTTPS.</description></item>
                /// <item><description>Listener port: When you modify the listener port range, make sure that the port range includes the ports configured in port mappings. For example, if you set the listener port range to 80 to 82 and map the listener ports to endpoint ports 100 to 102, you cannot change the listener port range to 80 to 81.</description></item>
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
            /// <para>The number of failed consecutive health checks that must occur before a healthy endpoint group is considered unhealthy or the number of successful consecutive health checks that must occur before an unhealthy endpoint group is considered healthy. Valid values: <b>2</b> to <b>10</b>. Default value: <b>3</b>.</para>
            /// <para>You can specify up to 10 values (the number of consecutive health check successes or consecutive health check failures).</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public long? ThresholdCount { get; set; }

            /// <summary>
            /// <para>The traffic distribution ratio. If an intelligent routing listener is associated with multiple endpoint groups, you can configure this parameter to specify the ratio of traffic distributed to each endpoint group.</para>
            /// <para>Valid values: <b>1</b> to <b>100</b>. Default value: <b>100</b>.</para>
            /// <para>You can specify traffic distribution ratios for up to 10 endpoint groups.</para>
            /// <remarks>
            /// <para> You can configure endpoint groups and endpoints only if you set <b>Type</b> to <b>Standard</b>.</para>
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
        /// <para>The maximum version of the HTTP protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>http3</b></description></item>
        /// <item><description><b>http2</b> (default)</description></item>
        /// <item><description><b>http1.1</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> Only HTTPS listeners support this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>http2</para>
        /// </summary>
        [NameInMap("HttpVersion")]
        [Validation(Required=false)]
        public string HttpVersion { get; set; }

        /// <summary>
        /// <para>The timeout period of idle connections. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>TCP: 10-900. Default value: 900. Unit: seconds.</description></item>
        /// <item><description>UDP: 10-20. Default value: 20. Unit: seconds.</description></item>
        /// <item><description>HTTP/HTTPS: 1-60. Default value: 15. Unit: seconds.</description></item>
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
        /// <para>The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Listener</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The listener ports. Valid values: <b>1</b> to <b>65499</b>. The maximum number of ports that can be configured depends on the routing type and protocol of the listener. For more information, see <a href="https://help.aliyun.com/document_detail/153216.html">Listener overview</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<CreateListenerRequestPortRanges> PortRanges { get; set; }
        public class CreateListenerRequestPortRanges : TeaModel {
            /// <summary>
            /// <para>The first port of the listener port range that you want to use to receive and forward requests to endpoints.</para>
            /// <para>Valid values: <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be smaller than or equal to the value of <b>ToPort</b>.</para>
            /// <para>The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see <a href="https://help.aliyun.com/document_detail/153216.html">Listener overview</a>.</para>
            /// <remarks>
            /// <para>You can configure only one listener port for an HTTP or HTTPS listener. In this case, the first port is the same as the last port.</para>
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
            /// <para>The last port of the listener port range that you want to use to receive and forward requests to endpoints.</para>
            /// <para>Valid values: <b>1</b> to <b>65499</b>. The value of <b>FromPort</b> must be smaller than or equal to the value of <b>ToPort</b>.</para>
            /// <para>The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see <a href="https://help.aliyun.com/document_detail/153216.html">Listener overview</a>.</para>
            /// <remarks>
            /// <para>You can configure only one listener port for an HTTP or HTTPS listener. In this case, the first port is the same as the last port.</para>
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
        /// <para>The network transmission protocol that you want to use for the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b>: TCP</description></item>
        /// <item><description><b>udp</b>: UDP</description></item>
        /// <item><description><b>http</b>: HTTP</description></item>
        /// <item><description><b>https</b>: HTTPS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

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

        /// <summary>
        /// <para>The timeout period for HTTP or HTTPS requests. Unit: seconds.</para>
        /// <para>Valid values: 1 to 180. Default value: 60. Unit: seconds.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for HTTP or HTTPS listeners. If the backend server does not respond within the timeout period, GA returns an HTTP 504 error code to the client.</para>
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
        /// <item><description>Supported Transport Layer Security (TLS) versions: TLS 1.0, TLS 1.1, and TLS 1.2</description></item>
        /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_1</b></para>
        /// <list type="bullet">
        /// <item><description>Supported TLS versions: TLS 1.1 and TLS 1.2</description></item>
        /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2</b></para>
        /// <list type="bullet">
        /// <item><description>Supported TLS version: TLS 1.2</description></item>
        /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2_strict</b></para>
        /// <list type="bullet">
        /// <item><description>Supported TLS version: TLS 1.2</description></item>
        /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2_strict_with_1_3</b></para>
        /// <list type="bullet">
        /// <item><description>Supported TLS versions: TLS 1.2 and TLS 1.3</description></item>
        /// <item><description>Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when you create an HTTPS listener.</para>
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
        /// <item><description><b>Standard</b> (default): intelligent routing</description></item>
        /// <item><description><b>CustomRouting</b>: custom routing</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Custom routing listeners are in invitational preview. To use custom routing listeners, contact your account manager.</description></item>
        /// <item><description>You can create only listeners of the same routing type for a standard GA instance. You cannot change the routing types of listeners. For more information, see <a href="https://help.aliyun.com/document_detail/153216.html">Listener overview</a>.</description></item>
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
        /// <para>The <c>XForward</c> headers.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class CreateListenerRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use the <c>GA-AP</c> header to retrieve the information about acceleration regions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS or HTTP listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForGaApEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaApEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>GA-ID</c> header to retrieve the ID of the GA instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS or HTTP listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForGaIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>GA-X-Forward-Port</c> header to retrieve the listener ports of the GA instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS or HTTP listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForPortEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>GA-X-Forward-Proto</c> header to retrieve the listener protocol of the GA instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS or HTTP listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Real-IP</c> header to retrieve client IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS or HTTP listener.</para>
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
