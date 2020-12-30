// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class SearchWorkitemResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ToPage")]
        [Validation(Required=false)]
        public int? ToPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SearchWorkitemResponseBodyData> Data { get; set; }
        public class SearchWorkitemResponseBodyData : TeaModel {
            [NameInMap("FixedUserId")]
            [Validation(Required=false)]
            public int? FixedUserId { get; set; }

            [NameInMap("SendWangwang")]
            [Validation(Required=false)]
            public bool? SendWangwang { get; set; }

            [NameInMap("SkipCollab")]
            [Validation(Required=false)]
            public bool? SkipCollab { get; set; }

            [NameInMap("VersionList")]
            [Validation(Required=false)]
            public string VersionList { get; set; }

            [NameInMap("AkProjectId")]
            [Validation(Required=false)]
            public int? AkProjectId { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public int? ProjectId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public int? UserId { get; set; }

            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public int? VersionId { get; set; }

            [NameInMap("IdPath")]
            [Validation(Required=false)]
            public string IdPath { get; set; }

            [NameInMap("IgnoreIntegrate")]
            [Validation(Required=false)]
            public bool? IgnoreIntegrate { get; set; }

            [NameInMap("AttachmentIds")]
            [Validation(Required=false)]
            public string AttachmentIds { get; set; }

            [NameInMap("CommitDate")]
            [Validation(Required=false)]
            public long? CommitDate { get; set; }

            [NameInMap("AkVersionIds")]
            [Validation(Required=false)]
            public string AkVersionIds { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Trackers")]
            [Validation(Required=false)]
            public string Trackers { get; set; }

            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("Solution")]
            [Validation(Required=false)]
            public int? Solution { get; set; }

            [NameInMap("AttachmentList")]
            [Validation(Required=false)]
            public string AttachmentList { get; set; }

            [NameInMap("UserStaffId")]
            [Validation(Required=false)]
            public string UserStaffId { get; set; }

            [NameInMap("IgnoreCheck")]
            [Validation(Required=false)]
            public bool? IgnoreCheck { get; set; }

            [NameInMap("AkPaths")]
            [Validation(Required=false)]
            public string AkPaths { get; set; }

            [NameInMap("VerifierId")]
            [Validation(Required=false)]
            public int? VerifierId { get; set; }

            [NameInMap("ModuleList")]
            [Validation(Required=false)]
            public string ModuleList { get; set; }

            [NameInMap("Attachmented")]
            [Validation(Required=false)]
            public bool? Attachmented { get; set; }

            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public int? SourceId { get; set; }

            [NameInMap("SeriousLevelId")]
            [Validation(Required=false)]
            public int? SeriousLevelId { get; set; }

            [NameInMap("TagIdList")]
            [Validation(Required=false)]
            public string TagIdList { get; set; }

            [NameInMap("Watched")]
            [Validation(Required=false)]
            public bool? Watched { get; set; }

            [NameInMap("AssignedTo")]
            [Validation(Required=false)]
            public string AssignedTo { get; set; }

            [NameInMap("AssignedToIds")]
            [Validation(Required=false)]
            public string AssignedToIds { get; set; }

            [NameInMap("ClosedDuration")]
            [Validation(Required=false)]
            public int? ClosedDuration { get; set; }

            [NameInMap("PriorityId")]
            [Validation(Required=false)]
            public int? PriorityId { get; set; }

            [NameInMap("RecordChangeLog")]
            [Validation(Required=false)]
            public bool? RecordChangeLog { get; set; }

            [NameInMap("IssueRelations")]
            [Validation(Required=false)]
            public string IssueRelations { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public int? TemplateId { get; set; }

            [NameInMap("Verifier")]
            [Validation(Required=false)]
            public string Verifier { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("RelatedUserIds")]
            [Validation(Required=false)]
            public string RelatedUserIds { get; set; }

            [NameInMap("RelatedAKProjectGuids")]
            [Validation(Required=false)]
            public string RelatedAKProjectGuids { get; set; }

            [NameInMap("RelatedAKProjectIds")]
            [Validation(Required=false)]
            public string RelatedAKProjectIds { get; set; }

            [NameInMap("WatcherIdList")]
            [Validation(Required=false)]
            public string WatcherIdList { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("AssignedToIdList")]
            [Validation(Required=false)]
            public string AssignedToIdList { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("StatusStage")]
            [Validation(Required=false)]
            public int? StatusStage { get; set; }

            [NameInMap("AssignedToStaffId")]
            [Validation(Required=false)]
            public string AssignedToStaffId { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public int? ParentId { get; set; }

            [NameInMap("LogicalStatus")]
            [Validation(Required=false)]
            public string LogicalStatus { get; set; }

            [NameInMap("VersionIds")]
            [Validation(Required=false)]
            public string VersionIds { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public int? Scope { get; set; }

            [NameInMap("SeriousLevel")]
            [Validation(Required=false)]
            public string SeriousLevel { get; set; }

            [NameInMap("StatusId")]
            [Validation(Required=false)]
            public int? StatusId { get; set; }

            [NameInMap("Stamp")]
            [Validation(Required=false)]
            public string Stamp { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("AssignedToId")]
            [Validation(Required=false)]
            public int? AssignedToId { get; set; }

            [NameInMap("TrackerIds")]
            [Validation(Required=false)]
            public string TrackerIds { get; set; }

            [NameInMap("IssueTypeId")]
            [Validation(Required=false)]
            public int? IssueTypeId { get; set; }

            [NameInMap("ChangeLogList")]
            [Validation(Required=false)]
            public string ChangeLogList { get; set; }

            [NameInMap("FixedDuration")]
            [Validation(Required=false)]
            public int? FixedDuration { get; set; }

            [NameInMap("ScopeUserIds")]
            [Validation(Required=false)]
            public string ScopeUserIds { get; set; }

            [NameInMap("DevDuration")]
            [Validation(Required=false)]
            public int? DevDuration { get; set; }

            [NameInMap("LinePath")]
            [Validation(Required=false)]
            public string LinePath { get; set; }

            [NameInMap("BlackListNotice")]
            [Validation(Required=false)]
            public string BlackListNotice { get; set; }

            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public string ProjectIds { get; set; }

            [NameInMap("TestsuiteId")]
            [Validation(Required=false)]
            public int? TestsuiteId { get; set; }

            [NameInMap("ModuleUpdated")]
            [Validation(Required=false)]
            public bool? ModuleUpdated { get; set; }

            [NameInMap("CommentList")]
            [Validation(Required=false)]
            public string CommentList { get; set; }

            [NameInMap("SprintId")]
            [Validation(Required=false)]
            public int? SprintId { get; set; }

            [NameInMap("RespondDuration")]
            [Validation(Required=false)]
            public int? RespondDuration { get; set; }

            [NameInMap("ModuleIds")]
            [Validation(Required=false)]
            public string ModuleIds { get; set; }

            [NameInMap("VerifierStaffId")]
            [Validation(Required=false)]
            public string VerifierStaffId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
