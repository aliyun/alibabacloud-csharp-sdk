// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaUsageResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetQuotaUsageResponseBodyData Data { get; set; }
        public class GetQuotaUsageResponseBodyData : TeaModel {
            [NameInMap("metrics")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metrics { get; set; }

            [NameInMap("plot")]
            [Validation(Required=false)]
            public List<GetQuotaUsageResponseBodyDataPlot> Plot { get; set; }
            public class GetQuotaUsageResponseBodyDataPlot : TeaModel {
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("yAxis")]
                [Validation(Required=false)]
                public List<string> YAxis { get; set; }

            }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
