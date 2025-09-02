// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersResponseBody : TeaModel {
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
        /// <para>The number of entries per page. Valid values: <b>1 to 50</b>. Default value: <b>10</b>.</para>
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
        /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
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
        /// <para>The information about the VBR.</para>
        /// </summary>
        [NameInMap("VirtualBorderRouterSet")]
        [Validation(Required=false)]
        public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSet VirtualBorderRouterSet { get; set; }
        public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSet : TeaModel {
            [NameInMap("VirtualBorderRouterType")]
            [Validation(Required=false)]
            public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterType> VirtualBorderRouterType { get; set; }
            public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterType : TeaModel {
                /// <summary>
                /// <para>The ID of the access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-cn-kojok1x****</para>
                /// </summary>
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                /// <summary>
                /// <para>The time when the VBR was activated for the first time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-08T12:20:55</para>
                /// </summary>
                [NameInMap("ActivationTime")]
                [Validation(Required=false)]
                public string ActivationTime { get; set; }

                /// <summary>
                /// <para>The information about the Cloud Enterprise Network (CEN) instance to which the VBR is attached.</para>
                /// </summary>
                [NameInMap("AssociatedCens")]
                [Validation(Required=false)]
                public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCens AssociatedCens { get; set; }
                public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCens : TeaModel {
                    [NameInMap("AssociatedCen")]
                    [Validation(Required=false)]
                    public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCensAssociatedCen> AssociatedCen { get; set; }
                    public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCensAssociatedCen : TeaModel {
                        /// <summary>
                        /// <para>The CEN instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cen-kojok19xxx****</para>
                        /// </summary>
                        [NameInMap("CenId")]
                        [Validation(Required=false)]
                        public string CenId { get; set; }

                        /// <summary>
                        /// <para>The ID of the account to which the CEN instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1688000000000****</para>
                        /// </summary>
                        [NameInMap("CenOwnerId")]
                        [Validation(Required=false)]
                        public long? CenOwnerId { get; set; }

                        /// <summary>
                        /// <para>The status of the CEN instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Attached</b></description></item>
                        /// <item><description><b>Attaching</b></description></item>
                        /// <item><description><b>Detached</b></description></item>
                        /// <item><description><b>Detaching</b></description></item>
                        /// <item><description>If no value is returned, the VBR is not attached to a CEN instance.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Attached</para>
                        /// </summary>
                        [NameInMap("CenStatus")]
                        [Validation(Required=false)]
                        public string CenStatus { get; set; }

                    }

                }

                /// <summary>
                /// <para>The information about the Express Connect circuit that is associated with the VBR.</para>
                /// </summary>
                [NameInMap("AssociatedPhysicalConnections")]
                [Validation(Required=false)]
                public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnections AssociatedPhysicalConnections { get; set; }
                public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnections : TeaModel {
                    [NameInMap("AssociatedPhysicalConnection")]
                    [Validation(Required=false)]
                    public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnectionsAssociatedPhysicalConnection> AssociatedPhysicalConnection { get; set; }
                    public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnectionsAssociatedPhysicalConnection : TeaModel {
                        /// <summary>
                        /// <para>The circuit code of the Express Connect circuit, which is provided by the connectivity provider.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>longtel0**</para>
                        /// </summary>
                        [NameInMap("CircuitCode")]
                        [Validation(Required=false)]
                        public string CircuitCode { get; set; }

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
                        /// <para>The IPv4 address of the VBR on the Alibaba Cloud side.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.XX.XX</para>
                        /// </summary>
                        [NameInMap("LocalGatewayIp")]
                        [Validation(Required=false)]
                        public string LocalGatewayIp { get; set; }

                        /// <summary>
                        /// <para>The IPv6 address of the VBR on the Alibaba Cloud side.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2001:XXXX:3c4d:0015:0000:0000:0000:1a2b</para>
                        /// </summary>
                        [NameInMap("LocalIpv6GatewayIp")]
                        [Validation(Required=false)]
                        public string LocalIpv6GatewayIp { get; set; }

                        /// <summary>
                        /// <para>The IPv4 address of the VBR on the user side.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>116.62.XX.XX</para>
                        /// </summary>
                        [NameInMap("PeerGatewayIp")]
                        [Validation(Required=false)]
                        public string PeerGatewayIp { get; set; }

                        /// <summary>
                        /// <para>The IPv6 address of the VBR on the user side.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2001:XXXX:3c4d:0015:0000:0000:0000:1a2b</para>
                        /// </summary>
                        [NameInMap("PeerIpv6GatewayIp")]
                        [Validation(Required=false)]
                        public string PeerIpv6GatewayIp { get; set; }

                        /// <summary>
                        /// <para>The subnet mask for the IPv6 addresses on the user side and on the Alibaba Cloud side.</para>
                        /// <para>Both IPv6 addresses must belong to the same subnet.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2408:4004:cc:400::/56</para>
                        /// </summary>
                        [NameInMap("PeeringIpv6SubnetMask")]
                        [Validation(Required=false)]
                        public string PeeringIpv6SubnetMask { get; set; }

                        /// <summary>
                        /// <para>The subnet mask for the IPv4 addresses of the VBR on the user side and on the Alibaba Cloud side.</para>
                        /// <para>Both IPv4 addresses must belong to the same subnet.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>255.255.255.252</para>
                        /// </summary>
                        [NameInMap("PeeringSubnetMask")]
                        [Validation(Required=false)]
                        public string PeeringSubnetMask { get; set; }

                        /// <summary>
                        /// <para>The business status of the Express Connect circuit. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Normal:</b> The Express Connect circuit is running as normal.</description></item>
                        /// <item><description><b>FinancialLocked:</b> The Express Connect circuit is locked due to overdue payments.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Normal</para>
                        /// </summary>
                        [NameInMap("PhysicalConnectionBusinessStatus")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionBusinessStatus { get; set; }

                        /// <summary>
                        /// <para>The ID of the Express Connect circuit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pc-119mfjzm7****</para>
                        /// </summary>
                        [NameInMap("PhysicalConnectionId")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionId { get; set; }

                        /// <summary>
                        /// <para>The ID of the account to which the Express Connect circuit belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12345678****</para>
                        /// </summary>
                        [NameInMap("PhysicalConnectionOwnerUid")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionOwnerUid { get; set; }

                        /// <summary>
                        /// <para>The status of the Express Connect circuit. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Initial:</b> The application is under review.</description></item>
                        /// <item><description><b>Approved</b>: The application is approved.</description></item>
                        /// <item><description><b>Allocating</b>: The system is allocating resources.</description></item>
                        /// <item><description><b>Allocated</b>: The Express Connect circuit is under construction.</description></item>
                        /// <item><description><b>Confirmed</b>: The Express Connect circuit is to be confirmed.</description></item>
                        /// <item><description><b>Enabled</b>: The Express Connect circuit is enabled.</description></item>
                        /// <item><description><b>Rejected</b>: The application is rejected.</description></item>
                        /// <item><description><b>Canceled</b>: The application is canceled.</description></item>
                        /// <item><description><b>Allocation Failed:</b> The system failed to allocate resources.</description></item>
                        /// <item><description><b>Terminated:</b> The Express Connect circuit is disabled.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Enabled</para>
                        /// </summary>
                        [NameInMap("PhysicalConnectionStatus")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionStatus { get; set; }

                        /// <summary>
                        /// <para>The status of the VBR. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>unconfirmed</b></description></item>
                        /// <item><description><b>active:</b></description></item>
                        /// <item><description><b>terminating</b></description></item>
                        /// <item><description><b>terminated</b></description></item>
                        /// <item><description><b>recovering</b></description></item>
                        /// <item><description><b>deleting:</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>active</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The VLAN ID of the VBR.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("VlanId")]
                        [Validation(Required=false)]
                        public string VlanId { get; set; }

                        /// <summary>
                        /// <para>The ID of the VBR interface, which can be used as a next hop of a VBR route.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ri-kojok19x3j0q6k****</para>
                        /// </summary>
                        [NameInMap("VlanInterfaceId")]
                        [Validation(Required=false)]
                        public string VlanInterfaceId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The bandwidth value of the VBR. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>The circuit code of the Express Connect circuit, which is provided by the connectivity provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>longtel0****</para>
                /// </summary>
                [NameInMap("CircuitCode")]
                [Validation(Required=false)]
                public string CircuitCode { get; set; }

                /// <summary>
                /// <para>The ID of the cloud box.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cb-****</para>
                /// </summary>
                [NameInMap("CloudBoxInstanceId")]
                [Validation(Required=false)]
                public string CloudBoxInstanceId { get; set; }

                /// <summary>
                /// <para>The time when the VBR was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-08T12:20:55</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the VBR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The multiple of the detection time.</para>
                /// <para>This value indicates the maximum number of dropped packets that is allowed by the receiver when the initiator transmits packets. This value can be used to check whether the connection works as expected.</para>
                /// <para>Valid values: <b>3 to 10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DetectMultiplier")]
                [Validation(Required=false)]
                public long? DetectMultiplier { get; set; }

                /// <summary>
                /// <para>The ID of the Express Cloud Connect (ECC) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecc-h****</para>
                /// </summary>
                [NameInMap("EccId")]
                [Validation(Required=false)]
                public string EccId { get; set; }

                /// <summary>
                /// <para>The status of the ECR. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Attached</b></description></item>
                /// <item><description><b>Attaching</b></description></item>
                /// <item><description><b>Detached</b></description></item>
                /// <item><description><b>Detaching</b></description></item>
                /// <item><description>If no value is returned, the VBR is not attached to a CEN instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Attached</para>
                /// </summary>
                [NameInMap("EcrAttatchStatus")]
                [Validation(Required=false)]
                public string EcrAttatchStatus { get; set; }

                /// <summary>
                /// <para>The ID of the Express Connect Router (ECR).</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecr-7vrbqv9lcgvzqbwwkm</para>
                /// </summary>
                [NameInMap("EcrId")]
                [Validation(Required=false)]
                public string EcrId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account (primary account)  to which the ECR belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192732132151xxxx</para>
                /// </summary>
                [NameInMap("EcrOwnerId")]
                [Validation(Required=false)]
                public string EcrOwnerId { get; set; }

                /// <summary>
                /// <para>Indicates whether IPv6 is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableIpv6")]
                [Validation(Required=false)]
                public bool? EnableIpv6 { get; set; }

                /// <summary>
                /// <para>The IPv4 address of the VBR on the Alibaba Cloud side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("LocalGatewayIp")]
                [Validation(Required=false)]
                public string LocalGatewayIp { get; set; }

                /// <summary>
                /// <para>The IPv6 address of the VBR on the Alibaba Cloud side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001:XXXX:3c4d:0015:0000:0000:0000:1a2b</para>
                /// </summary>
                [NameInMap("LocalIpv6GatewayIp")]
                [Validation(Required=false)]
                public string LocalIpv6GatewayIp { get; set; }

                /// <summary>
                /// <para>The time interval to receive BFD packets. Valid values: <b>200 to 1000</b>. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("MinRxInterval")]
                [Validation(Required=false)]
                public long? MinRxInterval { get; set; }

                /// <summary>
                /// <para>The time interval to send Bidirectional Forwarding Detection (BFD) packets. Valid values: <b>200 to 1000</b>. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("MinTxInterval")]
                [Validation(Required=false)]
                public long? MinTxInterval { get; set; }

                [NameInMap("Mtu")]
                [Validation(Required=false)]
                public int? Mtu { get; set; }

                /// <summary>
                /// <para>The VBR name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The billing method of the VBR. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PrePaid:</b> subscription. If you choose this billing method, make sure that your account supports balance payments or credit payments.</description></item>
                /// <item><description><b>PostPaid:</b> pay-as-you-go.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("PConnVbrChargeType")]
                [Validation(Required=false)]
                public string PConnVbrChargeType { get; set; }

                /// <summary>
                /// <para>The time when the VBR expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-08T12:20:55</para>
                /// </summary>
                [NameInMap("PConnVbrExpireTime")]
                [Validation(Required=false)]
                public string PConnVbrExpireTime { get; set; }

                /// <summary>
                /// <para>The IPv4 address of the VBR on the user side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("PeerGatewayIp")]
                [Validation(Required=false)]
                public string PeerGatewayIp { get; set; }

                /// <summary>
                /// <para>The IPv6 address of the VBR on the user side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001:XXXX:3c4d:0015:0000:0000:0000:1a2b</para>
                /// </summary>
                [NameInMap("PeerIpv6GatewayIp")]
                [Validation(Required=false)]
                public string PeerIpv6GatewayIp { get; set; }

                /// <summary>
                /// <para>The subnet mask for the IPv6 addresses on the user side and on the Alibaba Cloud side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000:1234:0:a000::/55</para>
                /// </summary>
                [NameInMap("PeeringIpv6SubnetMask")]
                [Validation(Required=false)]
                public string PeeringIpv6SubnetMask { get; set; }

                /// <summary>
                /// <para>The subnet mask for the IPv4 addresses on the Alibaba Cloud side and on the user side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255.255.255.252</para>
                /// </summary>
                [NameInMap("PeeringSubnetMask")]
                [Validation(Required=false)]
                public string PeeringSubnetMask { get; set; }

                /// <summary>
                /// <para>The business status of the Express Connect circuit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal:</b> The Express Connect circuit is running as normal.</description></item>
                /// <item><description><b>FinancialLocked:</b> The Express Connect circuit is locked due to overdue payments.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("PhysicalConnectionBusinessStatus")]
                [Validation(Required=false)]
                public string PhysicalConnectionBusinessStatus { get; set; }

                /// <summary>
                /// <para>The ID of the Express Connect circuit to which the VBR belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-119mfjzm7x****</para>
                /// </summary>
                [NameInMap("PhysicalConnectionId")]
                [Validation(Required=false)]
                public string PhysicalConnectionId { get; set; }

                /// <summary>
                /// <para>The ID of the account to which the Express Connect circuit belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1688000000000****</para>
                /// </summary>
                [NameInMap("PhysicalConnectionOwnerUid")]
                [Validation(Required=false)]
                public string PhysicalConnectionOwnerUid { get; set; }

                /// <summary>
                /// <para>The status of the Express Connect circuit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Initial:</b> The application is under review.</description></item>
                /// <item><description><b>Approved</b>: The application is approved.</description></item>
                /// <item><description><b>Allocating</b>: The system is allocating resources.</description></item>
                /// <item><description><b>Allocated</b>: The Express Connect circuit is under construction.</description></item>
                /// <item><description><b>Confirmed</b>: The Express Connect circuit is to be confirmed.</description></item>
                /// <item><description><b>Enabled</b>: The Express Connect circuit is enabled.</description></item>
                /// <item><description><b>Rejected</b>: The application is rejected.</description></item>
                /// <item><description><b>Canceled</b>: The application is canceled.</description></item>
                /// <item><description><b>Allocation Failed:</b> The system failed to allocate resources.</description></item>
                /// <item><description><b>Terminated:</b> The Express Connect circuit is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("PhysicalConnectionStatus")]
                [Validation(Required=false)]
                public string PhysicalConnectionStatus { get; set; }

                /// <summary>
                /// <para>The last time when the status of the VBR changed from <b>terminated</b> to <b>active</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-08T12:20:55</para>
                /// </summary>
                [NameInMap("RecoveryTime")]
                [Validation(Required=false)]
                public string RecoveryTime { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.html">Resource groups</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxazb4ph6aiy****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the route table of the VBR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtb-bp1****</para>
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// <para>Indicates whether to allow service access between data centers. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> If no value is returned, service access between data centers is not allowed.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SitelinkEnable")]
                [Validation(Required=false)]
                public bool? SitelinkEnable { get; set; }

                /// <summary>
                /// <para>The status of the VBR. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>unconfirmed</b></description></item>
                /// <item><description><b>active</b></description></item>
                /// <item><description><b>terminating</b></description></item>
                /// <item><description><b>terminated</b></description></item>
                /// <item><description><b>recovering</b></description></item>
                /// <item><description><b>deleting:</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag of the resource.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeTags Tags { get; set; }
                public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeTags : TeaModel {
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeTagsTags> Tags { get; set; }
                    public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeTagsTags : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceJoshua</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The last time when the VBR was terminated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-08T12:20:55</para>
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
                /// <para>vbr-bp1jcg5cmxjbl9xgc****</para>
                /// </summary>
                [NameInMap("VbrId")]
                [Validation(Required=false)]
                public string VbrId { get; set; }

                /// <summary>
                /// <para>The VLAN ID of the VBR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public int? VlanId { get; set; }

                /// <summary>
                /// <para>The ID of the VBR interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ri-2zeo3xzyf38r4xx****</para>
                /// </summary>
                [NameInMap("VlanInterfaceId")]
                [Validation(Required=false)]
                public string VlanInterfaceId { get; set; }

            }

        }

    }

}
