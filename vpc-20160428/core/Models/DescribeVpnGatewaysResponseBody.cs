// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the returned page.</para>
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
        /// <para>DF11D6F6-E35A-41C3-9B20-6FC8A901FE65</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpnGateways")]
        [Validation(Required=false)]
        public DescribeVpnGatewaysResponseBodyVpnGateways VpnGateways { get; set; }
        public class DescribeVpnGatewaysResponseBodyVpnGateways : TeaModel {
            [NameInMap("VpnGateway")]
            [Validation(Required=false)]
            public List<DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGateway> VpnGateway { get; set; }
            public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGateway : TeaModel {
                /// <summary>
                /// <para>是否已开启VPN网关的路由自动传播功能。</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>：已开启。</para>
                /// </description></item>
                /// <item><description><para><b>false</b>：未开启。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoPropagate")]
                [Validation(Required=false)]
                public bool? AutoPropagate { get; set; }

                /// <summary>
                /// <para>VPN网关的付费状态。</para>
                /// <list type="bullet">
                /// <item><description><para><b>Normal</b>：正常。</para>
                /// </description></item>
                /// <item><description><para><b>FinancialLocked</b>：欠费锁定。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>VPN网关的付费类型。</para>
                /// <para>&lt;props=&quot;china&quot;&gt;仅取值：<b>Prepay</b>，包年包月。</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;仅取值：<b>POSTPAY</b>，按量计费。</para>
                /// <para>&lt;props=&quot;partner&quot;&gt;仅取值： <b>POSTPAY</b>，按量计费。</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国站示例值：Prepay，国际站示例值：POSTPAY</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>创建VPN网关的时间戳。单位：毫秒。</para>
                /// <para>时间戳的格式采用Unix时间戳，表示从格林威治时间1970年01月01日00时00分00秒至创建VPN网关实例时的总时长。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1515383700000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>VPN网关的描述信息。</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>系统为VPN网关实例分配的用于创建IPsec-VPN连接的第二个IP地址。</para>
                /// <para>仅支持创建双隧道模式IPsec-VPN连接的VPN网关实例会返回当前参数。</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.91.XX.XX</para>
                /// </summary>
                [NameInMap("DisasterRecoveryInternetIp")]
                [Validation(Required=false)]
                public string DisasterRecoveryInternetIp { get; set; }

                /// <summary>
                /// <para>VPN网关实例关联的第二个交换机ID。</para>
                /// <para>仅支持创建双隧道模式IPsec-VPN连接的VPN网关实例会返回当前参数。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-p0w95ql6tmr2ludkt****</para>
                /// </summary>
                [NameInMap("DisasterRecoveryVSwitchId")]
                [Validation(Required=false)]
                public string DisasterRecoveryVSwitchId { get; set; }

                /// <summary>
                /// <para>VPN网关BGP功能的开启状态。</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>：已开启。</para>
                /// </description></item>
                /// <item><description><para><b>false</b>：未开启。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableBgp")]
                [Validation(Required=false)]
                public bool? EnableBgp { get; set; }

                /// <summary>
                /// <para>VPN网关到期时间戳。单位：毫秒。</para>
                /// <para>时间戳的格式采用Unix时间戳，表示从格林威治时间1970年01月01日00时00分00秒至VPN网关实例到期时的总时长。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1518105600000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>系统为VPN网关实例创建的弹性网卡ENI（Elastic Network Interfaces）列表。</para>
                /// </summary>
                [NameInMap("EniInstanceIds")]
                [Validation(Required=false)]
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayEniInstanceIds EniInstanceIds { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayEniInstanceIds : TeaModel {
                    [NameInMap("EniInstanceId")]
                    [Validation(Required=false)]
                    public List<string> EniInstanceId { get; set; }

                }

                /// <summary>
                /// <para>VPN 网关类型，取值：
                /// Traditional：传统型VPN网关，覆盖IPsec功能和SSL功能
                /// Enhance.SiteToSite：增强型站点入云VPN，只覆盖IPsec功能</para>
                /// </summary>
                [NameInMap("GatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description><para>在VPN网关实例支持创建单隧道模式IPsec-VPN连接的场景下，该地址为VPN网关实例的IP地址，可用于创建IPsec-VPN连接或SSL-VPN连接。</para>
                /// </description></item>
                /// <item><description><para>在VPN网关实例支持创建双隧道模式IPsec-VPN连接的场景下，该地址为用于创建IPsec-VPN连接的第一个IP地址，不能用于创建SSL-VPN连接。</para>
                /// <para>  在VPN网关实例支持创建双隧道模式IPsec-VPN连接的场景下，系统会为VPN网关实例分配两个IPsec地址，用于创建双隧道模式的IPsec-VPN连接。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>47.12.XX.XX</para>
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// <para>VPN网关是否开启了IPsec-VPN功能。</para>
                /// <list type="bullet">
                /// <item><description><para><b>enable</b>：已开启。</para>
                /// </description></item>
                /// <item><description><para><b>disable</b>：未开启。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("IpsecVpn")]
                [Validation(Required=false)]
                public string IpsecVpn { get; set; }

                /// <summary>
                /// <para>VPN网关的名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>VPN网关的网络类型。</para>
                /// <list type="bullet">
                /// <item><description><b>public</b>：公网VPN网关。</description></item>
                /// <item><description><b>private</b>：私网VPN网关。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>未生效的订购数据。</para>
                /// <remarks>
                /// <para>仅<b>IncludeReservationData</b>传入<b>true</b>才会返回该组参数。</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ReservationData")]
                [Validation(Required=false)]
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayReservationData ReservationData { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayReservationData : TeaModel {
                    /// <summary>
                    /// <para>如果未生效订单类型为<b>TEMP_UPGRADE</b>（临时升配）时，该参数表示为临时升配的还原时间。</para>
                    /// <para>如果未生效订单类型为<b>RENEWCHANGE</b>（续费变配）或<b>RENEW</b>（续费）时，该参数表示为续费或续费变配开始生效时间。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-07-20T16:00:00Z</para>
                    /// </summary>
                    [NameInMap("ReservationEndTime")]
                    [Validation(Required=false)]
                    public string ReservationEndTime { get; set; }

                    /// <summary>
                    /// <para>未生效订单IPsec-VPN功能开启状态。</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>enable</b>：已开启。</para>
                    /// </description></item>
                    /// <item><description><para><b>disable</b>：未开启。</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enable</para>
                    /// </summary>
                    [NameInMap("ReservationIpsec")]
                    [Validation(Required=false)]
                    public string ReservationIpsec { get; set; }

                    /// <summary>
                    /// <para>未生效订单SSL-VPN并发连接用户数的规格。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ReservationMaxConnections")]
                    [Validation(Required=false)]
                    public int? ReservationMaxConnections { get; set; }

                    /// <summary>
                    /// <para>未生效订单类型。</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>RENEWCHANGE</b>：续费变配。</para>
                    /// </description></item>
                    /// <item><description><para><b>TEMP_UPGRADE</b>：临时升配。</para>
                    /// </description></item>
                    /// <item><description><para><b>RENEW</b>：续费。</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMP_UPGRADE</para>
                    /// </summary>
                    [NameInMap("ReservationOrderType")]
                    [Validation(Required=false)]
                    public string ReservationOrderType { get; set; }

                    /// <summary>
                    /// <para>未生效订单的带宽规格。单位：Mbps。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ReservationSpec")]
                    [Validation(Required=false)]
                    public string ReservationSpec { get; set; }

                    /// <summary>
                    /// <para>未生效订单SSL-VPN功能开启状态。</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>enable</b>：已开启。</para>
                    /// </description></item>
                    /// <item><description><para><b>disable</b>：未开启。</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enable</para>
                    /// </summary>
                    [NameInMap("ReservationSsl")]
                    [Validation(Required=false)]
                    public string ReservationSsl { get; set; }

                    /// <summary>
                    /// <para>未生效订单状态。</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>1</b>：表示续费或续费变配的订单未生效。</para>
                    /// </description></item>
                    /// <item><description><para><b>2</b>：表示临时升配的订单已生效。在到达还原时间后，系统会将VPN网关规格恢复到临时升配前的规格。此时<b>ReservationIpsec</b>、<b>ReservationMaxConnections</b>、<b>ReservationSpec</b>、<b>ReservationSsl</b>表示为VPN网关临时升配前的规格。</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>VPN网关所属的资源组ID。</para>
                /// <para>您可以调用<a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a>接口查询资源组信息。</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzs372yg****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>VPN网关的带宽峰值。<b>M</b>表示单位Mbps。</para>
                /// 
                /// <b>Example:</b>
                /// <para>5M</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>VPN网关SSL连接数的规格。</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("SslMaxConnections")]
                [Validation(Required=false)]
                public long? SslMaxConnections { get; set; }

                /// <summary>
                /// <para>VPN网关是否开启了SSL-VPN功能。</para>
                /// <list type="bullet">
                /// <item><description><para><b>enable</b>：已开启。</para>
                /// </description></item>
                /// <item><description><para><b>disable</b>：未开启。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("SslVpn")]
                [Validation(Required=false)]
                public string SslVpn { get; set; }

                /// <summary>
                /// <para>SSL-VPN连接的IP地址。</para>
                /// <para>仅支持创建双隧道模式IPsec-VPN连接的公网网络类型的VPN网关实例开启SSL-VPN功能后，才会返回当前参数。</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.74.XX.XX</para>
                /// </summary>
                [NameInMap("SslVpnInternetIp")]
                [Validation(Required=false)]
                public string SslVpnInternetIp { get; set; }

                /// <summary>
                /// <para>VPN网关的状态。</para>
                /// <list type="bullet">
                /// <item><description><para><b>init</b> ：初始化。</para>
                /// </description></item>
                /// <item><description><para><b>provisioning</b> ：准备中。</para>
                /// </description></item>
                /// <item><description><para><b>active</b> ：正常。</para>
                /// </description></item>
                /// <item><description><para><b>updating</b> ：更新中。</para>
                /// </description></item>
                /// <item><description><para><b>deleting</b> ：删除中。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>系统自动生成的VPN网关标签。</para>
                /// <list type="bullet">
                /// <item><description><b>VpnEnableBgp</b>：表示VPN网关是否支持BGP功能。<list type="bullet">
                /// <item><description><b>true</b>：支持。</description></item>
                /// <item><description><b>false</b>：不支持。</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><b>VisuallySsl</b>：表示VPN网关是否支持查看SSL客户端的连接信息。<list type="bullet">
                /// <item><description><b>true</b>：支持。</description></item>
                /// <item><description><b>false</b>：不支持。</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><b>PbrPriority</b>：表示VPN网关是否支持为策略路由配置策略优先级。<list type="bullet">
                /// <item><description><b>true</b>：支持。</description></item>
                /// <item><description><b>false</b>：不支持。</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><b>VpnNewImage</b>：表示VPN网关是否为新型VPN网关。<list type="bullet">
                /// <item><description><b>true</b>：是。</description></item>
                /// <item><description><b>false</b>：否。</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><b>description</b>：表示VPN网关的描述信息，仅供系统内部使用。</description></item>
                /// <item><description><b>VpnVersion</b>：表示VPN网关的版本号。</description></item>
                /// <item><description><b>IDaaSNewVersion</b>：表示VPN网关是否支持绑定EIAM 2.0实例。<list type="bullet">
                /// <item><description><b>true</b>：支持。</description></item>
                /// <item><description><b>false</b>：不支持。</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;VpnEnableBgp\&quot;:\&quot;true\&quot;,\&quot;VisuallySsl\&quot;:\&quot;true\&quot;,\&quot;PbrPriority\&quot;:\&quot;true\&quot;,\&quot;VpnNewImage\&quot;:\&quot;true\&quot;,\&quot;description\&quot;:\&quot;转发1.3.24\&quot;,\&quot;VpnVersion\&quot;:\&quot;v1.2.4\&quot;,\&quot;IDaaSNewVersion\&quot;:\&quot;true\&quot;}</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>VPN网关绑定的标签列表。</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTags Tags { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTagsTag> Tag { get; set; }
                    public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTagsTag : TeaModel {
                        /// <summary>
                        /// <para>标签键。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>标签值。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceJoshua</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>VPN网关所属交换机的ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp15lbk8sgtr6r5b0****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>VPN网关所属VPC的ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1m3i0kn1nd4wiw9****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>VPN网关的ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpn-bp17lofy9fd0dnvzv****</para>
                /// </summary>
                [NameInMap("VpnGatewayId")]
                [Validation(Required=false)]
                public string VpnGatewayId { get; set; }

                /// <summary>
                /// <para>VPN网关类型。</para>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>：普通型。</description></item>
                /// <item><description><b>NationalStandard</b>：国密型。</description></item>
                /// </list>
                /// <para>&lt;props=&quot;intl&quot;&gt;取值：<b>Normal</b>，表示普通型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("VpnType")]
                [Validation(Required=false)]
                public string VpnType { get; set; }

            }

        }

    }

}
