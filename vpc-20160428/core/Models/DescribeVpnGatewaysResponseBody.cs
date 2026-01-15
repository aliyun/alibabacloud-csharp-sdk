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

        /// <summary>
        /// <para>The information about the VPN gateways.</para>
        /// </summary>
        [NameInMap("VpnGateways")]
        [Validation(Required=false)]
        public DescribeVpnGatewaysResponseBodyVpnGateways VpnGateways { get; set; }
        public class DescribeVpnGatewaysResponseBodyVpnGateways : TeaModel {
            [NameInMap("VpnGateway")]
            [Validation(Required=false)]
            public List<DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGateway> VpnGateway { get; set; }
            public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGateway : TeaModel {
                /// <summary>
                /// <para>Indicates whether BGP routes are automatically advertised to the VPC.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoPropagate")]
                [Validation(Required=false)]
                public bool? AutoPropagate { get; set; }

                /// <summary>
                /// <para>The payment status of the VPN gateway.</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>FinancialLocked</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The billing method of the VPN gateway.</para>
                /// <para>Only <b>POSTPAY</b> may be returned, which indicates the pay-as-you-go billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Example value for the China site (aliyun.com): Prepay. Example value for the International site (alibabacloud.com): POSTPAY.</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the VPN gateway was created. Unit: milliseconds.</para>
                /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1515383700000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The second IP address that is assigned to the VPN gateway to create IPsec-VPN connections.</para>
                /// <para>This parameter is returned only if the VPN gateway supports IPsec-VPN connections in dual-tunnel mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.91.XX.XX</para>
                /// </summary>
                [NameInMap("DisasterRecoveryInternetIp")]
                [Validation(Required=false)]
                public string DisasterRecoveryInternetIp { get; set; }

                /// <summary>
                /// <para>The ID of the second vSwitch that is associated with the VPN gateway.</para>
                /// <para>This parameter is returned only if the VPN gateway supports IPsec-VPN connections in dual-tunnel mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-p0w95ql6tmr2ludkt****</para>
                /// </summary>
                [NameInMap("DisasterRecoveryVSwitchId")]
                [Validation(Required=false)]
                public string DisasterRecoveryVSwitchId { get; set; }

                /// <summary>
                /// <para>The BGP status of the VPN gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableBgp")]
                [Validation(Required=false)]
                public bool? EnableBgp { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the VPN gateway expires. Unit: milliseconds.</para>
                /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1518105600000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The ENIs created by the system for the VPN gateway.</para>
                /// </summary>
                [NameInMap("EniInstanceIds")]
                [Validation(Required=false)]
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayEniInstanceIds EniInstanceIds { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayEniInstanceIds : TeaModel {
                    [NameInMap("EniInstanceId")]
                    [Validation(Required=false)]
                    public List<string> EniInstanceId { get; set; }

                }

                [NameInMap("GatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description><para>If the VPN gateway supports IPsec-VPN connections in single-tunnel mode, the value of this parameter is the IP address of the VPN gateway, which can be used to create IPsec-VPN or SSL-VPN connections.</para>
                /// </description></item>
                /// <item><description><para>If the VPN gateway supports IPsec-VPN connections in dual-tunnel mode, the value of this parameter is the first IP address that is used to create an IPsec-VPN connection. The IP address cannot be used to create SSL-VPN connections.</para>
                /// <para>If the VPN gateway supports IPsec-VPN connections in dual-tunnel mode, the system assigns two IPsec addresses to the VPN gateway to create IPsec-VPN connections in dual-tunnel mode.</para>
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
                /// <para>Indicates whether IPsec-VPN is enabled for the VPN gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>enable</b></description></item>
                /// <item><description><b>disable</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("IpsecVpn")]
                [Validation(Required=false)]
                public string IpsecVpn { get; set; }

                /// <summary>
                /// <para>The name of the VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The network type of the VPN gateway.</para>
                /// <list type="bullet">
                /// <item><description><b>public</b></description></item>
                /// <item><description><b>private</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The information about pending orders.</para>
                /// <remarks>
                /// <para>This parameter is returned only if <b>IncludeReservationData</b> is set to <b>true</b>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ReservationData")]
                [Validation(Required=false)]
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayReservationData ReservationData { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayReservationData : TeaModel {
                    /// <summary>
                    /// <para>If the value of ReservationOrderType is <b>TEMP_UPGRADE</b>, this parameter indicates the time when the temporary upgrade expires.</para>
                    /// <para>If the value of ReservationOrderType is <b>RENEWCHANGE</b> or <b>RENEW</b>, this parameter indicates the time when the renewal or renewal with a specification change takes effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-07-20T16:00:00Z</para>
                    /// </summary>
                    [NameInMap("ReservationEndTime")]
                    [Validation(Required=false)]
                    public string ReservationEndTime { get; set; }

                    /// <summary>
                    /// <para>The IPsec-VPN status of the pending order. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>enable</b></description></item>
                    /// <item><description><b>disable</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enable</para>
                    /// </summary>
                    [NameInMap("ReservationIpsec")]
                    [Validation(Required=false)]
                    public string ReservationIpsec { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent SSL-VPN connections of the pending order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ReservationMaxConnections")]
                    [Validation(Required=false)]
                    public int? ReservationMaxConnections { get; set; }

                    /// <summary>
                    /// <para>The type of the order that has not taken effect. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>RENEWCHANGE</b>: renewal with upgrade or downgrade</description></item>
                    /// <item><description><b>TEMP_UPGRADE</b>: temporary upgrade</description></item>
                    /// <item><description><b>RENEW</b>: renewal</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMP_UPGRADE</para>
                    /// </summary>
                    [NameInMap("ReservationOrderType")]
                    [Validation(Required=false)]
                    public string ReservationOrderType { get; set; }

                    /// <summary>
                    /// <para>The bandwidth of the pending order. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ReservationSpec")]
                    [Validation(Required=false)]
                    public string ReservationSpec { get; set; }

                    /// <summary>
                    /// <para>The SSL-VPN status of the pending order. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>enable</b></description></item>
                    /// <item><description><b>disable</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enable</para>
                    /// </summary>
                    [NameInMap("ReservationSsl")]
                    [Validation(Required=false)]
                    public string ReservationSsl { get; set; }

                    /// <summary>
                    /// <para>The status of the pending order.</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: indicates that the order for renewal or the order for renewal with a specification change has not taken effect.</description></item>
                    /// <item><description><b>2</b>: indicates that the order of the temporary upgrade has taken effect. After the temporary upgrade expires, the system restores the VPN gateway to its previous specifications. In this case, the values of <b>ReservationIpsec</b>, <b>ReservationMaxConnections</b>, <b>ReservationSpec</b>, and <b>ReservationSsl</b> indicate the previous specifications of the VPN gateway.</description></item>
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
                /// <para>The ID of the resource group to which the VPN gateway belongs.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzs372yg****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The maximum bandwidth of the VPN gateway. Unit: <b>M</b>, which indicates Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5M</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The number of SSL-VPN connections supported by the VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("SslMaxConnections")]
                [Validation(Required=false)]
                public long? SslMaxConnections { get; set; }

                /// <summary>
                /// <para>Indicates whether SSL-VPN is enabled for the VPN gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>enable</b></description></item>
                /// <item><description><b>disable</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("SslVpn")]
                [Validation(Required=false)]
                public string SslVpn { get; set; }

                /// <summary>
                /// <para>The IP address of the SSL-VPN connection.</para>
                /// <para>This parameter is returned only if the VPN gateway is a public VPN gateway and supports IPsec-VPN connections in dual-tunnel mode. In addition, SSL-VPN must be enabled for the VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.74.XX.XX</para>
                /// </summary>
                [NameInMap("SslVpnInternetIp")]
                [Validation(Required=false)]
                public string SslVpnInternetIp { get; set; }

                /// <summary>
                /// <para>The status of the VPN gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>init</b></description></item>
                /// <item><description><b>provisioning</b></description></item>
                /// <item><description><b>active</b></description></item>
                /// <item><description><b>updating</b></description></item>
                /// <item><description><b>deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag that is automatically generated for the VPN gateway.</para>
                /// <list type="bullet">
                /// <item><description><para><b>VpnEnableBgp</b>: indicates whether the VPN gateway supports BGP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>VisuallySsl</b>: indicates whether the VPN gateway allows you to view the connection information of SSL clients. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>PbrPriority</b>: indicates whether the VPN gateway allows you to configure priorities for policy-based routes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>VpnNewImage</b>: indicates whether the VPN gateway is upgraded. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: queries only SQL templates that need to be optimized.</description></item>
                /// <item><description><b>false</b>: does not query only SQL statements that need to be optimized.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>description</b>: the description of the VPN gateway. This parameter is only for internal use.</para>
                /// </description></item>
                /// <item><description><para><b>VpnVersion</b>: the version of the VPN gateway.</para>
                /// </description></item>
                /// <item><description><para><b>IDaaSNewVersion</b>: indicates whether the VPN gateway can be associated with an EIAM 2.0 instance.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;VpnEnableBgp\&quot;:\&quot;true\&quot;,\&quot;VisuallySsl\&quot;:\&quot;true\&quot;,\&quot;PbrPriority\&quot;:\&quot;true\&quot;,\&quot;VpnNewImage\&quot;:\&quot;true\&quot;,\&quot;description\&quot;:\&quot;forwarding1.3.7\&quot;,\&quot;VpnVersion\&quot;:\&quot;v1.2.4\&quot;}</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The tags that are added to the VPN gateway.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
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
                /// <para>The ID of the vSwitch to which the VPN gateway belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp15lbk8sgtr6r5b0****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the VPN gateway belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1m3i0kn1nd4wiw9****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpn-bp17lofy9fd0dnvzv****</para>
                /// </summary>
                [NameInMap("VpnGatewayId")]
                [Validation(Required=false)]
                public string VpnGatewayId { get; set; }

                /// <summary>
                /// <para>The type of VPN gateway.</para>
                /// <para>Only <b>Normal</b> may be returned, which indicates a standard VPN gateway.</para>
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
