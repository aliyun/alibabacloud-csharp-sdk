// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateSecurityProxyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the basic protection policies of the IPS. If this parameter is not specified, the system default (enabled) is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled.</description></item>
        /// <item><description><b>1</b>: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BasicDefenseEnabled")]
        [Validation(Required=false)]
        public string BasicDefenseEnabled { get; set; }

        /// <summary>
        /// <para>The deployment mode of the firewall service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrimaryStandby</b>: primary/secondary mode.</description></item>
        /// <item><description><b>MultiPrimary</b>: active-active mode.</description></item>
        /// </list>
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

        /// <summary>
        /// <para>The security protection switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: enabled.</description></item>
        /// <item><description><b>close</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>close</para>
        /// </summary>
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        /// <summary>
        /// <para>The zone of the firewall vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-b</para>
        /// </summary>
        [NameInMap("FwVswitchZoneId")]
        [Validation(Required=false)]
        public string FwVswitchZoneId { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The vSwitch CIDR block of the GWLB endpoint (GWLBe) in the active zone. This parameter applies only to NAT firewalls that use the GWLB architecture. For the GWLB architecture, this parameter is required along with MasterZoneId, StandbyZoneId, and StandbyVSwitchCidr. If any of these parameters is missing, ErrorParameters is returned. The vSwitch is created by the firewall creation node based on this vSwitch CIDR block. This parameter is not read for the ENI architecture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24</para>
        /// </summary>
        [NameInMap("MasterVSwitchCidr")]
        [Validation(Required=false)]
        public string MasterVSwitchCidr { get; set; }

        /// <summary>
        /// <para>The ID of the primary zone. This parameter applies only to NAT firewalls that use the GWLB architecture. For the GWLB architecture, this parameter is required along with MasterVSwitchCidr, StandbyZoneId, and StandbyVSwitchCidr. If any of these parameters is missing, ErrorParameters is returned. The value must be the same as the zone where the NAT gateway resides. This parameter is not read for the ENI architecture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("MasterZoneId")]
        [Validation(Required=false)]
        public string MasterZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1okz6k7******</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The architecture type of the NAT firewall. Valid values: <b>eni</b> (traditional ENI architecture) and <b>gwlb</b> (new GWLB architecture). If this parameter is omitted or left empty, the firewall is created by using the ENI architecture, and no implicit selection is performed on the server side. You can obtain the recommended architecture from the response of the DescribeNatFirewallArchitecture operation and pass it back when you create the firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gwlb</para>
        /// </summary>
        [NameInMap("NatMode")]
        [Validation(Required=false)]
        public string NatMode { get; set; }

        /// <summary>
        /// <para>The list of routes to be switched for the NAT gateway.</para>
        /// </summary>
        [NameInMap("NatRouteEntryList")]
        [Validation(Required=false)]
        public List<CreateSecurityProxyRequestNatRouteEntryList> NatRouteEntryList { get; set; }
        public class CreateSecurityProxyRequestNatRouteEntryList : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the default route.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("DestinationCidr")]
            [Validation(Required=false)]
            public string DestinationCidr { get; set; }

            /// <summary>
            /// <para>The next hop ID of the original NAT gateway.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-bp1okz6******</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The network type of the next hop. Valid values: NatGateway.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NatGateway</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The ID of the route table to which the default route of the NAT gateway belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-2ze1******</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

        /// <summary>
        /// <para>The name of the NAT firewall. The name must be 4 to 50 characters in length and can contain uppercase and lowercase letters, Chinese characters, digits, and underscores (_). It cannot start with an underscore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-firewall</para>
        /// </summary>
        [NameInMap("ProxyName")]
        [Validation(Required=false)]
        public string ProxyName { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC.</para>
        /// <remarks>
        /// <para>For more information about the regions supported by Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The level of the IPS rule group. This parameter is valid only in block mode. If this parameter is not specified, the system default (medium) is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: none. The value is forced to 0 in monitor mode.</description></item>
        /// <item><description><b>1</b>: loose.</description></item>
        /// <item><description><b>2</b>: medium.</description></item>
        /// <item><description><b>3</b>: strict.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public string RuleClass { get; set; }

        /// <summary>
        /// <para>The IPS defense mode. This parameter is supported only by NAT firewalls that use the GWLB architecture. If this parameter is not specified, the system default (Block Mode) is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: monitor mode. Only alerting is triggered, and traffic is not blocked.</description></item>
        /// <item><description><b>1</b>: Block Mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        /// <summary>
        /// <para>The vSwitch CIDR block of the GWLBe in the standby zone. This parameter applies only to NAT firewalls that use the GWLB architecture. For the GWLB architecture, this parameter is required along with MasterZoneId, MasterVSwitchCidr, and StandbyZoneId. If any of these parameters is missing, ErrorParameters is returned. The vSwitch is created by the firewall creation node based on this vSwitch CIDR block. This parameter is not read for the ENI architecture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.0/24</para>
        /// </summary>
        [NameInMap("StandbyVSwitchCidr")]
        [Validation(Required=false)]
        public string StandbyVSwitchCidr { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone. This parameter applies only to NAT firewalls that use the GWLB architecture. For the GWLB architecture, this parameter is required along with MasterZoneId, MasterVSwitchCidr, and StandbyVSwitchCidr. If any of these parameters is missing, ErrorParameters is returned. The value cannot be the same as MasterZoneId. If they are the same, ErrorZoneIdInvalid is returned. This parameter is not read for the ENI architecture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable strict mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables strict mode.</description></item>
        /// <item><description><b>0</b>: disables strict mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StrictMode")]
        [Validation(Required=false)]
        public int? StrictMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the threat intelligence rules of the IPS. If this parameter is not specified, the system default (enabled) is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled.</description></item>
        /// <item><description><b>1</b>: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ThreatIntelEnabled")]
        [Validation(Required=false)]
        public string ThreatIntelEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Virtual Patches of the IPS. If this parameter is not specified, the system default (enabled) is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled.</description></item>
        /// <item><description><b>1</b>: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VirtualPatchEnabled")]
        [Validation(Required=false)]
        public string VirtualPatchEnabled { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6b5lyul0x******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the automatic mode for the vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: automatic mode.</description></item>
        /// <item><description><b>false</b>: manual mode.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>true</b>. If VswitchAuto is set to true, VswitchCidr is required and must be a valid CIDR block. If VswitchAuto is set to false, VswitchId is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("VswitchAuto")]
        [Validation(Required=false)]
        public string VswitchAuto { get; set; }

        /// <summary>
        /// <para>The CIDR block of the vSwitch. This parameter is required when the automatic mode is used for the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("VswitchCidr")]
        [Validation(Required=false)]
        public string VswitchCidr { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. This parameter is required when the manual mode is used for the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1sqg9w******</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
