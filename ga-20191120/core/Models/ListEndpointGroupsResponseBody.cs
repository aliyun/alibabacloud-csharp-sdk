// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListEndpointGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the endpoint groups.</para>
        /// </summary>
        [NameInMap("EndpointGroups")]
        [Validation(Required=false)]
        public List<ListEndpointGroupsResponseBodyEndpointGroups> EndpointGroups { get; set; }
        public class ListEndpointGroupsResponseBodyEndpointGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the GA instance.</para>
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
            /// <para>The configurations of the endpoints in the endpoint group.</para>
            /// </summary>
            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsEndpointConfigurations : TeaModel {
                /// <summary>
                /// <para>Indicates whether the client IP address preservation feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableClientIPPreservation")]
                [Validation(Required=false)]
                public bool? EnableClientIPPreservation { get; set; }

                /// <summary>
                /// <para>Indicates whether the proxy protocol is used to preserve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// </summary>
                [NameInMap("EnableProxyProtocol")]
                [Validation(Required=false)]
                public bool? EnableProxyProtocol { get; set; }

                /// <summary>
                /// <para>The IP address or domain name of the endpoint.</para>
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
                /// <para>The port that is used to monitor latency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ProbePort")]
                [Validation(Required=false)]
                public int? ProbePort { get; set; }

                /// <summary>
                /// <para>The protocol that is used to monitor latency.</para>
                /// <list type="bullet">
                /// <item><description><b>icmp</b></description></item>
                /// <item><description><b>tcp</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("ProbeProtocol")]
                [Validation(Required=false)]
                public string ProbeProtocol { get; set; }

                /// <summary>
                /// <para>The private IP address of the ENI.</para>
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
                /// <item><description><b>Domain</b>: a custom domain name.</description></item>
                /// <item><description><b>Ip</b>: a custom IP address.</description></item>
                /// <item><description><b>IpTarget</b>: a custom private IP address.</description></item>
                /// <item><description><b>PublicIp</b>: a public IP address provided by Alibaba Cloud.</description></item>
                /// <item><description><b>ECS</b>: an Elastic Compute Service (ECS) instance.</description></item>
                /// <item><description><b>SLB</b>: a Server Load Balancer (SLB) instance.</description></item>
                /// <item><description><b>ALB</b>: an Application Load Balancer (ALB) instance.</description></item>
                /// <item><description><b>OSS</b>: an Object Storage Service (OSS) bucket.</description></item>
                /// <item><description><b>ENI</b>: an elastic network interface (ENI).</description></item>
                /// <item><description><b>NLB</b>: a Network Load Balancer (NLB) instance.</description></item>
                /// </list>
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
                /// <para>The VPC ID.</para>
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
            /// <para>The endpoint group IP addresses.</para>
            /// </summary>
            [NameInMap("EndpointGroupIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupIpList { get; set; }

            /// <summary>
            /// <para>The ID of the region where the endpoint group is created.</para>
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
            /// <item><description><b>default</b>: a default endpoint group</description></item>
            /// <item><description><b>virtual:</b> a virtual endpoint group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            /// <summary>
            /// <para>The endpoint group IP addresses to be confirmed after the GA instance is upgraded.</para>
            /// </summary>
            [NameInMap("EndpointGroupUnconfirmedIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupUnconfirmedIpList { get; set; }

            [NameInMap("EndpointIpVersion")]
            [Validation(Required=false)]
            public string EndpointIpVersion { get; set; }

            [NameInMap("EndpointPrivateIpList")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsEndpointPrivateIpList> EndpointPrivateIpList { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsEndpointPrivateIpList : TeaModel {
                [NameInMap("CIDR")]
                [Validation(Required=false)]
                public string CIDR { get; set; }

                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The protocol version that is used by the backend service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP1.1</b></description></item>
            /// <item><description><b>HTTP2</b></description></item>
            /// </list>
            /// </summary>
            [NameInMap("EndpointProtocolVersion")]
            [Validation(Required=false)]
            public string EndpointProtocolVersion { get; set; }

            /// <summary>
            /// <para>The protocol that is used by the backend server.</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP</b></description></item>
            /// <item><description><b>HTTPS</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            /// <summary>
            /// <para>The IDs of the forwarding rules that are associated with the endpoint group.</para>
            /// </summary>
            [NameInMap("ForwardingRuleIds")]
            [Validation(Required=false)]
            public List<string> ForwardingRuleIds { get; set; }

            /// <summary>
            /// <para>Indicates whether the health check feature is enabled.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <para>The interval at which you want to perform health checks. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public int? HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// <para>The path that is used for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthcheck</para>
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// <para>The port that is used for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public int? HealthCheckPort { get; set; }

            /// <summary>
            /// <para>The protocol over which health check requests are sent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b> or <b>TCP</b></description></item>
            /// <item><description><b>http</b> or <b>HTTP</b></description></item>
            /// <item><description><b>https</b> or <b>HTTPS</b></description></item>
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
            /// <para>The port mapping.</para>
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
            /// <para>The service that manages the instance.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if the value of <b>Service managed</b> is <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the GA instance is managed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The actions that users can perform on the managed instance.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only if the value of <b>ServiceManaged</b> is <b>true</b>.</description></item>
            /// <item><description>Users can perform only specific actions on a managed instance.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos : TeaModel {
                /// <summary>
                /// <para>The name of the action that was performed on the managed instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Create:</b> Create an instance.</description></item>
                /// <item><description><b>Update:</b> Update the current instance.</description></item>
                /// <item><description><b>Delete:</b> Delete the current instance.</description></item>
                /// <item><description><b>Associate:</b> Reference the current instance.</description></item>
                /// <item><description><b>UserUnmanaged:</b> Unmanage the instance.</description></item>
                /// <item><description><b>CreateChild:</b> Create a child resource in the current instance.</description></item>
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
                /// <item><description><b>Listener:</b> listener.</description></item>
                /// <item><description><b>IpSet:</b> acceleration region.</description></item>
                /// <item><description><b>EndpointGroup:</b> endpoint group.</description></item>
                /// <item><description><b>ForwardingRule:</b> forwarding rule.</description></item>
                /// <item><description><b>Endpoint:</b> endpoint.</description></item>
                /// <item><description><b>EndpointGroupDestination:</b> the protocol mapping of an endpoint group associated with a custom routing listener.</description></item>
                /// <item><description><b>EndpointPolicy:</b> the traffic policy of an endpoint associated with a custom routing listener.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter takes effect only if you set <b>Action</b> to <b>CreateChild</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Listener</para>
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// <para>Indicates whether the specified actions are managed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The specified actions are managed, and users cannot perform the specified actions on the managed instance.</description></item>
                /// <item><description><b>false</b>: The specified actions are not managed, and users can perform the specified actions on the managed instance.</description></item>
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
            /// <para>The status of the endpoint group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>init:</b> The endpoint group is being initialized.</description></item>
            /// <item><description><b>active:</b> The endpoint group is running normally.</description></item>
            /// <item><description>**updating:**The endpoint group is being updated.</description></item>
            /// <item><description><b>deleteing:</b> The endpoint group is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The tag of the endpoint group.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsTags> Tags { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the endpoint group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the endpoint group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of consecutive failed health checks that must occur before an endpoint is considered unhealthy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public int? ThresholdCount { get; set; }

            /// <summary>
            /// <para>The value of the traffic distribution ratio. If a listener is associated with multiple endpoint groups, you can set this parameter to distribute different percentages of traffic to the endpoint groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public int? TrafficPercentage { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
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
        /// <para>The ID of the request.</para>
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
