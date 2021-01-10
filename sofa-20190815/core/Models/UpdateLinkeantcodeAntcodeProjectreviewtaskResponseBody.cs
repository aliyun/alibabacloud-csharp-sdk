// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeProjectreviewtaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("GlobPattern")]
        [Validation(Required=false)]
        public string GlobPattern { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("IsOwner")]
        [Validation(Required=false)]
        public bool? IsOwner { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ReviewId")]
        [Validation(Required=false)]
        public long? ReviewId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("Score")]
        [Validation(Required=false)]
        public long? Score { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=false)]
        public long? Weight { get; set; }

        [NameInMap("Reviewer")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeProjectreviewtaskResponseBodyReviewer Reviewer { get; set; }
        public class UpdateLinkeantcodeAntcodeProjectreviewtaskResponseBodyReviewer : TeaModel {
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
        };

    }

}
