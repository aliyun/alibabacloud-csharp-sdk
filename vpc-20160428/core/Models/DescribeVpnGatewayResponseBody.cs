// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether BGP routes are automatically advertised to the VPC. Valid values:</para>
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
        /// <para>The payment status of the VPN gateway. Valid values:</para>
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
        /// <para>The billing method. Valid value:</para>
        /// <para><b>POSTPAY</b>: pay-as-you-go</para>
        /// 
        /// <b>Example:</b>
        /// <para>China site (aliyun.com): Prepay. International site (alibabacloud.com): POSTPAY.</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The timestamp when the VPN gateway was created. Unit: milliseconds.</para>
        /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1495382400000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpngatewaydescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The second IP address assigned by the system to create an IPsec-VPN connection.</para>
        /// <para>This parameter is returned only when the VPN gateway supports the dual-tunnel mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.91.XX.XX</para>
        /// </summary>
        [NameInMap("DisasterRecoveryInternetIp")]
        [Validation(Required=false)]
        public string DisasterRecoveryInternetIp { get; set; }

        /// <summary>
        /// <para>The ID of the second vSwitch associated with the VPN gateway.</para>
        /// <para>This parameter is returned only when the VPN gateway supports the dual-tunnel mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-p0w95ql6tmr2ludkt****</para>
        /// </summary>
        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// <para>Indicates whether BGP is enabled for the VPN gateway. Valid values:</para>
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
        /// <para>The timestamp when the VPN gateway expires. Unit: milliseconds.</para>
        /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1544666102000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ENIs created by the system for the VPN gateway.</para>
        /// </summary>
        [NameInMap("EniInstanceIds")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyEniInstanceIds EniInstanceIds { get; set; }
        public class DescribeVpnGatewayResponseBodyEniInstanceIds : TeaModel {
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public List<string> EniInstanceId { get; set; }

        }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If the VPN gateway supports IPsec-VPN connections in single-tunnel mode, the address is the IP address of the VPN gateway and can be used to create an IPsec-VPN connection or an SSL-VPN connection.</para>
        /// </description></item>
        /// <item><description><para>If the VPN gateway supports IPsec-VPN connections in dual-tunnel mode, the address is the first IP address used to create an IPsec-VPN connection. The address cannot be used to create an SSL-VPN connection.</para>
        /// <para>If the VPN gateway supports IPsec-VPN connections in dual-tunnel mode, the system assigns two IP addresses to the VPN gateway to create two encrypted tunnels.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>47.22.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>Indicates whether the IPsec-VPN feature is enabled. Valid values:</para>
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
        /// <para>vpngatewayname</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27E4E088-8DE0-4672-BF5C-0A412389DB9E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about pending orders.</para>
        /// <remarks>
        /// <para>This set of parameters is returned only when <b>IncludeReservationData</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ReservationData")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyReservationData ReservationData { get; set; }
        public class DescribeVpnGatewayResponseBodyReservationData : TeaModel {
            /// <summary>
            /// <para>If the order type is <b>TEMP_UPGRADE</b> (temporary upgrade), this parameter specifies the time when the temporary upgrade expires.</para>
            /// <para>If the order type is <b>RENEWCHANGE</b> (renewal with a specification change) or <b>RENEW</b> (renewal), this parameter indicates the time when the renewal or renewal with a specification change takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-20T16:00:00Z</para>
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
            /// <para>The type of the pending order. Valid values:</para>
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
            /// <para>The status of the pending order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: indicates that the order of the renewal or specification change has not taken effect.</description></item>
            /// <item><description><b>2</b>: indicates that the order is an order for temporary upgrade and the order has taken effect. After the temporary upgrade expires, the system restores the VPN gateway to its previous specifications. In this case, <b>ReservationIpsec</b>, <b>ReservationMaxConnections</b>, <b>ReservationSpec</b>, and <b>ReservationSsl</b> indicate the previous specification.</description></item>
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
        /// <para>The maximum bandwidth of the VPN gateway. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent SSL-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SslMaxConnections")]
        [Validation(Required=false)]
        public long? SslMaxConnections { get; set; }

        /// <summary>
        /// <para>The status of the SSL-VPN feature. Valid values:</para>
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
        /// <para>This parameter is returned only when the VPN gateway is a public VPN gateway and supports only the single-tunnel mode. In addition, the VPN gateway must have the SSL-VPN feature enabled.</para>
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
        /// <para>init</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The automatically generated tag of the VPN gateway.</para>
        /// <list type="bullet">
        /// <item><description><para><b>VpnEnableBgp</b>: indicates whether the VPN gateway supports BGP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>VisuallySsl</b>: indicates whether the VPN gateway allows you to view information about connected SSL clients.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>PbrPriority</b>: indicates whether the VPN gateway allows you to configure priorities for policy-based routes.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>VpnNewImage</b>: indicates whether the VPN gateway is upgraded.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>description</b></para>
        /// </description></item>
        /// <item><description><para><b>VpnVersion</b></para>
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
        /// <para>The tag value.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyTags Tags { get; set; }
        public class DescribeVpnGatewayResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVpnGatewayResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVpnGatewayResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbb</para>
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
        /// <para>vsw-bp1dmzugdikc6hdgx****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the VPN gateway belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp19m2yx1m5q0avyq****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1r3v1xqkl0w519g****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// <para>The type of the VPN gateway.</para>
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
