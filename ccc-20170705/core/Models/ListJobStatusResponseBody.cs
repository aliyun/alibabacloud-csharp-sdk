// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListJobStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public ListJobStatusResponseBodyJobs Jobs { get; set; }
        public class ListJobStatusResponseBodyJobs : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListJobStatusResponseBodyJobsList> List { get; set; }
            public class ListJobStatusResponseBodyJobsList : TeaModel {
                public List<string> CallingNumbers { get; set; }
                public List<ListJobStatusResponseBodyJobsListContacts> Contacts { get; set; }
                public class ListJobStatusResponseBodyJobsListContacts : TeaModel {
                    public string ContactId { get; set; }
                    public string ContactName { get; set; }
                    public string Honorific { get; set; }
                    public string JobId { get; set; }
                    public string PhoneNumber { get; set; }
                    public string ReferenceId { get; set; }
                    public string Role { get; set; }
                    public string State { get; set; }
                }
                public List<ListJobStatusResponseBodyJobsListExtras> Extras { get; set; }
                public class ListJobStatusResponseBodyJobsListExtras : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
                public string FailureReason { get; set; }
                public string GroupId { get; set; }
                public string JobId { get; set; }
                public int? Priority { get; set; }
                public string ReferenceId { get; set; }
                public string ScenarioId { get; set; }
                public string Status { get; set; }
                public string StrategyId { get; set; }
                public List<ListJobStatusResponseBodyJobsListSummary> Summary { get; set; }
                public class ListJobStatusResponseBodyJobsListSummary : TeaModel {
                    public string Category { get; set; }
                    public string Content { get; set; }
                    public string ConversationDetailId { get; set; }
                    public string GroupId { get; set; }
                    public string JobId { get; set; }
                    public string SummaryId { get; set; }
                    public string SummaryName { get; set; }
                    public string TaskId { get; set; }
                }
                public List<ListJobStatusResponseBodyJobsListTasks> Tasks { get; set; }
                public class ListJobStatusResponseBodyJobsListTasks : TeaModel {
                    public long? ActualTime { get; set; }
                    public string Brief { get; set; }
                    public string CallId { get; set; }
                    public string CalledNumber { get; set; }
                    public string CallingNumber { get; set; }
                    public string ChatbotId { get; set; }
                    public ListJobStatusResponseBodyJobsListTasksContact Contact { get; set; }
                    public class ListJobStatusResponseBodyJobsListTasksContact : TeaModel {
                        [NameInMap("ContactId")]
                        [Validation(Required=false)]
                        public string ContactId { get; set; }

                        [NameInMap("ContactName")]
                        [Validation(Required=false)]
                        public string ContactName { get; set; }

                        [NameInMap("Honorific")]
                        [Validation(Required=false)]
                        public string Honorific { get; set; }

                        [NameInMap("JobId")]
                        [Validation(Required=false)]
                        public string JobId { get; set; }

                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public string PhoneNumber { get; set; }

                        [NameInMap("ReferenceId")]
                        [Validation(Required=false)]
                        public string ReferenceId { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                    }
                    public int? Duration { get; set; }
                    public string JobId { get; set; }
                    public long? PlanedTime { get; set; }
                    public string ScenarioId { get; set; }
                    public string Status { get; set; }
                    public string TaskId { get; set; }
                }
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
