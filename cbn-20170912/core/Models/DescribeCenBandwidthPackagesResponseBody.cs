// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenBandwidthPackagesResponseBody : TeaModel {
        /// <summary>
        /// The details about the bandwidth plan.
        /// </summary>
        [NameInMap("CenBandwidthPackages")]
        [Validation(Required=false)]
        public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackages CenBandwidthPackages { get; set; }
        public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackages : TeaModel {
            [NameInMap("CenBandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackage> CenBandwidthPackage { get; set; }
            public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackage : TeaModel {
                /// <summary>
                /// The maximum bandwidth of the bandwidth plan.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// The billing method of the bandwidth plan.
                /// </summary>
                [NameInMap("BandwidthPackageChargeType")]
                [Validation(Required=false)]
                public string BandwidthPackageChargeType { get; set; }

                /// <summary>
                /// The status of the bandwidth plan. Valid values:
                /// 
                /// *   **Normal**: normal
                /// *   **FinancialLocked**: locked due to overdue payments
                /// *   **SecurityLocked**: locked due to security reasons
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The ID of the bandwidth plan.
                /// </summary>
                [NameInMap("CenBandwidthPackageId")]
                [Validation(Required=false)]
                public string CenBandwidthPackageId { get; set; }

                /// <summary>
                /// A list of CEN instances that are associated with the bandwidth plan.
                /// </summary>
                [NameInMap("CenIds")]
                [Validation(Required=false)]
                public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageCenIds CenIds { get; set; }
                public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageCenIds : TeaModel {
                    [NameInMap("CenId")]
                    [Validation(Required=false)]
                    public List<string> CenId { get; set; }

                }

                /// <summary>
                /// The time when the bandwidth plan was created. The time is displayed in the ISO8601 standard in the YYYY-MM-DDThh:mmZ format.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the bandwidth plan.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The timeout period of the bandwidth plan.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The ID of the area that you want to query. Valid values:
                /// 
                /// *   **china**: Chinese mainland.
                /// *   **asia-pacific**: Asia Pacific
                /// *   **europe**: Europe
                /// *   **australia**: Australia
                /// *   **north-america**: North America
                /// </summary>
                [NameInMap("GeographicRegionAId")]
                [Validation(Required=false)]
                public string GeographicRegionAId { get; set; }

                /// <summary>
                /// The ID of the other connected area of the bandwidth plan. Valid values:
                /// 
                /// *   **china**: Chinese mainland.
                /// *   **asia-pacific**: Asia Pacific
                /// *   **europe**: Europe
                /// *   **australia**: Australia
                /// *   **north-america**: North America
                /// </summary>
                [NameInMap("GeographicRegionBId")]
                [Validation(Required=false)]
                public string GeographicRegionBId { get; set; }

                /// <summary>
                /// The ID of the connected area.
                /// </summary>
                [NameInMap("GeographicSpanId")]
                [Validation(Required=false)]
                public string GeographicSpanId { get; set; }

                /// <summary>
                /// Indicates whether renewal data is included.
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// 
                /// >  This parameter returns **true** only when the **IncludeReservationData** parameter is set to **true** and an order has not taken effect.
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                /// <summary>
                /// Indicates whether the bandwidth plan is a cross-border bandwidth plan.
                /// 
                /// *   **false**: no
                /// *   **true**: yes
                /// </summary>
                [NameInMap("IsCrossBorder")]
                [Validation(Required=false)]
                public bool? IsCrossBorder { get; set; }

                /// <summary>
                /// The name of the bandwidth plan.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The details about the connected regions.
                /// </summary>
                [NameInMap("OrginInterRegionBandwidthLimits")]
                [Validation(Required=false)]
                public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimits OrginInterRegionBandwidthLimits { get; set; }
                public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimits : TeaModel {
                    [NameInMap("OrginInterRegionBandwidthLimit")]
                    [Validation(Required=false)]
                    public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimitsOrginInterRegionBandwidthLimit> OrginInterRegionBandwidthLimit { get; set; }
                    public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimitsOrginInterRegionBandwidthLimit : TeaModel {
                        /// <summary>
                        /// The maximum bandwidth value for the inter-region connection.
                        /// </summary>
                        [NameInMap("BandwidthLimit")]
                        [Validation(Required=false)]
                        public string BandwidthLimit { get; set; }

                        /// <summary>
                        /// The connected regions.
                        /// </summary>
                        [NameInMap("GeographicSpanId")]
                        [Validation(Required=false)]
                        public string GeographicSpanId { get; set; }

                        /// <summary>
                        /// The ID of the source region.
                        /// </summary>
                        [NameInMap("LocalRegionId")]
                        [Validation(Required=false)]
                        public string LocalRegionId { get; set; }

                        /// <summary>
                        /// The ID of the peer region.
                        /// </summary>
                        [NameInMap("OppositeRegionId")]
                        [Validation(Required=false)]
                        public string OppositeRegionId { get; set; }

                    }

                }

                /// <summary>
                /// The expiration time of the temporary upgrade.
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// The bandwidth value to which the bandwidth plan is rolled back when the temporary upgrade ends.
                /// </summary>
                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                /// <summary>
                /// The new billing method.
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// The renewal method.
                /// 
                /// *   **TEMP_UPGRADE**: temporary upgrade
                /// *   **UPGRADE**: upgrade
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether the bandwidth plan is associated with a CEN instance.
                /// 
                /// *   **Idle**: no
                /// *   **InUse**: yes
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageTags Tags { get; set; }
                public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageTagsTag> Tag { get; set; }
                    public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageTagsTag : TeaModel {
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
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
