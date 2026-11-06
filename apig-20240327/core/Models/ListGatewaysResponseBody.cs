// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The gateway list query results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListGatewaysResponseBodyData Data { get; set; }
        public class ListGatewaysResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The gateway list.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewaysResponseBodyDataItems> Items { get; set; }
            public class ListGatewaysResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>POSTPAY: Pay-as-you-go.</description></item>
                /// <item><description>PREPAY: Subscription.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>POSTPAY</para>
                /// </summary>
                [NameInMap("chargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The source from which the gateway was created. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Console: The console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Console</para>
                /// </summary>
                [NameInMap("createFrom")]
                [Validation(Required=false)]
                public string CreateFrom { get; set; }

                /// <summary>
                /// <para>The creation timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>Indicates whether elastic scaling is enabled. A value of true indicates that elastic scaling is enabled. A value of false indicates that elastic scaling is disabled. A value of null or an empty value indicates that the status is unknown. This parameter is for query and display purposes only.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("elasticEnabled")]
                [Validation(Required=false)]
                public bool? ElasticEnabled { get; set; }

                /// <summary>
                /// <para>The expiration timestamp for subscription instances. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172086834548</para>
                /// </summary>
                [NameInMap("expireTimestamp")]
                [Validation(Required=false)]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// <para>The edition of the gateway instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Professional: Regular instance.</description></item>
                /// <item><description>Serverless: Serverless instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Serverless</para>
                /// </summary>
                [NameInMap("gatewayEdition")]
                [Validation(Required=false)]
                public string GatewayEdition { get; set; }

                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-cpv54p5***</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The running mode of the AI MultiTenantServerless gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ENTERPRISE: Enterprise Edition.</description></item>
                /// <item><description>STANDARD: Standard Edition.
                /// This parameter is returned only for AI MultiTenantServerless gateways.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ENTERPRISE</para>
                /// </summary>
                [NameInMap("gatewayMode")]
                [Validation(Required=false)]
                public string GatewayMode { get; set; }

                /// <summary>
                /// <para>The gateway type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>API</para>
                /// </summary>
                [NameInMap("gatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

                /// <summary>
                /// <para>Indicates whether the gateway instance was created before the AI gateway feature was released.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("legacy")]
                [Validation(Required=false)]
                public bool? Legacy { get; set; }

                /// <summary>
                /// <para>The list of ingress addresses for the gateway.</para>
                /// </summary>
                [NameInMap("loadBalancers")]
                [Validation(Required=false)]
                public List<ListGatewaysResponseBodyDataItemsLoadBalancers> LoadBalancers { get; set; }
                public class ListGatewaysResponseBodyDataItemsLoadBalancers : TeaModel {
                    /// <summary>
                    /// <para>The load balancing address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nlb-xoh3pghr***.cn-hangzhou.nlb.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>The IP version. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ipv4: IPv4.</description></item>
                    /// <item><description>ipv6: IPv6.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ipv4</para>
                    /// </summary>
                    [NameInMap("addressIpVersion")]
                    [Validation(Required=false)]
                    public string AddressIpVersion { get; set; }

                    /// <summary>
                    /// <para>The load balancing address type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Internet: Internet.</description></item>
                    /// <item><description>Intranet: Private network.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Internet</para>
                    /// </summary>
                    [NameInMap("addressType")]
                    [Validation(Required=false)]
                    public string AddressType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the address is the default ingress address of the gateway.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("gatewayDefault")]
                    [Validation(Required=false)]
                    public bool? GatewayDefault { get; set; }

                    /// <summary>
                    /// <para>The list of IPv4 addresses.</para>
                    /// </summary>
                    [NameInMap("ipv4Addresses")]
                    [Validation(Required=false)]
                    public List<string> Ipv4Addresses { get; set; }

                    /// <summary>
                    /// <para>The list of IPv6 addresses.</para>
                    /// </summary>
                    [NameInMap("ipv6Addresses")]
                    [Validation(Required=false)]
                    public List<string> Ipv6Addresses { get; set; }

                    /// <summary>
                    /// <para>The load balancing ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nlb-xqwioje1c91r***</para>
                    /// </summary>
                    [NameInMap("loadBalancerId")]
                    [Validation(Required=false)]
                    public string LoadBalancerId { get; set; }

                    /// <summary>
                    /// <para>The load balancing provisioning pattern of the gateway. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Managed: Managed by Cloud-native API Gateway.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Managed</para>
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <para>The list of listened ports.</para>
                    /// </summary>
                    [NameInMap("ports")]
                    [Validation(Required=false)]
                    public List<ListGatewaysResponseBodyDataItemsLoadBalancersPorts> Ports { get; set; }
                    public class ListGatewaysResponseBodyDataItemsLoadBalancersPorts : TeaModel {
                        /// <summary>
                        /// <para>The port number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>443</para>
                        /// </summary>
                        [NameInMap("port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>The protocol. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>TCP: TCP.</description></item>
                        /// <item><description>UDP: UDP.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TCP</para>
                        /// </summary>
                        [NameInMap("protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                    /// <summary>
                    /// <para>The load balancing status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Ready: Active.</description></item>
                    /// <item><description>NotCreate: Not associated with an instance.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The load balancing type of the gateway. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>NLB: Network Load Balancer (NLB) load balancing.</description></item>
                    /// <item><description>CLB: Classic load balancing.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NLB</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The gateway name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>itemcenter-gateway</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The network access configuration of the gateway, including the access ingress type and the security group used by the private endpoint. This parameter is returned only when the gateway is configured with a private ingress.</para>
                /// </summary>
                [NameInMap("networkAccessConfig")]
                [Validation(Required=false)]
                public ListGatewaysResponseBodyDataItemsNetworkAccessConfig NetworkAccessConfig { get; set; }
                public class ListGatewaysResponseBodyDataItemsNetworkAccessConfig : TeaModel {
                    /// <summary>
                    /// <para>The ID of the security group configured for the private endpoint. The security group belongs to the VPC selected by the user and is a non-managed security group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-bp1example123456789</para>
                    /// </summary>
                    [NameInMap("endpointSecurityGroupId")]
                    [Validation(Required=false)]
                    public string EndpointSecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The gateway access ingress type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UnionSearchMCP</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The private connection information of the gateway, including the endpoint ID, access domain name, connection status, and zone information.</para>
                /// </summary>
                [NameInMap("privateLink")]
                [Validation(Required=false)]
                public ListGatewaysResponseBodyDataItemsPrivateLink PrivateLink { get; set; }
                public class ListGatewaysResponseBodyDataItemsPrivateLink : TeaModel {
                    /// <summary>
                    /// <para>The connection status between the private endpoint and the endpoint service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Connected</para>
                    /// </summary>
                    [NameInMap("connectionStatus")]
                    [Validation(Required=false)]
                    public string ConnectionStatus { get; set; }

                    /// <summary>
                    /// <para>The endpoint domain name used for connection configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ep-bp1example123456789.epsrv-bp1example123456789.cn-hangzhou.privatelink.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("endpointDomain")]
                    [Validation(Required=false)]
                    public string EndpointDomain { get; set; }

                    /// <summary>
                    /// <para>The endpoint ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ep-bp1example123456789</para>
                    /// </summary>
                    [NameInMap("endpointId")]
                    [Validation(Required=false)]
                    public string EndpointId { get; set; }

                    /// <summary>
                    /// <para>The ID of the security group configured for the private endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-bp1example123456789</para>
                    /// </summary>
                    [NameInMap("endpointSecurityGroupId")]
                    [Validation(Required=false)]
                    public string EndpointSecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The status of the private endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Active</para>
                    /// </summary>
                    [NameInMap("endpointStatus")]
                    [Validation(Required=false)]
                    public string EndpointStatus { get; set; }

                    /// <summary>
                    /// <para>The error code of the most recent fault that occurred during the private network ingress creation or delete procedure. This parameter is not returned if no error message is available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Forbidden.RAM</para>
                    /// </summary>
                    [NameInMap("lastErrorCode")]
                    [Validation(Required=false)]
                    public string LastErrorCode { get; set; }

                    /// <summary>
                    /// <para>The description of the most recent fault that occurred during the private network ingress creation or delete procedure. You can use this description along with the error code to troubleshoot the issue. This parameter is not returned if no error message is available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>private ingress CheckProductOpen failed (Forbidden.RAM)</para>
                    /// </summary>
                    [NameInMap("lastErrorMessage")]
                    [Validation(Required=false)]
                    public string LastErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The time when the system last obtained the status of the private endpoint. The time is in RFC 3339 format, such as 2026-11-02T10:00:00Z. This parameter is not returned if the status has not been obtained.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-11-02T10:00:00Z</para>
                    /// </summary>
                    [NameInMap("observedAt")]
                    [Validation(Required=false)]
                    public string ObservedAt { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the private endpoint may continue to incur charges. A value of true indicates that the endpoint has been created and its release has not been confirmed. A value of false indicates that there is no charge prompt. Actual charges are subject to the bill.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("resourceMayBeCharged")]
                    [Validation(Required=false)]
                    public bool? ResourceMayBeCharged { get; set; }

                    /// <summary>
                    /// <para>The current processing stage of the private ingress. A value of Ready indicates that the private ingress is ready.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("stage")]
                    [Validation(Required=false)]
                    public string Stage { get; set; }

                    /// <summary>
                    /// <para>The zone names.</para>
                    /// </summary>
                    [NameInMap("zones")]
                    [Validation(Required=false)]
                    public List<ListGatewaysResponseBodyDataItemsPrivateLinkZones> Zones { get; set; }
                    public class ListGatewaysResponseBodyDataItemsPrivateLinkZones : TeaModel {
                        /// <summary>
                        /// <para>The status of the endpoint in the zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The zone ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-beijing</para>
                        /// </summary>
                        [NameInMap("zoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of nodes in the gateway instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("replicas")]
                [Validation(Required=false)]
                public string Replicas { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-xxxx</para>
                /// </summary>
                [NameInMap("resourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The security group information of the gateway.</para>
                /// </summary>
                [NameInMap("securityGroup")]
                [Validation(Required=false)]
                public ListGatewaysResponseBodyDataItemsSecurityGroup SecurityGroup { get; set; }
                public class ListGatewaysResponseBodyDataItemsSecurityGroup : TeaModel {
                    /// <summary>
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-bp1apxihjdbt3***</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                }

                /// <summary>
                /// <para>The gateway specification. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>apigw.small.x1: Small specification.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>apigw.small.x1</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The gateway status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Running: Running.</description></item>
                /// <item><description>Creating: Creating.</description></item>
                /// <item><description>CreateFailed: Creation failed.</description></item>
                /// <item><description>Upgrading: Upgrading.</description></item>
                /// <item><description>UpgradeFailed: Upgrade failed.</description></item>
                /// <item><description>Restarting: Restarting.</description></item>
                /// <item><description>RestartFailed: Restart failed.</description></item>
                /// <item><description>Deleting: Releasing.</description></item>
                /// <item><description>DeleteFailed: Release failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The list of subdomains.</para>
                /// </summary>
                [NameInMap("subDomainInfos")]
                [Validation(Required=false)]
                public List<SubDomainInfo> SubDomainInfos { get; set; }

                /// <summary>
                /// <para>The list of tags.</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<ListGatewaysResponseBodyDataItemsTags> Tags { get; set; }
                public class ListGatewaysResponseBodyDataItemsTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>owner</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhangsan</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The target version of the gateway. If this value differs from the current version, you can upgrade the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0.2</para>
                /// </summary>
                [NameInMap("targetVersion")]
                [Validation(Required=false)]
                public string TargetVersion { get; set; }

                /// <summary>
                /// <para>The update timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("updateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// <para>The vSwitch information.</para>
                /// </summary>
                [NameInMap("vSwitch")]
                [Validation(Required=false)]
                public ListGatewaysResponseBodyDataItemsVSwitch VSwitch { get; set; }
                public class ListGatewaysResponseBodyDataItemsVSwitch : TeaModel {
                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp14efv***</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// <para>The gateway version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0.2</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The VPC information of the gateway.</para>
                /// </summary>
                [NameInMap("vpc")]
                [Validation(Required=false)]
                public ListGatewaysResponseBodyDataItemsVpc Vpc { get; set; }
                public class ListGatewaysResponseBodyDataItemsVpc : TeaModel {
                    /// <summary>
                    /// <para>The VPC ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-uf664ny***</para>
                    /// </summary>
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The zone information of the gateway.</para>
                /// </summary>
                [NameInMap("zones")]
                [Validation(Required=false)]
                public List<ListGatewaysResponseBodyDataItemsZones> Zones { get; set; }
                public class ListGatewaysResponseBodyDataItemsZones : TeaModel {
                    /// <summary>
                    /// <para>The vSwitch.</para>
                    /// </summary>
                    [NameInMap("vSwitch")]
                    [Validation(Required=false)]
                    public ListGatewaysResponseBodyDataItemsZonesVSwitch VSwitch { get; set; }
                    public class ListGatewaysResponseBodyDataItemsZonesVSwitch : TeaModel {
                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-bp14efvkcfbrt4***</para>
                        /// </summary>
                        [NameInMap("vSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                    }

                    /// <summary>
                    /// <para>The zone ID.</para>
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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

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
        /// <para>5B626361-070A-56A7-B127-ADAC8F3655DB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
