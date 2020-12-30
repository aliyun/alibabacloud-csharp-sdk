// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsByTagNameAndBatchIDResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public SenderStatisticsByTagNameAndBatchIDResponseBodyData Data { get; set; }
        public class SenderStatisticsByTagNameAndBatchIDResponseBodyData : TeaModel {
            [NameInMap("stat")]
            [Validation(Required=false)]
            public List<SenderStatisticsByTagNameAndBatchIDResponseBodyDataStat> Stat { get; set; }
            public class SenderStatisticsByTagNameAndBatchIDResponseBodyDataStat : TeaModel {
                public string UnavailablePercent { get; set; }
                public string CreateTime { get; set; }
                public string SucceededPercent { get; set; }
                public string FaildCount { get; set; }
                public string UnavailableCount { get; set; }
                public string SuccessCount { get; set; }
                public string RequestCount { get; set; }
            }
        };

    }

}
