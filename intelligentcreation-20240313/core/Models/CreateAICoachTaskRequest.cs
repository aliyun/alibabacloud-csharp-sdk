// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateAICoachTaskRequest : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scriptRecordId")]
        [Validation(Required=false)]
        public string ScriptRecordId { get; set; }

        [NameInMap("studentAudioUrl")]
        [Validation(Required=false)]
        public string StudentAudioUrl { get; set; }

        [NameInMap("studentId")]
        [Validation(Required=false)]
        public string StudentId { get; set; }

    }

}
