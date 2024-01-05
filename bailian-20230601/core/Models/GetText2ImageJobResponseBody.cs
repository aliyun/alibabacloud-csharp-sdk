// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class GetText2ImageJobResponseBody : TeaModel {
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<GetText2ImageJobResponseBodyImages> Images { get; set; }
        public class GetText2ImageJobResponseBodyImages : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskMetrics")]
        [Validation(Required=false)]
        public GetText2ImageJobResponseBodyTaskMetrics TaskMetrics { get; set; }
        public class GetText2ImageJobResponseBodyTaskMetrics : TeaModel {
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public int? Failed { get; set; }

            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public int? Succeeded { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("Usage")]
        [Validation(Required=false)]
        public List<GetText2ImageJobResponseBodyUsage> Usage { get; set; }
        public class GetText2ImageJobResponseBodyUsage : TeaModel {
            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public int? ImageCount { get; set; }

        }

    }

}
