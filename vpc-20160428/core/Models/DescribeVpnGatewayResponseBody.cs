// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the routing automatic propagation feature is enabled for the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
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
        /// <para>The payment status of the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: Normal.</para>
        /// </description></item>
        /// <item><description><para><b>FinancialLocked</b>: locked due to overdue payment.</para>
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
        /// <para>The billing method. Value:</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;<b>POSTPAY</b>: pay-as-you-go billing method.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;<b>POSTPAY</b>: pay-as-you-go billing method.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;<b>Prepay</b>: subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国站示例值：Prepay，国际站示例值：POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The timestamp when the VPN gateway was created. Unit: milliseconds.</para>
        /// <para>The timestamp follows the UNIX time format, which represents the total number of milliseconds elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
        /// <para>The second IP address assigned by the system to the VPN gateway instance for creating IPsec-VPN connections.</para>
        /// <para>This parameter is returned only for VPN gateway instances that support creating dual-tunnel IPsec-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.91.XX.XX</para>
        /// </summary>
        [NameInMap("DisasterRecoveryInternetIp")]
        [Validation(Required=false)]
        public string DisasterRecoveryInternetIp { get; set; }

        /// <summary>
        /// <para>The ID of the second vSwitch associated with the VPN gateway instance.</para>
        /// <para>This parameter is returned only for VPN gateway instances that support creating dual-tunnel IPsec-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-p0w95ql6tmr2ludkt****</para>
        /// </summary>
        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// <para>The enabling status of the BGP feature for the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
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
        /// <para>The expiration timestamp of the VPN gateway. Unit: milliseconds.</para>
        /// <para>The timestamp follows the UNIX time format, which represents the total number of milliseconds elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1544666102000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("EniInstanceIds")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyEniInstanceIds EniInstanceIds { get; set; }
        public class DescribeVpnGatewayResponseBodyEniInstanceIds : TeaModel {
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public List<string> EniInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The type of the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Traditional</b>: traditional VPN gateway that supports both IPsec and SSL features.</description></item>
        /// <item><description><b>Enhanced.SiteToSite</b>: enhanced site-to-cloud VPN gateway that supports only the IPsec feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced.SiteToSite</para>
        /// </summary>
        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If the VPN gateway instance supports creating single-tunnel IPsec-VPN connections, this address is the IP address of the VPN gateway instance and can be used to create IPsec-VPN connections or SSL-VPN connections.</para>
        /// </description></item>
        /// <item><description><para>If the VPN gateway instance supports creating dual-tunnel IPsec-VPN connections, this address is the first IP address used to create IPsec-VPN connections and cannot be used to create SSL-VPN connections.</para>
        /// <para>  If the VPN gateway instance supports creating dual-tunnel IPsec-VPN connections, the system assigns two IPsec IP addresses to the VPN gateway instance for creating dual-tunnel IPsec-VPN connections.</para>
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
        /// <item><description><para><b>enable</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>disable</b>: disabled.</para>
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
        /// <item><description><b>public</b>: public VPN gateway.</description></item>
        /// <item><description><b>private</b>: private VPN gateway.</description></item>
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
        /// <para>The pending order data.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>IncludeReservationData</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ReservationData")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyReservationData ReservationData { get; set; }
        public class DescribeVpnGatewayResponseBodyReservationData : TeaModel {
            /// <summary>
            /// <para>If the pending order type is <b>TEMP_UPGRADE</b> (temporary upgrade), this parameter indicates the revert time for the temporary upgrade.</para>
            /// <para>If the pending order type is <b>RENEWCHANGE</b> (renewal with specification change) or <b>RENEW</b> (renewal), this parameter indicates the effective period when the renewal or renewal with specification change takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-20T16:00:00Z</para>
            /// </summary>
            [NameInMap("ReservationEndTime")]
            [Validation(Required=false)]
            public string ReservationEndTime { get; set; }

            /// <summary>
            /// <para>The enabling status of the IPsec-VPN feature for the pending order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enable</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: disabled.</para>
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
            /// <item><description><para><b>RENEWCHANGE</b>: renewal with specification change.</para>
            /// </description></item>
            /// <item><description><para><b>TEMP_UPGRADE</b>: temporary upgrade.</para>
            /// </description></item>
            /// <item><description><para><b>RENEW</b>: renewal.</para>
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
            /// <para>The bandwidth specification of the pending order. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ReservationSpec")]
            [Validation(Required=false)]
            public string ReservationSpec { get; set; }

            /// <summary>
            /// <para>The enabling status of the SSL-VPN feature for the pending order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enable</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: disabled.</para>
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
            /// <para>The status of the pending order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: The renewal or renewal with specification change order has not taken effect.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: The temporary upgrade order has taken effect. After the restoration time is reached, the system restores the VPN gateway to the specification before the temporary upgrade. In this case, <b>ReservationIpsec</b>, <b>ReservationMaxConnections</b>, <b>ReservationSpec</b>, and <b>ReservationSsl</b> indicate the specifications before the temporary upgrade.</para>
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
        /// <para>The ID of the resource group to which the VPN gateway belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource group information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The bandwidth specification of the VPN gateway. Unit: Mbit/s.</para>
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
        /// <para>The enabling status of the SSL-VPN feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>enable</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>disable</b>: disabled.</para>
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
        /// <para>The IP address of the SSL-VPN connection.</para>
        /// <para>This parameter is returned only when the SSL-VPN feature is enabled on a VPN gateway instance of the public network type that supports creating dual-tunnel IPsec-VPN connections.</para>
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
        /// <item><description><para><b>init</b>: initializing.</para>
        /// </description></item>
        /// <item><description><para><b>provisioning</b>: preparing.</para>
        /// </description></item>
        /// <item><description><para><b>active</b>: Normal.</para>
        /// </description></item>
        /// <item><description><para><b>updating</b>: updating.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: deleting.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>init</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The labels automatically generated by the system for the VPN gateway.</para>
        /// <list type="bullet">
        /// <item><description><b>VpnEnableBgp</b>: indicates whether the VPN gateway supports the BGP feature.<list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>VisuallySsl</b>: indicates whether the VPN gateway supports viewing connection information of SSL clients.<list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>PbrPriority</b>: indicates whether the VPN gateway supports configuring policy priority for policy-based routing.<list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>VpnNewImage</b>: indicates whether the VPN gateway is a new-generation VPN gateway.<list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>description</b>: the description of the VPN gateway, which is used only for internal system purposes.</description></item>
        /// <item><description><b>VpnVersion</b>: the version number of the VPN gateway.</description></item>
        /// <item><description><b>IDaaSNewVersion</b>: indicates whether the VPN gateway supports attaching to an EIAM 2.0 instance.<list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
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

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyTags Tags { get; set; }
        public class DescribeVpnGatewayResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVpnGatewayResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVpnGatewayResponseBodyTagsTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

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
        /// <para>The instance ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1r3v1xqkl0w519g****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;intl&quot;&gt;The type of the VPN gateway. Value: <b>Normal</b>, which indicates a standard VPN gateway.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The type of the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: standard.</para>
        /// </description></item>
        /// <item><description><para><b>NationalStandard</b>: Chinese SM algorithm-based.</para>
        /// </description></item>
        /// </list>
        /// <para>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("VpnType")]
        [Validation(Required=false)]
        public string VpnType { get; set; }

    }

}
