// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListGatewayLoadBalancersResponseBodyData Data { get; set; }
        public class ListGatewayLoadBalancersResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewayLoadBalancersResponseBodyDataItems> Items { get; set; }
            public class ListGatewayLoadBalancersResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("defaultGatewayIngress")]
                [Validation(Required=false)]
                public bool? DefaultGatewayIngress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("editEnable")]
                [Validation(Required=false)]
                public bool? EditEnable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-xxxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>47.x.x.x</para>
                /// </summary>
                [NameInMap("loadBalancerAddress")]
                [Validation(Required=false)]
                public string LoadBalancerAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("loadBalancerAddressIpVersion")]
                [Validation(Required=false)]
                public string LoadBalancerAddressIpVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("loadBalancerAddressType")]
                [Validation(Required=false)]
                public string LoadBalancerAddressType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("loadBalancerAvailableStatus")]
                [Validation(Required=false)]
                public string LoadBalancerAvailableStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>lb-bp1xxxx / nlb-xxxx</para>
                /// </summary>
                [NameInMap("loadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Managed</para>
                /// </summary>
                [NameInMap("loadBalancerMode")]
                [Validation(Required=false)]
                public string LoadBalancerMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my-nlb</para>
                /// </summary>
                [NameInMap("loadBalancerName")]
                [Validation(Required=false)]
                public string LoadBalancerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>slb.s2.small</para>
                /// </summary>
                [NameInMap("loadBalancerSpec")]
                [Validation(Required=false)]
                public string LoadBalancerSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("loadBalancerStatus")]
                [Validation(Required=false)]
                public string LoadBalancerStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NLB</para>
                /// </summary>
                [NameInMap("loadBalancerType")]
                [Validation(Required=false)]
                public string LoadBalancerType { get; set; }

                [NameInMap("loadBalancerZoneMappings")]
                [Validation(Required=false)]
                public List<ListGatewayLoadBalancersResponseBodyDataItemsLoadBalancerZoneMappings> LoadBalancerZoneMappings { get; set; }
                public class ListGatewayLoadBalancersResponseBodyDataItemsLoadBalancerZoneMappings : TeaModel {
                    [NameInMap("loadBalancerAddresses")]
                    [Validation(Required=false)]
                    public List<ListGatewayLoadBalancersResponseBodyDataItemsLoadBalancerZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
                    public class ListGatewayLoadBalancersResponseBodyDataItemsLoadBalancerZoneMappingsLoadBalancerAddresses : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>eip-bp1xxxx</para>
                        /// </summary>
                        [NameInMap("allocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>eni-bp1xxxx</para>
                        /// </summary>
                        [NameInMap("eniId")]
                        [Validation(Required=false)]
                        public string EniId { get; set; }

                        [NameInMap("ipv4LocalAddresses")]
                        [Validation(Required=false)]
                        public List<string> Ipv4LocalAddresses { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2408:xxxx</para>
                        /// </summary>
                        [NameInMap("ipv6Address")]
                        [Validation(Required=false)]
                        public string Ipv6Address { get; set; }

                        [NameInMap("ipv6LocalAddresses")]
                        [Validation(Required=false)]
                        public List<string> Ipv6LocalAddresses { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>192.168.x.x</para>
                        /// </summary>
                        [NameInMap("privateIPv4Address")]
                        [Validation(Required=false)]
                        public string PrivateIPv4Address { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Healthy</para>
                        /// </summary>
                        [NameInMap("privateIPv4HcStatus")]
                        [Validation(Required=false)]
                        public string PrivateIPv4HcStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Healthy</para>
                        /// </summary>
                        [NameInMap("privateIPv6HcStatus")]
                        [Validation(Required=false)]
                        public string PrivateIPv6HcStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>47.x.x.x</para>
                        /// </summary>
                        [NameInMap("publicIPv4Address")]
                        [Validation(Required=false)]
                        public string PublicIPv4Address { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Active</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vsw-bp1xxxx</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-a</para>
                    /// </summary>
                    [NameInMap("zoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

                [NameInMap("ports")]
                [Validation(Required=false)]
                public List<ListGatewayLoadBalancersResponseBodyDataItemsPorts> Ports { get; set; }
                public class ListGatewayLoadBalancersResponseBodyDataItemsPorts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>443</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>https</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("serviceWeight")]
                [Validation(Required=false)]
                public long? ServiceWeight { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("vServerGroupMetaInfo")]
                [Validation(Required=false)]
                public string VServerGroupMetaInfo { get; set; }

                [NameInMap("virtualServerGroupList")]
                [Validation(Required=false)]
                public List<ListGatewayLoadBalancersResponseBodyDataItemsVirtualServerGroupList> VirtualServerGroupList { get; set; }
                public class ListGatewayLoadBalancersResponseBodyDataItemsVirtualServerGroupList : TeaModel {
                    [NameInMap("listeners")]
                    [Validation(Required=false)]
                    public List<ListGatewayLoadBalancersResponseBodyDataItemsVirtualServerGroupListListeners> Listeners { get; set; }
                    public class ListGatewayLoadBalancersResponseBodyDataItemsVirtualServerGroupListListeners : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>443</para>
                        /// </summary>
                        [NameInMap("port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>https</para>
                        /// </summary>
                        [NameInMap("protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rsp-xxxx</para>
                    /// </summary>
                    [NameInMap("virtualServiceGroupId")]
                    [Validation(Required=false)]
                    public string VirtualServiceGroupId { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7C7C3EB-00B6-509A-B6A3-5462EE759047</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
