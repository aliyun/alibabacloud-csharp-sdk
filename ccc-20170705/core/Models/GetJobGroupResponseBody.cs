// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetJobGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("JobGroup")]
        [Validation(Required=false)]
        public GetJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class GetJobGroupResponseBodyJobGroup : TeaModel {
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public GetJobGroupResponseBodyJobGroupProgress Progress { get; set; }
            public class GetJobGroupResponseBodyJobGroupProgress : TeaModel {
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<GetJobGroupResponseBodyJobGroupProgressCategories> Categories { get; set; }
                public class GetJobGroupResponseBodyJobGroupProgressCategories : TeaModel {
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
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public GetJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class GetJobGroupResponseBodyJobGroupStrategy : TeaModel {
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
                public List<GetJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class GetJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
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
