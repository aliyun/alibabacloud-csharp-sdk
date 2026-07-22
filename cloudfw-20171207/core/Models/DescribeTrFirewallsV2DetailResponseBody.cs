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
        /// <para>The description of the firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-firewall-description</para>
        /// </summary>
        [NameInMap("FirewallDescription")]
        [Validation(Required=false)]
        public string FirewallDescription { get; set; }

        /// <summary>
        /// <para>The ID of the firewall ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-uf621u00nafypeex****</para>
        /// </summary>
        [NameInMap("FirewallEniId")]
        [Validation(Required=false)]
        public string FirewallEniId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC in which the firewall ENI resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeppcci782zeh2bk****</para>
        /// </summary>
        [NameInMap("FirewallEniVpcId")]
        [Validation(Required=false)]
        public string FirewallEniVpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in which the firewall ENI resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6ptq1kl1c1d9pw9****</para>
        /// </summary>
        [NameInMap("FirewallEniVswitchId")]
        [Validation(Required=false)]
        public string FirewallEniVswitchId { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-9c7c711abdfa4d80****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The instance name of the virtual private cloud (VPC) firewall.</para>
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
        /// <para>The subnet CIDR block that is used to store the firewall ENI in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.1.0/24</para>
        /// </summary>
        [NameInMap("FirewallSubnetCidr")]
        [Validation(Required=false)]
        public string FirewallSubnetCidr { get; set; }

        /// <summary>
        /// <para>The status of the virtual private cloud (VPC) firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>opened</b>: The firewall is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>closed</b>: The firewall is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>notconfigured</b>: The virtual private cloud (VPC) firewall is not configured.</para>
        /// </description></item>
        /// <item><description><para><b>configured</b>: The virtual private cloud (VPC) firewall is configured.</para>
        /// </description></item>
        /// <item><description><para><b>creating</b>: The virtual private cloud (VPC) firewall is being created.</para>
        /// </description></item>
        /// <item><description><para><b>opening</b>: The virtual private cloud (VPC) firewall is being enabled.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: The virtual private cloud (VPC) firewall is being deleted.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not set, virtual private cloud (VPC) firewalls in all states are queried.</para>
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
        /// <para>The attachment ID that is used to connect to the transit router in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-r1llaxxeha71jsm36v</para>
        /// </summary>
        [NameInMap("TrAttachmentId")]
        [Validation(Required=false)]
        public string TrAttachmentId { get; set; }

        /// <summary>
        /// <para>The primary subnet CIDR block that is used to connect to the transit router in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.2.0/24</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterCidr")]
        [Validation(Required=false)]
        public string TrAttachmentMasterCidr { get; set; }

        /// <summary>
        /// <para>The primary zone of the subnet that is used to connect to the transit router in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterZone")]
        [Validation(Required=false)]
        public string TrAttachmentMasterZone { get; set; }

        /// <summary>
        /// <para>The secondary subnet CIDR block that is used to connect to the transit router in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.3.0/24</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveCidr")]
        [Validation(Required=false)]
        public string TrAttachmentSlaveCidr { get; set; }

        /// <summary>
        /// <para>The secondary zone of the subnet that is used to connect to the transit router in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveZone")]
        [Validation(Required=false)]
        public string TrAttachmentSlaveZone { get; set; }

        /// <summary>
        /// <para>The instance ID of the forward routing router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-wz9y8sgug8b1xb416****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
