// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListJobGroupsResponseBody : TeaModel {
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

        [NameInMap("JobGroups")]
        [Validation(Required=false)]
        public ListJobGroupsResponseBodyJobGroups JobGroups { get; set; }
        public class ListJobGroupsResponseBodyJobGroups : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListJobGroupsResponseBodyJobGroupsList> List { get; set; }
            public class ListJobGroupsResponseBodyJobGroupsList : TeaModel {
                public string ScenarioId { get; set; }
                public long? CreationTime { get; set; }
                public ListJobGroupsResponseBodyJobGroupsListStrategy Strategy { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListStrategy : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("MaxAttemptsPerDay")]
                    [Validation(Required=false)]
                    public int? MaxAttemptsPerDay { get; set; }

                    [NameInMap("WorkingTime")]
                    [Validation(Required=false)]
                    public List<ListJobGroupsResponseBodyJobGroupsListStrategyWorkingTime> WorkingTime { get; set; }
                    public class ListJobGroupsResponseBodyJobGroupsListStrategyWorkingTime : TeaModel {
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

                }
                public List<string> CallingNumbers { get; set; }
                public ListJobGroupsResponseBodyJobGroupsListProgress Progress { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListProgress : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TotalNotAnswered")]
                    [Validation(Required=false)]
                    public int? TotalNotAnswered { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public List<ListJobGroupsResponseBodyJobGroupsListProgressCategories> Categories { get; set; }
                    public class ListJobGroupsResponseBodyJobGroupsListProgressCategories : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("TotalJobs")]
                    [Validation(Required=false)]
                    public int? TotalJobs { get; set; }

                    [NameInMap("TotalCompleted")]
                    [Validation(Required=false)]
                    public int? TotalCompleted { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                }
                public string Description { get; set; }
                public string JobFilePath { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
