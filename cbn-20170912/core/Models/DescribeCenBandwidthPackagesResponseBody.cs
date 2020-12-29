// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenBandwidthPackagesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("CenBandwidthPackages")]
        [Validation(Required=false)]
        public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackages> CenBandwidthPackages { get; set; }
        public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackages : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ReservationActiveTime")]
            [Validation(Required=false)]
            public string ReservationActiveTime { get; set; }

            [NameInMap("ReservationOrderType")]
            [Validation(Required=false)]
            public string ReservationOrderType { get; set; }

            [NameInMap("BandwidthPackageChargeType")]
            [Validation(Required=false)]
            public string BandwidthPackageChargeType { get; set; }

            [NameInMap("CenBandwidthPackageId")]
            [Validation(Required=false)]
            public string CenBandwidthPackageId { get; set; }

            [NameInMap("OrginInterRegionBandwidthLimits")]
            [Validation(Required=false)]
            public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesOrginInterRegionBandwidthLimits> OrginInterRegionBandwidthLimits { get; set; }
            public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesOrginInterRegionBandwidthLimits : TeaModel {
                [NameInMap("OppositeRegionId")]
                [Validation(Required=false)]
                public string OppositeRegionId { get; set; }

                [NameInMap("GeographicSpanId")]
                [Validation(Required=false)]
                public string GeographicSpanId { get; set; }

                [NameInMap("LocalRegionId")]
                [Validation(Required=false)]
                public string LocalRegionId { get; set; }

                [NameInMap("BandwidthLimit")]
                [Validation(Required=false)]
                public string BandwidthLimit { get; set; }

            }

            [NameInMap("CenIds")]
            [Validation(Required=false)]
            public List<string> CenIds { get; set; }

            [NameInMap("GeographicRegionAId")]
            [Validation(Required=false)]
            public string GeographicRegionAId { get; set; }

            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public string Ratio { get; set; }

            [NameInMap("ReservationInternetChargeType")]
            [Validation(Required=false)]
            public string ReservationInternetChargeType { get; set; }

            [NameInMap("TypeFor95")]
            [Validation(Required=false)]
            public string TypeFor95 { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("ReservationBandwidth")]
            [Validation(Required=false)]
            public string ReservationBandwidth { get; set; }

            [NameInMap("GeographicSpanId")]
            [Validation(Required=false)]
            public string GeographicSpanId { get; set; }

            [NameInMap("GeographicRegionBId")]
            [Validation(Required=false)]
            public string GeographicRegionBId { get; set; }

            [NameInMap("IsCrossBorder")]
            [Validation(Required=false)]
            public bool? IsCrossBorder { get; set; }

            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("HasReservationData")]
            [Validation(Required=false)]
            public string HasReservationData { get; set; }

        }

    }

}
