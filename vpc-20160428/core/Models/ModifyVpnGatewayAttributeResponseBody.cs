// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnGatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether BGP routes are automatically propagated to the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: automatic propagation is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: automatic propagation is not enabled.</para>
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
        /// <item><description><b>Normal</b>: Normal.</description></item>
        /// <item><description><b>FinancialLocked</b>: locked due to overdue payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The timestamp when the VPN gateway instance was created. Unit: milliseconds.</para>
        /// <para>The timestamp follows the UNIX timestamp format, which represents the total number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC to the time when the VPN gateway instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1492753580000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the VPN gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The second IP address assigned by the system to the VPN gateway instance for creating IPsec-VPN connections.</para>
        /// <para>This parameter is returned only for VPN gateway instances that support dual-tunnel IPsec-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.11.XX.XX</para>
        /// </summary>
        [NameInMap("DisasterRecoveryInternetIp")]
        [Validation(Required=false)]
        public string DisasterRecoveryInternetIp { get; set; }

        /// <summary>
        /// <para>The ID of the second vSwitch associated with the VPN gateway instance.</para>
        /// <para>This parameter is returned only for VPN gateway instances that support dual-tunnel IPsec-VPN connections.</para>
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
        /// <item><description><para><b>false</b>: not enabled.</para>
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
        /// <para>The timestamp when the VPN gateway instance expires. Unit: milliseconds.</para>
        /// <para>The timestamp follows the UNIX timestamp format, which represents the total number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC to the time when the VPN gateway instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1495382400000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If the VPN gateway instance supports single-tunnel IPsec-VPN connections, this address is the IP address of the VPN gateway instance and can be used to create IPsec-VPN connections or SSL-VPN connections.</para>
        /// </description></item>
        /// <item><description><para>If the VPN gateway instance supports dual-tunnel IPsec-VPN connections, this address is the first IP address used to create IPsec-VPN connections and cannot be used to create SSL-VPN connections.</para>
        /// <para>  If the VPN gateway instance supports dual-tunnel IPsec-VPN connections, the system assigns two IPsec IP addresses to the VPN gateway instance for creating dual-tunnel IPsec-VPN connections.</para>
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
        /// <para>The private IP address of the vSwitch occupied by the system when the VPN gateway instance was deployed.</para>
        /// <para>This parameter is returned only for VPN gateway instances that support single-tunnel IPsec-VPN connections and have the IPsec-VPN feature enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.10.46</para>
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// <para>The name of the VPN gateway instance.</para>
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
        /// <para>The ID of the resource group to which the VPN gateway instance belongs.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> to query resource group information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The bandwidth specification of the VPN gateway instance. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5M</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The IP address of the SSL-VPN connection.</para>
        /// <para>This parameter is returned only when the SSL-VPN feature is enabled for a VPN gateway instance that supports dual-tunnel IPsec-VPN connections and uses the public network type.</para>
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
        /// <item><description><b>init</b>: initializing.</description></item>
        /// <item><description><b>provisioning</b>: preparing.</description></item>
        /// <item><description><b>active</b>: Normal.</description></item>
        /// <item><description><b>updating</b>: updating.</description></item>
        /// <item><description><b>deleting</b>: deleting.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch associated with the VPN gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1y9ovl1cu9ou4tv****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the VPN gateway instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1ub1yt9cvakoel****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm2ogj****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
