// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListGatewaysResponseBodyData Data { get; set; }
        public class ListGatewaysResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewaysResponseBodyDataItems> Items { get; set; }
            public class ListGatewaysResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POSTPAY</para>
                /// </summary>
                [NameInMap("chargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>Indicates whether the address is the default ingress address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Console</para>
                /// </summary>
                [NameInMap("createFrom")]
                [Validation(Required=false)]
                public string CreateFrom { get; set; }

                /// <summary>
                /// <para>The load balancer IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The mode in which the load balancer is provided. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Managed: Cloud-native API Gateway manages and provides the load balancer.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>172086834548</para>
                /// </summary>
                [NameInMap("expireTimestamp")]
                [Validation(Required=false)]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// <para>The gateway edition</para>
                /// 
                /// <b>Example:</b>
                /// <para>Serverless</para>
                /// </summary>
                [NameInMap("gatewayEdition")]
                [Validation(Required=false)]
                public string GatewayEdition { get; set; }

                /// <summary>
                /// <para>The information about a gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-cpv54p5***</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The instance state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Running: The instance is running.</description></item>
                /// <item><description>Creating: The instance is being created.</description></item>
                /// <item><description>CreateFailed: The instance fails to be created.</description></item>
                /// <item><description>Upgrading: The instance is being upgraded.</description></item>
                /// <item><description>UpgradeFailed: The instance fails to be upgraded.</description></item>
                /// <item><description>Restarting: The instance is being restarted.</description></item>
                /// <item><description>RestartFailed: The instance fails to be restarted.</description></item>
                /// <item><description>Deleting: The instance is being released.</description></item>
                /// <item><description>DeleteFailed: The instance failed to be released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>API</para>
                /// </summary>
                [NameInMap("gatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

                /// <summary>
                /// <para>Whether the gateway is a legacy instance</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("legacy")]
                [Validation(Required=false)]
                public bool? Legacy { get; set; }

                /// <summary>
                /// <para>The port number.</para>
                /// </summary>
                [NameInMap("loadBalancers")]
                [Validation(Required=false)]
                public List<ListGatewaysResponseBodyDataItemsLoadBalancers> LoadBalancers { get; set; }
                public class ListGatewaysResponseBodyDataItemsLoadBalancers : TeaModel {
                    /// <summary>
                    /// <para>vsw-xxxxx</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nlb-xoh3pghr***.cn-hangzhou.nlb.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>The vSwitch information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ipv4</para>
                    /// </summary>
                    [NameInMap("addressIpVersion")]
                    [Validation(Required=false)]
                    public string AddressIpVersion { get; set; }

                    /// <summary>
                    /// <para>sg-xxxx</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Internet</para>
                    /// </summary>
                    [NameInMap("addressType")]
                    [Validation(Required=false)]
                    public string AddressType { get; set; }

                    /// <summary>
                    /// <para>vsw-xxxxx</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("gatewayDefault")]
                    [Validation(Required=false)]
                    public bool? GatewayDefault { get; set; }

                    /// <summary>
                    /// <para>The IPv4 addresses</para>
                    /// </summary>
                    [NameInMap("ipv4Addresses")]
                    [Validation(Required=false)]
                    public List<string> Ipv4Addresses { get; set; }

                    /// <summary>
                    /// <para>The IPv6 addresses</para>
                    /// </summary>
                    [NameInMap("ipv6Addresses")]
                    [Validation(Required=false)]
                    public List<string> Ipv6Addresses { get; set; }

                    /// <summary>
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nlb-xqwioje1c91r***</para>
                    /// </summary>
                    [NameInMap("loadBalancerId")]
                    [Validation(Required=false)]
                    public string LoadBalancerId { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Managed</para>
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <para>The virtual private cloud (VPC) information of the instance.</para>
                    /// </summary>
                    [NameInMap("ports")]
                    [Validation(Required=false)]
                    public List<ListGatewaysResponseBodyDataItemsLoadBalancersPorts> Ports { get; set; }
                    public class ListGatewaysResponseBodyDataItemsLoadBalancersPorts : TeaModel {
                        /// <summary>
                        /// <para>The resource group ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>443</para>
                        /// </summary>
                        [NameInMap("port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>vpc-xxxxx</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TCP</para>
                        /// </summary>
                        [NameInMap("protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The zone ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NLB</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>itemcenter-gateway</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The load balancer status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Ready: The load balancer is available.</description></item>
                /// <item><description>NotCreate: The load balancer is not associated with the instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("replicas")]
                [Validation(Required=false)]
                public string Replicas { get; set; }

                /// <summary>
                /// <para>The resource group ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-xxxx</para>
                /// </summary>
                [NameInMap("resourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>rg-xxx</para>
                /// </summary>
                [NameInMap("securityGroup")]
                [Validation(Required=false)]
                public ListGatewaysResponseBodyDataItemsSecurityGroup SecurityGroup { get; set; }
                public class ListGatewaysResponseBodyDataItemsSecurityGroup : TeaModel {
                    /// <summary>
                    /// <para>The tags.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-bp1apxihjdbt3***</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                }

                /// <summary>
                /// <para>The load balancer type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NLB: Network Load Balancer</description></item>
                /// <item><description>CLB: Classic Load Balancer</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>apigw.small.x1</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The time when the instance was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The subdomain information</para>
                /// </summary>
                [NameInMap("subDomainInfos")]
                [Validation(Required=false)]
                public List<SubDomainInfo> SubDomainInfos { get; set; }

                /// <summary>
                /// <para>The tags</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<ListGatewaysResponseBodyDataItemsTags> Tags { get; set; }
                public class ListGatewaysResponseBodyDataItemsTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>owner</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhangsan</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TCP</description></item>
                /// <item><description>UDP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2.0.2</para>
                /// </summary>
                [NameInMap("targetVersion")]
                [Validation(Required=false)]
                public string TargetVersion { get; set; }

                /// <summary>
                /// <para>The IP version of the address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ipv4: IPv4</description></item>
                /// <item><description>ipv6: IPv6</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("updateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// <para>Indicates whether the gateway instance was created before AI Gateway launch.</para>
                /// </summary>
                [NameInMap("vSwitch")]
                [Validation(Required=false)]
                public ListGatewaysResponseBodyDataItemsVSwitch VSwitch { get; set; }
                public class ListGatewaysResponseBodyDataItemsVSwitch : TeaModel {
                    /// <summary>
                    /// <para>List Gateways</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp14efv***</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// <para>The information about the port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0.2</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The VPC information</para>
                /// </summary>
                [NameInMap("vpc")]
                [Validation(Required=false)]
                public ListGatewaysResponseBodyDataItemsVpc Vpc { get; set; }
                public class ListGatewaysResponseBodyDataItemsVpc : TeaModel {
                    /// <summary>
                    /// <para>The VPC ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-uf664ny***</para>
                    /// </summary>
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The tag.</para>
                /// </summary>
                [NameInMap("zones")]
                [Validation(Required=false)]
                public List<ListGatewaysResponseBodyDataItemsZones> Zones { get; set; }
                public class ListGatewaysResponseBodyDataItemsZones : TeaModel {
                    /// <summary>
                    /// <para>The second-level domain names.</para>
                    /// </summary>
                    [NameInMap("vSwitch")]
                    [Validation(Required=false)]
                    public ListGatewaysResponseBodyDataItemsZonesVSwitch VSwitch { get; set; }
                    public class ListGatewaysResponseBodyDataItemsZonesVSwitch : TeaModel {
                        /// <summary>
                        /// <para>The second-level domain name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-bp14efvkcfbrt4***</para>
                        /// </summary>
                        [NameInMap("vSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                    }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-i</para>
                    /// </summary>
                    [NameInMap("zoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

            /// <summary>
            /// <para>The gateway list query result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Schema of Response</para>
        /// 
        /// <b>Example:</b>
        /// <para>5B626361-070A-56A7-B127-ADAC8F3655DB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
