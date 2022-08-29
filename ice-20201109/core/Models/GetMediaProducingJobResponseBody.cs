// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaProducingJobResponseBody : TeaModel {
        [NameInMap("MediaProducingJob")]
        [Validation(Required=false)]
        public GetMediaProducingJobResponseBodyMediaProducingJob MediaProducingJob { get; set; }
        public class GetMediaProducingJobResponseBodyMediaProducingJob : TeaModel {
            [NameInMap("ClipsParam")]
            [Validation(Required=false)]
            public string ClipsParam { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }
            [NameInMap("MediaURL")]
            [Validation(Required=false)]
            public string MediaURL { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("Timeline")]
            [Validation(Required=false)]
            public string Timeline { get; set; }
            [NameInMap("VodMediaId")]
            [Validation(Required=false)]
            public string VodMediaId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
