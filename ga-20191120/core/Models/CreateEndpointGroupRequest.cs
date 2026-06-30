// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateEndpointGroupRequest : TeaModel {
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
        /// <para>The client token used to ensure request idempotence.</para>
        /// <para>You can generate this token, but you must ensure it is unique for each request. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. Each request has a unique <b>RequestId</b>.</para>
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
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run. The system checks the required parameters, request format, and service limits. If the request fails the dry run, the system returns an error message. If the request passes the dry run, the system returns an HTTP 2xx status code.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the check, the system returns an HTTP 2xx status code and creates the endpoint group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The endpoint configurations.</para>
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<CreateEndpointGroupRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class CreateEndpointGroupRequestEndpointConfigurations : TeaModel {
            /// <summary>
            /// <para>The API keys for the AI service.</para>
            /// </summary>
            [NameInMap("ApiKeys")]
            [Validation(Required=false)]
            public List<string> ApiKeys { get; set; }

            /// <summary>
            /// <para>Specifies whether to preserve client source IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: preserves client source IP addresses.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): does not preserve client source IP addresses.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>By default, this feature is disabled for endpoint groups that are associated with TCP or UDP listeners. You can enable this feature based on your business requirements.</para>
            /// </description></item>
            /// <item><description><para>By default, this feature is enabled for endpoint groups that are associated with HTTP or HTTPS listeners. The source IP address is retrieved from the X-Forwarded-For header field. This feature cannot be disabled.</para>
            /// </description></item>
            /// <item><description><para><c>EnableClientIPPreservation</c> and <c>EnableProxyProtocol</c> cannot both be set to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">Preserve client source IP addresses</a>.</para>
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
            /// <para>Specifies whether to use the PROXY protocol to preserve client source IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: uses the PROXY protocol.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): does not use the PROXY protocol.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter can be configured only for endpoint groups that are associated with TCP listeners.</para>
            /// </description></item>
            /// <item><description><para><c>EnableClientIPPreservation</c> and <c>EnableProxyProtocol</c> cannot both be set to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para>For more information, see <a href="https://help.aliyun.com/document_detail/158080.html">Preserve client source IP addresses</a>.</para>
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
            /// <para>The IP address, domain name, or resource ID of the endpoint. The value of this parameter depends on the value of the <c>Type</c> parameter.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.1.XX.XX</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The AI service provider. Set this to <c>BAILIAN</c> to use Alibaba Cloud Model Studio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BAILIAN</para>
            /// </summary>
            [NameInMap("Provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The private IP address of the ENI.</para>
            /// <remarks>
            /// <para>This parameter applies only when the endpoint type is set to <b>ENI</b>. If you omit this parameter, the primary private IP address of the ENI is used.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.168.X.X</para>
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
            /// <item><description><para><b>IpTarget</b>: a custom private IP address.</para>
            /// </description></item>
            /// <item><description><para><b>PublicIp</b>: an Alibaba Cloud public IP address.</para>
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
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>If you set the endpoint type to <b>ECS</b>, <b>ENI</b>, <b>SLB</b>, <b>ALB</b>, <b>NLB</b>, or <b>IpTarget</b>, the system automatically creates a service-linked role named AliyunServiceRoleForGaVpcEndpoint if the role does not exist.</para>
            /// </description></item>
            /// <item><description><para>If you set the endpoint type to <b>ALB</b>, the system automatically creates a service-linked role named AliyunServiceRoleForGaAlb if the role does not exist.</para>
            /// </description></item>
            /// <item><description><para>If you set the endpoint type to <b>OSS</b>, the system automatically creates a service-linked role named AliyunServiceRoleForGaOss if the role does not exist.</para>
            /// </description></item>
            /// <item><description><para>If you set the endpoint type to <b>NLB</b>, the system automatically creates a service-linked role named AliyunServiceRoleForGaNlb if the role does not exist.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178360.html">Service-linked roles</a>.</para>
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
            /// <para>The ID of the Virtual Private Cloud (VPC).</para>
            /// <para>You can specify at most one VPC ID for an endpoint group of an intelligent routing listener.</para>
            /// <remarks>
            /// <para>This parameter is required only when the endpoint type is set to <b>IpTarget</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1quce3451z5b2hv****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The weight of the endpoint.</para>
            /// <para>Valid values: <b>0</b> to <b>255</b>.</para>
            /// <remarks>
            /// <para>If you set the weight of an endpoint to 0, GA stops distributing traffic to it. Proceed with caution.</para>
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
        /// <para>The type of the endpoint group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>default</b> (default): a default endpoint group.</para>
        /// </description></item>
        /// <item><description><para><b>virtual</b>: a virtual endpoint group.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Before you create a virtual endpoint group for a Layer 4 listener, make sure that you have created a default endpoint group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("EndpointGroupType")]
        [Validation(Required=false)]
        public string EndpointGroupType { get; set; }

        /// <summary>
        /// <para>The IP version used to communicate with the backend service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IPv4</b> (default): GA uses only IPv4 to communicate with the backend service.</para>
        /// </description></item>
        /// <item><description><para><b>IPv6</b>: GA uses only IPv6 to communicate with the backend service.</para>
        /// </description></item>
        /// <item><description><para><b>ProtocolAffinity</b>: GA uses the same IP version as the client request to communicate with the backend service.</para>
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
        /// <para>The version of the backend service protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HTTP1.1</b> (default): HTTP/1.1.</para>
        /// </description></item>
        /// <item><description><para><b>HTTP2</b>: HTTP/2.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when <c>EndpointRequestProtocol</c> is set to HTTPS.</para>
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
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available only for endpoint groups of <b>HTTP</b> or <b>HTTPS</b> listeners.</para>
        /// </description></item>
        /// <item><description><para>For an <b>HTTP</b> listener, the backend service protocol must be <b>HTTP</b>.</para>
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
        /// <item><description><para><b>true</b>: enables health checks.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables health checks.</para>
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
        /// <para>The domain name used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.taobao.com">www.taobao.com</a></para>
        /// </summary>
        [NameInMap("HealthCheckHost")]
        [Validation(Required=false)]
        public string HealthCheckHost { get; set; }

        /// <summary>
        /// <para>The health check interval, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckIntervalSeconds")]
        [Validation(Required=false)]
        public int? HealthCheckIntervalSeconds { get; set; }

        /// <summary>
        /// <para>The path used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/healthcheck</para>
        /// </summary>
        [NameInMap("HealthCheckPath")]
        [Validation(Required=false)]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// <para>The port used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public int? HealthCheckPort { get; set; }

        /// <summary>
        /// <para>The protocol used for health checks. Valid values:</para>
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
        /// <para>The listener-to-endpoint port mappings.</para>
        /// </summary>
        [NameInMap("PortOverrides")]
        [Validation(Required=false)]
        public List<CreateEndpointGroupRequestPortOverrides> PortOverrides { get; set; }
        public class CreateEndpointGroupRequestPortOverrides : TeaModel {
            /// <summary>
            /// <para>The endpoint port for the port mapping.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("EndpointPort")]
            [Validation(Required=false)]
            public int? EndpointPort { get; set; }

            /// <summary>
            /// <para>The listener port for the port mapping.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>For TCP listeners, you cannot configure port mappings for virtual endpoint groups. If a listener is associated with a virtual endpoint group, you cannot configure port mappings for the default endpoint group. If a default endpoint group has port mappings configured, you cannot add a virtual endpoint group.</para>
            /// </description></item>
            /// <item><description><para>After you configure port mappings, you cannot change the listener protocol, except for switching between HTTP and HTTPS.</para>
            /// </description></item>
            /// <item><description><para>When you modify the listener port range, the new range must include all listener ports used in port mappings. For example, if the listener port range is 80-82 and the listener ports are mapped to endpoint ports 100-102, you cannot change the listener port range to 80-81.</para>
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
        /// <para>The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The tags of the endpoint group.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEndpointGroupRequestTag> Tag { get; set; }
        public class CreateEndpointGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters long and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters long and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of consecutive health checks that must succeed or fail before an endpoint\&quot;s status changes between healthy and unhealthy. Valid values: <b>2</b> to <b>10</b>. Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ThresholdCount")]
        [Validation(Required=false)]
        public int? ThresholdCount { get; set; }

        /// <summary>
        /// <para>The percentage of traffic distributed to the endpoint group when the listener is associated with multiple endpoint groups. Valid values: <b>1</b> to <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TrafficPercentage")]
        [Validation(Required=false)]
        public int? TrafficPercentage { get; set; }

    }

}
