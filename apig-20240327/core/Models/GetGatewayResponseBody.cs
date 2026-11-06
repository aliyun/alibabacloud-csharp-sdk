// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayResponseBody : TeaModel {
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
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGatewayResponseBodyData Data { get; set; }
        public class GetGatewayResponseBodyData : TeaModel {
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
            /// <para>Indicates whether elastic scaling is enabled. A value of true indicates that elastic scaling is enabled. A value of false indicates that elastic scaling is disabled. A value of null or a missing value indicates that the status is unknown. This parameter is for query and display purposes only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("elasticEnabled")]
            [Validation(Required=false)]
            public bool? ElasticEnabled { get; set; }

            /// <summary>
            /// <para>The list of environments associated with the gateway.</para>
            /// </summary>
            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataEnvironments> Environments { get; set; }
            public class GetGatewayResponseBodyDataEnvironments : TeaModel {
                /// <summary>
                /// <para>The environment alias.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default environment</para>
                /// </summary>
                [NameInMap("alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-cp9uhudlht***</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <para>The environment name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default-gw-cp9ugg5***</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The expiration timestamp for subscription instances. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("expireTimestamp")]
            [Validation(Required=false)]
            public long? ExpireTimestamp { get; set; }

            /// <summary>
            /// <para>The gateway edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Professional: Professional instance.</description></item>
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
            /// <para>gw-cq2vundlhtg***</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The AI multi-tenant V2 operation mode. The default value is ENTERPRISE. This parameter is allowed only for AI and MultiTenantServerless.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("gatewayMode")]
            [Validation(Required=false)]
            public string GatewayMode { get; set; }

            /// <summary>
            /// <para>The gateway type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>API: API gateway.</description></item>
            /// <item><description>AI: AI gateway.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("gatewayType")]
            [Validation(Required=false)]
            public string GatewayType { get; set; }

            /// <summary>
            /// <para>The network ISP type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The list of ingress addresses for the gateway.</para>
            /// </summary>
            [NameInMap("loadBalancers")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataLoadBalancers> LoadBalancers { get; set; }
            public class GetGatewayResponseBodyDataLoadBalancers : TeaModel {
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
                /// <para>Indicates whether the address is the default ingress address for the gateway.</para>
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
                /// <para>nlb-xoh3pghru7c***</para>
                /// </summary>
                [NameInMap("loadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The load balancing provisioning pattern for the gateway. Valid values:</para>
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
                public List<GetGatewayResponseBodyDataLoadBalancersPorts> Ports { get; set; }
                public class GetGatewayResponseBodyDataLoadBalancersPorts : TeaModel {
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
                /// <para>The status of the load balancing. Valid values:</para>
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
                /// <para>The load balancing type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NLB: Network Load Balancer (NLB).</description></item>
                /// <item><description>CLB: Classic Load Balancer.</description></item>
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
            /// <para>The O&amp;M window.</para>
            /// </summary>
            [NameInMap("maintenancePeriod")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataMaintenancePeriod MaintenancePeriod { get; set; }
            public class GetGatewayResponseBodyDataMaintenancePeriod : TeaModel {
                /// <summary>
                /// <para>The O&amp;M end time in HH:mm format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>06:00</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The O&amp;M start time in HH:mm format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02:00</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

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
            /// <para>The network access configuration of the gateway, including the access endpoint type and the security group used by the internal endpoint. This parameter is returned only when the gateway is configured with an internal endpoint.</para>
            /// </summary>
            [NameInMap("networkAccessConfig")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataNetworkAccessConfig NetworkAccessConfig { get; set; }
            public class GetGatewayResponseBodyDataNetworkAccessConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the security group configured for the internal endpoint. The security group belongs to the VPC selected by the user and is an unmanaged security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1example123456789</para>
                /// </summary>
                [NameInMap("endpointSecurityGroupId")]
                [Validation(Required=false)]
                public string EndpointSecurityGroupId { get; set; }

                /// <summary>
                /// <para>The access endpoint type of the gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Intranet: Internal endpoint only.</description></item>
                /// <item><description>InternetAndIntranet: Internet and internal endpoints.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InternetAndIntranet</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The PrivateLink information of the gateway, including the endpoint ID, access domain name, connection status, and zone information.</para>
            /// </summary>
            [NameInMap("privateLink")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataPrivateLink PrivateLink { get; set; }
            public class GetGatewayResponseBodyDataPrivateLink : TeaModel {
                /// <summary>
                /// <para>The connection status between the internal endpoint and the endpoint service. A value of Connected indicates that the endpoint is connected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Connected</para>
                /// </summary>
                [NameInMap("connectionStatus")]
                [Validation(Required=false)]
                public string ConnectionStatus { get; set; }

                /// <summary>
                /// <para>The access domain name of the internal endpoint, which can be used to access the gateway from the user VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-bp1example123456789.epsrv-bp1example123456789.cn-hangzhou.privatelink.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpointDomain")]
                [Validation(Required=false)]
                public string EndpointDomain { get; set; }

                /// <summary>
                /// <para>The internal endpoint ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-bp1example123456789</para>
                /// </summary>
                [NameInMap("endpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <para>The ID of the security group configured for the internal endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1example123456789</para>
                /// </summary>
                [NameInMap("endpointSecurityGroupId")]
                [Validation(Required=false)]
                public string EndpointSecurityGroupId { get; set; }

                /// <summary>
                /// <para>The status of the internal endpoint. A value of Active indicates that the endpoint is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("endpointStatus")]
                [Validation(Required=false)]
                public string EndpointStatus { get; set; }

                /// <summary>
                /// <para>The error code of the most recent fault that occurred during the creation or delete procedure of the private network ingress. This parameter is not returned if no error message is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Forbidden.RAM</para>
                /// </summary>
                [NameInMap("lastErrorCode")]
                [Validation(Required=false)]
                public string LastErrorCode { get; set; }

                /// <summary>
                /// <para>The description of the most recent fault that occurred during the creation or delete procedure of the private network ingress. You can use this description along with the error code to troubleshoot the issue. This parameter is not returned if no error message is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>private ingress CheckProductOpen failed (Forbidden.RAM)</para>
                /// </summary>
                [NameInMap("lastErrorMessage")]
                [Validation(Required=false)]
                public string LastErrorMessage { get; set; }

                /// <summary>
                /// <para>The time when the system last retrieved the status of the private endpoint. The time is in RFC 3339 format. This parameter is not returned if the status has not been retrieved.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-02T10:00:00Z</para>
                /// </summary>
                [NameInMap("observedAt")]
                [Validation(Required=false)]
                public string ObservedAt { get; set; }

                /// <summary>
                /// <para>Indicates whether the private endpoint may continue to incur charges. A value of true indicates that the endpoint is created and its release is not confirmed. A value of false indicates that no charge prompt is available. Actual charges are subject to the bill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("resourceMayBeCharged")]
                [Validation(Required=false)]
                public bool? ResourceMayBeCharged { get; set; }

                /// <summary>
                /// <para>The current processing stage of the private endpoint. A value of Ready indicates that the private endpoint is ready.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("stage")]
                [Validation(Required=false)]
                public string Stage { get; set; }

                /// <summary>
                /// <para>The list of zone information for the private endpoint.</para>
                /// </summary>
                [NameInMap("zones")]
                [Validation(Required=false)]
                public List<GetGatewayResponseBodyDataPrivateLinkZones> Zones { get; set; }
                public class GetGatewayResponseBodyDataPrivateLinkZones : TeaModel {
                    /// <summary>
                    /// <para>The connection status of the private endpoint in the zone. A value of Connected indicates that the endpoint is connected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Connected</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The zone ID of the private endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-h</para>
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
            /// <para>rg-acfm2ij6pwxsvua</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The security group of the gateway.</para>
            /// </summary>
            [NameInMap("securityGroup")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataSecurityGroup SecurityGroup { get; set; }
            public class GetGatewayResponseBodyDataSecurityGroup : TeaModel {
                /// <summary>
                /// <para>The name of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>APIG-sg-gw-cq7ke5ll***</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp16tafq9***</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

            /// <summary>
            /// <para>The gateway specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>apigw.small.x1: Small.</description></item>
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
            /// <item><description>Running: The gateway is running.</description></item>
            /// <item><description>Creating: The gateway is being created.</description></item>
            /// <item><description>CreateFailed: The gateway failed to be created.</description></item>
            /// <item><description>Upgrading: The gateway is being upgraded.</description></item>
            /// <item><description>UpgradeFailed: The gateway failed to be upgraded.</description></item>
            /// <item><description>Restarting: The gateway is being restarted.</description></item>
            /// <item><description>RestartFailed: The gateway failed to be restarted.</description></item>
            /// <item><description>Deleting: The gateway is being released.</description></item>
            /// <item><description>DeleteFailed: The gateway failed to be released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of default access domain name information for the gateway. This parameter is not returned if no default domain name information is available.</para>
            /// </summary>
            [NameInMap("subDomainInfos")]
            [Validation(Required=false)]
            public List<SubDomainInfo> SubDomainInfos { get; set; }

            /// <summary>
            /// <para>The resource tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataTags> Tags { get; set; }
            public class GetGatewayResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The key of the resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>owner</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The target version of the gateway. You can upgrade the gateway if this value is different from the current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.2</para>
            /// </summary>
            [NameInMap("targetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

            /// <summary>
            /// <para>The tenant ID returned in STANDARD mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pt-xxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

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
            /// <para>The vSwitch associated with the gateway.</para>
            /// </summary>
            [NameInMap("vSwitch")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataVSwitch VSwitch { get; set; }
            public class GetGatewayResponseBodyDataVSwitch : TeaModel {
                /// <summary>
                /// <para>The name of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou VPC vSwitch</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1c7ggkj***</para>
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
            /// <para>The VPC associated with the gateway.</para>
            /// </summary>
            [NameInMap("vpc")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataVpc Vpc { get; set; }
            public class GetGatewayResponseBodyDataVpc : TeaModel {
                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou VPC</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1llj52lvj6xc***</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The list of zones associated with the gateway.</para>
            /// </summary>
            [NameInMap("zones")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataZones> Zones { get; set; }
            public class GetGatewayResponseBodyDataZones : TeaModel {
                /// <summary>
                /// <para>The name of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou Zone E</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The vSwitch.</para>
                /// </summary>
                [NameInMap("vSwitch")]
                [Validation(Required=false)]
                public GetGatewayResponseBodyDataZonesVSwitch VSwitch { get; set; }
                public class GetGatewayResponseBodyDataZonesVSwitch : TeaModel {
                    /// <summary>
                    /// <para>The name of the vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hangzhou VPC vSwitch</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1c7ggkj***</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-e</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

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
        /// <para>0F138FFC-6E2B-56C1-9BAB-A67462E339D1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
