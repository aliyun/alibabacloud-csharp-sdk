// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateScenarioFromTemplateResponseBody : TeaModel {
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

        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public CreateScenarioFromTemplateResponseBodyScenario Scenario { get; set; }
        public class CreateScenarioFromTemplateResponseBodyScenario : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public CreateScenarioFromTemplateResponseBodyScenarioStrategy Strategy { get; set; }
            public class CreateScenarioFromTemplateResponseBodyScenarioStrategy : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<CreateScenarioFromTemplateResponseBodyScenarioStrategyWorkingTime> WorkingTime { get; set; }
                public class CreateScenarioFromTemplateResponseBodyScenarioStrategyWorkingTime : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                }

                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

            }
            [NameInMap("IsTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }
            [NameInMap("ScenarioDescription")]
            [Validation(Required=false)]
            public string ScenarioDescription { get; set; }
            [NameInMap("ScenarioName")]
            [Validation(Required=false)]
            public string ScenarioName { get; set; }
            [NameInMap("Surveys")]
            [Validation(Required=false)]
            public List<CreateScenarioFromTemplateResponseBodyScenarioSurveys> Surveys { get; set; }
            public class CreateScenarioFromTemplateResponseBodyScenarioSurveys : TeaModel {
                public int? Round { get; set; }
                public string SurveyDescription { get; set; }
                public string BeebotId { get; set; }
                public List<CreateScenarioFromTemplateResponseBodyScenarioSurveysIntents> Intents { get; set; }
                public class CreateScenarioFromTemplateResponseBodyScenarioSurveysIntents : TeaModel {
                    public string NodeId { get; set; }
                    public string IntentId { get; set; }
                }
                public string SurveyName { get; set; }
                public string Role { get; set; }
                public string SurveyId { get; set; }
            }
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<CreateScenarioFromTemplateResponseBodyScenarioVariables> Variables { get; set; }
            public class CreateScenarioFromTemplateResponseBodyScenarioVariables : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
