// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListPrecisionTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPrecisionTaskResponseBodyData Data { get; set; }
        public class ListPrecisionTaskResponseBodyData : TeaModel {
            [NameInMap("PrecisionTask")]
            [Validation(Required=false)]
            public List<ListPrecisionTaskResponseBodyDataPrecisionTask> PrecisionTask { get; set; }
            public class ListPrecisionTaskResponseBodyDataPrecisionTask : TeaModel {
                public int? Status { get; set; }
                public string UpdateTime { get; set; }
                public string CreateTime { get; set; }
                public int? IncorrectWords { get; set; }
                public long? DataSetId { get; set; }
                public int? VerifiedCount { get; set; }
                public int? TotalCount { get; set; }
                public int? Source { get; set; }
                public ListPrecisionTaskResponseBodyDataPrecisionTaskPrecisions Precisions { get; set; }
                public class ListPrecisionTaskResponseBodyDataPrecisionTaskPrecisions : TeaModel {
                    [NameInMap("Precision")]
                    [Validation(Required=false)]
                    public List<ListPrecisionTaskResponseBodyDataPrecisionTaskPrecisionsPrecision> Precision { get; set; }
                    public class ListPrecisionTaskResponseBodyDataPrecisionTaskPrecisionsPrecision : TeaModel {
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        [NameInMap("ModelName")]
                        [Validation(Required=false)]
                        public string ModelName { get; set; }

                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                        [NameInMap("ModelId")]
                        [Validation(Required=false)]
                        public long? ModelId { get; set; }

                        [NameInMap("Precision")]
                        [Validation(Required=false)]
                        public float? Precision { get; set; }

                    }

                }
                public int? Duration { get; set; }
                public string DataSetName { get; set; }
                public string Name { get; set; }
                public string TaskId { get; set; }
            }
        };

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
