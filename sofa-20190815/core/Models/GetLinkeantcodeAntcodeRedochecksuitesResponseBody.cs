// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeantcodeAntcodeRedochecksuitesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("AfterSha")]
        [Validation(Required=false)]
        public string AfterSha { get; set; }

        [NameInMap("BeforeSha")]
        [Validation(Required=false)]
        public string BeforeSha { get; set; }

        [NameInMap("Conclusion")]
        [Validation(Required=false)]
        public string Conclusion { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("HeadBranch")]
        [Validation(Required=false)]
        public string HeadBranch { get; set; }

        [NameInMap("HeadSha")]
        [Validation(Required=false)]
        public string HeadSha { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("PullRequestId")]
        [Validation(Required=false)]
        public long? PullRequestId { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("CheckRuns")]
        [Validation(Required=false)]
        public List<GetLinkeantcodeAntcodeRedochecksuitesResponseBodyCheckRuns> CheckRuns { get; set; }
        public class GetLinkeantcodeAntcodeRedochecksuitesResponseBodyCheckRuns : TeaModel {
            [NameInMap("CompletedAt")]
            [Validation(Required=false)]
            public string CompletedAt { get; set; }

            [NameInMap("Conclusion")]
            [Validation(Required=false)]
            public string Conclusion { get; set; }

            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("DetailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }

            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("StartedAt")]
            [Validation(Required=false)]
            public string StartedAt { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SuiteId")]
            [Validation(Required=false)]
            public long? SuiteId { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("UpdateAt")]
            [Validation(Required=false)]
            public string UpdateAt { get; set; }

            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<string> Annotations { get; set; }

        }

        [NameInMap("Service")]
        [Validation(Required=false)]
        public GetLinkeantcodeAntcodeRedochecksuitesResponseBodyService Service { get; set; }
        public class GetLinkeantcodeAntcodeRedochecksuitesResponseBodyService : TeaModel {
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public string AccessLevel { get; set; }
            [NameInMap("AccessUserId")]
            [Validation(Required=false)]
            public long? AccessUserId { get; set; }
            [NameInMap("AutoCheckSuite")]
            [Validation(Required=false)]
            public bool? AutoCheckSuite { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("BuildEvent")]
            [Validation(Required=false)]
            public bool? BuildEvent { get; set; }
            [NameInMap("CallUrl")]
            [Validation(Required=false)]
            public string CallUrl { get; set; }
            [NameInMap("Checks")]
            [Validation(Required=false)]
            public bool? Checks { get; set; }
            [NameInMap("ChecksDependOn")]
            [Validation(Required=false)]
            public string ChecksDependOn { get; set; }
            [NameInMap("CheckResultUrl")]
            [Validation(Required=false)]
            public string CheckResultUrl { get; set; }
            [NameInMap("CheckSite")]
            [Validation(Required=false)]
            public long? CheckSite { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Homepage")]
            [Validation(Required=false)]
            public string Homepage { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("IssueEvent")]
            [Validation(Required=false)]
            public bool? IssueEvent { get; set; }
            [NameInMap("MergeRequestEvent")]
            [Validation(Required=false)]
            public bool? MergeRequestEvent { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("NoteEvent")]
            [Validation(Required=false)]
            public bool? NoteEvent { get; set; }
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }
            [NameInMap("PushEvent")]
            [Validation(Required=false)]
            public bool? PushEvent { get; set; }
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }
            [NameInMap("TagPushEvent")]
            [Validation(Required=false)]
            public bool? TagPushEvent { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("VisibilityLevel")]
            [Validation(Required=false)]
            public string VisibilityLevel { get; set; }
        };

    }

}
