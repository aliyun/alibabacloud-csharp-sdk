// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListScenarioTemplatesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ScenarioTemplates")]
        [Validation(Required=false)]
        public List<ListScenarioTemplatesResponseBodyScenarioTemplates> ScenarioTemplates { get; set; }
        public class ListScenarioTemplatesResponseBodyScenarioTemplates : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("IsTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Surveys")]
            [Validation(Required=false)]
            public List<ListScenarioTemplatesResponseBodyScenarioTemplatesSurveys> Surveys { get; set; }
            public class ListScenarioTemplatesResponseBodyScenarioTemplatesSurveys : TeaModel {
                [NameInMap("GlobalQuestions")]
                [Validation(Required=false)]
                public string GlobalQuestions { get; set; }

                [NameInMap("Round")]
                [Validation(Required=false)]
                public int? Round { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("BeebotId")]
                [Validation(Required=false)]
                public string BeebotId { get; set; }

                [NameInMap("Flow")]
                [Validation(Required=false)]
                public ListScenarioTemplatesResponseBodyScenarioTemplatesSurveysFlow Flow { get; set; }
                public class ListScenarioTemplatesResponseBodyScenarioTemplatesSurveysFlow : TeaModel {
                    [NameInMap("IsPublished")]
                    [Validation(Required=false)]
                    public bool? IsPublished { get; set; }
                    [NameInMap("FlowJson")]
                    [Validation(Required=false)]
                    public string FlowJson { get; set; }
                    [NameInMap("FlowId")]
                    [Validation(Required=false)]
                    public string FlowId { get; set; }
                };

                [NameInMap("Intents")]
                [Validation(Required=false)]
                public List<ListScenarioTemplatesResponseBodyScenarioTemplatesSurveysIntents> Intents { get; set; }
                public class ListScenarioTemplatesResponseBodyScenarioTemplatesSurveysIntents : TeaModel {
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    [NameInMap("IntentId")]
                    [Validation(Required=false)]
                    public string IntentId { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<ListScenarioTemplatesResponseBodyScenarioTemplatesVariables> Variables { get; set; }
            public class ListScenarioTemplatesResponseBodyScenarioTemplatesVariables : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
