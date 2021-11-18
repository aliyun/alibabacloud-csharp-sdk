// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateJobGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("JobGroup")]
        [Validation(Required=false)]
        public CreateJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class CreateJobGroupResponseBodyJobGroup : TeaModel {
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }
            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }
            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }
            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public CreateJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class CreateJobGroupResponseBodyJobGroupStrategy : TeaModel {
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
                public List<CreateJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class CreateJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public string From { get; set; }

                    [NameInMap("To")]
                    [Validation(Required=false)]
                    public string To { get; set; }

                }

            }
        };

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
