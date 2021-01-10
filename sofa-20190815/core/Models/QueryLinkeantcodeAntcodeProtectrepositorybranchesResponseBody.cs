// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeProtectrepositorybranchesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("MergeAccessLevel")]
        [Validation(Required=false)]
        public string MergeAccessLevel { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PushAccessLevel")]
        [Validation(Required=false)]
        public string PushAccessLevel { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("MatchedBranches")]
        [Validation(Required=false)]
        public List<string> MatchedBranches { get; set; }

        [NameInMap("AllowedMergeUsers")]
        [Validation(Required=false)]
        public List<QueryLinkeantcodeAntcodeProtectrepositorybranchesResponseBodyAllowedMergeUsers> AllowedMergeUsers { get; set; }
        public class QueryLinkeantcodeAntcodeProtectrepositorybranchesResponseBodyAllowedMergeUsers : TeaModel {
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("ExternUid")]
            [Validation(Required=false)]
            public string ExternUid { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NotificationLevel")]
            [Validation(Required=false)]
            public long? NotificationLevel { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        [NameInMap("AllowedPushUsers")]
        [Validation(Required=false)]
        public List<QueryLinkeantcodeAntcodeProtectrepositorybranchesResponseBodyAllowedPushUsers> AllowedPushUsers { get; set; }
        public class QueryLinkeantcodeAntcodeProtectrepositorybranchesResponseBodyAllowedPushUsers : TeaModel {
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("ExternUid")]
            [Validation(Required=false)]
            public string ExternUid { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NotificationLevel")]
            [Validation(Required=false)]
            public long? NotificationLevel { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        [NameInMap("Commit")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeProtectrepositorybranchesResponseBodyCommit Commit { get; set; }
        public class QueryLinkeantcodeAntcodeProtectrepositorybranchesResponseBodyCommit : TeaModel {
            [NameInMap("AuthoredDate")]
            [Validation(Required=false)]
            public string AuthoredDate { get; set; }
            [NameInMap("AuthorEmail")]
            [Validation(Required=false)]
            public string AuthorEmail { get; set; }
            [NameInMap("AuthorName")]
            [Validation(Required=false)]
            public string AuthorName { get; set; }
            [NameInMap("CommittedDate")]
            [Validation(Required=false)]
            public string CommittedDate { get; set; }
            [NameInMap("CommitterEmail")]
            [Validation(Required=false)]
            public string CommitterEmail { get; set; }
            [NameInMap("CommitterName")]
            [Validation(Required=false)]
            public string CommitterName { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("ShortId")]
            [Validation(Required=false)]
            public string ShortId { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("ParentIds")]
            [Validation(Required=false)]
            public List<string> ParentIds { get; set; }
        };

    }

}
