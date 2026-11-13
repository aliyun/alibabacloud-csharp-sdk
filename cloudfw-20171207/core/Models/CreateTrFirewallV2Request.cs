// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateTrFirewallV2Request : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance. Create a CEN instance in the CEN console and make sure that an Enterprise Edition transit router is created.</para>
        /// <remarks>
        /// <para>Note: Although the required field in the schema is set to false, this parameter is actually required. If this parameter is not specified, the API returns ErrorParameters(400).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cen-4xbjup276au29r****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The zone ID used for the firewall connection.</para>
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
        /// <item><description><b>PrimaryStandby</b>: primary/secondary mode</description></item>
        /// <item><description><b>MultiPrimary</b>: active-active mode</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the system automatically selects the deployment mode based on the capabilities of the transit router. If the value is invalid, ErrorFwServiceMode (-360437) is returned. The MultiPrimary mode does not support specifying zones.</para>
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
        /// <para>The CIDR block of the subnet that stores the firewall elastic network interface (ENI) in the firewall VPC in automatic mode.</para>
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
        /// <para>The ID of the VPC where the firewall ENI is created in manual mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-wz9r5qvryn0lg3atb****</para>
        /// </summary>
        [NameInMap("FirewallVpcId")]
        [Validation(Required=false)]
        public string FirewallVpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch where the firewall ENI is created in manual mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6ydz3vqj77mr5l6****</para>
        /// </summary>
        [NameInMap("FirewallVswitchId")]
        [Validation(Required=false)]
        public string FirewallVswitchId { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
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
        /// <para>The region ID of the Enterprise Edition transit router.</para>
        /// <remarks>
        /// <para>Note: Although the required field in the schema is set to false, this parameter is actually required. If this parameter is not specified, the API returns ErrorParameters(400).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The routing mode. Valid values: managed (automatic mode), manual (manual mode for custom VPCs), and semi-managed (manual mode for managed VPCs).</para>
        /// <list type="bullet">
        /// <item><description><para>In managed mode, you only need to specify FirewallVpcCidr. The FirewallSubnetCidr, TrAttachmentSlaveCidr, and TrAttachmentMasterCidr parameters are deprecated (deprecated:true) and do not need to be specified.</para>
        /// </description></item>
        /// <item><description><para>In manual mode, you must specify FirewallVpcId, FirewallVswitchId, TrAttachmentSlaveZone, and TrAttachmentMasterZone.</para>
        /// </description></item>
        /// <item><description><para>In semi-managed mode, you only need to specify FirewallVpcCidr.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: Although the required field in the schema is set to false, this parameter is actually required. If this parameter is not specified, the API returns ErrorParameters(400).</para>
        /// </remarks>
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
        /// <para>The primary CIDR block of the subnet used to connect to the transit router in the firewall VPC in automatic mode.</para>
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
        /// <para>The secondary CIDR block of the subnet used to connect to the transit router in the firewall VPC in automatic mode.</para>
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
        /// <para>The list of zone IDs used for the transit router connection.</para>
        /// </summary>
        [NameInMap("TrAttachmentZones")]
        [Validation(Required=false)]
        public List<string> TrAttachmentZones { get; set; }

        /// <summary>
        /// <para>The ID of the Enterprise Edition transit router instance. The transit router must belong to the CEN instance specified by CenId.</para>
        /// <remarks>
        /// <para>Note: Although the required field in the schema is set to false, this parameter is actually required. If this parameter is not specified, the API returns ErrorParameters(400).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tr-m5etmb2q7e0mxcur****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
