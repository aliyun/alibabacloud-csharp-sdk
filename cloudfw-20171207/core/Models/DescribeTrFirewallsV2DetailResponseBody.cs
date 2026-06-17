// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2DetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-37nddhri7jf0d2****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

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
        /// <para>The ID of the elastic network interface (ENI) of the firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-uf621u00nafypeex****</para>
        /// </summary>
        [NameInMap("FirewallEniId")]
        [Validation(Required=false)]
        public string FirewallEniId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the ENI of the firewall belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeppcci782zeh2bk****</para>
        /// </summary>
        [NameInMap("FirewallEniVpcId")]
        [Validation(Required=false)]
        public string FirewallEniVpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the ENI of the firewall belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6ptq1kl1c1d9pw9****</para>
        /// </summary>
        [NameInMap("FirewallEniVswitchId")]
        [Validation(Required=false)]
        public string FirewallEniVswitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC firewall instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-9c7c711abdfa4d80****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The name of the VPC firewall instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudfirewall-manual</para>
        /// </summary>
        [NameInMap("FirewallName")]
        [Validation(Required=false)]
        public string FirewallName { get; set; }

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
        /// <para>The CIDR block of the vSwitch that is automatically created in the firewall VPC to host the ENI of the firewall in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.1.0/24</para>
        /// </summary>
        [NameInMap("FirewallSubnetCidr")]
        [Validation(Required=false)]
        public string FirewallSubnetCidr { get; set; }

        /// <summary>
        /// <para>The status of the VPC firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>opened</b>: The firewall is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>closed</b>: The firewall is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>notconfigured</b>: The firewall is not configured.</para>
        /// </description></item>
        /// <item><description><para><b>configured</b>: The firewall is configured.</para>
        /// </description></item>
        /// <item><description><para><b>creating</b>: The firewall is being created.</para>
        /// </description></item>
        /// <item><description><para><b>opening</b>: The firewall is being enabled.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: The firewall is being deleted.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, VPC firewalls in all states are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>opened</para>
        /// </summary>
        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        /// <summary>
        /// <para>The CIDR block of the VPC that is automatically created for the firewall in automatic mode.</para>
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
        /// <para>The ID of the request.</para>
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
        /// <para>The ID of the transit router attachment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-r1llaxxeha71jsm36v</para>
        /// </summary>
        [NameInMap("TrAttachmentId")]
        [Validation(Required=false)]
        public string TrAttachmentId { get; set; }

        /// <summary>
        /// <para>The primary CIDR block of the vSwitch that is automatically created in the firewall VPC to connect to the transit router in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.2.0/24</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterCidr")]
        [Validation(Required=false)]
        public string TrAttachmentMasterCidr { get; set; }

        /// <summary>
        /// <para>The primary zone of the vSwitch that is automatically created in the firewall VPC to connect to the transit router in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterZone")]
        [Validation(Required=false)]
        public string TrAttachmentMasterZone { get; set; }

        /// <summary>
        /// <para>The secondary CIDR block of the vSwitch that is automatically created in the firewall VPC to connect to the transit router in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.3.0/24</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveCidr")]
        [Validation(Required=false)]
        public string TrAttachmentSlaveCidr { get; set; }

        /// <summary>
        /// <para>The secondary zone of the vSwitch that is automatically created in the firewall VPC to connect to the transit router in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveZone")]
        [Validation(Required=false)]
        public string TrAttachmentSlaveZone { get; set; }

        /// <summary>
        /// <para>The ID of the transit router instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-wz9y8sgug8b1xb416****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
