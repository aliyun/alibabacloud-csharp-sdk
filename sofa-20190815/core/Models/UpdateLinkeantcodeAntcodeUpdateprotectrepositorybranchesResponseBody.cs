// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeUpdateprotectrepositorybranchesResponseBody : TeaModel {
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
        public List<UpdateLinkeantcodeAntcodeUpdateprotectrepositorybranchesResponseBodyAllowedMergeUsers> AllowedMergeUsers { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprotectrepositorybranchesResponseBodyAllowedMergeUsers : TeaModel {
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public long? AccessLevel { get; set; }

            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("Bio")]
            [Validation(Required=false)]
            public string Bio { get; set; }

            [NameInMap("CanCreateGroup")]
            [Validation(Required=false)]
            public bool? CanCreateGroup { get; set; }

            [NameInMap("CanCreateProject")]
            [Validation(Required=false)]
            public bool? CanCreateProject { get; set; }

            [NameInMap("ColorSchemeId")]
            [Validation(Required=false)]
            public long? ColorSchemeId { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("CurrentSignInAt")]
            [Validation(Required=false)]
            public string CurrentSignInAt { get; set; }

            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            [NameInMap("ExternUid")]
            [Validation(Required=false)]
            public string ExternUid { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsAdmin")]
            [Validation(Required=false)]
            public bool? IsAdmin { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PrivateToken")]
            [Validation(Required=false)]
            public string PrivateToken { get; set; }

            [NameInMap("ProjectsLimit")]
            [Validation(Required=false)]
            public long? ProjectsLimit { get; set; }

            [NameInMap("Registered")]
            [Validation(Required=false)]
            public bool? Registered { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public long? Role { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public long? ThemeId { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            [NameInMap("WebsiteUrl")]
            [Validation(Required=false)]
            public string WebsiteUrl { get; set; }

            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

            [NameInMap("Identities")]
            [Validation(Required=false)]
            public List<string> Identities { get; set; }

        }

        [NameInMap("AllowedPushUsers")]
        [Validation(Required=false)]
        public List<UpdateLinkeantcodeAntcodeUpdateprotectrepositorybranchesResponseBodyAllowedPushUsers> AllowedPushUsers { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprotectrepositorybranchesResponseBodyAllowedPushUsers : TeaModel {
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public long? AccessLevel { get; set; }

            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("Bio")]
            [Validation(Required=false)]
            public string Bio { get; set; }

            [NameInMap("CanCreateGroup")]
            [Validation(Required=false)]
            public bool? CanCreateGroup { get; set; }

            [NameInMap("CanCreateProject")]
            [Validation(Required=false)]
            public bool? CanCreateProject { get; set; }

            [NameInMap("ColorSchemeId")]
            [Validation(Required=false)]
            public long? ColorSchemeId { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("CurrentSignInAt")]
            [Validation(Required=false)]
            public string CurrentSignInAt { get; set; }

            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            [NameInMap("ExternUid")]
            [Validation(Required=false)]
            public string ExternUid { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsAdmin")]
            [Validation(Required=false)]
            public bool? IsAdmin { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PrivateToken")]
            [Validation(Required=false)]
            public string PrivateToken { get; set; }

            [NameInMap("ProjectsLimit")]
            [Validation(Required=false)]
            public long? ProjectsLimit { get; set; }

            [NameInMap("Registered")]
            [Validation(Required=false)]
            public bool? Registered { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public long? Role { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public long? ThemeId { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            [NameInMap("WebsiteUrl")]
            [Validation(Required=false)]
            public string WebsiteUrl { get; set; }

            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

            [NameInMap("Identities")]
            [Validation(Required=false)]
            public List<string> Identities { get; set; }

        }

        [NameInMap("Commit")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdateprotectrepositorybranchesResponseBodyCommit Commit { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprotectrepositorybranchesResponseBodyCommit : TeaModel {
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }
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
            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }
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
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("CheckSuites")]
            [Validation(Required=false)]
            public List<string> CheckSuites { get; set; }
            [NameInMap("ParentIds")]
            [Validation(Required=false)]
            public List<string> ParentIds { get; set; }
        };

    }

}
