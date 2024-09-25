// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C5AE8B3-A2D8-428D-A2FF-93A225C0821E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The information about VBRs.</para>
        /// </summary>
        [NameInMap("VirtualBorderRouterForPhysicalConnectionSet")]
        [Validation(Required=false)]
        public DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSet VirtualBorderRouterForPhysicalConnectionSet { get; set; }
        public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSet : TeaModel {
            [NameInMap("VirtualBorderRouterForPhysicalConnectionType")]
            [Validation(Required=false)]
            public List<DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSetVirtualBorderRouterForPhysicalConnectionType> VirtualBorderRouterForPhysicalConnectionType { get; set; }
            public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSetVirtualBorderRouterForPhysicalConnectionType : TeaModel {
                /// <summary>
                /// <para>The time when the VBR was first activated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-08T12:20:55</para>
                /// </summary>
                [NameInMap("ActivationTime")]
                [Validation(Required=false)]
                public string ActivationTime { get; set; }

                /// <summary>
                /// <para>The bandwidth of the VBR that is associated with the Express Connect circuit. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// <para>The status of the bandwidth. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Active</b></description></item>
                /// <item><description><b>Inactive</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("BandwidthStatus")]
                [Validation(Required=false)]
                public string BandwidthStatus { get; set; }

                /// <summary>
                /// <para>The circuit code of the Express Connect circuit. The circuit code is provided by the connectivity provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>longtel0**</para>
                /// </summary>
                [NameInMap("CircuitCode")]
                [Validation(Required=false)]
                public string CircuitCode { get; set; }

                /// <summary>
                /// <para>The time when the VBR was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-08T12:20:55</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The ID of the ECC instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecc-sjghe****</para>
                /// </summary>
                [NameInMap("EccId")]
                [Validation(Required=false)]
                public string EccId { get; set; }

                /// <summary>
                /// <para>Indicates whether IPv6 is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableIpv6")]
                [Validation(Required=false)]
                public bool? EnableIpv6 { get; set; }

                /// <summary>
                /// <para>The IPv4 address of the gateway device on the Alibaba Cloud side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.X</para>
                /// </summary>
                [NameInMap("LocalGatewayIp")]
                [Validation(Required=false)]
                public string LocalGatewayIp { get; set; }

                /// <summary>
                /// <para>The IPv6 address of the gateway device on the Alibaba Cloud side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6bw-uf6hcyzu65v98v3du****</para>
                /// </summary>
                [NameInMap("LocalIpv6GatewayIp")]
                [Validation(Required=false)]
                public string LocalIpv6GatewayIp { get; set; }

                /// <summary>
                /// <para>The status of the VBR associated with the Express Connect circuit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>FinancialLocked</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("PConnVbrBussinessStatus")]
                [Validation(Required=false)]
                public string PConnVbrBussinessStatus { get; set; }

                /// <summary>
                /// <para>The billing method of the VBR. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PrePaid</b>: subscription. If you choose this billing method, make sure that your Apsara Stack account supports balance payments or credit payments.</description></item>
                /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("PConnVbrChargeType")]
                [Validation(Required=false)]
                public string PConnVbrChargeType { get; set; }

                /// <summary>
                /// <para>The time when the VBR associated with the Express Connect circuit expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-10T12:20:55</para>
                /// </summary>
                [NameInMap("PConnVbrExpireTime")]
                [Validation(Required=false)]
                public string PConnVbrExpireTime { get; set; }

                /// <summary>
                /// <para>The IPv4 address of the gateway device on the user side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>162.62.XX.XX</para>
                /// </summary>
                [NameInMap("PeerGatewayIp")]
                [Validation(Required=false)]
                public string PeerGatewayIp { get; set; }

                /// <summary>
                /// <para>The IPv6 address of the gateway device on the user side.</para>
                /// <para>This parameter is required when you create a VBR for the owner of the Express Connect circuit. You can ignore this parameter when you create a VBR for another Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001:XXXX:3c4d:0015:0000:0000:0000:1a2b</para>
                /// </summary>
                [NameInMap("PeerIpv6GatewayIp")]
                [Validation(Required=false)]
                public string PeerIpv6GatewayIp { get; set; }

                /// <summary>
                /// <para>The subnet mask for the IPv6 addresses of the gateway devices on the Alibaba Cloud side and on the user side.</para>
                /// <para>The two IPv6 addresses must fall within the same subnet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2408:4004:cc:400::/56</para>
                /// </summary>
                [NameInMap("PeeringIpv6SubnetMask")]
                [Validation(Required=false)]
                public string PeeringIpv6SubnetMask { get; set; }

                /// <summary>
                /// <para>The subnet mask of the IPv4 addresses configured on the user side and Alibaba Cloud side.</para>
                /// <para>The two IPv4 addresses must fall within the same subnet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255.255.255.0</para>
                /// </summary>
                [NameInMap("PeeringSubnetMask")]
                [Validation(Required=false)]
                public string PeeringSubnetMask { get; set; }

                /// <summary>
                /// <para>The last time when the status of the VBR changed from Terminated to Active.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-08T12:20:55</para>
                /// </summary>
                [NameInMap("RecoveryTime")]
                [Validation(Required=false)]
                public string RecoveryTime { get; set; }

                /// <summary>
                /// <para>The status of the VBR. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>unconfirmed</b></description></item>
                /// <item><description><b>active</b></description></item>
                /// <item><description><b>terminating</b></description></item>
                /// <item><description><b>terminated</b></description></item>
                /// <item><description><b>recovering</b></description></item>
                /// <item><description><b>deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The last time when the VBR was disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-07T12:20:55</para>
                /// </summary>
                [NameInMap("TerminationTime")]
                [Validation(Required=false)]
                public string TerminationTime { get; set; }

                /// <summary>
                /// <para>The VBR type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pconnVBR</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The VBR ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vbr-bp16ksp61j7e0tk****</para>
                /// </summary>
                [NameInMap("VbrId")]
                [Validation(Required=false)]
                public string VbrId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the VBR belongs.</para>
                /// <para>If the owner of the VBR is the same as that of the Express Connect circuit, this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>253460731706911258</para>
                /// </summary>
                [NameInMap("VbrOwnerUid")]
                [Validation(Required=false)]
                public long? VbrOwnerUid { get; set; }

                /// <summary>
                /// <para>The VLAN ID of the VBR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678</para>
                /// </summary>
                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public int? VlanId { get; set; }

            }

        }

    }

}
