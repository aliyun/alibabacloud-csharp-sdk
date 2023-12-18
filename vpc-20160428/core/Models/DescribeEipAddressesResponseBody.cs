// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipAddressesResponseBody : TeaModel {
        /// <summary>
        /// The details about the EIPs.
        /// </summary>
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public DescribeEipAddressesResponseBodyEipAddresses EipAddresses { get; set; }
        public class DescribeEipAddressesResponseBodyEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public List<DescribeEipAddressesResponseBodyEipAddressesEipAddress> EipAddress { get; set; }
            public class DescribeEipAddressesResponseBodyEipAddressesEipAddress : TeaModel {
                /// <summary>
                /// The ID of the EIP.
                /// </summary>
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                /// <summary>
                /// The time when the EIP was created. The time follows the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("AllocationTime")]
                [Validation(Required=false)]
                public string AllocationTime { get; set; }

                /// <summary>
                /// The maximum bandwidth of the EIP. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// The maximum bandwidth of the Internet Shared Bandwidth instance with which the EIP is associated. Unit: Mbit/s.
                /// </summary>
                [NameInMap("BandwidthPackageBandwidth")]
                [Validation(Required=false)]
                public string BandwidthPackageBandwidth { get; set; }

                /// <summary>
                /// The ID of the Internet Shared Bandwidth instance.
                /// </summary>
                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                /// <summary>
                /// The type of the bandwidth. Only **CommonBandwidthPackage** may be returned, which indicates Internet Shared Bandwidth.
                /// </summary>
                [NameInMap("BandwidthPackageType")]
                [Validation(Required=false)]
                public string BandwidthPackageType { get; set; }

                /// <summary>
                /// The service type. Valid values:
                /// 
                /// *   **CloudBox** Only cloud box users can select this type.
                /// *   **Default** (default)
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// The service state of the EIP. Valid values:
                /// 
                /// *   **Normal**
                /// *   **FinancialLocked**
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The billing method of the EIP. Valid values:
                /// 
                /// *   **PostPaid**: pay-as-you-go.
                /// *   **PrePaid**: subscription.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// Indicates whether deletion protection is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// The description of the EIP.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The maximum bandwidth of the EIP when it is not associated with an Internet Shared Bandwidth instance. Unit: Mbit/s.
                /// </summary>
                [NameInMap("EipBandwidth")]
                [Validation(Required=false)]
                public string EipBandwidth { get; set; }

                /// <summary>
                /// The time when the EIP expires. The time follows the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// Indicates whether fine-grained monitoring is enabled for the EIP. Valid values:
                /// 
                /// *   **false**
                /// *   **true**
                /// </summary>
                [NameInMap("HDMonitorStatus")]
                [Validation(Required=false)]
                public string HDMonitorStatus { get; set; }

                /// <summary>
                /// Indicates whether renewal data is included. Valid values:
                /// 
                /// *   **false**
                /// *   **true** A value of **true** is returned only when **IncludeReservationData** is set to **true** and some orders have not taken effect.
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                /// <summary>
                /// The line type. Valid values:
                /// 
                /// *   **BGP**: BGP (Multi-ISP) lines. All regions support BGP (Multi-ISP) EIPs.
                /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines. Only the following regions support BGP (Multi-ISP) Pro lines: China (Hong Kong), Singapore, Japan (Tokyo), Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok).
                /// 
                /// For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see the [Line types](~~32321~~) section of the "What is EIP?" topic.
                /// 
                /// If you are allowed to use single-ISP bandwidth, one of the following values may be returned:
                /// 
                /// *   **ChinaTelecom**
                /// *   **ChinaUnicom**
                /// *   **ChinaMobile**
                /// *   **ChinaTelecom_L2**
                /// *   **ChinaUnicom_L2**
                /// *   **ChinaMobile_L2**
                /// 
                /// If your services are deployed in China East 1 Finance, **BGP_FinanceCloud** is returned.
                /// </summary>
                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                /// <summary>
                /// The ID of the associated instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The region ID of the associated instance.
                /// </summary>
                [NameInMap("InstanceRegionId")]
                [Validation(Required=false)]
                public string InstanceRegionId { get; set; }

                /// <summary>
                /// The type of the associated instance. Valid values:
                /// 
                /// *   **EcsInstance**: an ECS instance in a VPC.
                /// *   **SlbInstance**: an SLB instance in a VPC.
                /// *   **Nat**: a NAT gateway.
                /// *   **HaVip**: an HAVIP.
                /// *   **NetworkInterface**: a secondary ENI.
                /// *   **IpAddress**: an IP address.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The metering method of the EIP. Valid values:
                /// 
                /// *   **PayByBandwidth**: pay-by-bandwidth.
                /// *   **PayByTraffic**: pay-by-traffic.
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// The EIP.
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The name of the EIP.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The network type. Only **public** may be returned.
                /// </summary>
                [NameInMap("Netmode")]
                [Validation(Required=false)]
                public string Netmode { get; set; }

                /// <summary>
                /// The details about the locked EIP.
                /// </summary>
                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocks OperationLocks { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocks : TeaModel {
                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public List<DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocksLockReason> LockReason { get; set; }
                    public class DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocksLockReason : TeaModel {
                        /// <summary>
                        /// The reason why the EIP is locked. Valid values:
                        /// 
                        /// *   **financial**: The EIP is locked due to overdue payments.
                        /// *   **security**: The EIP is locked for security reasons.
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

                /// <summary>
                /// The ID of the IP address pool to which the EIP belongs.
                /// </summary>
                [NameInMap("PublicIpAddressPoolId")]
                [Validation(Required=false)]
                public string PublicIpAddressPoolId { get; set; }

                /// <summary>
                /// The region ID of the EIP.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The time when the renewal took effect. The time follows the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// The maximum bandwidth after the renewal takes effect. Unit: Mbit/s.
                /// </summary>
                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                /// <summary>
                /// The metering method that is used after the renewal takes effect. Valid values:
                /// 
                /// *   **PayByBandwidth**: pay-by-bandwidth.
                /// *   **PayByTraffic**: pay-by-traffic.
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// The type of the renewal order. Valid values:
                /// 
                /// *   **RENEWCHANGE**: renewal with an upgrade or a downgrade.
                /// *   **TEMP_UPGRADE**: temporary upgrade.
                /// *   **UPGRADE**: upgrade.
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether level-2 throttling is configured. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("SecondLimited")]
                [Validation(Required=false)]
                public bool? SecondLimited { get; set; }

                /// <summary>
                /// The edition of Anti-DDoS.
                /// 
                /// *   If an empty value is returned, it indicates that Anti-DDoS Origin Basic is used.
                /// *   If **AntiDDoS_Enhanced** is returned, it indicates that Anti-DDoS Pro/Premium is used.
                /// </summary>
                [NameInMap("SecurityProtectionTypes")]
                [Validation(Required=false)]
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressSecurityProtectionTypes SecurityProtectionTypes { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressSecurityProtectionTypes : TeaModel {
                    [NameInMap("SecurityProtectionType")]
                    [Validation(Required=false)]
                    public List<string> SecurityProtectionType { get; set; }

                }

                /// <summary>
                /// The ID of the contiguous EIP group.
                /// 
                /// This value is returned only when you query contiguous EIPs.
                /// </summary>
                [NameInMap("SegmentInstanceId")]
                [Validation(Required=false)]
                public string SegmentInstanceId { get; set; }

                /// <summary>
                /// Indicates whether the resource is created by the service account. Valid values:
                /// 
                /// *   **0**: The resource is not created by the service account.
                /// *   **1**: The resource is created by the service account.
                /// </summary>
                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public int? ServiceManaged { get; set; }

                /// <summary>
                /// The state of the EIP. Valid values:
                /// 
                /// *   **Associating**
                /// *   **Unassociating**
                /// *   **InUse**
                /// *   **Available**
                /// *   **Releasing**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags of the EIP.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressTags Tags { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeEipAddressesResponseBodyEipAddressesEipAddressTagsTag> Tag { get; set; }
                    public class DescribeEipAddressesResponseBodyEipAddressesEipAddressTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the EIP.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value of the EIP.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the VPC in which an IPv4 gateway is created and that is deployed in the same region as the EIP.
                /// 
                /// When you associate an EIP with an IP address, the system can enable the IP address to access the Internet based on VPC route configurations.
                /// 
                /// >  This parameter is returned if the value of **InstanceType** is **IpAddress**. In this case, the EIP is associated with an IP address.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone of the EIP.
                /// 
                /// This parameter is returned only when the service type is CloudBox.
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
