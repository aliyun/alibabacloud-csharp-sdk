// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBandwidthPackagesResponseBody : TeaModel {
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

        [NameInMap("BandwidthPackages")]
        [Validation(Required=false)]
        public List<ListBandwidthPackagesResponseBodyBandwidthPackages> BandwidthPackages { get; set; }
        public class ListBandwidthPackagesResponseBodyBandwidthPackages : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("BandwidthType")]
            [Validation(Required=false)]
            public string BandwidthType { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("CbnGeographicRegionIdA")]
            [Validation(Required=false)]
            public string CbnGeographicRegionIdA { get; set; }

            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("Accelerators")]
            [Validation(Required=false)]
            public List<string> Accelerators { get; set; }

            [NameInMap("CbnGeographicRegionIdB")]
            [Validation(Required=false)]
            public string CbnGeographicRegionIdB { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("BillingType")]
            [Validation(Required=false)]
            public string BillingType { get; set; }

        }

    }

}
