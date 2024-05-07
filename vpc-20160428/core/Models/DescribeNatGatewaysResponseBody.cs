// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNatGatewaysResponseBody : TeaModel {
        /// <summary>
        /// The details about the NAT gateway.
        /// </summary>
        [NameInMap("NatGateways")]
        [Validation(Required=false)]
        public DescribeNatGatewaysResponseBodyNatGateways NatGateways { get; set; }
        public class DescribeNatGatewaysResponseBodyNatGateways : TeaModel {
            [NameInMap("NatGateway")]
            [Validation(Required=false)]
            public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGateway> NatGateway { get; set; }
            public class DescribeNatGatewaysResponseBodyNatGatewaysNatGateway : TeaModel {
                /// <summary>
                /// Indicates whether automatic payment is enabled. Valid values:
                /// 
                /// *   **false**: no
                /// *   **true**: yes
                /// </summary>
                [NameInMap("AutoPay")]
                [Validation(Required=false)]
                public bool? AutoPay { get; set; }

                /// <summary>
                /// The status of the NAT gateway. Valid values:
                /// 
                /// *   **Normal**: normal
                /// *   **FinancialLocked**: locked due to overdue payments
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The time when the NAT gateway was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// Indicates whether the deletion protection feature is enabled. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// The description of the NAT gateway.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates whether the traffic monitoring feature is enabled. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("EcsMetricEnabled")]
                [Validation(Required=false)]
                public bool? EcsMetricEnabled { get; set; }

                /// <summary>
                /// The mode in which the NAT gateway is associated with an elastic IP address (EIP). Valid values:
                /// 
                /// *   **MULTI_BINDED**: multi-EIP-to-ENI mode
                /// *   **NAT**: NAT mode, which is compatible with IPv4 addresses.
                /// 
                /// >  Note: If you use the NAT mode, the EIP occupies one private IP address on the vSwitch of the NAT gateway. Make sure that the vSwitch has sufficient private IP addresses. Otherwise, the NAT gateway fails to be associated with the EIP. In NAT mode, you can associate a NAT gateway with up to 50 EIPs.
                /// </summary>
                [NameInMap("EipBindMode")]
                [Validation(Required=false)]
                public string EipBindMode { get; set; }

                [NameInMap("EnableSessionLog")]
                [Validation(Required=false)]
                public string EnableSessionLog { get; set; }

                /// <summary>
                /// The time when the NAT gateway expires.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The ID of the DNAT table.
                /// </summary>
                [NameInMap("ForwardTableIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds ForwardTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds : TeaModel {
                    [NameInMap("ForwardTableId")]
                    [Validation(Required=false)]
                    public List<string> ForwardTableId { get; set; }

                }

                /// <summary>
                /// The ID of the FULLNAT table.
                /// </summary>
                [NameInMap("FullNatTableIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayFullNatTableIds FullNatTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayFullNatTableIds : TeaModel {
                    [NameInMap("FullNatTableId")]
                    [Validation(Required=false)]
                    public List<string> FullNatTableId { get; set; }

                }

                /// <summary>
                /// Indicates whether the ICMP non-retrieval feature is enabled. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("IcmpReplyEnabled")]
                [Validation(Required=false)]
                public bool? IcmpReplyEnabled { get; set; }

                /// <summary>
                /// The billing method of the NAT gateway. The value is set to **PostPaid**, which indicates the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The metering method of the NAT gateway. Valid values:
                /// 
                /// *   **PayBySpec**: pay-by-specification
                /// *   **PayByLcu**: pay-by-CU
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// The list of elastic IP addresses (EIPs) that are associated with the Internet NAT gateway.
                /// </summary>
                [NameInMap("IpLists")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpLists IpLists { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpLists : TeaModel {
                    [NameInMap("IpList")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpListsIpList> IpList { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpListsIpList : TeaModel {
                        /// <summary>
                        /// The ID of the EIP associated with the NAT gateway.
                        /// </summary>
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        /// <summary>
                        /// The IP address of the EIP associated with the NAT gateway.
                        /// </summary>
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                        /// <summary>
                        /// The private IP address of the NAT gateway.
                        /// </summary>
                        [NameInMap("PrivateIpAddress")]
                        [Validation(Required=false)]
                        public string PrivateIpAddress { get; set; }

                        /// <summary>
                        /// Indicates whether IP addresses that are used in DNAT entries can be specified in SNAT entries. Valid values:
                        /// 
                        /// *   **true**: yes
                        /// *   **false**: no
                        /// </summary>
                        [NameInMap("SnatEntryEnabled")]
                        [Validation(Required=false)]
                        public bool? SnatEntryEnabled { get; set; }

                        /// <summary>
                        /// The association between the EIP and the Internet NAT gateway. Valid values:
                        /// 
                        /// *   **UsedByForwardTable**: The EIP is specified in a DNAT entry.
                        /// *   **UsedBySnatTable**: The EIP is specified in an SNAT entry.
                        /// *   **UsedByForwardSnatTable**: The EIP is specified in both an SNAT entry and a DNAT entry.
                        /// *   **Idle**: The EIP is not specified in a DNAT or SNAT entry.
                        /// </summary>
                        [NameInMap("UsingStatus")]
                        [Validation(Required=false)]
                        public string UsingStatus { get; set; }

                    }

                }

                /// <summary>
                /// The name of the NAT gateway.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the NAT gateway.
                /// </summary>
                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                /// <summary>
                /// The private network information about the enhanced Internet NAT gateway.
                /// 
                /// >  If **NatType** is set to **Normal**, all parameters returned in this list are empty.
                /// </summary>
                [NameInMap("NatGatewayPrivateInfo")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayNatGatewayPrivateInfo NatGatewayPrivateInfo { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayNatGatewayPrivateInfo : TeaModel {
                    /// <summary>
                    /// The ID of the elastic network interface (ENI).
                    /// </summary>
                    [NameInMap("EniInstanceId")]
                    [Validation(Required=false)]
                    public string EniInstanceId { get; set; }

                    /// <summary>
                    /// The mode in which the ENI is associated with the NAT gateway.
                    /// 
                    /// *   **indirect**: non-cut-through mode
                    /// *   If an empty value is returned, it indicates that the cut-through mode is used.
                    /// </summary>
                    [NameInMap("EniType")]
                    [Validation(Required=false)]
                    public string EniType { get; set; }

                    /// <summary>
                    /// The zone to which the NAT gateway belongs.
                    /// </summary>
                    [NameInMap("IzNo")]
                    [Validation(Required=false)]
                    public string IzNo { get; set; }

                    /// <summary>
                    /// The maximum bandwidth. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("MaxBandwidth")]
                    [Validation(Required=false)]
                    public int? MaxBandwidth { get; set; }

                    /// <summary>
                    /// The number of new connections to the NAT gateway. Unit: connections per second.
                    /// </summary>
                    [NameInMap("MaxSessionEstablishRate")]
                    [Validation(Required=false)]
                    public int? MaxSessionEstablishRate { get; set; }

                    /// <summary>
                    /// The number of concurrent connections to the NAT gateway. Unit: connections.
                    /// </summary>
                    [NameInMap("MaxSessionQuota")]
                    [Validation(Required=false)]
                    public int? MaxSessionQuota { get; set; }

                    /// <summary>
                    /// The private IP address.
                    /// </summary>
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    /// <summary>
                    /// The ID of the vSwitch to which the NAT gateway belongs.
                    /// </summary>
                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }

                /// <summary>
                /// The type of the NAT gateway. The value is set to **Enhanced** (enhanced NAT gateway).
                /// </summary>
                [NameInMap("NatType")]
                [Validation(Required=false)]
                public string NatType { get; set; }

                /// <summary>
                /// The type of NAT gateway. Valid values:
                /// 
                /// *   **internet**: an Internet NAT gateway
                /// *   **intranet**: a VPC NAT gateway
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// Indicates whether the NAT gateway supports PrivateLink. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("PrivateLinkEnabled")]
                [Validation(Required=false)]
                public bool? PrivateLinkEnabled { get; set; }

                /// <summary>
                /// The mode that is used by PrivateLink. Valid values:
                /// 
                /// *   **FullNat**: the FULLNAT mode
                /// *   **Geneve**: the GENEVE mode
                /// </summary>
                [NameInMap("PrivateLinkMode")]
                [Validation(Required=false)]
                public string PrivateLinkMode { get; set; }

                /// <summary>
                /// The ID of the region where the NAT gateway is deployed.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the contiguous EIP group belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether the firewall feature is enabled. Valid values:
                /// 
                /// *   **false**: no
                /// *   **true**: yes
                /// </summary>
                [NameInMap("SecurityProtectionEnabled")]
                [Validation(Required=false)]
                public bool? SecurityProtectionEnabled { get; set; }

                /// <summary>
                /// The ID of the SNAT table of the NAT gateway.
                /// </summary>
                [NameInMap("SnatTableIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewaySnatTableIds SnatTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewaySnatTableIds : TeaModel {
                    [NameInMap("SnatTableId")]
                    [Validation(Required=false)]
                    public List<string> SnatTableId { get; set; }

                }

                /// <summary>
                /// The size of the NAT gateway. An empty value is returned for the parameter.
                /// 
                /// If **InternetChargeType** is set to **PayByLcu**, an empty value is returned.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The status of the NAT gateway. Valid values:
                /// 
                /// *   **Creating**: After you send a request to create a NAT gateway, the system creates the NAT gateway in the background. The NAT gateway remains in the Creating state until the operation is completed.
                /// *   **Available**: The NAT gateway remains in a stable state after the NAT gateway is created.
                /// *   **Modifying**: After you send a request to modify a NAT gateway, the system modifies the NAT gateway in the background. The NAT gateway remains in the Modifying state until the operation is completed.
                /// *   **Deleting**: After you send a request to delete a NAT gateway, the system deletes the NAT gateway in the background. The NAT gateway remains in the Deleting state until the operation is completed.
                /// *   **Converting**: After you send a request to upgrade a standard NAT gateway to an enhanced NAT gateway, the system upgrades the NAT gateway in the background. The NAT gateway remains in the Converting state until the operation is completed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags that are added to the resource group.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTags Tags { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTagsTag> Tag { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the instance.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value of the instance.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the VPC where the NAT gateway is deployed.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of NAT gateway entries that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
