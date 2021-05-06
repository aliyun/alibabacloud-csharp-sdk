// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenBandwidthPackagesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("CenBandwidthPackages")]
        [Validation(Required=false)]
        public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackages CenBandwidthPackages { get; set; }
        public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackages : TeaModel {
            [NameInMap("CenBandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackage> CenBandwidthPackage { get; set; }
            public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackage : TeaModel {
                public string ReservationActiveTime { get; set; }
                public string Status { get; set; }
                public string CreationTime { get; set; }
                public string ReservationOrderType { get; set; }
                public string BandwidthPackageChargeType { get; set; }
                public string CenBandwidthPackageId { get; set; }
                public string ReservationInternetChargeType { get; set; }
                public string Ratio { get; set; }
                public string GeographicRegionAId { get; set; }
                public string TypeFor95 { get; set; }
                public long? Bandwidth { get; set; }
                public string Description { get; set; }
                public string ExpiredTime { get; set; }
                public string ReservationBandwidth { get; set; }
                public string GeographicSpanId { get; set; }
                public string GeographicRegionBId { get; set; }
                public bool? IsCrossBorder { get; set; }
                public string BusinessStatus { get; set; }
                public string Name { get; set; }
                public string HasReservationData { get; set; }
                public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimits OrginInterRegionBandwidthLimits { get; set; }
                public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimits : TeaModel {
                    [NameInMap("OrginInterRegionBandwidthLimit")]
                    [Validation(Required=false)]
                    public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimitsOrginInterRegionBandwidthLimit> OrginInterRegionBandwidthLimit { get; set; }
                    public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimitsOrginInterRegionBandwidthLimit : TeaModel {
                        [NameInMap("BandwidthLimit")]
                        [Validation(Required=false)]
                        public string BandwidthLimit { get; set; }

                        [NameInMap("OppositeRegionId")]
                        [Validation(Required=false)]
                        public string OppositeRegionId { get; set; }

                        [NameInMap("GeographicSpanId")]
                        [Validation(Required=false)]
                        public string GeographicSpanId { get; set; }

                        [NameInMap("LocalRegionId")]
                        [Validation(Required=false)]
                        public string LocalRegionId { get; set; }

                    }

                }
                public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageCenIds CenIds { get; set; }
                public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageCenIds : TeaModel {
                    [NameInMap("CenId")]
                    [Validation(Required=false)]
                    public List<string> CenId { get; set; }

                }
            }
        };

    }

}
