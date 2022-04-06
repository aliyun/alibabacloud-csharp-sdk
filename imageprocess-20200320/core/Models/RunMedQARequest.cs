// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunMedQARequest : TeaModel {
        [NameInMap("AnswerImageDataList")]
        [Validation(Required=false)]
        public List<RunMedQARequestAnswerImageDataList> AnswerImageDataList { get; set; }
        public class RunMedQARequestAnswerImageDataList : TeaModel {
            [NameInMap("AnswerImageData")]
            [Validation(Required=false)]
            public byte[] AnswerImageData { get; set; }

        }

        [NameInMap("AnswerImageURLList")]
        [Validation(Required=false)]
        public List<RunMedQARequestAnswerImageURLList> AnswerImageURLList { get; set; }
        public class RunMedQARequestAnswerImageURLList : TeaModel {
            [NameInMap("AnswerImageURL")]
            [Validation(Required=false)]
            public string AnswerImageURL { get; set; }

        }

        [NameInMap("AnswerTextList")]
        [Validation(Required=false)]
        public List<RunMedQARequestAnswerTextList> AnswerTextList { get; set; }
        public class RunMedQARequestAnswerTextList : TeaModel {
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
