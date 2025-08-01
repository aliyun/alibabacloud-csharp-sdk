// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class QuestionAnswer : TeaModel {
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public QuestionAnswerAnswer Answer { get; set; }
        public class QuestionAnswerAnswer : TeaModel {
            [NameInMap("Contexts")]
            [Validation(Required=false)]
            public List<string> Contexts { get; set; }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("GroundTruth")]
        [Validation(Required=false)]
        public QuestionAnswerGroundTruth GroundTruth { get; set; }
        public class QuestionAnswerGroundTruth : TeaModel {
            [NameInMap("Contexts")]
            [Validation(Required=false)]
            public List<string> Contexts { get; set; }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

    }

}
