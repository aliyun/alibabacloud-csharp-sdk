// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class CreateTtsQuestionRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public CreateTtsQuestionRequestRequest Request { get; set; }
        public class CreateTtsQuestionRequestRequest : TeaModel {
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            [NameInMap("Question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            [NameInMap("QuestionGroupId")]
            [Validation(Required=false)]
            public string QuestionGroupId { get; set; }

        }

    }

}
