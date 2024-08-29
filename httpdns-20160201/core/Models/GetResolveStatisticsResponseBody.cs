// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class GetResolveStatisticsResponseBody : TeaModel {
        [NameInMap("DataPoints")]
        [Validation(Required=false)]
        public GetResolveStatisticsResponseBodyDataPoints DataPoints { get; set; }
        public class GetResolveStatisticsResponseBodyDataPoints : TeaModel {
            [NameInMap("DataPoint")]
            [Validation(Required=false)]
            public List<GetResolveStatisticsResponseBodyDataPointsDataPoint> DataPoint { get; set; }
            public class GetResolveStatisticsResponseBodyDataPointsDataPoint : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
