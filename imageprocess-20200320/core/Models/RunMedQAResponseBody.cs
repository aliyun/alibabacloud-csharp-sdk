// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunMedQAResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RunMedQAResponseBodyData Data { get; set; }
        public class RunMedQAResponseBodyData : TeaModel {
            [NameInMap("AnswerType")]
            [Validation(Required=false)]
            public string AnswerType { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public List<string> Options { get; set; }

            [NameInMap("Question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            [NameInMap("QuestionType")]
            [Validation(Required=false)]
            public string QuestionType { get; set; }

            [NameInMap("Reports")]
            [Validation(Required=false)]
            public Dictionary<string, string> Reports { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
