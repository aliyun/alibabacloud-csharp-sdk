// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListGlobalQuestionsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GlobalQuestions")]
        [Validation(Required=false)]
        public ListGlobalQuestionsResponseBodyGlobalQuestions GlobalQuestions { get; set; }
        public class ListGlobalQuestionsResponseBodyGlobalQuestions : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListGlobalQuestionsResponseBodyGlobalQuestionsList> List { get; set; }
            public class ListGlobalQuestionsResponseBodyGlobalQuestionsList : TeaModel {
                [NameInMap("Answers")]
                [Validation(Required=false)]
                public string Answers { get; set; }

                [NameInMap("GlobalQuestionId")]
                [Validation(Required=false)]
                public string GlobalQuestionId { get; set; }

                [NameInMap("GlobalQuestionName")]
                [Validation(Required=false)]
                public string GlobalQuestionName { get; set; }

                [NameInMap("GlobalQuestionType")]
                [Validation(Required=false)]
                public string GlobalQuestionType { get; set; }

                [NameInMap("Questions")]
                [Validation(Required=false)]
                public string Questions { get; set; }

                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
