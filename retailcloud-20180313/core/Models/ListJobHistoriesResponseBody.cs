// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListJobHistoriesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListJobHistoriesResponseBodyData> Data { get; set; }
        public class ListJobHistoriesResponseBodyData : TeaModel {
            [NameInMap("ActiveDeadlineSeconds")]
            [Validation(Required=false)]
            public int? ActiveDeadlineSeconds { get; set; }

            [NameInMap("BackoffLimit")]
            [Validation(Required=false)]
            public int? BackoffLimit { get; set; }

            [NameInMap("CompletionTime")]
            [Validation(Required=false)]
            public string CompletionTime { get; set; }

            [NameInMap("Completions")]
            [Validation(Required=false)]
            public int? Completions { get; set; }

            [NameInMap("Failed")]
            [Validation(Required=false)]
            public int? Failed { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

            [NameInMap("PodList")]
            [Validation(Required=false)]
            public List<string> PodList { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public int? Succeeded { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

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
        public long? TotalCount { get; set; }

    }

}
