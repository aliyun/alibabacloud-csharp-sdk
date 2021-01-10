// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeLinktWorkitemrelationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AddLinkeLinktWorkitemrelationsResponseBodyData> Data { get; set; }
        public class AddLinkeLinktWorkitemrelationsResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("RelatedProjects")]
            [Validation(Required=false)]
            public List<string> RelatedProjects { get; set; }

            [NameInMap("StatusStage")]
            [Validation(Required=false)]
            public long? StatusStage { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("ParentWorkItem")]
            [Validation(Required=false)]
            public string ParentWorkItem { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("TemplateList")]
            [Validation(Required=false)]
            public List<string> TemplateList { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("FinishedChildrenCount")]
            [Validation(Required=false)]
            public long? FinishedChildrenCount { get; set; }

            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            [NameInMap("Modules")]
            [Validation(Required=false)]
            public List<string> Modules { get; set; }

            [NameInMap("StatusId")]
            [Validation(Required=false)]
            public long? StatusId { get; set; }

            [NameInMap("Stamp")]
            [Validation(Required=false)]
            public string Stamp { get; set; }

            [NameInMap("CustomFieldsValues")]
            [Validation(Required=false)]
            public List<string> CustomFieldsValues { get; set; }

            [NameInMap("PriorityEntity")]
            [Validation(Required=false)]
            public string PriorityEntity { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("Ccs")]
            [Validation(Required=false)]
            public List<string> Ccs { get; set; }

            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("Iteration")]
            [Validation(Required=false)]
            public string Iteration { get; set; }

            [NameInMap("ParentSign")]
            [Validation(Required=false)]
            public string ParentSign { get; set; }

            [NameInMap("SignPath")]
            [Validation(Required=false)]
            public string SignPath { get; set; }

            [NameInMap("ChildrenCount")]
            [Validation(Required=false)]
            public long? ChildrenCount { get; set; }

            [NameInMap("IterationSign")]
            [Validation(Required=false)]
            public string IterationSign { get; set; }

            [NameInMap("AssignedToIds")]
            [Validation(Required=false)]
            public string AssignedToIds { get; set; }

            [NameInMap("AttachmentVOs")]
            [Validation(Required=false)]
            public List<string> AttachmentVOs { get; set; }

            [NameInMap("ExpectedAt")]
            [Validation(Required=false)]
            public long? ExpectedAt { get; set; }

            [NameInMap("ProjectSign")]
            [Validation(Required=false)]
            public string ProjectSign { get; set; }

            [NameInMap("CustomFields")]
            [Validation(Required=false)]
            public List<string> CustomFields { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            [NameInMap("FilteredChildrenCount")]
            [Validation(Required=false)]
            public long? FilteredChildrenCount { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            [NameInMap("AsRootLevel")]
            [Validation(Required=false)]
            public bool? AsRootLevel { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public long? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
