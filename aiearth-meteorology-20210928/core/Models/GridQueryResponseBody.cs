// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIEarth_Meteorology20210928.Models
{
    public class GridQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public GridQueryResponseBodyModule Module { get; set; }
        public class GridQueryResponseBodyModule : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<GridQueryResponseBodyModuleList> List { get; set; }
            public class GridQueryResponseBodyModuleList : TeaModel {
                [NameInMap("dataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("element")]
                [Validation(Required=false)]
                public string Element { get; set; }

                [NameInMap("elementUnit")]
                [Validation(Required=false)]
                public string ElementUnit { get; set; }

                [NameInMap("forecastTimestamp")]
                [Validation(Required=false)]
                public string ForecastTimestamp { get; set; }

                [NameInMap("latitude")]
                [Validation(Required=false)]
                public double? Latitude { get; set; }

                [NameInMap("longitude")]
                [Validation(Required=false)]
                public double? Longitude { get; set; }

                [NameInMap("reportTimestamp")]
                [Validation(Required=false)]
                public string ReportTimestamp { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            [NameInMap("pageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
