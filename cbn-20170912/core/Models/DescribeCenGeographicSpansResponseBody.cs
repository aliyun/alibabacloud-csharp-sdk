// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenGeographicSpansResponseBody : TeaModel {
        /// <summary>
        /// The information about area combinations.
        /// </summary>
        [NameInMap("GeographicSpanModels")]
        [Validation(Required=false)]
        public DescribeCenGeographicSpansResponseBodyGeographicSpanModels GeographicSpanModels { get; set; }
        public class DescribeCenGeographicSpansResponseBodyGeographicSpanModels : TeaModel {
            [NameInMap("GeographicSpanModel")]
            [Validation(Required=false)]
            public List<DescribeCenGeographicSpansResponseBodyGeographicSpanModelsGeographicSpanModel> GeographicSpanModel { get; set; }
            public class DescribeCenGeographicSpansResponseBodyGeographicSpanModelsGeographicSpanModel : TeaModel {
                /// <summary>
                /// The ID of the area combination.
                /// </summary>
                [NameInMap("GeographicSpanId")]
                [Validation(Required=false)]
                public string GeographicSpanId { get; set; }

                /// <summary>
                /// The ID of the local area.
                /// </summary>
                [NameInMap("LocalGeoRegionId")]
                [Validation(Required=false)]
                public string LocalGeoRegionId { get; set; }

                /// <summary>
                /// The ID of the peer area.
                /// </summary>
                [NameInMap("OppositeGeoRegionId")]
                [Validation(Required=false)]
                public string OppositeGeoRegionId { get; set; }

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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
