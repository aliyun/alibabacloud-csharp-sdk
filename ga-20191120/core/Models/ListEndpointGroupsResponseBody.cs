// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListEndpointGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of endpoint groups.</para>
        /// </summary>
        [NameInMap("EndpointGroups")]
        [Validation(Required=false)]
        public List<ListEndpointGroupsResponseBodyEndpointGroups> EndpointGroups { get; set; }
        public class ListEndpointGroupsResponseBodyEndpointGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the Global Accelerator instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

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
            /// <para>A list of endpoint configurations.</para>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsEndpointConfigurations : TeaModel {
                /// <summary>
                /// <para>The API keys in the endpoint configuration.</para>
                /// </summary>
                [NameInMap("ApiKeys")]
                [Validation(Required=false)]
                public List<string> ApiKeys { get; set; }

                /// <summary>
                /// <para>Specifies whether to preserve client IP addresses.</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Client IP preservation is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Client IP preservation is disabled.</para>
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
                /// <para>Specifies whether to use Proxy Protocol to preserve client IP addresses.</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Proxy Protocol is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Proxy Protocol is disabled.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("EnableProxyProtocol")]
                [Validation(Required=false)]
                public bool? EnableProxyProtocol { get; set; }

                /// <summary>
                /// <para>The endpoint\&quot;s IP address, domain name, or instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.1.XX.XX</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The ID of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-bp1d2utp8qqe2a44t****</para>
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <para>The port used for latency monitoring probes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ProbePort")]
                [Validation(Required=false)]
                public int? ProbePort { get; set; }

                /// <summary>
                /// <para>The protocol that is used for latency monitoring probes.</para>
                /// <list type="bullet">
                /// <item><description><para><b>icmp</b>: ICMP</para>
                /// </description></item>
                /// <item><description><para><b>tcp</b>: TCP</para>
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
                /// <para>The service provider.</para>
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
                /// <item><description><para><b>ECS</b>: an Alibaba Cloud ECS instance.</para>
                /// </description></item>
                /// <item><description><para><b>SLB</b>: an Alibaba Cloud SLB instance.</para>
                /// </description></item>
                /// <item><description><para><b>ALB</b>: an Alibaba Cloud ALB instance.</para>
                /// </description></item>
                /// <item><description><para><b>OSS</b>: an Alibaba Cloud OSS bucket.</para>
                /// </description></item>
                /// <item><description><para><b>ENI</b>: an Alibaba Cloud elastic network interface.</para>
                /// </description></item>
                /// <item><description><para><b>NLB</b>: an Alibaba Cloud NLB instance.</para>
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
                /// <para>A list of vSwitches in the VPC.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbhucmd5b2q2fpqqu****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The weight of the endpoint.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>epg-bp16jdc00bhe97sr5****</para>
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// <para>A list of public egress IP addresses of the endpoint group.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>For endpoint groups connected to private backend services, the console shows only the private source IP addresses, not the public ones. If the network connection type of a backend service changes (for example, from private to public), monitor the source IP addresses and update the backend service\&quot;s access control list (ACL).</para>
            /// </summary>
            [NameInMap("EndpointGroupIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupIpList { get; set; }

            /// <summary>
            /// <para>The ID of the region where the endpoint group is deployed.</para>
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
            /// <item><description><para><b>default</b>: a default endpoint group.</para>
            /// </description></item>
            /// <item><description><para><b>virtual</b>: a virtual endpoint group.</para>
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
            /// <para>The list of new IP addresses in the endpoint group that require confirmation after a Global Accelerator instance is upgraded.</para>
            /// </summary>
            [NameInMap("EndpointGroupUnconfirmedIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupUnconfirmedIpList { get; set; }

            /// <summary>
            /// <para>The IP protocol of the backend service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>IPv4</b> (default): Connections to the backend service use IPv4.</para>
            /// </description></item>
            /// <item><description><para><b>IPv6</b>: Connections to the backend service use IPv6.</para>
            /// </description></item>
            /// <item><description><para><b>ProtocolAffinity</b>: The connection to the backend service uses the same IP protocol as the client request.</para>
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
            /// <para>A list of private IP addresses of the endpoints.</para>
            /// </summary>
            [NameInMap("EndpointPrivateIpList")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsEndpointPrivateIpList> EndpointPrivateIpList { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsEndpointPrivateIpList : TeaModel {
                [NameInMap("CIDR")]
                [Validation(Required=false)]
                public string CIDR { get; set; }

                /// <summary>
                /// <para>The private IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.19.115.37</para>
                /// </summary>
                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gsw-0jl6tmriqep1ga***</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The version of the backend service protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP1.1</b>: HTTP/1.1</para>
            /// </description></item>
            /// <item><description><para><b>HTTP2</b>: HTTP/2</para>
            /// </description></item>
            /// </list>
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
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// <para>The IDs of forwarding rules associated with the endpoint group.</para>
            /// </summary>
            [NameInMap("ForwardingRuleIds")]
            [Validation(Required=false)]
            public List<string> ForwardingRuleIds { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable health checks.</para>
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
            /// <para>The health check path.</para>
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
            /// <para>10</para>
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
            /// <para>The ID of the listener.</para>
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
            /// <para>The port mappings.</para>
            /// </summary>
            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsPortOverrides> PortOverrides { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsPortOverrides : TeaModel {
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
            /// <para>The ID of the service that manages the instance.</para>
            /// <remarks>
            /// <para>This parameter is returned only if <b>ServiceManaged</b> is <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Specifies whether the instance is managed. Valid values:</para>
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
            /// <para>The actions that you can perform on the managed instance.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is returned only if <b>ServiceManaged</b> is <b>true</b>.</para>
            /// </description></item>
            /// <item><description><para>Your permissions to operate on a managed instance are restricted.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos : TeaModel {
                /// <summary>
                /// <para>The name of the action on the managed instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Create</b>: creates an instance.</para>
                /// </description></item>
                /// <item><description><para><b>Update</b>: updates the instance.</para>
                /// </description></item>
                /// <item><description><para><b>Delete</b>: deletes the instance.</para>
                /// </description></item>
                /// <item><description><para><b>Associate</b>: associates the instance with other resources.</para>
                /// </description></item>
                /// <item><description><para><b>UserUnmanaged</b>: Reverts the instance to an unmanaged state.</para>
                /// </description></item>
                /// <item><description><para><b>CreateChild</b>: creates a child resource for the instance.</para>
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
                /// <item><description><para><b>Listener</b>: a listener.</para>
                /// </description></item>
                /// <item><description><para><b>IpSet</b>: an acceleration region.</para>
                /// </description></item>
                /// <item><description><para><b>EndpointGroup</b>: an endpoint group.</para>
                /// </description></item>
                /// <item><description><para><b>ForwardingRule</b>: a forwarding rule.</para>
                /// </description></item>
                /// <item><description><para><b>Endpoint</b>: an endpoint.</para>
                /// </description></item>
                /// <item><description><para><b>EndpointGroupDestination</b>: a protocol mapping for an endpoint group of a custom routing listener.</para>
                /// </description></item>
                /// <item><description><para><b>EndpointPolicy</b>: a traffic policy for an endpoint of a custom routing listener.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is returned only if <b>Action</b> is set to <b>CreateChild</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Listener</para>
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// <para>Specifies whether the action is managed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The action is managed. You cannot perform the specified action on the managed instance.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The action is not managed. You can perform the specified action on the managed instance.</para>
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
            /// <para>The state of the endpoint group.</para>
            /// <list type="bullet">
            /// <item><description><para><b>init</b>: The endpoint group is initializing.</para>
            /// </description></item>
            /// <item><description><para><b>active</b>: The endpoint group is stable.</para>
            /// </description></item>
            /// <item><description><para><b>updating</b>: The endpoint group is updating.</para>
            /// </description></item>
            /// <item><description><para><b>deleting</b>: The endpoint group is deleting.</para>
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
            /// <para>The tags attached to the endpoint group.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsTags> Tags { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsTags : TeaModel {
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
            /// <para>The number of consecutive failed health checks required to mark an endpoint as unhealthy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public int? ThresholdCount { get; set; }

            /// <summary>
            /// <para>The percentage of traffic routed to the endpoint group. This parameter applies only if a listener is associated with multiple endpoint groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public int? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A052D49E-CCC2-41DB-816C-DC3381503194</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
