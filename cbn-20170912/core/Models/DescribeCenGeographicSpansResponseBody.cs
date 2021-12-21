// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenGeographicSpansResponseBody : TeaModel {
        [NameInMap("GeographicSpanModels")]
        [Validation(Required=false)]
        public DescribeCenGeographicSpansResponseBodyGeographicSpanModels GeographicSpanModels { get; set; }
        public class DescribeCenGeographicSpansResponseBodyGeographicSpanModels : TeaModel {
            [NameInMap("GeographicSpanModel")]
            [Validation(Required=false)]
            public List<DescribeCenGeographicSpansResponseBodyGeographicSpanModelsGeographicSpanModel> GeographicSpanModel { get; set; }
            public class DescribeCenGeographicSpansResponseBodyGeographicSpanModelsGeographicSpanModel : TeaModel {
                public string GeographicSpanId { get; set; }
                public string LocalGeoRegionId { get; set; }
                public string OppositeGeoRegionId { get; set; }
            }
        };

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
