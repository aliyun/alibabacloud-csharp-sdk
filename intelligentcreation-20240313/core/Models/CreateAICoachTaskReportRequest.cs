// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateAICoachTaskReportRequest : TeaModel {
        [NameInMap("dialogueList")]
        [Validation(Required=false)]
        public List<CreateAICoachTaskReportRequestDialogueList> DialogueList { get; set; }
        public class CreateAICoachTaskReportRequestDialogueList : TeaModel {
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("idempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
