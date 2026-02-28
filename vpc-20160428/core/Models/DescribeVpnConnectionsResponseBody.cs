// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnConnectionsResponseBody : TeaModel {
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
        /// <para>238752DC-0693-49BE-9C85-711D5691D3E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpnConnections")]
        [Validation(Required=false)]
        public DescribeVpnConnectionsResponseBodyVpnConnections VpnConnections { get; set; }
        public class DescribeVpnConnectionsResponseBodyVpnConnections : TeaModel {
            [NameInMap("VpnConnection")]
            [Validation(Required=false)]
            public List<DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnection> VpnConnection { get; set; }
            public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnection : TeaModel {
                /// <summary>
                /// <para>转发路由器实例所属的云企业网实例ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-lxxpbpalc776qz****</para>
                /// </summary>
                [NameInMap("AttachInstanceId")]
                [Validation(Required=false)]
                public string AttachInstanceId { get; set; }

                /// <summary>
                /// <para>IPsec连接绑定的资源类型。</para>
                /// <list type="bullet">
                /// <item><description><b>CEN</b>：表示IPsec连接已绑定云企业网实例下的转发路由器实例。</description></item>
                /// <item><description><b>NO_ASSOCIATED</b>：表示IPsec连接未绑定任何资源。</description></item>
                /// <item><description><b>VPNGW</b>：表示IPsec连接绑定了VPN网关实例。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CEN</para>
                /// </summary>
                [NameInMap("AttachType")]
                [Validation(Required=false)]
                public string AttachType { get; set; }

                /// <summary>
                /// <para>创建IPsec连接的时间戳。单位：毫秒。</para>
                /// <para>时间戳的格式采用Unix时间戳，表示从格林威治时间1970年01月01日00时00分00秒至创建IPsec连接时的总时长。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1492753817000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>IPsec连接是否绑定了跨账号的转发路由器实例。</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>：是。</description></item>
                /// <item><description><b>false</b>：否。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CrossAccountAuthorized")]
                [Validation(Required=false)]
                public bool? CrossAccountAuthorized { get; set; }

                /// <summary>
                /// <para>IPsec连接关联的用户网关的实例ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>cgw-bp1mvj4g9kogw****</para>
                /// </summary>
                [NameInMap("CustomerGatewayId")]
                [Validation(Required=false)]
                public string CustomerGatewayId { get; set; }

                /// <summary>
                /// <para>IPsec连接的配置是否立即生效。</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>：是，配置变更完成后触发重连。</description></item>
                /// <item><description><b>false</b>：否，有流量时触发重连。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EffectImmediately")]
                [Validation(Required=false)]
                public bool? EffectImmediately { get; set; }

                /// <summary>
                /// <para>IPsec连接是否已开启DPD（对等体存活检测）功能。</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>：开启DPD功能。</para>
                /// <para>  IPsec发起端会发送DPD报文用来检测对端的设备是否存活，如果在设定时间内未收到正确回应则认为对端已经断线，IPsec将删除ISAKMP SA和相应的IPsec SA，安全隧道同样也会被删除。</para>
                /// </description></item>
                /// <item><description><para><b>false</b>：不开启DPD功能，IPsec发起端不会发送DPD探测报文。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableDpd")]
                [Validation(Required=false)]
                public bool? EnableDpd { get; set; }

                /// <summary>
                /// <para>IPsec连接是否已开启NAT穿越功能。</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>：开启NAT穿越功能。</para>
                /// <para> 开启后，IKE协商过程会删除对UDP端口号的验证过程，同时实现对VPN隧道中NAT网关设备的发现功能。</para>
                /// </description></item>
                /// <item><description><para><b>false</b>：不开启NAT穿越功能。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableNatTraversal")]
                [Validation(Required=false)]
                public bool? EnableNatTraversal { get; set; }

                /// <summary>
                /// <para>隧道BGP的开启状态。</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>：已开启。</description></item>
                /// <item><description><b>false</b>：未开启。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableTunnelsBgp")]
                [Validation(Required=false)]
                public bool? EnableTunnelsBgp { get; set; }

                /// <summary>
                /// <para>第一阶段协商的配置。</para>
                /// </summary>
                [NameInMap("IkeConfig")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIkeConfig IkeConfig { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIkeConfig : TeaModel {
                    /// <summary>
                    /// <para>IKE阶段认证算法。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sha1</para>
                    /// </summary>
                    [NameInMap("IkeAuthAlg")]
                    [Validation(Required=false)]
                    public string IkeAuthAlg { get; set; }

                    /// <summary>
                    /// <para>IKE阶段加密算法。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aes</para>
                    /// </summary>
                    [NameInMap("IkeEncAlg")]
                    [Validation(Required=false)]
                    public string IkeEncAlg { get; set; }

                    /// <summary>
                    /// <para>IKE阶段生存时间。单位：秒。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86400</para>
                    /// </summary>
                    [NameInMap("IkeLifetime")]
                    [Validation(Required=false)]
                    public long? IkeLifetime { get; set; }

                    /// <summary>
                    /// <para>IKE阶段协商模式。</para>
                    /// <list type="bullet">
                    /// <item><description><b>main</b>：主模式，协商过程安全性高。</description></item>
                    /// <item><description><b>aggressive</b>：野蛮模式，协商快速且协商成功率高。</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>main</para>
                    /// </summary>
                    [NameInMap("IkeMode")]
                    [Validation(Required=false)]
                    public string IkeMode { get; set; }

                    /// <summary>
                    /// <para>IKE阶段DH分组。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>group2</para>
                    /// </summary>
                    [NameInMap("IkePfs")]
                    [Validation(Required=false)]
                    public string IkePfs { get; set; }

                    /// <summary>
                    /// <para>IKE协议版本。</para>
                    /// <list type="bullet">
                    /// <item><description><b>ikev1</b></description></item>
                    /// <item><description><b>ikev2</b></description></item>
                    /// </list>
                    /// <para>相对于IKEv1版本，IKEv2版本简化了SA的协商过程并且对于多网段的场景提供了更好的支持。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ikev1</para>
                    /// </summary>
                    [NameInMap("IkeVersion")]
                    [Validation(Required=false)]
                    public string IkeVersion { get; set; }

                    /// <summary>
                    /// <para>IPsec连接对端本地数据中心侧的标识。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>116.64.XX.XX</para>
                    /// </summary>
                    [NameInMap("LocalId")]
                    [Validation(Required=false)]
                    public string LocalId { get; set; }

                    /// <summary>
                    /// <para>预共享密钥。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pgw6dy7****</para>
                    /// </summary>
                    [NameInMap("Psk")]
                    [Validation(Required=false)]
                    public string Psk { get; set; }

                    /// <summary>
                    /// <para>IPsec连接阿里云侧的标识。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>139.17.XX.XX</para>
                    /// </summary>
                    [NameInMap("RemoteId")]
                    [Validation(Required=false)]
                    public string RemoteId { get; set; }

                }

                /// <summary>
                /// <para>IPsec连接的网关IP地址。</para>
                /// <remarks>
                /// <para>仅IPsec连接绑定转发路由器实例时会返回当前参数。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10.XX.XX.10</para>
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// <para>第二阶段协商的配置。</para>
                /// </summary>
                [NameInMap("IpsecConfig")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIpsecConfig IpsecConfig { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIpsecConfig : TeaModel {
                    /// <summary>
                    /// <para>IPsec阶段认证算法。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sha1</para>
                    /// </summary>
                    [NameInMap("IpsecAuthAlg")]
                    [Validation(Required=false)]
                    public string IpsecAuthAlg { get; set; }

                    /// <summary>
                    /// <para>IPsec阶段加密算法。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aes</para>
                    /// </summary>
                    [NameInMap("IpsecEncAlg")]
                    [Validation(Required=false)]
                    public string IpsecEncAlg { get; set; }

                    /// <summary>
                    /// <para>IPsec阶段生存时间。单位：秒。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86400</para>
                    /// </summary>
                    [NameInMap("IpsecLifetime")]
                    [Validation(Required=false)]
                    public long? IpsecLifetime { get; set; }

                    /// <summary>
                    /// <para>IPsec阶段DH分组。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>group2</para>
                    /// </summary>
                    [NameInMap("IpsecPfs")]
                    [Validation(Required=false)]
                    public string IpsecPfs { get; set; }

                }

                /// <summary>
                /// <para>IPsec连接阿里云侧的网段。</para>
                /// <para>在多个网段的情况下，网段之间使用半角逗号（,）分隔。</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/16,172.17.0.0/16</para>
                /// </summary>
                [NameInMap("LocalSubnet")]
                [Validation(Required=false)]
                public string LocalSubnet { get; set; }

                /// <summary>
                /// <para>IPsec连接的名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>nametest</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>IPsec连接的网络类型。</para>
                /// <list type="bullet">
                /// <item><description><b>public</b>：公网，表示IPsec连接通过公网建立加密通信通道。</description></item>
                /// <item><description><b>private</b>：私网，表示IPsec连接通过私网建立加密通信通道。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>对端的CA证书。</para>
                /// 
                /// <b>Example:</b>
                /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
                /// </summary>
                [NameInMap("RemoteCaCertificate")]
                [Validation(Required=false)]
                public string RemoteCaCertificate { get; set; }

                /// <summary>
                /// <para>本地数据中心侧的网段。</para>
                /// <para>在多个网段的情况下，网段之间使用半角逗号（,）分隔。</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/8,172.16.0.0/16</para>
                /// </summary>
                [NameInMap("RemoteSubnet")]
                [Validation(Required=false)]
                public string RemoteSubnet { get; set; }

                /// <summary>
                /// <para>IPsec连接所属的资源组ID。</para>
                /// <para>您可以调用<a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a>接口查询资源组信息。</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzs372yg****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>IPsec连接的带宽规格。单位：<b>Mbps</b>。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000M</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>IPsec连接与转发路由器实例的绑定状态。</para>
                /// <list type="bullet">
                /// <item><description><b>active</b>：IPsec连接已与VPN网关实例绑定，状态正常。</description></item>
                /// <item><description><b>init</b>：IPsec连接未绑定任何资源，IPsec连接初始化。</description></item>
                /// <item><description><b>attaching</b>：IPsec连接与转发路由器实例绑定中。</description></item>
                /// <item><description><b>attached</b>：IPsec连接已与转发路由器实例绑定。</description></item>
                /// <item><description><b>detaching</b>：IPsec连接与转发路由器实例解绑中。</description></item>
                /// <item><description><b>financialLocked</b>：欠费锁定。</description></item>
                /// <item><description><b>provisioning</b>：资源准备中。</description></item>
                /// <item><description><b>updating</b>：更新中。</description></item>
                /// <item><description><b>upgrading</b>：升级中。</description></item>
                /// <item><description><b>deleted</b>：已删除。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>attached</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>IPsec连接的状态。</para>
                /// <list type="bullet">
                /// <item><description><para><b>ike_sa_not_established</b>：第一阶段协商失败。</para>
                /// </description></item>
                /// <item><description><para><b>ike_sa_established</b>：第一阶段协商成功。</para>
                /// </description></item>
                /// <item><description><para><b>ipsec_sa_not_established</b>：第二阶段协商失败。</para>
                /// </description></item>
                /// <item><description><para><b>ipsec_sa_established</b>：第二阶段协商成功。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ipsec_sa_established</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>IPsec连接绑定的标签列表。</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTag Tag { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTag : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTagTag> Tag { get; set; }
                    public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTagTag : TeaModel {
                        /// <summary>
                        /// <para>标签键。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TagKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>标签值。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TagValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>IPsec连接绑定的转发路由器实例ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>tr-p0we2edef9qr44a85****</para>
                /// </summary>
                [NameInMap("TransitRouterId")]
                [Validation(Required=false)]
                public string TransitRouterId { get; set; }

                /// <summary>
                /// <para>转发路由器实例的名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>nametest</para>
                /// </summary>
                [NameInMap("TransitRouterName")]
                [Validation(Required=false)]
                public string TransitRouterName { get; set; }

                /// <summary>
                /// <para>用于说明VPN单条隧道的带宽规格，取值：
                /// Standard（默认值）：标准型，默认带宽1Gbps
                /// Large（大型）：大型，默认带宽3Gbps</para>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("TunnelBandwidth")]
                [Validation(Required=false)]
                public string TunnelBandwidth { get; set; }

                /// <summary>
                /// <para>IPsec连接的隧道配置信息。</para>
                /// <para>仅查询双隧道模式的IPsec连接会返回<b>TunnelOptionsSpecification</b>数组下的参数。</para>
                /// </summary>
                [NameInMap("TunnelOptionsSpecification")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecification TunnelOptionsSpecification { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecification : TeaModel {
                    [NameInMap("TunnelOptions")]
                    [Validation(Required=false)]
                    public List<DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptions> TunnelOptions { get; set; }
                    public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptions : TeaModel {
                        /// <summary>
                        /// <para>隧道关联的用户网关ID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cgw-p0wy363lucf1uyae8****</para>
                        /// </summary>
                        [NameInMap("CustomerGatewayId")]
                        [Validation(Required=false)]
                        public string CustomerGatewayId { get; set; }

                        /// <summary>
                        /// <para>隧道是否已开启DPD（对等体存活检测）功能。</para>
                        /// <list type="bullet">
                        /// <item><description><b>false</b>：未开启。</description></item>
                        /// <item><description><b>true</b>：已开启。</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("EnableDpd")]
                        [Validation(Required=false)]
                        public string EnableDpd { get; set; }

                        /// <summary>
                        /// <para>隧道是否已开启NAT穿越功能。</para>
                        /// <list type="bullet">
                        /// <item><description><b>false</b>：未开启。</description></item>
                        /// <item><description><b>true</b>：已开启。</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("EnableNatTraversal")]
                        [Validation(Required=false)]
                        public string EnableNatTraversal { get; set; }

                        /// <summary>
                        /// <para>隧道的IP地址。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>47.21.XX.XX</para>
                        /// </summary>
                        [NameInMap("InternetIp")]
                        [Validation(Required=false)]
                        public string InternetIp { get; set; }

                        /// <summary>
                        /// <para>隧道对端的CA证书。</para>
                        /// <para>仅VPN网关实例的类型为国密型时才会返回当前参数。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
                        /// </summary>
                        [NameInMap("RemoteCaCertificate")]
                        [Validation(Required=false)]
                        public string RemoteCaCertificate { get; set; }

                        /// <summary>
                        /// <para>隧道的角色。</para>
                        /// <list type="bullet">
                        /// <item><description><b>master</b>：表示当前隧道为主隧道。</description></item>
                        /// <item><description><b>slave</b>：表示当前隧道为备隧道。</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>master</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <para>隧道的状态。</para>
                        /// <list type="bullet">
                        /// <item><description><b>active</b>：状态正常。</description></item>
                        /// <item><description><b>updating</b>：更新中。</description></item>
                        /// <item><description><b>deleting</b>：删除中。</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>active</para>
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                        /// <summary>
                        /// <para>IPsec连接的状态。</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>ike_sa_not_established</b>：第一阶段协商失败。</para>
                        /// </description></item>
                        /// <item><description><para><b>ike_sa_established</b>：第一阶段协商成功。</para>
                        /// </description></item>
                        /// <item><description><para><b>ipsec_sa_not_established</b>：第二阶段协商失败。</para>
                        /// </description></item>
                        /// <item><description><para><b>ipsec_sa_established</b>：第二阶段协商成功。</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ipsec_sa_established</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>隧道的BGP配置信息。</para>
                        /// </summary>
                        [NameInMap("TunnelBgpConfig")]
                        [Validation(Required=false)]
                        public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig TunnelBgpConfig { get; set; }
                        public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig : TeaModel {
                            /// <summary>
                            /// <para>BGP的协商状态。</para>
                            /// <list type="bullet">
                            /// <item><description><b>success</b>：正常。</description></item>
                            /// <item><description><b>failed</b>：异常。</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>success</para>
                            /// </summary>
                            [NameInMap("BgpStatus")]
                            [Validation(Required=false)]
                            public string BgpStatus { get; set; }

                            /// <summary>
                            /// <para>隧道本端（阿里云侧）的自治系统号。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>65530</para>
                            /// </summary>
                            [NameInMap("LocalAsn")]
                            [Validation(Required=false)]
                            public string LocalAsn { get; set; }

                            /// <summary>
                            /// <para>隧道本端（阿里云侧）的BGP地址。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>169.254.10.1</para>
                            /// </summary>
                            [NameInMap("LocalBgpIp")]
                            [Validation(Required=false)]
                            public string LocalBgpIp { get; set; }

                            /// <summary>
                            /// <para>隧道对端的自治系统号。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>65531</para>
                            /// </summary>
                            [NameInMap("PeerAsn")]
                            [Validation(Required=false)]
                            public string PeerAsn { get; set; }

                            /// <summary>
                            /// <para>隧道对端的BGP地址。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>169.254.10.2</para>
                            /// </summary>
                            [NameInMap("PeerBgpIp")]
                            [Validation(Required=false)]
                            public string PeerBgpIp { get; set; }

                            /// <summary>
                            /// <para>隧道的BGP网段。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>169.254.10.0/30</para>
                            /// </summary>
                            [NameInMap("TunnelCidr")]
                            [Validation(Required=false)]
                            public string TunnelCidr { get; set; }

                        }

                        /// <summary>
                        /// <para>隧道ID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tun-opsqc4d97wni27****</para>
                        /// </summary>
                        [NameInMap("TunnelId")]
                        [Validation(Required=false)]
                        public string TunnelId { get; set; }

                        /// <summary>
                        /// <para>第一阶段协商的配置。</para>
                        /// </summary>
                        [NameInMap("TunnelIkeConfig")]
                        [Validation(Required=false)]
                        public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig TunnelIkeConfig { get; set; }
                        public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig : TeaModel {
                            /// <summary>
                            /// <para>IKE阶段认证算法。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>sha1</para>
                            /// </summary>
                            [NameInMap("IkeAuthAlg")]
                            [Validation(Required=false)]
                            public string IkeAuthAlg { get; set; }

                            /// <summary>
                            /// <para>IKE阶段加密算法。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>aes</para>
                            /// </summary>
                            [NameInMap("IkeEncAlg")]
                            [Validation(Required=false)]
                            public string IkeEncAlg { get; set; }

                            /// <summary>
                            /// <para>IKE阶段生存时间。单位：秒。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>86400</para>
                            /// </summary>
                            [NameInMap("IkeLifetime")]
                            [Validation(Required=false)]
                            public string IkeLifetime { get; set; }

                            /// <summary>
                            /// <para>IKE协商模式。</para>
                            /// <list type="bullet">
                            /// <item><description><b>main</b>：主模式，协商过程安全性高。</description></item>
                            /// <item><description><b>aggressive</b>：野蛮模式，协商快速且协商成功率高。</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>main</para>
                            /// </summary>
                            [NameInMap("IkeMode")]
                            [Validation(Required=false)]
                            public string IkeMode { get; set; }

                            /// <summary>
                            /// <para>IKE阶段DH分组。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>group2</para>
                            /// </summary>
                            [NameInMap("IkePfs")]
                            [Validation(Required=false)]
                            public string IkePfs { get; set; }

                            /// <summary>
                            /// <para>IKE协议版本。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ikev1</para>
                            /// </summary>
                            [NameInMap("IkeVersion")]
                            [Validation(Required=false)]
                            public string IkeVersion { get; set; }

                            /// <summary>
                            /// <para>隧道本端（阿里云侧）的标识。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>47.21.XX.XX</para>
                            /// </summary>
                            [NameInMap("LocalId")]
                            [Validation(Required=false)]
                            public string LocalId { get; set; }

                            /// <summary>
                            /// <para>预共享密钥。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>123456****</para>
                            /// </summary>
                            [NameInMap("Psk")]
                            [Validation(Required=false)]
                            public string Psk { get; set; }

                            /// <summary>
                            /// <para>隧道对端的标识。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>47.42.XX.XX</para>
                            /// </summary>
                            [NameInMap("RemoteId")]
                            [Validation(Required=false)]
                            public string RemoteId { get; set; }

                        }

                        /// <summary>
                        /// <para>隧道的创建顺序。</para>
                        /// <list type="bullet">
                        /// <item><description><b>1</b>：第一条隧道。</description></item>
                        /// <item><description><b>2</b>：第二条隧道。</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>仅IPsec连接绑定转发路由器时会返回该参数。</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("TunnelIndex")]
                        [Validation(Required=false)]
                        public int? TunnelIndex { get; set; }

                        /// <summary>
                        /// <para>第二阶段协商的配置。</para>
                        /// </summary>
                        [NameInMap("TunnelIpsecConfig")]
                        [Validation(Required=false)]
                        public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig TunnelIpsecConfig { get; set; }
                        public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig : TeaModel {
                            /// <summary>
                            /// <para>IPsec阶段认证算法。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>sha1</para>
                            /// </summary>
                            [NameInMap("IpsecAuthAlg")]
                            [Validation(Required=false)]
                            public string IpsecAuthAlg { get; set; }

                            /// <summary>
                            /// <para>IPsec阶段加密算法。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>aes</para>
                            /// </summary>
                            [NameInMap("IpsecEncAlg")]
                            [Validation(Required=false)]
                            public string IpsecEncAlg { get; set; }

                            /// <summary>
                            /// <para>IPsec阶段生存时间。单位：秒。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>86400</para>
                            /// </summary>
                            [NameInMap("IpsecLifetime")]
                            [Validation(Required=false)]
                            public string IpsecLifetime { get; set; }

                            /// <summary>
                            /// <para>IPsec阶段DH分组。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>group2</para>
                            /// </summary>
                            [NameInMap("IpsecPfs")]
                            [Validation(Required=false)]
                            public string IpsecPfs { get; set; }

                        }

                        /// <summary>
                        /// <para>隧道部署的可用区。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ap-southeast-5a</para>
                        /// </summary>
                        [NameInMap("ZoneNo")]
                        [Validation(Required=false)]
                        public string ZoneNo { get; set; }

                    }

                }

                /// <summary>
                /// <para>IPsec连接的健康检查配置。</para>
                /// </summary>
                [NameInMap("VcoHealthCheck")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVcoHealthCheck VcoHealthCheck { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVcoHealthCheck : TeaModel {
                    /// <summary>
                    /// <para>目的IP地址。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.0.1</para>
                    /// </summary>
                    [NameInMap("Dip")]
                    [Validation(Required=false)]
                    public string Dip { get; set; }

                    /// <summary>
                    /// <para>健康检查的开启状态。</para>
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
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public string Enable { get; set; }

                    /// <summary>
                    /// <para>健康检查的时间间隔。单位：秒。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <para>健康检查失败时是否撤销已发布的路由。</para>
                    /// <list type="bullet">
                    /// <item><description><b>revoke_route</b>：撤销路由。</description></item>
                    /// <item><description><b>reserve_route</b>：不撤销路由。</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>revoke_route</para>
                    /// </summary>
                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    /// <summary>
                    /// <para>健康检查的重试发包次数。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Retry")]
                    [Validation(Required=false)]
                    public int? Retry { get; set; }

                    /// <summary>
                    /// <para>源IP地址。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.0.50</para>
                    /// </summary>
                    [NameInMap("Sip")]
                    [Validation(Required=false)]
                    public string Sip { get; set; }

                    /// <summary>
                    /// <para>健康检查状态。</para>
                    /// <list type="bullet">
                    /// <item><description><b>success</b>：正常。</description></item>
                    /// <item><description><b>failed</b>：异常。</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>IPsec连接BGP路由协议的配置。</para>
                /// </summary>
                [NameInMap("VpnBgpConfig")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVpnBgpConfig VpnBgpConfig { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVpnBgpConfig : TeaModel {
                    /// <summary>
                    /// <para>BGP路由协议的认证密钥。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AuthKey****</para>
                    /// </summary>
                    [NameInMap("AuthKey")]
                    [Validation(Required=false)]
                    public string AuthKey { get; set; }

                    /// <summary>
                    /// <para>阿里云侧自治系统号。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65531</para>
                    /// </summary>
                    [NameInMap("LocalAsn")]
                    [Validation(Required=false)]
                    public long? LocalAsn { get; set; }

                    /// <summary>
                    /// <para>阿里云侧BGP地址。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>169.254.10.2</para>
                    /// </summary>
                    [NameInMap("LocalBgpIp")]
                    [Validation(Required=false)]
                    public string LocalBgpIp { get; set; }

                    /// <summary>
                    /// <para>对端自治系统号。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65530</para>
                    /// </summary>
                    [NameInMap("PeerAsn")]
                    [Validation(Required=false)]
                    public long? PeerAsn { get; set; }

                    /// <summary>
                    /// <para>对端BGP地址。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>169.254.10.1</para>
                    /// </summary>
                    [NameInMap("PeerBgpIp")]
                    [Validation(Required=false)]
                    public string PeerBgpIp { get; set; }

                    /// <summary>
                    /// <para>BGP路由协议的协商状态。</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>success</b>：正常。</para>
                    /// </description></item>
                    /// <item><description><para><b>false</b>：异常。</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>IPsec连接BGP网段。该网段是一个在169.254.0.0/16内的子网掩码长度为30的网段。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>169.254.10.0/30</para>
                    /// </summary>
                    [NameInMap("TunnelCidr")]
                    [Validation(Required=false)]
                    public string TunnelCidr { get; set; }

                }

                /// <summary>
                /// <para>IPsec连接的ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vco-bp10lz7aejumd****</para>
                /// </summary>
                [NameInMap("VpnConnectionId")]
                [Validation(Required=false)]
                public string VpnConnectionId { get; set; }

                /// <summary>
                /// <para>VPN网关的实例ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpn-bp1q8bgx4xnkm****</para>
                /// </summary>
                [NameInMap("VpnGatewayId")]
                [Validation(Required=false)]
                public string VpnGatewayId { get; set; }

            }

        }

    }

}
