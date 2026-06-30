// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateEndpointGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a value for this parameter on your client. Make sure that the value is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each request.</para>
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
        /// <item><description><para><b>true</b>: performs a dry run. The system checks the required parameters, request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, a 2xx HTTP status code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends the request. If the request passes the check, a 2xx HTTP status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The configurations of the endpoint group.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndpointGroupConfigurations")]
        [Validation(Required=false)]
        public List<UpdateEndpointGroupsRequestEndpointGroupConfigurations> EndpointGroupConfigurations { get; set; }
        public class UpdateEndpointGroupsRequestEndpointGroupConfigurations : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use the Proxy Protocol to preserve client IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableClientIPPreservationProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationProxyProtocol { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the TCP Option Address (TOA) module to preserve client IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableClientIPPreservationToa")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservationToa { get; set; }

            /// <summary>
            /// <para>The configurations of the endpoint.</para>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<UpdateEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class UpdateEndpointGroupsRequestEndpointGroupConfigurationsEndpointConfigurations : TeaModel {
                [NameInMap("ApiKeys")]
                [Validation(Required=false)]
                public List<string> ApiKeys { get; set; }

                /// <summary>
                /// <para>Specifies whether to preserve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: preserves client IP addresses.</para>
                /// </description></item>
                /// <item><description><para><b>false</b> (default): does not preserve client IP addresses.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>By default, client IP address preservation is disabled for endpoint groups of TCP and UDP listeners. You can enable it based on your business needs.</para>
                /// </description></item>
                /// <item><description><para>Client IP address preservation is enabled by default for endpoint groups of HTTP and HTTPS listeners. The client IP addresses are retrieved from the X-Forwarded-For header field. You cannot disable this feature.</para>
                /// </description></item>
                /// <item><description><para>EnableClientIPPreservation and EnableProxyProtocol cannot be set to true at the same time.</para>
                /// </description></item>
                /// <item><description><para>For more information, see <a href="t1863665.xdita#"></a>.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("EnableClientIPPreservation")]
                [Validation(Required=false)]
                public bool? EnableClientIPPreservation { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the Proxy Protocol to preserve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: uses the Proxy Protocol.</para>
                /// </description></item>
                /// <item><description><para><b>false</b> (default): does not use the Proxy Protocol.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter is available only for endpoint groups of TCP listeners.</para>
                /// </description></item>
                /// <item><description><para>EnableClientIPPreservation and EnableProxyProtocol cannot be set to true at the same time.</para>
                /// </description></item>
                /// <item><description><para>For more information, see <a href="t1863665.xdita#"></a>.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("EnableProxyProtocol")]
                [Validation(Required=false)]
                public bool? EnableProxyProtocol { get; set; }

                /// <summary>
                /// <para>The IP address, domain name, or instance ID of the endpoint, based on the value of Type.</para>
                /// <para>This parameter is required.</para>
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
                /// <list type="bullet">
                /// <item><description>This parameter is available only when the endpoint type is ENI. You can specify this parameter. If you do not specify this parameter, the primary private IP address of the ENI is used.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>172.168.XX.XX</para>
                /// </summary>
                [NameInMap("SubAddress")]
                [Validation(Required=false)]
                public string SubAddress { get; set; }

                /// <summary>
                /// <para>The type of the endpoint.</para>
                /// <list type="bullet">
                /// <item><description><para><b>Domain</b>: a custom domain name.</para>
                /// </description></item>
                /// <item><description><para><b>Ip</b>: a custom IP address.</para>
                /// </description></item>
                /// <item><description><para><b>IpTarget</b>: a custom private IP address.</para>
                /// </description></item>
                /// <item><description><para><b>PublicIp</b>: an Alibaba Cloud public IP address.</para>
                /// </description></item>
                /// <item><description><para><b>ECS</b>: an Alibaba Cloud Elastic Compute Service (ECS) instance.</para>
                /// </description></item>
                /// <item><description><para><b>SLB</b>: an Alibaba Cloud Server Load Balancer (SLB) instance.</para>
                /// </description></item>
                /// <item><description><para><b>ALB</b>: an Alibaba Cloud Application Load Balancer (ALB) instance.</para>
                /// </description></item>
                /// <item><description><para><b>OSS</b>: an Alibaba Cloud Object Storage Service (OSS) bucket.</para>
                /// </description></item>
                /// <item><description><para><b>ENI</b>: an Alibaba Cloud Elastic Network Interface (ENI).</para>
                /// </description></item>
                /// <item><description><para><b>NLB</b>: an Alibaba Cloud Network Load Balancer (NLB) instance.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>If you set the endpoint type to <b>ECS</b>, <b>ENI</b>, <b>SLB</b>, <b>NLB</b>, or <b>IpTarget</b>, and the service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaVpcEndpoint.</para>
                /// </description></item>
                /// <item><description><para>If you set the endpoint type to <b>ALB</b>, and the service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaAlb.</para>
                /// </description></item>
                /// <item><description><para>If you set the endpoint type to <b>OSS</b>, and the service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaOss.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>For more information, see <a href="t1963894.xdita#"></a>.</para>
                /// </remarks>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ip</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The list of vSwitches in the VPC.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// <para>You can specify at most one VPC ID for an endpoint group that is associated with a listener that uses smart routing.</para>
                /// <remarks>
                /// <para>This parameter is required and takes effect only when the endpoint type is <b>IpTarget</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf66oesmrqge1t2gs****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The weight of the endpoint.</para>
                /// <para>Valid values: <b>0</b> to <b>255</b>.</para>
                /// <remarks>
                /// <para>If you set the weight of an endpoint to 0, GA stops distributing traffic to the endpoint. Handle this with care.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
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
            /// <para>The description can be up to 200 characters in length and cannot start with http\:// or https\://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("EndpointGroupDescription")]
            [Validation(Required=false)]
            public string EndpointGroupDescription { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp1d2utp8qqe2a44t****</para>
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint group.</para>
            /// <para>The name must be 1 to 128 characters in length, start with a letter or a Chinese character, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("EndpointGroupName")]
            [Validation(Required=false)]
            public string EndpointGroupName { get; set; }

            [NameInMap("EndpointIpVersion")]
            [Validation(Required=false)]
            public string EndpointIpVersion { get; set; }

            /// <summary>
            /// <para>The version of the backend service protocol for endpoints in a listener that uses smart routing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP1.1</b> (default): HTTP/1.1</para>
            /// </description></item>
            /// <item><description><para><b>HTTP2</b>: HTTP/2</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you set EndpointRequestProtocol to HTTPS.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP1.1</para>
            /// </summary>
            [NameInMap("EndpointProtocolVersion")]
            [Validation(Required=false)]
            public string EndpointProtocolVersion { get; set; }

            /// <summary>
            /// <para>The protocol of the backend service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP</b>: HTTP</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: HTTPS</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>You can set this parameter only when you create an endpoint group for an HTTP or HTTPS listener.</para>
            /// </description></item>
            /// <item><description><para>For an HTTP listener, the backend service protocol must be HTTP.</para>
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
            /// <para>Specifies whether to enable the health check feature.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables the health check feature.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): disables the health check feature.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The interval between two consecutive health checks. Unit: seconds. Valid values: <b>1</b> to <b>50</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public long? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// <para>The path of the health check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthcheck</para>
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// <para>The port that is used for health checks.</para>
            /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public long? HealthCheckPort { get; set; }

            /// <summary>
            /// <para>The protocol that is used for health checks.</para>
            /// <list type="bullet">
            /// <item><description><para><b>tcp</b> or <b>TCP</b>: TCP</para>
            /// </description></item>
            /// <item><description><para><b>http</b> or <b>HTTP</b>: HTTP</para>
            /// </description></item>
            /// <item><description><para><b>https</b> or <b>HTTPS</b>: HTTPS</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// <para>The port mapping.</para>
            /// </summary>
            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<UpdateEndpointGroupsRequestEndpointGroupConfigurationsPortOverrides> PortOverrides { get; set; }
            public class UpdateEndpointGroupsRequestEndpointGroupConfigurationsPortOverrides : TeaModel {
                /// <summary>
                /// <para>The endpoint port.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public long? EndpointPort { get; set; }

                /// <summary>
                /// <para>The listener port.</para>
                /// <para>Valid values: <b>1</b> to <b>65499</b>.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>For TCP listeners, virtual endpoint groups do not support port mapping. If a virtual endpoint group already exists under the listener, you cannot configure port mapping for the default endpoint group. If port mapping is already configured for the default endpoint group, you cannot add a virtual endpoint group.</para>
                /// </description></item>
                /// <item><description><para>After you configure port mapping, the following limits apply to subsequent listener modifications: You cannot change the listener protocol, except for changing it between HTTP and HTTPS.</para>
                /// </description></item>
                /// <item><description><para>Listener port: The modified listener port range must include all listener ports that are currently mapped. For example, if the listener port range is 80-82 and the ports are mapped to endpoint ports 100-102, you cannot change the listener port range to 80-81.</para>
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
            /// <para>The number of consecutive health checks that an endpoint must pass to be considered healthy, or fail to be considered unhealthy.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public long? ThresholdCount { get; set; }

            /// <summary>
            /// <para>The traffic distribution ratio. If a listener is associated with multiple endpoint groups, you can specify this parameter to distribute traffic to the endpoint groups.</para>
            /// <para>Valid values: <b>1</b> to <b>100</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public long? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// <para>The ID of the listener.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The region ID of the GA instance. Set the value to <b>cn-hangzhou</b>.</para>
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
