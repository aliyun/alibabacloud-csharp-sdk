// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class CreateWorkitemRequest : TeaModel {
        [NameInMap("CorpIdentifier")]
        [Validation(Required=false)]
        public string CorpIdentifier { get; set; }

        [NameInMap("Author")]
        [Validation(Required=false)]
        public string Author { get; set; }

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

        [NameInMap("AKProjectId")]
        [Validation(Required=false)]
        public int? AKProjectId { get; set; }

        [NameInMap("CfList")]
        [Validation(Required=false)]
        public string CfList { get; set; }

        [NameInMap("Verifier")]
        [Validation(Required=false)]
        public string Verifier { get; set; }

        [NameInMap("PriorityId")]
        [Validation(Required=false)]
        public int? PriorityId { get; set; }

        [NameInMap("SeriousLevelId")]
        [Validation(Required=false)]
        public int? SeriousLevelId { get; set; }

        [NameInMap("WatcherUsers")]
        [Validation(Required=false)]
        public string WatcherUsers { get; set; }

        [NameInMap("ModuleIds")]
        [Validation(Required=false)]
        public string ModuleIds { get; set; }

    }

}
