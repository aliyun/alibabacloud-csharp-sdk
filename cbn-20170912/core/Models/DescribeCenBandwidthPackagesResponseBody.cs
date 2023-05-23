// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenBandwidthPackagesResponseBody : TeaModel {
        /// <summary>
        /// The expiration time of the temporary upgrade.
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
                /// The ID of the bandwidth plan.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// The maximum bandwidth of the bandwidth plan.
                /// </summary>
                [NameInMap("BandwidthPackageChargeType")]
                [Validation(Required=false)]
                public string BandwidthPackageChargeType { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The ID of the connected area.
                /// </summary>
                [NameInMap("CenBandwidthPackageId")]
                [Validation(Required=false)]
                public string CenBandwidthPackageId { get; set; }

                [NameInMap("CenIds")]
                [Validation(Required=false)]
                public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageCenIds CenIds { get; set; }
                public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageCenIds : TeaModel {
                    [NameInMap("CenId")]
                    [Validation(Required=false)]
                    public List<string> CenId { get; set; }

                }

                /// <summary>
                /// The connected regions.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The timeout period of the bandwidth plan.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The new billing method.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The name of the bandwidth plan.
                /// </summary>
                [NameInMap("GeographicRegionAId")]
                [Validation(Required=false)]
                public string GeographicRegionAId { get; set; }

                /// <summary>
                /// The number of entries returned per page.
                /// </summary>
                [NameInMap("GeographicRegionBId")]
                [Validation(Required=false)]
                public string GeographicRegionBId { get; set; }

                /// <summary>
                /// The page number of the returned page.
                /// </summary>
                [NameInMap("GeographicSpanId")]
                [Validation(Required=false)]
                public string GeographicSpanId { get; set; }

                /// <summary>
                /// Queries details about Cloud Enterprise Network (CEN) bandwidth plans within the current Alibaba Cloud account.
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                /// <summary>
                /// The filter condition.
                /// 
                /// You can use filter conditions to filter the bandwidth plans that you want to query. The following filter conditions are supported:
                /// 
                /// *   **CenId**: CEN instance ID
                /// 
                /// *   **Status**: bandwidth plan status. Valid values:
                /// 
                ///     *   **Idle**: not associated with a CEN instance.
                ///     *   **InUse**: associated with a CEN instance.
                /// 
                /// *   **CenBandwidthPackageId**: bandwidth plan ID
                /// 
                /// *   **Name**: bandwidth plan name
                /// 
                ///     You can specify one or more filter conditions. The maximum value of **N** is **5**.
                /// </summary>
                [NameInMap("IsCrossBorder")]
                [Validation(Required=false)]
                public bool? IsCrossBorder { get; set; }

                /// <summary>
                /// The renewal method.
                /// 
                /// *   **TEMP_UPGRADE**: temporary upgrade
                /// *   **UPGRADE**: upgrade
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// DescribeCenBandwidthPackages
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
                        /// WB01235021
                        /// </summary>
                        [NameInMap("BandwidthLimit")]
                        [Validation(Required=false)]
                        public string BandwidthLimit { get; set; }

                        [NameInMap("GeographicSpanId")]
                        [Validation(Required=false)]
                        public string GeographicSpanId { get; set; }

                        [NameInMap("LocalRegionId")]
                        [Validation(Required=false)]
                        public string LocalRegionId { get; set; }

                        [NameInMap("OppositeRegionId")]
                        [Validation(Required=false)]
                        public string OppositeRegionId { get; set; }

                    }

                }

                /// <summary>
                /// The maximum bandwidth value for the inter-region connection.
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// The logical operator between the filter conditions. Valid values:
                /// 
                /// *   **false** (default): **AND** Bandwidth plans that meet all filter conditions are returned.
                /// *   **true**: **OR** Bandwidth plans that meet one of the filter conditions are returned.
                /// </summary>
                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                /// <summary>
                /// Indicates whether the bandwidth plan is associated with a CEN instance.
                /// 
                /// *   **Idle**: no
                /// *   **InUse**: yes
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// The number of entries to return on each page. Maximum value: **50**. Default value: **10**.
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The number of the page to return. Default value: **1**.
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
        /// A list of CEN instances that are associated with the bandwidth plan.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the source region.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the area that you want to query. Valid values:
        /// 
        /// *   **china**: Chinese mainland.
        /// *   **asia-pacific**: Asia Pacific
        /// *   **europe**: Europe
        /// *   **australia**: Australia
        /// *   **north-america**: North America
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The bandwidth value to which the bandwidth plan is rolled back when the temporary upgrade ends.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
