// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobsByGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public ListJobsByGroupResponseBodyJobs Jobs { get; set; }
        public class ListJobsByGroupResponseBodyJobs : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListJobsByGroupResponseBodyJobsList> List { get; set; }
            public class ListJobsByGroupResponseBodyJobsList : TeaModel {
                [NameInMap("CallingNumbers")]
                [Validation(Required=false)]
                public List<string> CallingNumbers { get; set; }

                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<ListJobsByGroupResponseBodyJobsListContacts> Contacts { get; set; }
                public class ListJobsByGroupResponseBodyJobsListContacts : TeaModel {
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

                [NameInMap("Extras")]
                [Validation(Required=false)]
                public List<ListJobsByGroupResponseBodyJobsListExtras> Extras { get; set; }
                public class ListJobsByGroupResponseBodyJobsListExtras : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("FailureReason")]
                [Validation(Required=false)]
                public string FailureReason { get; set; }

                [NameInMap("JobGroupId")]
                [Validation(Required=false)]
                public string JobGroupId { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public string ScenarioId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public List<ListJobsByGroupResponseBodyJobsListSummary> Summary { get; set; }
                public class ListJobsByGroupResponseBodyJobsListSummary : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("ConversationDetailId")]
                    [Validation(Required=false)]
                    public string ConversationDetailId { get; set; }

                    [NameInMap("JobGroupId")]
                    [Validation(Required=false)]
                    public string JobGroupId { get; set; }

                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    [NameInMap("SummaryId")]
                    [Validation(Required=false)]
                    public string SummaryId { get; set; }

                    [NameInMap("SummaryName")]
                    [Validation(Required=false)]
                    public string SummaryName { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                [NameInMap("SystemPriority")]
                [Validation(Required=false)]
                public int? SystemPriority { get; set; }

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

        }

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
