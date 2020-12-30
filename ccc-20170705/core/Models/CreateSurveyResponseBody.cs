// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateSurveyResponseBody : TeaModel {
        [NameInMap("Survey")]
        [Validation(Required=false)]
        public CreateSurveyResponseBodySurvey Survey { get; set; }
        public class CreateSurveyResponseBodySurvey : TeaModel {
            [NameInMap("GlobalQuestions")]
            [Validation(Required=false)]
            public string GlobalQuestions { get; set; }
            [NameInMap("Round")]
            [Validation(Required=false)]
            public int? Round { get; set; }
            [NameInMap("SpeechOptimizationParam")]
            [Validation(Required=false)]
            public string SpeechOptimizationParam { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("HotWords")]
            [Validation(Required=false)]
            public string HotWords { get; set; }
            [NameInMap("AsrCustomModel")]
            [Validation(Required=false)]
            public CreateSurveyResponseBodySurveyAsrCustomModel AsrCustomModel { get; set; }
            public class CreateSurveyResponseBodySurveyAsrCustomModel : TeaModel {
                [NameInMap("CustomModelStatus")]
                [Validation(Required=false)]
                public int? CustomModelStatus { get; set; }

                [NameInMap("Corpora")]
                [Validation(Required=false)]
                public string Corpora { get; set; }

            }
            [NameInMap("Flow")]
            [Validation(Required=false)]
            public CreateSurveyResponseBodySurveyFlow Flow { get; set; }
            public class CreateSurveyResponseBodySurveyFlow : TeaModel {
                [NameInMap("IsPublished")]
                [Validation(Required=false)]
                public bool? IsPublished { get; set; }

                [NameInMap("FlowJson")]
                [Validation(Required=false)]
                public string FlowJson { get; set; }

                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

            }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ScenarioUuid")]
            [Validation(Required=false)]
            public string ScenarioUuid { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
