// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetPredictiveJobGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("JobGroup")]
        [Validation(Required=false)]
        public GetPredictiveJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class GetPredictiveJobGroupResponseBodyJobGroup : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public GetPredictiveJobGroupResponseBodyJobGroupProgress Progress { get; set; }
            public class GetPredictiveJobGroupResponseBodyJobGroupProgress : TeaModel {
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<GetPredictiveJobGroupResponseBodyJobGroupProgressCategories> Categories { get; set; }
                public class GetPredictiveJobGroupResponseBodyJobGroupProgressCategories : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalCompleted")]
                [Validation(Required=false)]
                public int? TotalCompleted { get; set; }

                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                [NameInMap("TotalNotAnswered")]
                [Validation(Required=false)]
                public int? TotalNotAnswered { get; set; }

            }
            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public long? Ratio { get; set; }
            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public string SkillGroupId { get; set; }
            [NameInMap("SkillGroupName")]
            [Validation(Required=false)]
            public string SkillGroupName { get; set; }
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public GetPredictiveJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class GetPredictiveJobGroupResponseBodyJobGroupStrategy : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<GetPredictiveJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class GetPredictiveJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

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
