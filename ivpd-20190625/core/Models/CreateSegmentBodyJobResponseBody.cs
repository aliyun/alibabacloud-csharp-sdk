// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class CreateSegmentBodyJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSegmentBodyJobResponseBodyData Data { get; set; }
        public class CreateSegmentBodyJobResponseBodyData : TeaModel {
            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }
            [NameInMap("ResultList")]
            [Validation(Required=false)]
            public List<CreateSegmentBodyJobResponseBodyDataResultList> ResultList { get; set; }
            public class CreateSegmentBodyJobResponseBodyDataResultList : TeaModel {
                public string Code { get; set; }
                public string DataId { get; set; }
                public string Message { get; set; }
                public CreateSegmentBodyJobResponseBodyDataResultListResultData ResultData { get; set; }
                public class CreateSegmentBodyJobResponseBodyDataResultListResultData : TeaModel {
                    [NameInMap("ImageUrl")]
                    [Validation(Required=false)]
                    public string ImageUrl { get; set; }

                }
                public bool? Success { get; set; }
            }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TotalUsedTime")]
            [Validation(Required=false)]
            public long? TotalUsedTime { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
