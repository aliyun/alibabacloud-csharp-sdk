// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateGenerateAICoachScriptTaskRequest : TeaModel {
        [NameInMap("assessmentPoint")]
        [Validation(Required=false)]
        public bool? AssessmentPoint { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("dialogueKey")]
        [Validation(Required=false)]
        public string DialogueKey { get; set; }

        [NameInMap("dialogueUrl")]
        [Validation(Required=false)]
        public string DialogueUrl { get; set; }

        [NameInMap("docList")]
        [Validation(Required=false)]
        public List<CreateGenerateAICoachScriptTaskRequestDocList> DocList { get; set; }
        public class CreateGenerateAICoachScriptTaskRequestDocList : TeaModel {
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("docName")]
            [Validation(Required=false)]
            public string DocName { get; set; }

            [NameInMap("kbId")]
            [Validation(Required=false)]
            public string KbId { get; set; }

        }

        [NameInMap("docUrlList")]
        [Validation(Required=false)]
        public List<string> DocUrlList { get; set; }

        [NameInMap("scriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

    }

}
