// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

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

        [NameInMap("Assignee")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodyAssignee Assignee { get; set; }
        public class QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodyAssignee : TeaModel {
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public long? AccessLevel { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
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
        };

        [NameInMap("Author")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodyAuthor Author { get; set; }
        public class QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodyAuthor : TeaModel {
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public long? AccessLevel { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
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
        };

        [NameInMap("Review")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodyReview Review { get; set; }
        public class QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodyReview : TeaModel {
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
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
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("StateDetail")]
            [Validation(Required=false)]
            public string StateDetail { get; set; }
            [NameInMap("ThresholdClear")]
            [Validation(Required=false)]
            public bool? ThresholdClear { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("Reviewers")]
            [Validation(Required=false)]
            public List<string> Reviewers { get; set; }
        };

        [NameInMap("Source")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodySource Source { get; set; }
        public class QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodySource : TeaModel {
            [NameInMap("Archived")]
            [Validation(Required=false)]
            public bool? Archived { get; set; }
            [NameInMap("Artifacts")]
            [Validation(Required=false)]
            public bool? Artifacts { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("CheckEmail")]
            [Validation(Required=false)]
            public bool? CheckEmail { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }
            [NameInMap("DefaultBranch")]
            [Validation(Required=false)]
            public string DefaultBranch { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }
            [NameInMap("ExceptBranch")]
            [Validation(Required=false)]
            public string ExceptBranch { get; set; }
            [NameInMap("Homepage")]
            [Validation(Required=false)]
            public string Homepage { get; set; }
            [NameInMap("HttpUrlToRepo")]
            [Validation(Required=false)]
            public string HttpUrlToRepo { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("ImportStatus")]
            [Validation(Required=false)]
            public string ImportStatus { get; set; }
            [NameInMap("IsGray")]
            [Validation(Required=false)]
            public bool? IsGray { get; set; }
            [NameInMap("IsReview")]
            [Validation(Required=false)]
            public bool? IsReview { get; set; }
            [NameInMap("LastActivityAt")]
            [Validation(Required=false)]
            public string LastActivityAt { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("NameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("PathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }
            [NameInMap("Public")]
            [Validation(Required=false)]
            public bool? Public { get; set; }
            [NameInMap("RepositorySize")]
            [Validation(Required=false)]
            public string RepositorySize { get; set; }
            [NameInMap("RepositorySizeLimit")]
            [Validation(Required=false)]
            public long? RepositorySizeLimit { get; set; }
            [NameInMap("RunnersToken")]
            [Validation(Required=false)]
            public string RunnersToken { get; set; }
            [NameInMap("SshUrlToRepo")]
            [Validation(Required=false)]
            public string SshUrlToRepo { get; set; }
            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }
            [NameInMap("VisibilityLevel")]
            [Validation(Required=false)]
            public long? VisibilityLevel { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }
        };

        [NameInMap("Target")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodyTarget Target { get; set; }
        public class QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodyTarget : TeaModel {
            [NameInMap("Archived")]
            [Validation(Required=false)]
            public bool? Archived { get; set; }
            [NameInMap("Artifacts")]
            [Validation(Required=false)]
            public bool? Artifacts { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("CheckEmail")]
            [Validation(Required=false)]
            public bool? CheckEmail { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }
            [NameInMap("DefaultBranch")]
            [Validation(Required=false)]
            public string DefaultBranch { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }
            [NameInMap("ExceptBranch")]
            [Validation(Required=false)]
            public string ExceptBranch { get; set; }
            [NameInMap("Homepage")]
            [Validation(Required=false)]
            public string Homepage { get; set; }
            [NameInMap("HttpUrlToRepo")]
            [Validation(Required=false)]
            public string HttpUrlToRepo { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("ImportStatus")]
            [Validation(Required=false)]
            public string ImportStatus { get; set; }
            [NameInMap("IsGray")]
            [Validation(Required=false)]
            public bool? IsGray { get; set; }
            [NameInMap("IsReview")]
            [Validation(Required=false)]
            public bool? IsReview { get; set; }
            [NameInMap("LastActivityAt")]
            [Validation(Required=false)]
            public string LastActivityAt { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("NameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("PathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }
            [NameInMap("Public")]
            [Validation(Required=false)]
            public bool? Public { get; set; }
            [NameInMap("RepositorySize")]
            [Validation(Required=false)]
            public string RepositorySize { get; set; }
            [NameInMap("RepositorySizeLimit")]
            [Validation(Required=false)]
            public long? RepositorySizeLimit { get; set; }
            [NameInMap("RunnersToken")]
            [Validation(Required=false)]
            public string RunnersToken { get; set; }
            [NameInMap("SshUrlToRepo")]
            [Validation(Required=false)]
            public string SshUrlToRepo { get; set; }
            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }
            [NameInMap("VisibilityLevel")]
            [Validation(Required=false)]
            public long? VisibilityLevel { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }
        };

        [NameInMap("UpdatedBy")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodyUpdatedBy UpdatedBy { get; set; }
        public class QueryLinkeantcodeAntcodeMergeprojectpullrequestResponseBodyUpdatedBy : TeaModel {
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public long? AccessLevel { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
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
        };

    }

}
