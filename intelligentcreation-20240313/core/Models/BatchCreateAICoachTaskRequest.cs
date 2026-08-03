// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BatchCreateAICoachTaskRequest : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scriptRecordId")]
        [Validation(Required=false)]
        public string ScriptRecordId { get; set; }

        [NameInMap("studentIds")]
        [Validation(Required=false)]
        public List<string> StudentIds { get; set; }

        [NameInMap("studentList")]
        [Validation(Required=false)]
        public List<BatchCreateAICoachTaskRequestStudentList> StudentList { get; set; }
        public class BatchCreateAICoachTaskRequestStudentList : TeaModel {
            [NameInMap("studentAudioUrl")]
            [Validation(Required=false)]
            public string StudentAudioUrl { get; set; }

            [NameInMap("studentId")]
            [Validation(Required=false)]
            public string StudentId { get; set; }

        }

    }

}
