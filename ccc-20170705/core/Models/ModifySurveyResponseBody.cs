// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ModifySurveyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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

        [NameInMap("Survey")]
        [Validation(Required=false)]
        public ModifySurveyResponseBodySurvey Survey { get; set; }
        public class ModifySurveyResponseBodySurvey : TeaModel {
            [NameInMap("AsrCustomModel")]
            [Validation(Required=false)]
            public ModifySurveyResponseBodySurveyAsrCustomModel AsrCustomModel { get; set; }
            public class ModifySurveyResponseBodySurveyAsrCustomModel : TeaModel {
                [NameInMap("Corpora")]
                [Validation(Required=false)]
                public string Corpora { get; set; }

                [NameInMap("CustomModelStatus")]
                [Validation(Required=false)]
                public int? CustomModelStatus { get; set; }

            }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Flow")]
            [Validation(Required=false)]
            public ModifySurveyResponseBodySurveyFlow Flow { get; set; }
            public class ModifySurveyResponseBodySurveyFlow : TeaModel {
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                [NameInMap("FlowJson")]
                [Validation(Required=false)]
                public string FlowJson { get; set; }

                [NameInMap("IsPublished")]
                [Validation(Required=false)]
                public bool? IsPublished { get; set; }

            }
            [NameInMap("GlobalQuestions")]
            [Validation(Required=false)]
            public string GlobalQuestions { get; set; }
            [NameInMap("HotWords")]
            [Validation(Required=false)]
            public string HotWords { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }
            [NameInMap("Round")]
            [Validation(Required=false)]
            public int? Round { get; set; }
            [NameInMap("ScenarioUuid")]
            [Validation(Required=false)]
            public string ScenarioUuid { get; set; }
            [NameInMap("SpeechOptimizationParam")]
            [Validation(Required=false)]
            public string SpeechOptimizationParam { get; set; }
        };

    }

}
