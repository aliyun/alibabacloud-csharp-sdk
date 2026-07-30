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
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The source from which the gateway was created. Valid values:</para>
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
            /// <para>The subscription expiration timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("expireTimestamp")]
            [Validation(Required=false)]
            public long? ExpireTimestamp { get; set; }

            /// <summary>
            /// <para>The gateway instance edition. Valid values:</para>
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

            [NameInMap("gatewayMode")]
            [Validation(Required=false)]
            public string GatewayMode { get; set; }

            /// <summary>
            /// <para>The gateway type. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("gatewayType")]
            [Validation(Required=false)]
            public string GatewayType { get; set; }

            /// <summary>
            /// <para>The type of the network service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The list of ingress addresses of the gateway.</para>
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
                /// <para>The protocol version. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("addressIpVersion")]
                [Validation(Required=false)]
                public string AddressIpVersion { get; set; }

                /// <summary>
                /// <para>The load balancing address type. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("addressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// <para>Indicates whether this is the default ingress address of the gateway.</para>
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
                /// <para>The load balancing instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nlb-xoh3pghru7c***</para>
                /// </summary>
                [NameInMap("loadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The load balancing mode of the gateway. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Managed</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The list of listening ports.</para>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// <para>The status of load balancing. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The load balancing type.</para>
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
                /// <para>The O&amp;M end time (HH:mm).</para>
                /// 
                /// <b>Example:</b>
                /// <para>06:00</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The O&amp;M start time (HH:mm).</para>
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
            /// <para>The number of gateway instance nodes.</para>
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
                /// <para>The security group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>APIG-sg-gw-cq7ke5ll***</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp16tafq9***</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

            /// <summary>
            /// <para>The gateway specification. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>apigw.small.x1</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The gateway status. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
            /// <para>The target version of the gateway. When this value differs from version, a version upgrade can be performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.2</para>
            /// </summary>
            [NameInMap("targetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

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
                /// <para>The vSwitch name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou VPC vSwitch</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
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
                /// <para>The VPC name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou VPC</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
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
                /// <para>The zone name.</para>
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
                    /// <para>The vSwitch name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hangzhou VPC vSwitch</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
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
