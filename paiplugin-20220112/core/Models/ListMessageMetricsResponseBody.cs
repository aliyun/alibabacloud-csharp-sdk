// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListMessageMetricsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMessageMetricsResponseBodyData Data { get; set; }
        public class ListMessageMetricsResponseBodyData : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<ListMessageMetricsResponseBodyDataMetrics> Metrics { get; set; }
            public class ListMessageMetricsResponseBodyDataMetrics : TeaModel {
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("Fail")]
                [Validation(Required=false)]
                public int? Fail { get; set; }

                [NameInMap("Pending")]
                [Validation(Required=false)]
                public int? Pending { get; set; }

                [NameInMap("Rate")]
                [Validation(Required=false)]
                public float? Rate { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public int? Success { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
