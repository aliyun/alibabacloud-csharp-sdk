/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIEarth_Meteorology20210928.Models
{
    public class GridQueryRequest : TeaModel {
        [NameInMap("element")]
        [Validation(Required=false)]
        public string Element { get; set; }

        [NameInMap("forecastTimestamp")]
        [Validation(Required=false)]
        public string ForecastTimestamp { get; set; }

        [NameInMap("latitude")]
        [Validation(Required=false)]
        public double? Latitude { get; set; }

        [NameInMap("longitude")]
        [Validation(Required=false)]
        public double? Longitude { get; set; }

        [NameInMap("pageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("reportTimestamp")]
        [Validation(Required=false)]
        public string ReportTimestamp { get; set; }

    }

}
