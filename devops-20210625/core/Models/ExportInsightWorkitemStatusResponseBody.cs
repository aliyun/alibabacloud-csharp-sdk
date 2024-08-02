// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ExportInsightWorkitemStatusResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ExportInsightWorkitemStatusResponseBodyResult> Result { get; set; }
        public class ExportInsightWorkitemStatusResponseBodyResult : TeaModel {
            [NameInMap("assignedToId")]
            [Validation(Required=false)]
            public string AssignedToId { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("expectedWorkTime")]
            [Validation(Required=false)]
            public long? ExpectedWorkTime { get; set; }

            [NameInMap("gmtClosed")]
            [Validation(Required=false)]
            public long? GmtClosed { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtDue")]
            [Validation(Required=false)]
            public long? GmtDue { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public long? GmtStart { get; set; }

            [NameInMap("gmtTodo")]
            [Validation(Required=false)]
            public long? GmtTodo { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public string IsArchived { get; set; }

            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public string IsDeleted { get; set; }

            [NameInMap("isDone")]
            [Validation(Required=false)]
            public string IsDone { get; set; }

            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("participantIds")]
            [Validation(Required=false)]
            public string ParticipantIds { get; set; }

            [NameInMap("phase")]
            [Validation(Required=false)]
            public int? Phase { get; set; }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("productId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public int? SerialNumber { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("sprintId")]
            [Validation(Required=false)]
            public string SprintId { get; set; }

            [NameInMap("stage")]
            [Validation(Required=false)]
            public int? Stage { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("statusId")]
            [Validation(Required=false)]
            public string StatusId { get; set; }

            [NameInMap("storyPoint")]
            [Validation(Required=false)]
            public float? StoryPoint { get; set; }

            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            [NameInMap("versions")]
            [Validation(Required=false)]
            public string Versions { get; set; }

            [NameInMap("workTime")]
            [Validation(Required=false)]
            public long? WorkTime { get; set; }

            [NameInMap("workitemId")]
            [Validation(Required=false)]
            public string WorkitemId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
