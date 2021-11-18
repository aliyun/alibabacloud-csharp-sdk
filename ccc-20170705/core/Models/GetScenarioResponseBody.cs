// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetScenarioResponseBody : TeaModel {
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
        public GetScenarioResponseBodyScenario Scenario { get; set; }
        public class GetScenarioResponseBodyScenario : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("IsTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public GetScenarioResponseBodyScenarioStrategy Strategy { get; set; }
            public class GetScenarioResponseBodyScenarioStrategy : TeaModel {
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<GetScenarioResponseBodyScenarioStrategyWorkingTime> WorkingTime { get; set; }
                public class GetScenarioResponseBodyScenarioStrategyWorkingTime : TeaModel {
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
            public List<GetScenarioResponseBodyScenarioSurveys> Surveys { get; set; }
            public class GetScenarioResponseBodyScenarioSurveys : TeaModel {
                public string BeebotId { get; set; }
                public string Description { get; set; }
                public string Id { get; set; }
                public List<GetScenarioResponseBodyScenarioSurveysIntents> Intents { get; set; }
                public class GetScenarioResponseBodyScenarioSurveysIntents : TeaModel {
                    public string IntentId { get; set; }
                    public string NodeId { get; set; }
                }
                public string Name { get; set; }
                public string Role { get; set; }
                public int? Round { get; set; }
            }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<GetScenarioResponseBodyScenarioVariables> Variables { get; set; }
            public class GetScenarioResponseBodyScenarioVariables : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
