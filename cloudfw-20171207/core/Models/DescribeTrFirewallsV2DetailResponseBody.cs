// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2DetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID of the Cloud Enterprise Network (CEN).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-37nddhri7jf0d2****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The zone ID used by the firewall connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("FirewallAttachmentZone")]
        [Validation(Required=false)]
        public string FirewallAttachmentZone { get; set; }

        /// <summary>
        /// <para>The description of the firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-firewall-description</para>
        /// </summary>
        [NameInMap("FirewallDescription")]
        [Validation(Required=false)]
        public string FirewallDescription { get; set; }

        /// <summary>
        /// <para>The ENI ID of the firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-uf621u00nafypeex****</para>
        /// </summary>
        [NameInMap("FirewallEniId")]
        [Validation(Required=false)]
        public string FirewallEniId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the firewall ENI belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeppcci782zeh2bk****</para>
        /// </summary>
        [NameInMap("FirewallEniVpcId")]
        [Validation(Required=false)]
        public string FirewallEniVpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the firewall ENI belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6ptq1kl1c1d9pw9****</para>
        /// </summary>
        [NameInMap("FirewallEniVswitchId")]
        [Validation(Required=false)]
        public string FirewallEniVswitchId { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-9c7c711abdfa4d80****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The name of the virtual private cloud (VPC) firewalls instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudfirewall-manual</para>
        /// </summary>
        [NameInMap("FirewallName")]
        [Validation(Required=false)]
        public string FirewallName { get; set; }

        /// <summary>
        /// <para>The deployment mode of the TR firewall service. Valid values: <b>PrimaryStandby</b> (active/standby mode) and <b>MultiPrimary</b> (active-active mode).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrimaryStandby</para>
        /// </summary>
        [NameInMap("FirewallServiceMode")]
        [Validation(Required=false)]
        public string FirewallServiceMode { get; set; }

        /// <summary>
        /// <para>The list of zone IDs used by the TR firewall service.</para>
        /// </summary>
        [NameInMap("FirewallServiceZones")]
        [Validation(Required=false)]
        public List<string> FirewallServiceZones { get; set; }

        /// <summary>
        /// <para>The status of the firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Creating: The firewall is being created.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The firewall is being deleted.</para>
        /// </description></item>
        /// <item><description><para>Ready: The firewall is ready.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("FirewallStatus")]
        [Validation(Required=false)]
        public string FirewallStatus { get; set; }

        /// <summary>
        /// <para>The subnet CIDR block that hosts the firewall ENI in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.1.0/24</para>
        /// </summary>
        [NameInMap("FirewallSubnetCidr")]
        [Validation(Required=false)]
        public string FirewallSubnetCidr { get; set; }

        /// <summary>
        /// <para>The status of the virtual private cloud (VPC) firewalls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>opened</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>closed</b>: disabled</para>
        /// </description></item>
        /// <item><description><para><b>notconfigured</b>: The VPC firewall is not configured.</para>
        /// </description></item>
        /// <item><description><para><b>configured</b>: The VPC firewall is configured.</para>
        /// </description></item>
        /// <item><description><para><b>creating</b>: The VPC firewall is being created.</para>
        /// </description></item>
        /// <item><description><para><b>opening</b>: The VPC firewall is being enabled.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: The VPC firewall is being deleted.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, virtual private cloud (VPC) firewalls in all states are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>opened</para>
        /// </summary>
        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        /// <summary>
        /// <para>The CIDR block of the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/16</para>
        /// </summary>
        [NameInMap("FirewallVpcCidr")]
        [Validation(Required=false)]
        public string FirewallVpcCidr { get; set; }

        /// <summary>
        /// <para>The region ID of the transit router instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E53A7FB-3EB9-5E33-8E50-B8F417D1E02B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The routing mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>managed</b>: automatic mode</para>
        /// </description></item>
        /// <item><description><para><b>manual</b>: manual mode</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>managed</para>
        /// </summary>
        [NameInMap("RouteMode")]
        [Validation(Required=false)]
        public string RouteMode { get; set; }

        /// <summary>
        /// <para>The attachment ID used to connect to the transit router in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-r1llaxxeha71jsm36v</para>
        /// </summary>
        [NameInMap("TrAttachmentId")]
        [Validation(Required=false)]
        public string TrAttachmentId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The primary subnet CIDR block used to connect to the transit router in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.2.0/24</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterCidr")]
        [Validation(Required=false)]
        [Obsolete]
        public string TrAttachmentMasterCidr { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The primary zone used to connect to the transit router in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterZone")]
        [Validation(Required=false)]
        [Obsolete]
        public string TrAttachmentMasterZone { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The secondary subnet CIDR block used to connect to the transit router in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.3.0/24</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveCidr")]
        [Validation(Required=false)]
        [Obsolete]
        public string TrAttachmentSlaveCidr { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The secondary zone used to connect to the transit router in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveZone")]
        [Validation(Required=false)]
        [Obsolete]
        public string TrAttachmentSlaveZone { get; set; }

        /// <summary>
        /// <para>The list of zones and vSwitch CIDR blocks for the transit router connection.</para>
        /// </summary>
        [NameInMap("TrAttachmentZones")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallsV2DetailResponseBodyTrAttachmentZones> TrAttachmentZones { get; set; }
        public class DescribeTrFirewallsV2DetailResponseBodyTrAttachmentZones : TeaModel {
            /// <summary>
            /// <para>The CIDR block of the vSwitch for the transit router connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.2.0/24</para>
            /// </summary>
            [NameInMap("VSwitchCidr")]
            [Validation(Required=false)]
            public string VSwitchCidr { get; set; }

            /// <summary>
            /// <para>The zone ID of the vSwitch for the transit router connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("VSwitchZoneId")]
            [Validation(Required=false)]
            public string VSwitchZoneId { get; set; }

        }

        /// <summary>
        /// <para>The instance ID of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-wz9y8sgug8b1xb416****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
