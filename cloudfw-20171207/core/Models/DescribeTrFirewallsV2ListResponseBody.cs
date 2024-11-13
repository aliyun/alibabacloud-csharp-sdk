// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2ListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1471E2EC-F706-5F11-A79B-BD583ACB8297</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The VPC firewalls.</para>
        /// </summary>
        [NameInMap("VpcTrFirewalls")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallsV2ListResponseBodyVpcTrFirewalls> VpcTrFirewalls { get; set; }
        public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewalls : TeaModel {
            /// <summary>
            /// <para>The ID of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-03f8s0z052ka3v****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The name of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen_swas</para>
            /// </summary>
            [NameInMap("CenName")]
            [Validation(Required=false)]
            public string CenName { get; set; }

            [NameInMap("CloudFirewallVpcOrderType")]
            [Validation(Required=false)]
            public string CloudFirewallVpcOrderType { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vfw-tr-99bc4f0fc88b4d00****</para>
            /// </summary>
            [NameInMap("FirewallId")]
            [Validation(Required=false)]
            public string FirewallId { get; set; }

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
            /// <para> If you do not specify this parameter, VPC firewalls in all states are queried.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>opened</para>
            /// </summary>
            [NameInMap("FirewallSwitchStatus")]
            [Validation(Required=false)]
            public string FirewallSwitchStatus { get; set; }

            /// <summary>
            /// <para>The information about the intrusion prevention system (IPS) configuration.</para>
            /// </summary>
            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsIpsConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether basic protection is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BasicRules")]
                [Validation(Required=false)]
                public int? BasicRules { get; set; }

                /// <summary>
                /// <para>Indicates whether virtual patching is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EnableAllPatch")]
                [Validation(Required=false)]
                public int? EnableAllPatch { get; set; }

                [NameInMap("RuleClass")]
                [Validation(Required=false)]
                public int? RuleClass { get; set; }

                /// <summary>
                /// <para>The mode of the IPS. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: block mode</description></item>
                /// <item><description><b>0</b>: monitor mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RunMode")]
                [Validation(Required=false)]
                public int? RunMode { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>171761785151****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>Indicates whether the VPC firewall can be automatically enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>passed</b>: yes</description></item>
            /// <item><description><b>failed</b>: no</description></item>
            /// <item><description><b>unknown</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>passed</para>
            /// </summary>
            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public string PrecheckStatus { get; set; }

            /// <summary>
            /// <para>The protected resources.</para>
            /// </summary>
            [NameInMap("ProtectedResource")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsProtectedResource ProtectedResource { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsProtectedResource : TeaModel {
                /// <summary>
                /// <para>The number of protected resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("EcrList")]
                [Validation(Required=false)]
                public List<string> EcrList { get; set; }

                /// <summary>
                /// <para>The protected peer transit routers.</para>
                /// </summary>
                [NameInMap("PeerTrList")]
                [Validation(Required=false)]
                public List<string> PeerTrList { get; set; }

                /// <summary>
                /// <para>The protected virtual border routers (VBRs).</para>
                /// </summary>
                [NameInMap("VbrList")]
                [Validation(Required=false)]
                public List<string> VbrList { get; set; }

                /// <summary>
                /// <para>The protected VPCs.</para>
                /// </summary>
                [NameInMap("VpcList")]
                [Validation(Required=false)]
                public List<string> VpcList { get; set; }

                /// <summary>
                /// <para>The protected VPN gateways.</para>
                /// </summary>
                [NameInMap("VpnList")]
                [Validation(Required=false)]
                public List<string> VpnList { get; set; }

            }

            /// <summary>
            /// <para>The region ID of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>Indicates whether you can create a VPC firewall in a specified region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enable</b>: yes</description></item>
            /// <item><description><b>disable</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// <para>The result code of the operation that creates the VPC firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RegionDisable</b>: VPC Firewall is not supported in the region of the network instance. You cannot create a VPC firewall for the network instance.</description></item>
            /// <item><description><b>Empty string</b>: You can create a VPC firewall for the network instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RegionDisable</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

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
            /// <para>The ID of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-2vcmhjs88nil55fvu****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The unprotected resources.</para>
            /// </summary>
            [NameInMap("UnprotectedResource")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsUnprotectedResource UnprotectedResource { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsUnprotectedResource : TeaModel {
                /// <summary>
                /// <para>The number of unprotected resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("EcrList")]
                [Validation(Required=false)]
                public List<string> EcrList { get; set; }

                /// <summary>
                /// <para>The unprotected peer transit routers.</para>
                /// </summary>
                [NameInMap("PeerTrList")]
                [Validation(Required=false)]
                public List<string> PeerTrList { get; set; }

                /// <summary>
                /// <para>The unprotected VBRs.</para>
                /// </summary>
                [NameInMap("VbrList")]
                [Validation(Required=false)]
                public List<string> VbrList { get; set; }

                /// <summary>
                /// <para>The unprotected VPCs.</para>
                /// </summary>
                [NameInMap("VpcList")]
                [Validation(Required=false)]
                public List<string> VpcList { get; set; }

                /// <summary>
                /// <para>The unprotected VPN gateways.</para>
                /// </summary>
                [NameInMap("VpnList")]
                [Validation(Required=false)]
                public List<string> VpnList { get; set; }

            }

            /// <summary>
            /// <para>The instance name of the VPC firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
