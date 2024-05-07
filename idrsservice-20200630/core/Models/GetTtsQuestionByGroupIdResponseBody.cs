// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class GetTtsQuestionByGroupIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTtsQuestionByGroupIdResponseBodyData Data { get; set; }
        public class GetTtsQuestionByGroupIdResponseBodyData : TeaModel {
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("Questions")]
            [Validation(Required=false)]
            public List<GetTtsQuestionByGroupIdResponseBodyDataQuestions> Questions { get; set; }
            public class GetTtsQuestionByGroupIdResponseBodyDataQuestions : TeaModel {
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("OssUrl")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                [NameInMap("QuestionGroupId")]
                [Validation(Required=false)]
                public long? QuestionGroupId { get; set; }

                [NameInMap("QuestionKey")]
                [Validation(Required=false)]
                public string QuestionKey { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
