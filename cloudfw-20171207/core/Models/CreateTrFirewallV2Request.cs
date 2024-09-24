// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateTrFirewallV2Request : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-4xbjup276au29r****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The description of the firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-sz</para>
        /// </summary>
        [NameInMap("FirewallDescription")]
        [Validation(Required=false)]
        public string FirewallDescription { get; set; }

        /// <summary>
        /// <para>The name of the firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw_test2</para>
        /// </summary>
        [NameInMap("FirewallName")]
        [Validation(Required=false)]
        public string FirewallName { get; set; }

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
        /// <para>The CIDR block that is allocated to the VPC created for the VPC firewall in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/16</para>
        /// </summary>
        [NameInMap("FirewallVpcCidr")]
        [Validation(Required=false)]
        public string FirewallVpcCidr { get; set; }

        /// <summary>
        /// <para>The ID of the VPC in which the ENI associated with the VPC firewall is created in manual mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-wz9r5qvryn0lg3atb****</para>
        /// </summary>
        [NameInMap("FirewallVpcId")]
        [Validation(Required=false)]
        public string FirewallVpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that is used to create the ENI in manual mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6ydz3vqj77mr5l6****</para>
        /// </summary>
        [NameInMap("FirewallVswitchId")]
        [Validation(Required=false)]
        public string FirewallVswitchId { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region ID of the route router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

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
        /// <para>10.0.3.0/24</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterCidr")]
        [Validation(Required=false)]
        public string TrAttachmentMasterCidr { get; set; }

        /// <summary>
        /// <para>The primary zone for the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-a</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterZone")]
        [Validation(Required=false)]
        public string TrAttachmentMasterZone { get; set; }

        /// <summary>
        /// <para>The secondary subnet CIDR block that the VPC uses to connect to the transit router in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.16/28</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveCidr")]
        [Validation(Required=false)]
        public string TrAttachmentSlaveCidr { get; set; }

        /// <summary>
        /// <para>The secondary zone for the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-b</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveZone")]
        [Validation(Required=false)]
        public string TrAttachmentSlaveZone { get; set; }

        /// <summary>
        /// <para>The ID of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-m5etmb2q7e0mxcur****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
