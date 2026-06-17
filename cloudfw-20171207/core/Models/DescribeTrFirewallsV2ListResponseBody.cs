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
        /// <para>The list of VPC firewalls.</para>
        /// </summary>
        [NameInMap("VpcTrFirewalls")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallsV2ListResponseBodyVpcTrFirewalls> VpcTrFirewalls { get; set; }
        public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewalls : TeaModel {
            /// <summary>
            /// <para>The mode of the access control list (ACL) engine.</para>
            /// </summary>
            [NameInMap("AclConfig")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsAclConfig AclConfig { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsAclConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether the strict mode is enabled.</para>
                /// <list type="bullet">
                /// <item><description><para>1: enabled</para>
                /// </description></item>
                /// <item><description><para>0: disabled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StrictMode")]
                [Validation(Required=false)]
                public int? StrictMode { get; set; }

            }

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

            /// <summary>
            /// <para>The payer for the transit router (TR) instance that is created for the VPC firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PayByCloudFirewall</b>: Cloud Firewall</para>
            /// </description></item>
            /// <item><description><para><b>PayByCenOwner</b>: The account that owns the CEN instance</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByCenOwner</para>
            /// </summary>
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
            /// <item><description><para><b>opened</b>: Enabled</para>
            /// </description></item>
            /// <item><description><para><b>closed</b>: Disabled</para>
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
            /// <para>The configurations of the intrusion prevention system (IPS).</para>
            /// </summary>
            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsIpsConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether to enable the basic protection feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: enabled</para>
                /// </description></item>
                /// <item><description><para><b>0</b>: disabled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BasicRules")]
                [Validation(Required=false)]
                public int? BasicRules { get; set; }

                /// <summary>
                /// <para>Indicates whether to enable virtual patching. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: enabled</para>
                /// </description></item>
                /// <item><description><para><b>0</b>: disabled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EnableAllPatch")]
                [Validation(Required=false)]
                public int? EnableAllPatch { get; set; }

                /// <summary>
                /// <para>The IPS rule group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: loose</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: medium</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: strict</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RuleClass")]
                [Validation(Required=false)]
                public int? RuleClass { get; set; }

                /// <summary>
                /// <para>The IPS mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: block mode</para>
                /// </description></item>
                /// <item><description><para><b>0</b>: monitor mode</para>
                /// </description></item>
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
            /// <para>The ID of the Alibaba Cloud account that owns the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>171761785151****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>Indicates whether the VPC firewall can be automatically created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>passed</b>: The VPC firewall can be automatically created.</para>
            /// </description></item>
            /// <item><description><para><b>failed</b>: The VPC firewall cannot be automatically created.</para>
            /// </description></item>
            /// <item><description><para><b>unknown</b>: The status is unknown.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>passed</para>
            /// </summary>
            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public string PrecheckStatus { get; set; }

            /// <summary>
            /// <para>The list of protected resources.</para>
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

                /// <summary>
                /// <para>The list of protected Express Connect Router (ECR) instances.</para>
                /// </summary>
                [NameInMap("EcrList")]
                [Validation(Required=false)]
                public List<string> EcrList { get; set; }

                /// <summary>
                /// <para>The list of protected peer transit routers.</para>
                /// </summary>
                [NameInMap("PeerTrList")]
                [Validation(Required=false)]
                public List<string> PeerTrList { get; set; }

                /// <summary>
                /// <para>The list of protected virtual border routers (VBRs).</para>
                /// </summary>
                [NameInMap("VbrList")]
                [Validation(Required=false)]
                public List<string> VbrList { get; set; }

                /// <summary>
                /// <para>The list of protected VPCs.</para>
                /// </summary>
                [NameInMap("VpcList")]
                [Validation(Required=false)]
                public List<string> VpcList { get; set; }

                /// <summary>
                /// <para>The list of protected VPN gateways.</para>
                /// </summary>
                [NameInMap("VpnList")]
                [Validation(Required=false)]
                public List<string> VpnList { get; set; }

            }

            /// <summary>
            /// <para>The region ID of the transit router instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The status of the region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enable</b>: The VPC firewall is available in the region.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: The VPC firewall is not available in the region.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// <para>The result code of the operation to create the VPC firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RegionDisable</b>: The VPC firewall is not supported in the region where the network instance resides. The VPC firewall cannot be created.</para>
            /// </description></item>
            /// <item><description><para>An empty string: The VPC firewall can be created for the network instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RegionDisable</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

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
            /// <para>The instance ID of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-2vcmhjs88nil55fvu****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The list of unprotected resources.</para>
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

                /// <summary>
                /// <para>The list of unprotected Express Connect Router (ECR) instances.</para>
                /// </summary>
                [NameInMap("EcrList")]
                [Validation(Required=false)]
                public List<string> EcrList { get; set; }

                /// <summary>
                /// <para>The list of unprotected peer transit routers.</para>
                /// </summary>
                [NameInMap("PeerTrList")]
                [Validation(Required=false)]
                public List<string> PeerTrList { get; set; }

                /// <summary>
                /// <para>The list of unprotected virtual border routers (VBRs).</para>
                /// </summary>
                [NameInMap("VbrList")]
                [Validation(Required=false)]
                public List<string> VbrList { get; set; }

                /// <summary>
                /// <para>The list of unprotected VPCs.</para>
                /// </summary>
                [NameInMap("VpcList")]
                [Validation(Required=false)]
                public List<string> VpcList { get; set; }

                /// <summary>
                /// <para>The list of unprotected VPN gateways.</para>
                /// </summary>
                [NameInMap("VpnList")]
                [Validation(Required=false)]
                public List<string> VpnList { get; set; }

            }

            /// <summary>
            /// <para>The instance name of the VPC firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-firewall-test</para>
            /// </summary>
            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
