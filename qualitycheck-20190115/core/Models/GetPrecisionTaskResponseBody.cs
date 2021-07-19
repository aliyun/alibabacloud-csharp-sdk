// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetPrecisionTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPrecisionTaskResponseBodyData Data { get; set; }
        public class GetPrecisionTaskResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
            [NameInMap("IncorrectWords")]
            [Validation(Required=false)]
            public int? IncorrectWords { get; set; }
            [NameInMap("DataSetId")]
            [Validation(Required=false)]
            public long? DataSetId { get; set; }
            [NameInMap("VerifiedCount")]
            [Validation(Required=false)]
            public int? VerifiedCount { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }
            [NameInMap("DataSetName")]
            [Validation(Required=false)]
            public string DataSetName { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Source")]
            [Validation(Required=false)]
            public int? Source { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("Precisions")]
            [Validation(Required=false)]
            public GetPrecisionTaskResponseBodyDataPrecisions Precisions { get; set; }
            public class GetPrecisionTaskResponseBodyDataPrecisions : TeaModel {
                [NameInMap("Precision")]
                [Validation(Required=false)]
                public List<GetPrecisionTaskResponseBodyDataPrecisionsPrecision> Precision { get; set; }
                public class GetPrecisionTaskResponseBodyDataPrecisionsPrecision : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("ModelName")]
                    [Validation(Required=false)]
                    public string ModelName { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    [NameInMap("Precision")]
                    [Validation(Required=false)]
                    public float? Precision { get; set; }

                    [NameInMap("ModelId")]
                    [Validation(Required=false)]
                    public long? ModelId { get; set; }

                }

            }
        };

    }

}
