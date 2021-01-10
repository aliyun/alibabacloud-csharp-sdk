// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeSnippetsidResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("VisibilityLevel")]
        [Validation(Required=false)]
        public long? VisibilityLevel { get; set; }

        [NameInMap("Author")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeSnippetsidResponseBodyAuthor Author { get; set; }
        public class UpdateLinkeantcodeAntcodeSnippetsidResponseBodyAuthor : TeaModel {
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
