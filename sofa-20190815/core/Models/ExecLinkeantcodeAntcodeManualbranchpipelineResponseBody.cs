// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeantcodeAntcodeManualbranchpipelineResponseBody : TeaModel {
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("BeginAt")]
        [Validation(Required=false)]
        public string BeginAt { get; set; }

        [NameInMap("PullRequestId")]
        [Validation(Required=false)]
        public long? PullRequestId { get; set; }

        [NameInMap("UtCoverUrl")]
        [Validation(Required=false)]
        public string UtCoverUrl { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("FinishedAt")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        [NameInMap("CommitShortId")]
        [Validation(Required=false)]
        public string CommitShortId { get; set; }

        [NameInMap("PullRequestIid")]
        [Validation(Required=false)]
        public long? PullRequestIid { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UtPass")]
        [Validation(Required=false)]
        public string UtPass { get; set; }

        [NameInMap("ExecId")]
        [Validation(Required=false)]
        public string ExecId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Builds")]
        [Validation(Required=false)]
        public List<ExecLinkeantcodeAntcodeManualbranchpipelineResponseBodyBuilds> Builds { get; set; }
        public class ExecLinkeantcodeAntcodeManualbranchpipelineResponseBodyBuilds : TeaModel {
            [NameInMap("BuildId")]
            [Validation(Required=false)]
            public string BuildId { get; set; }

            [NameInMap("BuildSystem")]
            [Validation(Required=false)]
            public string BuildSystem { get; set; }

        }

        [NameInMap("CommitId")]
        [Validation(Required=false)]
        public string CommitId { get; set; }

        [NameInMap("EventTriggerType")]
        [Validation(Required=false)]
        public string EventTriggerType { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("UtCover")]
        [Validation(Required=false)]
        public string UtCover { get; set; }

        [NameInMap("Artifacts")]
        [Validation(Required=false)]
        public List<ExecLinkeantcodeAntcodeManualbranchpipelineResponseBodyArtifacts> Artifacts { get; set; }
        public class ExecLinkeantcodeAntcodeManualbranchpipelineResponseBodyArtifacts : TeaModel {
            [NameInMap("FsType")]
            [Validation(Required=false)]
            public string FsType { get; set; }

            [NameInMap("FsPath")]
            [Validation(Required=false)]
            public string FsPath { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("BuildId")]
            [Validation(Required=false)]
            public string BuildId { get; set; }

            [NameInMap("BuildType")]
            [Validation(Required=false)]
            public string BuildType { get; set; }

            [NameInMap("Sha")]
            [Validation(Required=false)]
            public string Sha { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("BuildSystem")]
            [Validation(Required=false)]
            public string BuildSystem { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Ref")]
        [Validation(Required=false)]
        public string Ref { get; set; }

        [NameInMap("Author")]
        [Validation(Required=false)]
        public ExecLinkeantcodeAntcodeManualbranchpipelineResponseBodyAuthor Author { get; set; }
        public class ExecLinkeantcodeAntcodeManualbranchpipelineResponseBodyAuthor : TeaModel {
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("CurrentSignInAt")]
            [Validation(Required=false)]
            public string CurrentSignInAt { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("ExternUid")]
            [Validation(Required=false)]
            public string ExternUid { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public long? ThemeId { get; set; }
            [NameInMap("Bio")]
            [Validation(Required=false)]
            public string Bio { get; set; }
            [NameInMap("CanCreateProject")]
            [Validation(Required=false)]
            public bool? CanCreateProject { get; set; }
            [NameInMap("IsAdmin")]
            [Validation(Required=false)]
            public bool? IsAdmin { get; set; }
            [NameInMap("CanCreateGroup")]
            [Validation(Required=false)]
            public bool? CanCreateGroup { get; set; }
            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }
            [NameInMap("ProjectsLimit")]
            [Validation(Required=false)]
            public long? ProjectsLimit { get; set; }
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("WebsiteUrl")]
            [Validation(Required=false)]
            public string WebsiteUrl { get; set; }
            [NameInMap("Identities")]
            [Validation(Required=false)]
            public List<string> Identities { get; set; }
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public long? AccessLevel { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public long? Role { get; set; }
            [NameInMap("PrivateToken")]
            [Validation(Required=false)]
            public string PrivateToken { get; set; }
            [NameInMap("Registered")]
            [Validation(Required=false)]
            public bool? Registered { get; set; }
            [NameInMap("ColorSchemeId")]
            [Validation(Required=false)]
            public long? ColorSchemeId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }
        };

        [NameInMap("Lastest")]
        [Validation(Required=false)]
        public bool? Lastest { get; set; }

        [NameInMap("CommitMsg")]
        [Validation(Required=false)]
        public string CommitMsg { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
