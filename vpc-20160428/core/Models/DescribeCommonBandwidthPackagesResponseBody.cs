// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeCommonBandwidthPackagesResponseBody : TeaModel {
        /// <summary>
        /// The details of the Internet Shared Bandwidth instance.
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
                /// The maximum bandwidth of the Internet Shared Bandwidth instance. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// The ID of the Internet Shared Bandwidth instance.
                /// </summary>
                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                /// <summary>
                /// The service type of the Internet Shared Bandwidth instance. Valid values:
                /// 
                /// *   **CloudBox** The cloud box. Only cloud box users can select this type.
                /// *   **Default** (default): The general service type.
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// The service status of the Internet Shared Bandwidth instance. Valid values:
                /// 
                /// *   **Normal**: The Internet Shared Bandwidth instance runs as expected.
                /// *   **FinancialLocked**: An overdue payment occurs in the Internet Shared Bandwidth instance
                /// *   **Unactivated**: The Internet Shared Bandwidth instance is not activated.
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The time when the Internet Shared Bandwidth instance was created. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

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
                /// The description of the Internet Shared Bandwidth instance.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the Internet Shared Bandwidth instance expired. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// Indicates whether the information about pending orders is returned. Valid values:
                /// 
                /// *   **false**
                /// *   **true**
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                /// <summary>
                /// The line type. Valid values:
                /// 
                /// *   **BGP**: BGP (Multi-ISP) line The BGP (Multi-ISP) line is supported in all regions.
                /// *   **BGP_PRO**: BGP (Multi-ISP) Pro line The BGP (Multi-ISP) Pro line is supported in the China (Hong Kong), Singapore (Singapore), Japan (Tokyo), Philippines (Manila), Malaysia (Kuala Lumpur), Indonesia (Jakarta), and Thailand (Bangkok) regions.
                /// 
                /// If you are allowed to use single-ISP bandwidth, one of the following values is returned:
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
                /// The billing method of the Internet Shared Bandwidth instance. Valid value:
                /// 
                /// **PostPaid**: pay-as-you-go
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The metering method of the Internet Shared Bandwidth instance. Valid value:
                /// 
                /// **PayByTraffic**
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// The name of the Internet Shared Bandwidth instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The elastic IP addresses (EIPs) that are associated with the Internet Shared Bandwidth instance.
                /// </summary>
                [NameInMap("PublicIpAddresses")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddresse")]
                    [Validation(Required=false)]
                    public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddressesPublicIpAddresse> PublicIpAddresse { get; set; }
                    public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddressesPublicIpAddresse : TeaModel {
                        /// <summary>
                        /// The ID of the EIP.
                        /// </summary>
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        /// <summary>
                        /// Indicates whether the EIP is associated with the Internet Shared Bandwidth instance. Valid values:
                        /// 
                        /// *   **BINDED**
                        /// *   **BINDING**
                        /// </summary>
                        [NameInMap("BandwidthPackageIpRelationStatus")]
                        [Validation(Required=false)]
                        public string BandwidthPackageIpRelationStatus { get; set; }

                        /// <summary>
                        /// The public IP address.
                        /// </summary>
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                    }

                }

                /// <summary>
                /// The percentage of the minimum bandwidth commitment. Only **20** is returned.
                /// 
                /// >  This parameter is supported only on the Alibaba Cloud China site.
                /// </summary>
                [NameInMap("Ratio")]
                [Validation(Required=false)]
                public int? Ratio { get; set; }

                /// <summary>
                /// The ID of the region where the Internet Shared Bandwidth instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The time when the renewal took effect. The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// The new maximum bandwidth after the configurations are changed. Unit: Mbit/s.
                /// </summary>
                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                /// <summary>
                /// The metering method after the configurations are changed. Valid value:
                /// 
                /// **PayByTraffic**
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// The renewal method. Valid values:
                /// 
                /// *   **RENEWCHANGE**: renewal with a specification change
                /// *   **TEMP_UPGRADE**: renewal with a temporary upgrade
                /// *   **UPGRADE**: renewal with an upgrade
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
                /// The editions of Anti-DDoS.
                /// 
                /// *   If this parameter is empty, Anti-DDoS Origin Basic is enabled.
                /// *   If **AntiDDoS_Enhanced** is returned, Anti-DDoS Pro/Premium is enabled.
                /// </summary>
                [NameInMap("SecurityProtectionTypes")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageSecurityProtectionTypes SecurityProtectionTypes { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageSecurityProtectionTypes : TeaModel {
                    [NameInMap("SecurityProtectionType")]
                    [Validation(Required=false)]
                    public List<string> SecurityProtectionType { get; set; }

                }

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
                /// The status of the Internet Shared Bandwidth instance. Valid values:
                /// 
                /// *   **Available**: The Internet Shared Bandwidth instance is available.
                /// *   **Modifying**: The Internet Shared Bandwidth instance is being modified.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tag that is added to the Internet Shared Bandwidth instance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTags Tags { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTagsTag> Tag { get; set; }
                    public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key that is added to the Internet Shared Bandwidth instance.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value that is added to the Internet Shared Bandwidth instance.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The zone of the Internet Shared Bandwidth instance. This parameter is returned only when BizType is set to CloudBox. If BizType is set to Default, an empty value is returned.
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
