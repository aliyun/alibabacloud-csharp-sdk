// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateTrFirewallV2Request : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance. This parameter is required. Create a CEN instance in the CEN console before calling this operation, and ensure that an Enterprise Edition transit router has been created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-4xbjup276au29r****</para>
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
        /// <para>The name of the Cloud Firewall instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-firewall-test</para>
        /// </summary>
        [NameInMap("FirewallName")]
        [Validation(Required=false)]
        public string FirewallName { get; set; }

        /// <summary>
        /// <para>The deployment mode of the firewall service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrimaryStandby</b>: Primary/standby mode.</description></item>
        /// <item><description><b>MultiPrimary</b>: Active-active mode.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the system automatically selects a deployment mode based on the capabilities of the transit router. If an invalid value is specified, the error ErrorFwServiceMode (-360437) is returned. MultiPrimary mode does not support specifying zones.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PrimaryStandby</para>
        /// </summary>
        [NameInMap("FirewallServiceMode")]
        [Validation(Required=false)]
        public string FirewallServiceMode { get; set; }

        /// <summary>
        /// <para>The list of zone IDs used by the firewall service.</para>
        /// </summary>
        [NameInMap("FirewallServiceZones")]
        [Validation(Required=false)]
        public List<string> FirewallServiceZones { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The subnet CIDR block used to store the firewall ENI in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.1.0/24</para>
        /// </summary>
        [NameInMap("FirewallSubnetCidr")]
        [Validation(Required=false)]
        [Obsolete]
        public string FirewallSubnetCidr { get; set; }

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
        /// <para>The ID of the VPC in which the firewall ENI is created in manual mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-wz9r5qvryn0lg3atb****</para>
        /// </summary>
        [NameInMap("FirewallVpcId")]
        [Validation(Required=false)]
        public string FirewallVpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in which the firewall ENI is created in manual mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6ydz3vqj77mr5l6****</para>
        /// </summary>
        [NameInMap("FirewallVswitchId")]
        [Validation(Required=false)]
        public string FirewallVswitchId { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
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
        /// <para>The region ID of the Enterprise Edition transit router. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The routing mode. This parameter is required. Valid values: managed (automatic mode) and manual (manual mode). In managed mode, you must specify FirewallVpcCidr, FirewallSubnetCidr, TrAttachmentSlaveCidr, and TrAttachmentMasterCidr. In manual mode, you must specify FirewallVpcId, FirewallVswitchId, TrAttachmentSlaveZone, and TrAttachmentMasterZone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>managed</para>
        /// </summary>
        [NameInMap("RouteMode")]
        [Validation(Required=false)]
        public string RouteMode { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The primary subnet CIDR block used to connect to the TR in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.3.0/24</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterCidr")]
        [Validation(Required=false)]
        [Obsolete]
        public string TrAttachmentMasterCidr { get; set; }

        /// <summary>
        /// <para>The primary zone of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-a</para>
        /// </summary>
        [NameInMap("TrAttachmentMasterZone")]
        [Validation(Required=false)]
        public string TrAttachmentMasterZone { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The secondary subnet CIDR block used to connect to the TR in the firewall VPC in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.16/28</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveCidr")]
        [Validation(Required=false)]
        [Obsolete]
        public string TrAttachmentSlaveCidr { get; set; }

        /// <summary>
        /// <para>The secondary zone of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-b</para>
        /// </summary>
        [NameInMap("TrAttachmentSlaveZone")]
        [Validation(Required=false)]
        public string TrAttachmentSlaveZone { get; set; }

        /// <summary>
        /// <para>The list of zone IDs used by the TR connection.</para>
        /// </summary>
        [NameInMap("TrAttachmentZones")]
        [Validation(Required=false)]
        public List<string> TrAttachmentZones { get; set; }

        /// <summary>
        /// <para>The ID of the Enterprise Edition transit router instance. This parameter is required. The transit router must belong to the CEN instance specified by CenId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-m5etmb2q7e0mxcur****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
