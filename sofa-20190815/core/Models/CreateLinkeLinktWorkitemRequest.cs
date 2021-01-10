// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeLinktWorkitemRequest : TeaModel {
        [NameInMap("AssignedToIds")]
        [Validation(Required=false)]
        public string AssignedToIds { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExpectedAt")]
        [Validation(Required=false)]
        public long? ExpectedAt { get; set; }

        [NameInMap("IterationSign")]
        [Validation(Required=false)]
        public string IterationSign { get; set; }

        [NameInMap("ParentSign")]
        [Validation(Required=false)]
        public string ParentSign { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("ProjectSign")]
        [Validation(Required=false)]
        public string ProjectSign { get; set; }

        [NameInMap("Stamp")]
        [Validation(Required=false)]
        public string Stamp { get; set; }

        [NameInMap("StatusId")]
        [Validation(Required=false)]
        public long? StatusId { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("AttachmentVOsRepeatList")]
        [Validation(Required=false)]
        public List<string> AttachmentVOsRepeatList { get; set; }

        [NameInMap("CcsRepeatList")]
        [Validation(Required=false)]
        public List<string> CcsRepeatList { get; set; }

        [NameInMap("CreatedDependentWorkItemsRepeatList")]
        [Validation(Required=false)]
        public List<string> CreatedDependentWorkItemsRepeatList { get; set; }

        [NameInMap("CreatedRelevantWorkItemsRepeatList")]
        [Validation(Required=false)]
        public List<string> CreatedRelevantWorkItemsRepeatList { get; set; }

        [NameInMap("CreatedSubWorkItemsRepeatList")]
        [Validation(Required=false)]
        public List<string> CreatedSubWorkItemsRepeatList { get; set; }

        [NameInMap("CustomFieldsValuesRepeatList")]
        [Validation(Required=false)]
        public List<string> CustomFieldsValuesRepeatList { get; set; }

        [NameInMap("ModulesRepeatList")]
        [Validation(Required=false)]
        public List<int?> ModulesRepeatList { get; set; }

        [NameInMap("RelatedDependentWorkItemsRepeatList")]
        [Validation(Required=false)]
        public List<string> RelatedDependentWorkItemsRepeatList { get; set; }

        [NameInMap("RelatedProjectsRepeatList")]
        [Validation(Required=false)]
        public List<string> RelatedProjectsRepeatList { get; set; }

        [NameInMap("RelatedRelevantWorkItemsRepeatList")]
        [Validation(Required=false)]
        public List<string> RelatedRelevantWorkItemsRepeatList { get; set; }

        [NameInMap("RelatedSubWorkItemsRepeatList")]
        [Validation(Required=false)]
        public List<string> RelatedSubWorkItemsRepeatList { get; set; }

        [NameInMap("TagsRepeatList")]
        [Validation(Required=false)]
        public List<int?> TagsRepeatList { get; set; }

    }

}
