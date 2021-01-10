// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("ActiveTime")]
        [Validation(Required=false)]
        public string ActiveTime { get; set; }

        [NameInMap("AutoMerge")]
        [Validation(Required=false)]
        public bool? AutoMerge { get; set; }

        [NameInMap("CompareId")]
        [Validation(Required=false)]
        public long? CompareId { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FfOnlyEnabled")]
        [Validation(Required=false)]
        public bool? FfOnlyEnabled { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Iid")]
        [Validation(Required=false)]
        public long? Iid { get; set; }

        [NameInMap("Mergeable")]
        [Validation(Required=false)]
        public bool? Mergeable { get; set; }

        [NameInMap("MergedAt")]
        [Validation(Required=false)]
        public string MergedAt { get; set; }

        [NameInMap("MergeCommitMessage")]
        [Validation(Required=false)]
        public string MergeCommitMessage { get; set; }

        [NameInMap("MergeCommitSha")]
        [Validation(Required=false)]
        public string MergeCommitSha { get; set; }

        [NameInMap("MergeError")]
        [Validation(Required=false)]
        public string MergeError { get; set; }

        [NameInMap("MergeStatus")]
        [Validation(Required=false)]
        public string MergeStatus { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Reviewed")]
        [Validation(Required=false)]
        public bool? Reviewed { get; set; }

        [NameInMap("ReviewAction")]
        [Validation(Required=false)]
        public string ReviewAction { get; set; }

        [NameInMap("ShouldBeRebased")]
        [Validation(Required=false)]
        public bool? ShouldBeRebased { get; set; }

        [NameInMap("ShouldRemoveSourceBranch")]
        [Validation(Required=false)]
        public bool? ShouldRemoveSourceBranch { get; set; }

        [NameInMap("SourceBranch")]
        [Validation(Required=false)]
        public string SourceBranch { get; set; }

        [NameInMap("SourceProjectId")]
        [Validation(Required=false)]
        public long? SourceProjectId { get; set; }

        [NameInMap("SquashMerge")]
        [Validation(Required=false)]
        public bool? SquashMerge { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("TargetBranch")]
        [Validation(Required=false)]
        public string TargetBranch { get; set; }

        [NameInMap("TargetProjectId")]
        [Validation(Required=false)]
        public long? TargetProjectId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("WebUrl")]
        [Validation(Required=false)]
        public string WebUrl { get; set; }

        [NameInMap("WorkInProgress")]
        [Validation(Required=false)]
        public bool? WorkInProgress { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        [NameInMap("Issues")]
        [Validation(Required=false)]
        public List<UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyIssues> Issues { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyIssues : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IssueId")]
            [Validation(Required=false)]
            public string IssueId { get; set; }

            [NameInMap("IssueProvider")]
            [Validation(Required=false)]
            public string IssueProvider { get; set; }

            [NameInMap("IssueSite")]
            [Validation(Required=false)]
            public string IssueSite { get; set; }

            [NameInMap("IssueTitle")]
            [Validation(Required=false)]
            public string IssueTitle { get; set; }

            [NameInMap("IssueType")]
            [Validation(Required=false)]
            public string IssueType { get; set; }

            [NameInMap("IssueUrl")]
            [Validation(Required=false)]
            public string IssueUrl { get; set; }

            [NameInMap("PullRequestId")]
            [Validation(Required=false)]
            public long? PullRequestId { get; set; }

        }

        [NameInMap("Assignee")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyAssignee Assignee { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyAssignee : TeaModel {
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

        [NameInMap("Author")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyAuthor Author { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyAuthor : TeaModel {
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

        [NameInMap("LastCommit")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyLastCommit LastCommit { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyLastCommit : TeaModel {
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

        [NameInMap("MergedBy")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyMergedBy MergedBy { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyMergedBy : TeaModel {
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

        [NameInMap("Review")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyReview Review { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyReview : TeaModel {
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Iid")]
            [Validation(Required=false)]
            public long? Iid { get; set; }
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }
            [NameInMap("RulesType")]
            [Validation(Required=false)]
            public string RulesType { get; set; }
            [NameInMap("SourceBranch")]
            [Validation(Required=false)]
            public string SourceBranch { get; set; }
            [NameInMap("SourceProject")]
            [Validation(Required=false)]
            public string SourceProject { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("StateDetail")]
            [Validation(Required=false)]
            public string StateDetail { get; set; }
            [NameInMap("TargetBranch")]
            [Validation(Required=false)]
            public string TargetBranch { get; set; }
            [NameInMap("TargetProject")]
            [Validation(Required=false)]
            public string TargetProject { get; set; }
            [NameInMap("ThresholdClear")]
            [Validation(Required=false)]
            public bool? ThresholdClear { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("Reviewers")]
            [Validation(Required=false)]
            public List<string> Reviewers { get; set; }
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<string> Tasks { get; set; }
        };

        [NameInMap("Source")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodySource Source { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodySource : TeaModel {
            [NameInMap("HttpUrl")]
            [Validation(Required=false)]
            public string HttpUrl { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("NameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("PathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }
            [NameInMap("SshUrl")]
            [Validation(Required=false)]
            public string SshUrl { get; set; }
            [NameInMap("VisibilityLevel")]
            [Validation(Required=false)]
            public long? VisibilityLevel { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
        };

        [NameInMap("Target")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyTarget Target { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyTarget : TeaModel {
            [NameInMap("HttpUrl")]
            [Validation(Required=false)]
            public string HttpUrl { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("NameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("PathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }
            [NameInMap("SshUrl")]
            [Validation(Required=false)]
            public string SshUrl { get; set; }
            [NameInMap("VisibilityLevel")]
            [Validation(Required=false)]
            public long? VisibilityLevel { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
        };

        [NameInMap("UpdatedBy")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyUpdatedBy UpdatedBy { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdateprojectpullrequestResponseBodyUpdatedBy : TeaModel {
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
