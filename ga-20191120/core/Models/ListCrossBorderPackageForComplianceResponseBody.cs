// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCrossBorderPackageForComplianceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("BandwidthPackages")]
        [Validation(Required=false)]
        public List<ListCrossBorderPackageForComplianceResponseBodyBandwidthPackages> BandwidthPackages { get; set; }
        public class ListCrossBorderPackageForComplianceResponseBodyBandwidthPackages : TeaModel {
            [NameInMap("IsBinded")]
            [Validation(Required=false)]
            public bool? IsBinded { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("CbnGeographicRegionIdA")]
            [Validation(Required=false)]
            public string CbnGeographicRegionIdA { get; set; }

            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            [NameInMap("CbnGeographicRegionIdB")]
            [Validation(Required=false)]
            public string CbnGeographicRegionIdB { get; set; }

            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("BindTime")]
            [Validation(Required=false)]
            public long? BindTime { get; set; }

        }

    }

}
