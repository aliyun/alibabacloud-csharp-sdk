// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeantcodeAntcodeProjecttagResponseBody : TeaModel {
        [NameInMap("Commit")]
        [Validation(Required=false)]
        public CreateLinkeantcodeAntcodeProjecttagResponseBodyCommit Commit { get; set; }
        public class CreateLinkeantcodeAntcodeProjecttagResponseBodyCommit : TeaModel {
            [NameInMap("ShortId")]
            [Validation(Required=false)]
            public string ShortId { get; set; }
            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }
            [NameInMap("AuthoredDate")]
            [Validation(Required=false)]
            public string AuthoredDate { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("ParentIds")]
            [Validation(Required=false)]
            public List<string> ParentIds { get; set; }
            [NameInMap("AuthorName")]
            [Validation(Required=false)]
            public string AuthorName { get; set; }
            [NameInMap("CheckSuites")]
            [Validation(Required=false)]
            public List<string> CheckSuites { get; set; }
            [NameInMap("CommitterName")]
            [Validation(Required=false)]
            public string CommitterName { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("AuthorEmail")]
            [Validation(Required=false)]
            public string AuthorEmail { get; set; }
            [NameInMap("CommitterEmail")]
            [Validation(Required=false)]
            public string CommitterEmail { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("CommittedDate")]
            [Validation(Required=false)]
            public string CommittedDate { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Tagger")]
        [Validation(Required=false)]
        public CreateLinkeantcodeAntcodeProjecttagResponseBodyTagger Tagger { get; set; }
        public class CreateLinkeantcodeAntcodeProjecttagResponseBodyTagger : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("When")]
            [Validation(Required=false)]
            public string When { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
        };

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("CheckSuites")]
        [Validation(Required=false)]
        public List<CreateLinkeantcodeAntcodeProjecttagResponseBodyCheckSuites> CheckSuites { get; set; }
        public class CreateLinkeantcodeAntcodeProjecttagResponseBodyCheckSuites : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("BeforeSha")]
            [Validation(Required=false)]
            public string BeforeSha { get; set; }

            [NameInMap("HeadBranch")]
            [Validation(Required=false)]
            public string HeadBranch { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("AfterSha")]
            [Validation(Required=false)]
            public string AfterSha { get; set; }

            [NameInMap("Conclusion")]
            [Validation(Required=false)]
            public string Conclusion { get; set; }

            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("PullRequestId")]
            [Validation(Required=false)]
            public long? PullRequestId { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("CheckRuns")]
            [Validation(Required=false)]
            public List<string> CheckRuns { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("HeadSha")]
            [Validation(Required=false)]
            public string HeadSha { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Release")]
        [Validation(Required=false)]
        public CreateLinkeantcodeAntcodeProjecttagResponseBodyRelease Release { get; set; }
        public class CreateLinkeantcodeAntcodeProjecttagResponseBodyRelease : TeaModel {
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
        };

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
