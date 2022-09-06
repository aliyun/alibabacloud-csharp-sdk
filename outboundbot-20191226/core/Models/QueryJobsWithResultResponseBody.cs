// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsWithResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public QueryJobsWithResultResponseBodyJobs Jobs { get; set; }
        public class QueryJobsWithResultResponseBodyJobs : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryJobsWithResultResponseBodyJobsList> List { get; set; }
            public class QueryJobsWithResultResponseBodyJobsList : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("JobFailureReason")]
                [Validation(Required=false)]
                public string JobFailureReason { get; set; }

                [NameInMap("LatestTask")]
                [Validation(Required=false)]
                public QueryJobsWithResultResponseBodyJobsListLatestTask LatestTask { get; set; }
                public class QueryJobsWithResultResponseBodyJobsListLatestTask : TeaModel {
                    [NameInMap("CallDuration")]
                    [Validation(Required=false)]
                    public int? CallDuration { get; set; }

                    [NameInMap("CallDurationDisplay")]
                    [Validation(Required=false)]
                    public string CallDurationDisplay { get; set; }

                    [NameInMap("CallTime")]
                    [Validation(Required=false)]
                    public long? CallTime { get; set; }

                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public QueryJobsWithResultResponseBodyJobsListLatestTaskContact Contact { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskContact : TeaModel {
                        [NameInMap("Honorific")]
                        [Validation(Required=false)]
                        public string Honorific { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("JobUuid")]
                        [Validation(Required=false)]
                        public string JobUuid { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public string PhoneNumber { get; set; }

                        [NameInMap("PreferredPhoneNumber")]
                        [Validation(Required=false)]
                        public string PreferredPhoneNumber { get; set; }

                        [NameInMap("ReferenceId")]
                        [Validation(Required=false)]
                        public string ReferenceId { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        [NameInMap("Round")]
                        [Validation(Required=false)]
                        public int? Round { get; set; }

                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                    }

                    [NameInMap("DialExceptionCodes")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskDialExceptionCodes> DialExceptionCodes { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskDialExceptionCodes : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Hint")]
                        [Validation(Required=false)]
                        public string Hint { get; set; }

                    }

                    [NameInMap("Extras")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskExtras> Extras { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskExtras : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("HasAnswered")]
                    [Validation(Required=false)]
                    public bool? HasAnswered { get; set; }

                    [NameInMap("HasHangUpByRejection")]
                    [Validation(Required=false)]
                    public bool? HasHangUpByRejection { get; set; }

                    [NameInMap("HasLastPlaybackCompleted")]
                    [Validation(Required=false)]
                    public bool? HasLastPlaybackCompleted { get; set; }

                    [NameInMap("HasReachedEndOfFlow")]
                    [Validation(Required=false)]
                    public bool? HasReachedEndOfFlow { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StatusName")]
                    [Validation(Required=false)]
                    public string StatusName { get; set; }

                    [NameInMap("TagHits")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskTagHits> TagHits { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskTagHits : TeaModel {
                        [NameInMap("TagGroup")]
                        [Validation(Required=false)]
                        public string TagGroup { get; set; }

                        [NameInMap("TagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                    }

                    [NameInMap("TaskEndReason")]
                    [Validation(Required=false)]
                    public string TaskEndReason { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StatusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

            }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public int? RowCount { get; set; }

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

        [NameInMap("VariableNames")]
        [Validation(Required=false)]
        public List<string> VariableNames { get; set; }

    }

}
