// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListJobsByGroupResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public ListJobsByGroupResponseBodyJobs Jobs { get; set; }
        public class ListJobsByGroupResponseBodyJobs : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListJobsByGroupResponseBodyJobsList> List { get; set; }
            public class ListJobsByGroupResponseBodyJobsList : TeaModel {
                public string Status { get; set; }
                public List<string> CallingNumbers { get; set; }
                public List<ListJobsByGroupResponseBodyJobsListSummary> Summary { get; set; }
                public class ListJobsByGroupResponseBodyJobsListSummary : TeaModel {
                    public string SummaryName { get; set; }
                    public string GroupId { get; set; }
                    public string JobId { get; set; }
                    public string Category { get; set; }
                    public string Content { get; set; }
                    public string SummaryId { get; set; }
                    public string TaskId { get; set; }
                    public string ConversationDetailId { get; set; }
                }
                public List<ListJobsByGroupResponseBodyJobsListContacts> Contacts { get; set; }
                public class ListJobsByGroupResponseBodyJobsListContacts : TeaModel {
                    public string PhoneNumber { get; set; }
                    public string ContactId { get; set; }
                    public string State { get; set; }
                    public string JobId { get; set; }
                    public string Honorific { get; set; }
                    public string ContactName { get; set; }
                    public string Role { get; set; }
                    public string ReferenceId { get; set; }
                }
                public int? Priority { get; set; }
                public string FailureReason { get; set; }
                public int? SystemPriority { get; set; }
                public List<ListJobsByGroupResponseBodyJobsListExtras> Extras { get; set; }
                public class ListJobsByGroupResponseBodyJobsListExtras : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
                public string ReferenceId { get; set; }
                public string ScenarioId { get; set; }
                public string StrategyId { get; set; }
                public string GroupId { get; set; }
                public string JobId { get; set; }
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

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
