// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenGeographicSpansResponseBody : TeaModel {
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

        [NameInMap("GeographicSpanModels")]
        [Validation(Required=false)]
        public List<DescribeCenGeographicSpansResponseBodyGeographicSpanModels> GeographicSpanModels { get; set; }
        public class DescribeCenGeographicSpansResponseBodyGeographicSpanModels : TeaModel {
            [NameInMap("GeographicSpanId")]
            [Validation(Required=false)]
            public string GeographicSpanId { get; set; }

            [NameInMap("OppositeGeoRegionId")]
            [Validation(Required=false)]
            public string OppositeGeoRegionId { get; set; }

            [NameInMap("LocalGeoRegionId")]
            [Validation(Required=false)]
            public string LocalGeoRegionId { get; set; }

        }

    }

}
