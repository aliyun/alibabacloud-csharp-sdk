// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>Response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGatewayResponseBodyData Data { get; set; }
        public class GetGatewayResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Charge type</para>
            /// <list type="bullet">
            /// <item><description>POSTPAY: Postpaid (pay-as-you-go)</description></item>
            /// <item><description>PREPAY: Prepaid (subscription)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Source of gateway creation:</para>
            /// <list type="bullet">
            /// <item><description>Console: Console.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Console</para>
            /// </summary>
            [NameInMap("createFrom")]
            [Validation(Required=false)]
            public string CreateFrom { get; set; }

            /// <summary>
            /// <para>Creation timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>List of environments associated with the gateway.</para>
            /// </summary>
            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataEnvironments> Environments { get; set; }
            public class GetGatewayResponseBodyDataEnvironments : TeaModel {
                /// <summary>
                /// <para>The environment alias.</para>
                /// 
                /// <b>Example:</b>
                /// <para>默认环境</para>
                /// </summary>
                [NameInMap("alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>Environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-cp9uhudlht***</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <para>The environment name。</para>
                /// 
                /// <b>Example:</b>
                /// <para>default-gw-cp9ugg5***</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Expiration timestamp for subscription. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("expireTimestamp")]
            [Validation(Required=false)]
            public long? ExpireTimestamp { get; set; }

            /// <summary>
            /// <para>Gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-cq2vundlhtg***</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>List of entry addresses for the gateway.</para>
            /// </summary>
            [NameInMap("loadBalancers")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataLoadBalancers> LoadBalancers { get; set; }
            public class GetGatewayResponseBodyDataLoadBalancers : TeaModel {
                /// <summary>
                /// <para>The address of the load balancer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nlb-xoh3pghr***.cn-hangzhou.nlb.aliyuncs.com</para>
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The IP version of the protocol:</para>
                /// <list type="bullet">
                /// <item><description>ipv4: IPv4 type.</description></item>
                /// <item><description>ipv6: IPv6 type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("addressIpVersion")]
                [Validation(Required=false)]
                public string AddressIpVersion { get; set; }

                /// <summary>
                /// <para>Load balancer address type:</para>
                /// <list type="bullet">
                /// <item><description>Internet: Public.</description></item>
                /// <item><description>Intranet: Private.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("addressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// <para>Whether it is the default entry address for the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("gatewayDefault")]
                [Validation(Required=false)]
                public bool? GatewayDefault { get; set; }

                /// <summary>
                /// <para>Load balancer ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nlb-xoh3pghru7c***</para>
                /// </summary>
                [NameInMap("loadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The provision mode of the load balancer for the gateway:</para>
                /// <list type="bullet">
                /// <item><description>Managed: Managed by the Cloud Native API Gateway.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Managed</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>List of listening ports.</para>
                /// </summary>
                [NameInMap("ports")]
                [Validation(Required=false)]
                public List<GetGatewayResponseBodyDataLoadBalancersPorts> Ports { get; set; }
                public class GetGatewayResponseBodyDataLoadBalancersPorts : TeaModel {
                    /// <summary>
                    /// <para>Port number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>443</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>Protocol:</para>
                    /// <list type="bullet">
                    /// <item><description>TCP</description></item>
                    /// <item><description>UDP</description></item>
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
                /// <para>The status of the load balancer:</para>
                /// <list type="bullet">
                /// <item><description>Ready: Available.</description></item>
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
                /// <para>The type of load balancer:</para>
                /// <list type="bullet">
                /// <item><description>NLB: Network Load Balancer.</description></item>
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
            /// <para>Gateway name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>itemcenter-gateway</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Number of gateway instance nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("replicas")]
            [Validation(Required=false)]
            public string Replicas { get; set; }

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
                /// <para>Security group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>APIG-sg-gw-cq7ke5ll***</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp16tafq9***</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

            /// <summary>
            /// <para>Gateway specification:</para>
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
            /// <para>Gateway status:</para>
            /// <list type="bullet">
            /// <item><description>Running: Running.</description></item>
            /// <item><description>Creating: Creating.</description></item>
            /// <item><description>CreateFailed: Creation failed.</description></item>
            /// <item><description>Upgrading: Upgrading.</description></item>
            /// <item><description>UpgradeFailed: Upgrade failed.</description></item>
            /// <item><description>Restarting: Restarting.</description></item>
            /// <item><description>RestartFailed: Restart failed.</description></item>
            /// <item><description>Deleting: Deleting.</description></item>
            /// <item><description>DeleteFailed: Deletion failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataTags> Tags { get; set; }
            public class GetGatewayResponseBodyDataTags : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Target version of the gateway. When it is inconsistent with the current version, an upgrade can be performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.2</para>
            /// </summary>
            [NameInMap("targetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

            /// <summary>
            /// <para>Update timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("updateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

            /// <summary>
            /// <para>The virtual switch associated with the gateway.</para>
            /// </summary>
            [NameInMap("vSwitch")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataVSwitch VSwitch { get; set; }
            public class GetGatewayResponseBodyDataVSwitch : TeaModel {
                /// <summary>
                /// <para>Virtual switch name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州VPC虚拟交换机</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Virtual switch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1c7ggkj***</para>
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>Gateway version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The VPC (Virtual Private Cloud) associated with the gateway.</para>
            /// </summary>
            [NameInMap("vpc")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataVpc Vpc { get; set; }
            public class GetGatewayResponseBodyDataVpc : TeaModel {
                /// <summary>
                /// <para>VPC gateway name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州VPC</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>VPC network ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1llj52lvj6xc***</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>List of availability zones associated with the gateway.</para>
            /// </summary>
            [NameInMap("zones")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataZones> Zones { get; set; }
            public class GetGatewayResponseBodyDataZones : TeaModel {
                /// <summary>
                /// <para>Availability zone name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州可用区E</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Virtual switch.</para>
                /// </summary>
                [NameInMap("vSwitch")]
                [Validation(Required=false)]
                public GetGatewayResponseBodyDataZonesVSwitch VSwitch { get; set; }
                public class GetGatewayResponseBodyDataZonesVSwitch : TeaModel {
                    /// <summary>
                    /// <para>Virtual switch name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州VPC虚拟交换机</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Virtual switch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1c7ggkj***</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// <para>Availability zone ID.</para>
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
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0F138FFC-6E2B-56C1-9BAB-A67462E339D1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
