// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeLinktWorkitemRequest : TeaModel {
        [NameInMap("AssignedToIds")]
        [Validation(Required=false)]
        public string AssignedToIds { get; set; }

        [NameInMap("AttachmentVOs")]
        [Validation(Required=false)]
        public string AttachmentVOs { get; set; }

        [NameInMap("Ccs")]
        [Validation(Required=false)]
        public string Ccs { get; set; }

        [NameInMap("CustomFieldsRepeatList")]
        [Validation(Required=false)]
        public List<string> CustomFieldsRepeatList { get; set; }

        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExpectedAt")]
        [Validation(Required=false)]
        public string ExpectedAt { get; set; }

        [NameInMap("IterationSign")]
        [Validation(Required=false)]
        public string IterationSign { get; set; }

        [NameInMap("Modules")]
        [Validation(Required=false)]
        public string Modules { get; set; }

        [NameInMap("ParentSign")]
        [Validation(Required=false)]
        public string ParentSign { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("ProjectSign")]
        [Validation(Required=false)]
        public string ProjectSign { get; set; }

        [NameInMap("RelatedProjects")]
        [Validation(Required=false)]
        public string RelatedProjects { get; set; }

        [NameInMap("SignListRepeatList")]
        [Validation(Required=false)]
        public List<string> SignListRepeatList { get; set; }

        [NameInMap("StatusId")]
        [Validation(Required=false)]
        public string StatusId { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateLabel")]
        [Validation(Required=false)]
        public string TemplateLabel { get; set; }

        [NameInMap("WorkitemSign")]
        [Validation(Required=false)]
        public string WorkitemSign { get; set; }

    }

}
