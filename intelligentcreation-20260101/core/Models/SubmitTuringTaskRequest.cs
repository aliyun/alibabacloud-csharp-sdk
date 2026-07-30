// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20260101.Models
{
    public class SubmitTuringTaskRequest : TeaModel {
        [NameInMap("duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("idempotentKey")]
        [Validation(Required=false)]
        public string IdempotentKey { get; set; }

        [NameInMap("imgUrl")]
        [Validation(Required=false)]
        public string ImgUrl { get; set; }

        [NameInMap("resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
