// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunMedQAAdvanceRequest : TeaModel {
        [NameInMap("AnswerImageDataList")]
        [Validation(Required=false)]
        public List<RunMedQAAdvanceRequestAnswerImageDataList> AnswerImageDataList { get; set; }
        public class RunMedQAAdvanceRequestAnswerImageDataList : TeaModel {
            [NameInMap("AnswerImageData")]
            [Validation(Required=false)]
            public string AnswerImageData { get; set; }

        }

        [NameInMap("AnswerImageURLList")]
        [Validation(Required=false)]
        public List<RunMedQAAdvanceRequestAnswerImageURLList> AnswerImageURLList { get; set; }
        public class RunMedQAAdvanceRequestAnswerImageURLList : TeaModel {
            [NameInMap("AnswerImageURL")]
            [Validation(Required=false)]
            public Stream AnswerImageURLObject { get; set; }

        }

        [NameInMap("AnswerTextList")]
        [Validation(Required=false)]
        public List<RunMedQAAdvanceRequestAnswerTextList> AnswerTextList { get; set; }
        public class RunMedQAAdvanceRequestAnswerTextList : TeaModel {
            [NameInMap("AnswerText")]
            [Validation(Required=false)]
            public string AnswerText { get; set; }

        }

        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("QuestionType")]
        [Validation(Required=false)]
        public string QuestionType { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
