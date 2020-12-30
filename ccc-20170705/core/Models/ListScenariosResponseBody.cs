// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListScenariosResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public List<ListScenariosResponseBodyScenarios> Scenarios { get; set; }
        public class ListScenariosResponseBodyScenarios : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public ListScenariosResponseBodyScenariosStrategy Strategy { get; set; }
            public class ListScenariosResponseBodyScenariosStrategy : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }
                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<ListScenariosResponseBodyScenariosStrategyWorkingTime> WorkingTime { get; set; }
                public class ListScenariosResponseBodyScenariosStrategyWorkingTime : TeaModel {
                    public string EndTime { get; set; }
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
                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }
                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }
                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
            };

            [NameInMap("IsTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Surveys")]
            [Validation(Required=false)]
            public List<ListScenariosResponseBodyScenariosSurveys> Surveys { get; set; }
            public class ListScenariosResponseBodyScenariosSurveys : TeaModel {
                [NameInMap("Round")]
                [Validation(Required=false)]
                public int? Round { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("BeebotId")]
                [Validation(Required=false)]
                public string BeebotId { get; set; }

                [NameInMap("Intents")]
                [Validation(Required=false)]
                public List<ListScenariosResponseBodyScenariosSurveysIntents> Intents { get; set; }
                public class ListScenariosResponseBodyScenariosSurveysIntents : TeaModel {
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
            public List<ListScenariosResponseBodyScenariosVariables> Variables { get; set; }
            public class ListScenariosResponseBodyScenariosVariables : TeaModel {
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
