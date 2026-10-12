// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListGatewayLoadBalancersResponseBodyData Data { get; set; }
        public class ListGatewayLoadBalancersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The instances.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewayLoadBalancersResponseBodyDataItems> Items { get; set; }
            public class ListGatewayLoadBalancersResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Indicates whether this is the default ingress of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("defaultGatewayIngress")]
                [Validation(Required=false)]
                public bool? DefaultGatewayIngress { get; set; }

                /// <summary>
                /// <para>Indicates whether the load balancer can be edited. This parameter serves as an edit switch for load balancers that are being migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("editEnable")]
                [Validation(Required=false)]
                public bool? EditEnable { get; set; }

                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The load balancer address (IP address or domain name).</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.x.x.x</para>
                /// </summary>
                [NameInMap("loadBalancerAddress")]
                [Validation(Required=false)]
                public string LoadBalancerAddress { get; set; }

                /// <summary>
                /// <para>The IP version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("loadBalancerAddressIpVersion")]
                [Validation(Required=false)]
                public string LoadBalancerAddressIpVersion { get; set; }

                /// <summary>
                /// <para>The address type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("loadBalancerAddressType")]
                [Validation(Required=false)]
                public string LoadBalancerAddressType { get; set; }

                /// <summary>
                /// <para>The load balancer availability status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("loadBalancerAvailableStatus")]
                [Validation(Required=false)]
                public string LoadBalancerAvailableStatus { get; set; }

                /// <summary>
                /// <para>The load balancer instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-bp1xxxx / nlb-xxxx</para>
                /// </summary>
                [NameInMap("loadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The binding mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Managed</para>
                /// </summary>
                [NameInMap("loadBalancerMode")]
                [Validation(Required=false)]
                public string LoadBalancerMode { get; set; }

                /// <summary>
                /// <para>The load balancer name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-nlb</para>
                /// </summary>
                [NameInMap("loadBalancerName")]
                [Validation(Required=false)]
                public string LoadBalancerName { get; set; }

                /// <summary>
                /// <para>The load balancer specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>slb.s2.small</para>
                /// </summary>
                [NameInMap("loadBalancerSpec")]
                [Validation(Required=false)]
                public string LoadBalancerSpec { get; set; }

                /// <summary>
                /// <para>The association status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("loadBalancerStatus")]
                [Validation(Required=false)]
                public string LoadBalancerStatus { get; set; }

                /// <summary>
                /// <para>The load balancer type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NLB</para>
                /// </summary>
                [NameInMap("loadBalancerType")]
                [Validation(Required=false)]
                public string LoadBalancerType { get; set; }

                /// <summary>
                /// <para>The zone mappings.</para>
                /// </summary>
                [NameInMap("loadBalancerZoneMappings")]
                [Validation(Required=false)]
                public List<ListGatewayLoadBalancersResponseBodyDataItemsLoadBalancerZoneMappings> LoadBalancerZoneMappings { get; set; }
                public class ListGatewayLoadBalancersResponseBodyDataItemsLoadBalancerZoneMappings : TeaModel {
                    /// <summary>
                    /// <para>The list of load balancer addresses in the zone.</para>
                    /// </summary>
                    [NameInMap("loadBalancerAddresses")]
                    [Validation(Required=false)]
                    public List<ListGatewayLoadBalancersResponseBodyDataItemsLoadBalancerZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
                    public class ListGatewayLoadBalancersResponseBodyDataItemsLoadBalancerZoneMappingsLoadBalancerAddresses : TeaModel {
                        /// <summary>
                        /// <para>The Elastic IP Address (EIP) allocation ID that corresponds to the public address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eip-bp1xxxx</para>
                        /// </summary>
                        [NameInMap("allocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        /// <summary>
                        /// <para>The ID of the elastic network interface (ENI).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eni-bp1xxxx</para>
                        /// </summary>
                        [NameInMap("eniId")]
                        [Validation(Required=false)]
                        public string EniId { get; set; }

                        /// <summary>
                        /// <para>The list of private IPv4 addresses.</para>
                        /// </summary>
                        [NameInMap("ipv4LocalAddresses")]
                        [Validation(Required=false)]
                        public List<string> Ipv4LocalAddresses { get; set; }

                        /// <summary>
                        /// <para>The public IPv6 address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2408:xxxx</para>
                        /// </summary>
                        [NameInMap("ipv6Address")]
                        [Validation(Required=false)]
                        public string Ipv6Address { get; set; }

                        /// <summary>
                        /// <para>The list of private IPv6 addresses.</para>
                        /// </summary>
                        [NameInMap("ipv6LocalAddresses")]
                        [Validation(Required=false)]
                        public List<string> Ipv6LocalAddresses { get; set; }

                        /// <summary>
                        /// <para>The private IPv4 address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.x.x</para>
                        /// </summary>
                        [NameInMap("privateIPv4Address")]
                        [Validation(Required=false)]
                        public string PrivateIPv4Address { get; set; }

                        /// <summary>
                        /// <para>The health check status of the private IPv4 address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Healthy</para>
                        /// </summary>
                        [NameInMap("privateIPv4HcStatus")]
                        [Validation(Required=false)]
                        public string PrivateIPv4HcStatus { get; set; }

                        /// <summary>
                        /// <para>The health check status of the private IPv6 address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Healthy</para>
                        /// </summary>
                        [NameInMap("privateIPv6HcStatus")]
                        [Validation(Required=false)]
                        public string PrivateIPv6HcStatus { get; set; }

                        /// <summary>
                        /// <para>The public IPv4 address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>47.x.x.x</para>
                        /// </summary>
                        [NameInMap("publicIPv4Address")]
                        [Validation(Required=false)]
                        public string PublicIPv4Address { get; set; }

                    }

                    /// <summary>
                    /// <para>The zone status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Active</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID that corresponds to the zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1xxxx</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The zone ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-a</para>
                    /// </summary>
                    [NameInMap("zoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

                /// <summary>
                /// <para>The list of listener ports.</para>
                /// </summary>
                [NameInMap("ports")]
                [Validation(Required=false)]
                public List<ListGatewayLoadBalancersResponseBodyDataItemsPorts> Ports { get; set; }
                public class ListGatewayLoadBalancersResponseBodyDataItemsPorts : TeaModel {
                    /// <summary>
                    /// <para>The port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>443</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The port protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>https</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// <para>The gateway service weight, which ranges from 0 to 100. This parameter is used in migration and traffic shifting scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("serviceWeight")]
                [Validation(Required=false)]
                public long? ServiceWeight { get; set; }

                /// <summary>
                /// <para>The VServerGroup metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("vServerGroupMetaInfo")]
                [Validation(Required=false)]
                public string VServerGroupMetaInfo { get; set; }

                /// <summary>
                /// <para>The list of virtual server groups.</para>
                /// </summary>
                [NameInMap("virtualServerGroupList")]
                [Validation(Required=false)]
                public List<ListGatewayLoadBalancersResponseBodyDataItemsVirtualServerGroupList> VirtualServerGroupList { get; set; }
                public class ListGatewayLoadBalancersResponseBodyDataItemsVirtualServerGroupList : TeaModel {
                    /// <summary>
                    /// <para>The list of associated listeners.</para>
                    /// </summary>
                    [NameInMap("listeners")]
                    [Validation(Required=false)]
                    public List<ListGatewayLoadBalancersResponseBodyDataItemsVirtualServerGroupListListeners> Listeners { get; set; }
                    public class ListGatewayLoadBalancersResponseBodyDataItemsVirtualServerGroupListListeners : TeaModel {
                        /// <summary>
                        /// <para>The listener port.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>443</para>
                        /// </summary>
                        [NameInMap("port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>The listener protocol. No backend enumeration validation is performed. The actual values are returned from SLB or NLB OpenAPI. Common values include tcp, udp, http, https, and tls.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>https</para>
                        /// </summary>
                        [NameInMap("protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                    /// <summary>
                    /// <para>The virtual server group ID. For CLB, this is the VServerGroupId. For NLB, this is the ServerGroupId.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rsp-xxxx</para>
                    /// </summary>
                    [NameInMap("virtualServiceGroupId")]
                    [Validation(Required=false)]
                    public string VirtualServiceGroupId { get; set; }

                    /// <summary>
                    /// <para>The group name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80-tcp</para>
                    /// </summary>
                    [NameInMap("virtualServiceGroupName")]
                    [Validation(Required=false)]
                    public string VirtualServiceGroupName { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7C7C3EB-00B6-509A-B6A3-5462EE759047</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
