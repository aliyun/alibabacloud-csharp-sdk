// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class UpdateWorkitemShrinkRequest : TeaModel {
        [NameInMap("AKProjectId")]
        [Validation(Required=false)]
        public int? AKProjectId { get; set; }

        [NameInMap("CorpIdentifier")]
        [Validation(Required=false)]
        public string CorpIdentifier { get; set; }

        [NameInMap("Modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        [NameInMap("AssignedTo")]
        [Validation(Required=false)]
        public string AssignedTo { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Stamp")]
        [Validation(Required=false)]
        public string Stamp { get; set; }

        [NameInMap("CfList")]
        [Validation(Required=false)]
        public string CfListShrink { get; set; }

        [NameInMap("IssueId")]
        [Validation(Required=false)]
        public int? IssueId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("SeriousLevel")]
        [Validation(Required=false)]
        public string SeriousLevel { get; set; }

        [NameInMap("Verifier")]
        [Validation(Required=false)]
        public string Verifier { get; set; }

        [NameInMap("SprintId")]
        [Validation(Required=false)]
        public int? SprintId { get; set; }

        [NameInMap("IgnoreCheck")]
        [Validation(Required=false)]
        public bool? IgnoreCheck { get; set; }

        [NameInMap("Cfs")]
        [Validation(Required=false)]
        public string CfsShrink { get; set; }

    }

}
