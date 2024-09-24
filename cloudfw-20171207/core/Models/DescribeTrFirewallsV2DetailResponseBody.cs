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
        /// <para>The description of the VPC firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC Firewall</para>
        /// </summary>
        [NameInMap("FirewallDescription")]
        [Validation(Required=false)]
        public string FirewallDescription { get; set; }

        /// <summary>
        /// <para>The ID of the Elastic Network Interface (ENI) with which the VPC firewall is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-uf621u00nafypeex****</para>
        /// </summary>
        [NameInMap("FirewallEniId")]
        [Validation(Required=false)]
        public string FirewallEniId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the ENI is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeppcci782zeh2bk****</para>
        /// </summary>
        [NameInMap("FirewallEniVpcId")]
        [Validation(Required=false)]
        public string FirewallEniVpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch with which the ENI is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6ptq1kl1c1d9pw9****</para>
        /// </summary>
        [NameInMap("FirewallEniVswitchId")]
        [Validation(Required=false)]
        public string FirewallEniVswitchId { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-9c7c711abdfa4d80****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The name of the VPC firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudfirewall-manual</para>
        /// </summary>
        [NameInMap("FirewallName")]
        [Validation(Required=false)]
        public string FirewallName { get; set; }

        /// <summary>
        /// <para>The status of the VPC firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>Deleting</description></item>
        /// <item><description>Ready</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("FirewallStatus")]
        [Validation(Required=false)]
        public string FirewallStatus { get; set; }

        /// <summary>
        /// <para>The subnet CIDR block of the VPC in which the ENI of the firewall is stored in automatic mode.</para>
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
        /// <item><description><b>opened</b>: The VPC firewall is enabled.</description></item>
        /// <item><description><b>closed</b>: The VPC firewall is disabled.</description></item>
        /// <item><description><b>notconfigured</b>: The VPC firewall is not created.</description></item>
        /// <item><description><b>configured</b>: The VPC firewall is created but is not enabled.</description></item>
        /// <item><description><b>creating</b>: The VPC firewall is being created.</description></item>
        /// <item><description><b>opening</b>: The VPC firewall is being enabled.</description></item>
        /// <item><description><b>deleting</b>: The VPC firewall is being deleted.</description></item>
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
        /// <para>The CIDR block that is allocated to the VPC created for the VPC firewall in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/16</para>
        /// </summary>
        [NameInMap("FirewallVpcCidr")]
        [Validation(Required=false)]
        public string FirewallVpcCidr { get; set; }

        /// <summary>
        /// <para>The region ID of the transit router.</para>
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
        /// <para>The routing mode of the VPC firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>managed</b>: automatic mode</description></item>
        /// <item><description><b>manual</b>: manual mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>managed</para>
        /// </summary>
        [NameInMap("RouteMode")]
        [Validation(Required=false)]
        public string RouteMode { get; set; }

        /// <summary>
        /// <para>The primary subnet CIDR block that the VPC uses to connect to the transit router in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.2.0/24</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterCidr")]
        [Validation(Required=false)]
        public string TrAttachmentMasterCidr { get; set; }

        /// <summary>
        /// <para>The secondary subnet CIDR block that the VPC uses to connect to the transit router in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.3.0/24</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveCidr")]
        [Validation(Required=false)]
        public string TrAttachmentSlaveCidr { get; set; }

        /// <summary>
        /// <para>The ID of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-wz9y8sgug8b1xb416****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
