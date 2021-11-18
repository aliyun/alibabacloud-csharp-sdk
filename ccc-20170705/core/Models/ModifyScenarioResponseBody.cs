// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ModifyScenarioResponseBody : TeaModel {
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

        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public ModifyScenarioResponseBodyScenario Scenario { get; set; }
        public class ModifyScenarioResponseBodyScenario : TeaModel {
            [NameInMap("IsTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }
            [NameInMap("ScenarioDescription")]
            [Validation(Required=false)]
            public string ScenarioDescription { get; set; }
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }
            [NameInMap("ScenarioName")]
            [Validation(Required=false)]
            public string ScenarioName { get; set; }
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public ModifyScenarioResponseBodyScenarioStrategy Strategy { get; set; }
            public class ModifyScenarioResponseBodyScenarioStrategy : TeaModel {
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<ModifyScenarioResponseBodyScenarioStrategyWorkingTime> WorkingTime { get; set; }
                public class ModifyScenarioResponseBodyScenarioStrategyWorkingTime : TeaModel {
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                }

            }
            [NameInMap("Surveys")]
            [Validation(Required=false)]
            public List<ModifyScenarioResponseBodyScenarioSurveys> Surveys { get; set; }
            public class ModifyScenarioResponseBodyScenarioSurveys : TeaModel {
                public string BeebotId { get; set; }
                public List<ModifyScenarioResponseBodyScenarioSurveysIntents> Intents { get; set; }
                public class ModifyScenarioResponseBodyScenarioSurveysIntents : TeaModel {
                    public string IntentId { get; set; }
                    public string NodeId { get; set; }
                }
                public string Role { get; set; }
                public int? Round { get; set; }
                public string SurveyDescription { get; set; }
                public string SurveyId { get; set; }
                public string SurveyName { get; set; }
            }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<ModifyScenarioResponseBodyScenarioVariables> Variables { get; set; }
            public class ModifyScenarioResponseBodyScenarioVariables : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
