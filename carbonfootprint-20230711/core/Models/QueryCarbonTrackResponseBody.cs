// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CarbonFootprint20230711.Models
{
    public class QueryCarbonTrackResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCarbonTrackResponseBodyData> Data { get; set; }
        public class QueryCarbonTrackResponseBodyData : TeaModel {
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public double? QuotaValue { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("StatisticsDate")]
            [Validation(Required=false)]
            public long? StatisticsDate { get; set; }

            [NameInMap("SubUid")]
            [Validation(Required=false)]
            public string SubUid { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
