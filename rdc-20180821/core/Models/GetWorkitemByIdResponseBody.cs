// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class GetWorkitemByIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkitemByIdResponseBodyData Data { get; set; }
        public class GetWorkitemByIdResponseBodyData : TeaModel {
            [NameInMap("SkipCollab")]
            [Validation(Required=false)]
            public bool? SkipCollab { get; set; }
            [NameInMap("SendWangwang")]
            [Validation(Required=false)]
            public bool? SendWangwang { get; set; }
            [NameInMap("VersionList")]
            [Validation(Required=false)]
            public string VersionList { get; set; }
            [NameInMap("AkProjectId")]
            [Validation(Required=false)]
            public int? AkProjectId { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public int? UserId { get; set; }
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
            [NameInMap("UpdateStatusAt")]
            [Validation(Required=false)]
            public long? UpdateStatusAt { get; set; }
            [NameInMap("Trackers")]
            [Validation(Required=false)]
            public string Trackers { get; set; }
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }
            [NameInMap("UserStaffId")]
            [Validation(Required=false)]
            public string UserStaffId { get; set; }
            [NameInMap("AttachmentList")]
            [Validation(Required=false)]
            public string AttachmentList { get; set; }
            [NameInMap("VerifierId")]
            [Validation(Required=false)]
            public int? VerifierId { get; set; }
            [NameInMap("IgnoreCheck")]
            [Validation(Required=false)]
            public bool? IgnoreCheck { get; set; }
            [NameInMap("ModuleList")]
            [Validation(Required=false)]
            public string ModuleList { get; set; }
            [NameInMap("Attachmented")]
            [Validation(Required=false)]
            public bool? Attachmented { get; set; }
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
            [NameInMap("PriorityId")]
            [Validation(Required=false)]
            public int? PriorityId { get; set; }
            [NameInMap("RecordChangeLog")]
            [Validation(Required=false)]
            public bool? RecordChangeLog { get; set; }
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
            [NameInMap("RelatedAKProjectIds")]
            [Validation(Required=false)]
            public string RelatedAKProjectIds { get; set; }
            [NameInMap("RelatedAKProjectGuids")]
            [Validation(Required=false)]
            public string RelatedAKProjectGuids { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }
            [NameInMap("AssignedToIdList")]
            [Validation(Required=false)]
            public string AssignedToIdList { get; set; }
            [NameInMap("CfsList")]
            [Validation(Required=false)]
            public List<GetWorkitemByIdResponseBodyDataCfsList> CfsList { get; set; }
            public class GetWorkitemByIdResponseBodyDataCfsList : TeaModel {
                public string Type { get; set; }
                public string Value { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
            }
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
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("LogicalStatus")]
            [Validation(Required=false)]
            public string LogicalStatus { get; set; }
            [NameInMap("VersionIds")]
            [Validation(Required=false)]
            public string VersionIds { get; set; }
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
            [NameInMap("TrackerIds")]
            [Validation(Required=false)]
            public string TrackerIds { get; set; }
            [NameInMap("AssignedToId")]
            [Validation(Required=false)]
            public int? AssignedToId { get; set; }
            [NameInMap("ChangeLogList")]
            [Validation(Required=false)]
            public string ChangeLogList { get; set; }
            [NameInMap("IssueTypeId")]
            [Validation(Required=false)]
            public int? IssueTypeId { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public int? RegionId { get; set; }
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }
            [NameInMap("AssignedToMaps")]
            [Validation(Required=false)]
            public string AssignedToMaps { get; set; }
            [NameInMap("BlackListNotice")]
            [Validation(Required=false)]
            public string BlackListNotice { get; set; }
            [NameInMap("ModuleUpdated")]
            [Validation(Required=false)]
            public bool? ModuleUpdated { get; set; }
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public string ProjectIds { get; set; }
            [NameInMap("CommentList")]
            [Validation(Required=false)]
            public string CommentList { get; set; }
            [NameInMap("VerifierStaffId")]
            [Validation(Required=false)]
            public string VerifierStaffId { get; set; }
            [NameInMap("ModuleIds")]
            [Validation(Required=false)]
            public string ModuleIds { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
