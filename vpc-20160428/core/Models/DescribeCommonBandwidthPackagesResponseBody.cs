// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeCommonBandwidthPackagesResponseBody : TeaModel {
        /// <summary>
        /// The time when the EIP bandwidth plan was created. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format.
        /// </summary>
        [NameInMap("CommonBandwidthPackages")]
        [Validation(Required=false)]
        public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackages CommonBandwidthPackages { get; set; }
        public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackages : TeaModel {
            [NameInMap("CommonBandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackage> CommonBandwidthPackage { get; set; }
            public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackage : TeaModel {
                /// <summary>
                /// The new maximum bandwidth. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// The description of the EIP bandwidth plan.
                /// </summary>
                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                /// <summary>
                /// Indicates whether the information about pending orders was returned.
                /// 
                /// *   **false**: The information about pending orders was not returned.
                /// *   **true**: The information about pending orders was returned.
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The new metering method.
                /// 
                /// **PayByTraffic**: the pay-by-data-transfer metering method
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The billing method of the EIP bandwidth plan.
                /// 
                /// **PostPaid**: the pay-as-you-go billing method
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The metering method of the EIP bandwidth plan.
                /// 
                /// **PayByTraffic**: the pay-by-data-transfer metering method.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The ID of the EIP.
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                /// <summary>
                /// The public IP address.
                /// </summary>
                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                /// <summary>
                /// Indicates whether the EIP bandwidth plan was created by the service account.
                /// 
                /// *   **0**: The EIP bandwidth plan was not created by the service account.
                /// *   **1**: The EIP bandwidth plan was created by the service account.
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The line type.
                /// 
                /// *   **BGP**: BGP (Multi-ISP) lines. BGP (Multi-ISP) lines are available in all regions.
                /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines. BGP (Multi-ISP) Pro lines are available only in the China (Hong Kong), Singapore, Philippines (Manila), Malaysia (Kuala Lumpur), Indonesia (Jakarta), and Thailand (Bangkok) regions.
                /// 
                /// If you are allowed to use single-ISP bandwidth, one of the following values is returned:
                /// 
                /// *   **ChinaTelecom**: China Telecom
                /// *   **ChinaUnicom**: China Unicom
                /// *   **ChinaMobile**: China Mobile
                /// *   **ChinaTelecom_L2**: China Telecom L2
                /// *   **ChinaUnicom_L2**: China Unicom L2
                /// *   **ChinaMobile_L2**: China Mobile L2
                /// 
                /// If your services are deployed in China East 1 Finance, **BGP_FinanceCloud** is returned.
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// The elastic IP addresses (EIPs) associated with the EIP bandwidth plan.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Indicates whether the EIP is associated with the EIP bandwidth plan.
                /// 
                /// *   **BINDED**: The EIP is associated with the EIP bandwidth plan.
                /// *   **BINDING**: The EIP is being associated with the EIP bandwidth plan.
                /// </summary>
                [NameInMap("PublicIpAddresses")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddresse")]
                    [Validation(Required=false)]
                    public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddressesPublicIpAddresse> PublicIpAddresse { get; set; }
                    public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddressesPublicIpAddresse : TeaModel {
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        [NameInMap("BandwidthPackageIpRelationStatus")]
                        [Validation(Required=false)]
                        public string BandwidthPackageIpRelationStatus { get; set; }

                        /// <summary>
                        /// The edition of Anti-DDoS. 
                        /// 
                        /// - If this parameter is empty, it indicates that Anti-DDoS Origin Basic was enabled.
                        /// - If **AntiDDoS_Enhanced** is returned, it indicates that Anti-DDoS Pro/Premium was enabled.
                        /// </summary>
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the EIP bandwidth plan.
                /// </summary>
                [NameInMap("Ratio")]
                [Validation(Required=false)]
                public int? Ratio { get; set; }

                /// <summary>
                /// The maximum bandwidth of the EIP bandwidth plan. Unit: Mbit/s.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The renewal method.
                /// 
                /// *   **RENEWCHANGE**: renewal with an upgrade or a downgrade
                /// *   **TEMP_UPGRADE**: temporary upgrade
                /// *   **UPGRADE**: upgrade
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// The service state of the EIP bandwidth plan.
                /// 
                /// *   **Normal**: The EIP bandwidth plan works as expected.
                /// *   **FinancialLocked**: The EIP bandwidth plan has an overdue payment.
                /// *   **Unactivated**: The EIP bandwidth plan is not activated.
                /// </summary>
                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                /// <summary>
                /// The region ID of the EIP bandwidth plan.
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// The percentage of the minimum bandwidth commitment. **20** is returned.
                /// 
                /// >  This parameter is available only on the Alibaba Cloud China site.
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                /// <summary>
                /// The name of the EIP bandwidth plan.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecurityProtectionTypes")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageSecurityProtectionTypes SecurityProtectionTypes { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageSecurityProtectionTypes : TeaModel {
                    [NameInMap("SecurityProtectionType")]
                    [Validation(Required=false)]
                    public List<string> SecurityProtectionType { get; set; }

                }

                /// <summary>
                /// The time when the EIP bandwidth plan expired. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public int? ServiceManaged { get; set; }

                /// <summary>
                /// Indicates whether deletion protection was enabled.
                /// 
                /// *   **true**: Deletion protection was enabled.
                /// *   **false**: Deletion protection was disabled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTags Tags { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTagsTag> Tag { get; set; }
                    public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The time when the renewal took effect. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The details of the EIP bandwidth plan.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the EIP bandwidth plan. Valid values:
        /// 
        /// *   **Available**: The EIP bandwidth plan is available.
        /// *   **Modifying**: The EIP bandwidth plan is being modified.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
