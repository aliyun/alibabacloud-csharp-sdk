// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateEndpointGroupRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token to ensure the idempotence of the request.</para>
        /// <para>The token must be unique across requests and can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> is unique for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the endpoint group.</para>
        /// <para>The description can be up to 200 characters long and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EndpointGroup</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configurations of the endpoints.</para>
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<UpdateEndpointGroupRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class UpdateEndpointGroupRequestEndpointConfigurations : TeaModel {
            [NameInMap("ApiKeys")]
            [Validation(Required=false)]
            public List<string> ApiKeys { get; set; }

            /// <summary>
            /// <para>Specifies whether to preserve client source IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Preserves client source IP addresses.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Does not preserve client source IP addresses.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>For endpoint groups of TCP or UDP listeners, this feature is disabled by default but can be enabled if needed.</para>
            /// </description></item>
            /// <item><description><para>For endpoint groups of HTTP or HTTPS listeners, client source IP addresses are preserved by default. The client IP addresses are retrieved from the X-Forwarded-For header. You cannot disable this feature.</para>
            /// </description></item>
            /// <item><description><para>You cannot set both <c>EnableClientIPPreservation</c> and <c>EnableProxyProtocol</c> to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">preserve client source IP addresses</a>.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableClientIPPreservation")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservation { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the Proxy Protocol to preserve client source IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Preserves client source IP addresses.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Does not preserve client source IP addresses.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>You can configure this parameter only for endpoint groups of TCP listeners.</para>
            /// </description></item>
            /// <item><description><para>You cannot set both <c>EnableClientIPPreservation</c> and <c>EnableProxyProtocol</c> to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">preserve client source IP addresses</a>.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableProxyProtocol { get; set; }

            /// <summary>
            /// <para>Enter an IP address, a domain name, or an instance ID based on the value of the <c>Type</c> parameter.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.XX.XX.21</para>
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
            /// <para>The private IP address of the elastic network interface.</para>
            /// <remarks>
            /// <para>If the endpoint type is <b>ENI</b>, you can specify this parameter. If you omit this parameter, the primary private IP address of the ENI is used.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.168.XX.XX</para>
            /// </summary>
            [NameInMap("SubAddress")]
            [Validation(Required=false)]
            public string SubAddress { get; set; }

            /// <summary>
            /// <para>The type of endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Domain</b>: a custom domain name.</para>
            /// </description></item>
            /// <item><description><para><b>Ip</b>: a custom IP address.</para>
            /// </description></item>
            /// <item><description><para><b>IpTarget</b>: a custom private IP address.</para>
            /// </description></item>
            /// <item><description><para><b>PublicIp</b>: an Alibaba Cloud public IP address.</para>
            /// </description></item>
            /// <item><description><para><b>ECS</b>: an ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>SLB</b>: an SLB instance.</para>
            /// </description></item>
            /// <item><description><para><b>ALB</b>: an ALB instance.</para>
            /// </description></item>
            /// <item><description><para><b>OSS</b>: an OSS instance.</para>
            /// </description></item>
            /// <item><description><para><b>ENI</b>: an elastic network interface.</para>
            /// </description></item>
            /// <item><description><para><b>NLB</b>: an NLB instance.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>If the endpoint type is <b>ECS</b>, <b>ENI</b>, <b>SLB</b>, or <b>IpTarget</b>, and the service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaVpcEndpoint.</para>
            /// </description></item>
            /// <item><description><para>If the endpoint type is <b>ALB</b>, and the service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaAlb.</para>
            /// </description></item>
            /// <item><description><para>If the endpoint type is <b>OSS</b>, and the service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaOss.</para>
            /// </description></item>
            /// <item><description><para>If the endpoint type is <b>NLB</b>, and the service-linked role does not exist, the system automatically creates a service-linked role named AliyunServiceRoleForGaNlb.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178360.html">service-linked roles</a>.</para>
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
            /// <para>A list of vSwitches in the VPC.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// <para>You can specify at most one VPC ID for an endpoint group that is associated with an intelligent routing listener.</para>
            /// <remarks>
            /// <para>This parameter is required only when the endpoint type is <b>IpTarget</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zen6t0u7xhm0k5iz****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The weight of the endpoint.</para>
            /// <para>Valid values: <b>0</b> to <b>255</b>.</para>
            /// <remarks>
            /// <para>If you set the weight of an endpoint to 0, Global Accelerator stops distributing traffic to the endpoint. Proceed with caution.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The ID of the endpoint group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp1dmlohjjz4kqaun****</para>
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the endpoint group is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("EndpointGroupRegion")]
        [Validation(Required=false)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// <para>Specifies the IP protocol that GA uses to communicate with endpoints. Valid values: ● <b>IPv4</b> (default): Use IPv4. ● <b>IPv6</b>: Use IPv6. ● <b>ProtocolAffinity</b>: Use the same IP protocol as the client request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("EndpointIpVersion")]
        [Validation(Required=false)]
        public string EndpointIpVersion { get; set; }

        /// <summary>
        /// <para>The version of the backend service protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HTTP1.1</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTP2</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can configure this parameter only when <c>EndpointRequestProtocol</c> is set to HTTPS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP1.1</para>
        /// </summary>
        [NameInMap("EndpointProtocolVersion")]
        [Validation(Required=false)]
        public string EndpointProtocolVersion { get; set; }

        /// <summary>
        /// <para>The backend service protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HTTP</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can configure this parameter only for endpoint groups of HTTP or HTTPS listeners.</para>
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
        /// <para>Specifies whether to enable health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables health checks.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Disables health checks.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HealthCheckEnabled")]
        [Validation(Required=false)]
        public bool? HealthCheckEnabled { get; set; }

        /// <summary>
        /// <para>The domain name for the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.taobao.com">www.taobao.com</a></para>
        /// </summary>
        [NameInMap("HealthCheckHost")]
        [Validation(Required=false)]
        public string HealthCheckHost { get; set; }

        /// <summary>
        /// <para>The interval between health checks, in seconds. Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckIntervalSeconds")]
        [Validation(Required=false)]
        public int? HealthCheckIntervalSeconds { get; set; }

        /// <summary>
        /// <para>The path for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/healthcheck</para>
        /// </summary>
        [NameInMap("HealthCheckPath")]
        [Validation(Required=false)]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public int? HealthCheckPort { get; set; }

        /// <summary>
        /// <para>The protocol for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tcp</b> or <b>TCP</b></para>
        /// </description></item>
        /// <item><description><para><b>http</b> or <b>HTTP</b></para>
        /// </description></item>
        /// <item><description><para><b>https</b> or <b>HTTPS</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPS</para>
        /// </summary>
        [NameInMap("HealthCheckProtocol")]
        [Validation(Required=false)]
        public string HealthCheckProtocol { get; set; }

        /// <summary>
        /// <para>The name of the endpoint group.</para>
        /// <para>The name must be 1 to 128 characters long, start with a letter or a Chinese character, and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The port override settings.</para>
        /// </summary>
        [NameInMap("PortOverrides")]
        [Validation(Required=false)]
        public List<UpdateEndpointGroupRequestPortOverrides> PortOverrides { get; set; }
        public class UpdateEndpointGroupRequestPortOverrides : TeaModel {
            /// <summary>
            /// <para>The endpoint port in the port override settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("EndpointPort")]
            [Validation(Required=false)]
            public int? EndpointPort { get; set; }

            /// <summary>
            /// <para>The listener port in the port override settings.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>For TCP listeners, virtual endpoint groups do not support port overrides. If a listener is already associated with a virtual endpoint group, you cannot configure port overrides for the default endpoint group. If the default endpoint group has port overrides configured, you cannot add a virtual endpoint group.</para>
            /// </description></item>
            /// <item><description><para>After you configure port overrides, you can change the listener protocol only between HTTP and HTTPS.</para>
            /// </description></item>
            /// <item><description><para>The updated listener port range must include all listener ports in the configured port overrides. For example, if the listener port range is 80-82 and port overrides are configured to map the ports to endpoint ports 100-102, you cannot update the listener port range to 80-81.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

        }

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
        /// <para>The number of consecutive successful or failed health checks required to change an endpoint\&quot;s health status.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ThresholdCount")]
        [Validation(Required=false)]
        public int? ThresholdCount { get; set; }

        /// <summary>
        /// <para>The weight of the endpoint group when the listener is associated with multiple endpoint groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TrafficPercentage")]
        [Validation(Required=false)]
        public int? TrafficPercentage { get; set; }

    }

}
