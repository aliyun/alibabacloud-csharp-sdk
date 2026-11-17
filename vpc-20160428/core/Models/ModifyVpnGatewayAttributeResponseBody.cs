// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnGatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether BGP routes are automatically propagated to the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: automatically propagated</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: not automatically propagated</para>
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
        /// <para>The billing status of the VPN gateway instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: normal</description></item>
        /// <item><description><b>FinancialLocked</b>: locked due to overdue payments</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The timestamp when the VPN gateway was created. Unit: milliseconds.</para>
        /// <para>The timestamp follows the UNIX time format. It indicates the total number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1492753580000</para>
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
        /// <para>The second IP address assigned by the system to the VPN gateway for creating an IPsec-VPN connection.</para>
        /// <para>This parameter is returned only for VPN gateways that support dual-tunnel IPsec-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.11.XX.XX</para>
        /// </summary>
        [NameInMap("DisasterRecoveryInternetIp")]
        [Validation(Required=false)]
        public string DisasterRecoveryInternetIp { get; set; }

        /// <summary>
        /// <para>The ID of the second vSwitch associated with the VPN gateway.</para>
        /// <para>This parameter is returned only for VPN gateways that support dual-tunnel IPsec-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-p0w95ql6tmr2ludkt****</para>
        /// </summary>
        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// <para>Specifies whether the BGP feature is enabled for the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled</para>
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
        /// <para>The UNIX timestamp of when the VPN gateway instance expires. Unit: milliseconds.</para>
        /// <para>The UNIX timestamp follows the UNIX time format. It indicates the total number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC until the VPN gateway instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1495382400000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If the VPN gateway supports single-tunnel IPsec-VPN connections, this parameter indicates the IP address of the VPN gateway, which can be used to create an IPsec-VPN connection or an SSL-VPN connection.</para>
        /// </description></item>
        /// <item><description><para>If the VPN gateway supports dual-tunnel IPsec-VPN connections, this parameter indicates the first IP address used to create an IPsec-VPN connection. It cannot be used to create an SSL-VPN connection.</para>
        /// <para>  If the VPN gateway supports dual-tunnel IPsec-VPN connections, the system assigns two IPsec addresses to the VPN gateway for creating dual-tunnel IPsec-VPN connections.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>116.62.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>The private IP address of the vSwitch that is occupied when the system deploys the VPN gateway.</para>
        /// <para>This parameter is returned only for VPN gateways that support only single-tunnel IPsec-VPN connections and have the IPsec-VPN feature enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.10.46</para>
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B457</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>5M</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The IP address of the SSL-VPN connection.</para>
        /// <para>This parameter is returned only after the SSL-VPN feature is enabled for a VPN gateway instance of the public network type that supports dual-tunnel IPsec-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.33.XX.XX</para>
        /// </summary>
        [NameInMap("SslVpnInternetIp")]
        [Validation(Required=false)]
        public string SslVpnInternetIp { get; set; }

        /// <summary>
        /// <para>The status of the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: initializing</description></item>
        /// <item><description><b>provisioning</b>: preparing</description></item>
        /// <item><description><b>active</b>: active</description></item>
        /// <item><description><b>updating</b>: updating</description></item>
        /// <item><description><b>deleting</b>: deleting</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch associated with the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1y9ovl1cu9ou4tv****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the VPN gateway belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1ub1yt9cvakoel****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm2ogj****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
