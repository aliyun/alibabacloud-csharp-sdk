// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeEndpointGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The Global Accelerator instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The custom header fields to record in access logs.</para>
        /// </summary>
        [NameInMap("AccessLogRecordCustomizedHeaderList")]
        [Validation(Required=false)]
        public List<string> AccessLogRecordCustomizedHeaderList { get; set; }

        /// <summary>
        /// <para>Specifies whether to record custom header fields in access logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): No.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can set this parameter to <b>true</b> only when <b>EnableAccessLog</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

        /// <summary>
        /// <para>The status of the access log configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: The access log is configured.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: The access log is not configured.</para>
        /// </description></item>
        /// <item><description><para><b>binding</b>: The access log is being configured.</para>
        /// </description></item>
        /// <item><description><para><b>unbinding</b>: The access log configuration is being removed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AccessLogSwitch")]
        [Validation(Required=false)]
        public string AccessLogSwitch { get; set; }

        /// <summary>
        /// <para>The description of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether access logging is enabled.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Access logging is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Access logging is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAccessLog")]
        [Validation(Required=false)]
        public bool? EnableAccessLog { get; set; }

        /// <summary>
        /// <para>The endpoint configurations.</para>
        /// </summary>
        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyEndpointConfigurations> EndpointConfigurations { get; set; }
        public class DescribeEndpointGroupResponseBodyEndpointConfigurations : TeaModel {
            /// <summary>
            /// <para>The API keys for the endpoint configuration.</para>
            /// </summary>
            [NameInMap("ApiKeys")]
            [Validation(Required=false)]
            public List<string> ApiKeys { get; set; }

            /// <summary>
            /// <para>Indicates whether client IP preservation is enabled by using the automatic method.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableClientIPPreservation")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservation { get; set; }

            /// <summary>
            /// <para>Indicates whether client IP preservation is enabled using the Proxy Protocol.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableProxyProtocol { get; set; }

            /// <summary>
            /// <para>The IP address, domain name, or instance ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.XX.XX.21</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The port used for latency probing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ProbePort")]
            [Validation(Required=false)]
            public int? ProbePort { get; set; }

            /// <summary>
            /// <para>The protocol for latency probing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>tcp</b>: TCP</para>
            /// </description></item>
            /// <item><description><para><b>icmp</b>: ICMP</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("ProbeProtocol")]
            [Validation(Required=false)]
            public string ProbeProtocol { get; set; }

            /// <summary>
            /// <para>The provider of the endpoint configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BAILIAN</para>
            /// </summary>
            [NameInMap("Provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The private IP address of the elastic network interface.</para>
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
            /// <item><description><para><b>Domain</b>: A custom domain name.</para>
            /// </description></item>
            /// <item><description><para><b>Ip</b>: A custom IP address.</para>
            /// </description></item>
            /// <item><description><para><b>IpTarget</b>: A custom private IP address.</para>
            /// </description></item>
            /// <item><description><para><b>PublicIp</b>: An Alibaba Cloud public IP address.</para>
            /// </description></item>
            /// <item><description><para><b>ECS</b>: An ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>SLB</b>: An SLB instance.</para>
            /// </description></item>
            /// <item><description><para><b>ALB</b>: An ALB instance.</para>
            /// </description></item>
            /// <item><description><para><b>OSS</b>: An OSS instance.</para>
            /// </description></item>
            /// <item><description><para><b>ENI</b>: An elastic network interface.</para>
            /// </description></item>
            /// <item><description><para><b>NLB</b>: An NLB instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ip</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>A list of VSwitch IDs.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-hp30gtnxkfxj1l2xt****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The weight of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The endpoint group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp14sz7ftcwwjgrdm****</para>
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// <para>The list of active IP addresses of the endpoints in the endpoint group.</para>
        /// <remarks>
        /// <para>Notice: For an endpoint group configured for back-to-source from a private network, the console displays only the private back-to-source IP addresses and not the public IP addresses. If the network connection type for the backend service of the endpoint group changes (for example, from a private network to a public network, or to a mix of private and public networks), you must monitor the changes in the back-to-source IP addresses and update the access control list (ACL) of the backend service accordingly.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("EndpointGroupIpList")]
        [Validation(Required=false)]
        public List<string> EndpointGroupIpList { get; set; }

        /// <summary>
        /// <para>The region ID where the endpoint group is deployed.</para>
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
        /// <item><description><para><b>default</b>: A default endpoint group.</para>
        /// </description></item>
        /// <item><description><para><b>virtual</b>: A virtual endpoint group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("EndpointGroupType")]
        [Validation(Required=false)]
        public string EndpointGroupType { get; set; }

        /// <summary>
        /// <para>A list of endpoint IP addresses pending confirmation after a Global Accelerator instance upgrade.</para>
        /// </summary>
        [NameInMap("EndpointGroupUnconfirmedIpList")]
        [Validation(Required=false)]
        public List<string> EndpointGroupUnconfirmedIpList { get; set; }

        /// <summary>
        /// <para>The IP version used to connect to the backend service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IPv4</b> (default): Global Accelerator connects to the backend service using IPv4.</para>
        /// </description></item>
        /// <item><description><para><b>IPv6</b>: Global Accelerator connects to the backend service using IPv6.</para>
        /// </description></item>
        /// <item><description><para><b>ProtocolAffinity</b>: Global Accelerator connects to the backend service using the same IP version as the client request.</para>
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
        /// <para>The private IP addresses of the endpoints.</para>
        /// </summary>
        [NameInMap("EndpointPrivateIpList")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyEndpointPrivateIpList> EndpointPrivateIpList { get; set; }
        public class DescribeEndpointGroupResponseBodyEndpointPrivateIpList : TeaModel {
            [NameInMap("CIDR")]
            [Validation(Required=false)]
            public string CIDR { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.49.***</para>
            /// </summary>
            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <para>The VSwitch ID in the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gsw-bp1rsfd2frym**</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>The version of the backend service protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HTTP1.1</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTP2</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP2</para>
        /// </summary>
        [NameInMap("EndpointProtocolVersion")]
        [Validation(Required=false)]
        public string EndpointProtocolVersion { get; set; }

        /// <summary>
        /// <para>The protocol used by the backend service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HTTP</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("EndpointRequestProtocol")]
        [Validation(Required=false)]
        public string EndpointRequestProtocol { get; set; }

        /// <summary>
        /// <para>The IDs of the associated forwarding rules.</para>
        /// </summary>
        [NameInMap("ForwardingRuleIds")]
        [Validation(Required=false)]
        public List<string> ForwardingRuleIds { get; set; }

        /// <summary>
        /// <para>Indicates whether health checks are enabled.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Health checks are enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Health checks are disabled.</para>
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
        /// <para>The path for health check probes.</para>
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
        /// <para>The protocol used for health checks.</para>
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
        /// <para>The listener ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The port mapping configuration.</para>
        /// </summary>
        [NameInMap("PortOverrides")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyPortOverrides> PortOverrides { get; set; }
        public class DescribeEndpointGroupResponseBodyPortOverrides : TeaModel {
            /// <summary>
            /// <para>The endpoint port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("EndpointPort")]
            [Validation(Required=false)]
            public int? EndpointPort { get; set; }

            /// <summary>
            /// <para>The listener port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FEA0CF3-D3B9-43E5-A304-D217037876A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the service that manages the instance.</para>
        /// <remarks>
        /// <para>This parameter is returned only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ALB</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is a managed instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The instance is a managed instance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The instance is not a managed instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>A list of management states for actions that can be performed on the instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is returned only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
        /// </description></item>
        /// <item><description><para>When an instance is managed, some operations may be restricted.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeEndpointGroupResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// <para>The name of the action on the managed instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Create</b>: Create an instance.</para>
            /// </description></item>
            /// <item><description><para><b>Update</b>: Update the instance.</para>
            /// </description></item>
            /// <item><description><para><b>Delete</b>: Delete the instance.</para>
            /// </description></item>
            /// <item><description><para><b>Associate</b>: Associate the instance.</para>
            /// </description></item>
            /// <item><description><para><b>UserUnmanaged</b>: Releases the instance from service management.</para>
            /// </description></item>
            /// <item><description><para><b>CreateChild</b>: Create a child resource.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Update</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The type of the child resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Listener</b>: A listener.</para>
            /// </description></item>
            /// <item><description><para><b>IpSet</b>: An acceleration region.</para>
            /// </description></item>
            /// <item><description><para><b>EndpointGroup</b>: An endpoint group.</para>
            /// </description></item>
            /// <item><description><para><b>ForwardingRule</b>: A forwarding rule.</para>
            /// </description></item>
            /// <item><description><para><b>Endpoint</b>: An endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>EndpointGroupDestination</b>: A protocol mapping for an endpoint group of a custom routing listener.</para>
            /// </description></item>
            /// <item><description><para><b>EndpointPolicy</b>: A traffic policy for an endpoint of a custom routing listener.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is valid only when <b>Action</b> is set to <b>CreateChild</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Listener</para>
            /// </summary>
            [NameInMap("ChildType")]
            [Validation(Required=false)]
            public string ChildType { get; set; }

            /// <summary>
            /// <para>Indicates whether the action is managed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The action is managed. You cannot perform this action on the instance.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The action is not managed. You can perform this action on the instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsManaged")]
            [Validation(Required=false)]
            public bool? IsManaged { get; set; }

        }

        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-01</para>
        /// </summary>
        [NameInMap("SlsLogStoreName")]
        [Validation(Required=false)]
        public string SlsLogStoreName { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pn-01</para>
        /// </summary>
        [NameInMap("SlsProjectName")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

        /// <summary>
        /// <para>The region of the Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SlsRegion")]
        [Validation(Required=false)]
        public string SlsRegion { get; set; }

        /// <summary>
        /// <para>The status of the endpoint group.</para>
        /// <list type="bullet">
        /// <item><description><para><b>init</b>: The endpoint group is being initialized.</para>
        /// </description></item>
        /// <item><description><para><b>active</b>: The endpoint group is active.</para>
        /// </description></item>
        /// <item><description><para><b>updating</b>: The endpoint group is being updated.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: The endpoint group is being deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>A list of tags attached to the endpoint group.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeEndpointGroupResponseBodyTags> Tags { get; set; }
        public class DescribeEndpointGroupResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of consecutive failed health checks before an endpoint is marked as unhealthy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ThresholdCount")]
        [Validation(Required=false)]
        public int? ThresholdCount { get; set; }

        /// <summary>
        /// <para>The percentage of traffic that is distributed to the endpoint group. This parameter is returned only when a listener is associated with multiple endpoint groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TrafficPercentage")]
        [Validation(Required=false)]
        public int? TrafficPercentage { get; set; }

    }

}
