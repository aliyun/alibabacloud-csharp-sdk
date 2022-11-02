// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenBandwidthPackagesResponseBody : TeaModel {
        [NameInMap("CenBandwidthPackages")]
        [Validation(Required=false)]
        public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackages CenBandwidthPackages { get; set; }
        public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackages : TeaModel {
            [NameInMap("CenBandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackage> CenBandwidthPackage { get; set; }
            public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackage : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                [NameInMap("BandwidthPackageChargeType")]
                [Validation(Required=false)]
                public string BandwidthPackageChargeType { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

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

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("GeographicRegionAId")]
                [Validation(Required=false)]
                public string GeographicRegionAId { get; set; }

                [NameInMap("GeographicRegionBId")]
                [Validation(Required=false)]
                public string GeographicRegionBId { get; set; }

                [NameInMap("GeographicSpanId")]
                [Validation(Required=false)]
                public string GeographicSpanId { get; set; }

                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                [NameInMap("IsCrossBorder")]
                [Validation(Required=false)]
                public bool? IsCrossBorder { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OrginInterRegionBandwidthLimits")]
                [Validation(Required=false)]
                public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimits OrginInterRegionBandwidthLimits { get; set; }
                public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimits : TeaModel {
                    [NameInMap("OrginInterRegionBandwidthLimit")]
                    [Validation(Required=false)]
                    public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimitsOrginInterRegionBandwidthLimit> OrginInterRegionBandwidthLimit { get; set; }
                    public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimitsOrginInterRegionBandwidthLimit : TeaModel {
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

                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
