// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsByTagNameAndBatchIDResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public SenderStatisticsByTagNameAndBatchIDResponseBodyData Data { get; set; }
        public class SenderStatisticsByTagNameAndBatchIDResponseBodyData : TeaModel {
            [NameInMap("stat")]
            [Validation(Required=false)]
            public List<SenderStatisticsByTagNameAndBatchIDResponseBodyDataStat> Stat { get; set; }
            public class SenderStatisticsByTagNameAndBatchIDResponseBodyDataStat : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("faildCount")]
                [Validation(Required=false)]
                public string FaildCount { get; set; }

                [NameInMap("requestCount")]
                [Validation(Required=false)]
                public string RequestCount { get; set; }

                [NameInMap("succeededPercent")]
                [Validation(Required=false)]
                public string SucceededPercent { get; set; }

                [NameInMap("successCount")]
                [Validation(Required=false)]
                public string SuccessCount { get; set; }

                [NameInMap("unavailableCount")]
                [Validation(Required=false)]
                public string UnavailableCount { get; set; }

                [NameInMap("unavailablePercent")]
                [Validation(Required=false)]
                public string UnavailablePercent { get; set; }

            }

        }

    }

}
