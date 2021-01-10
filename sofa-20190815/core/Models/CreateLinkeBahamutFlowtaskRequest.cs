// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeBahamutFlowtaskRequest : TeaModel {
        [NameInMap("ApprovalContext")]
        [Validation(Required=false)]
        public string ApprovalContext { get; set; }

        [NameInMap("ApprovalTitle")]
        [Validation(Required=false)]
        public string ApprovalTitle { get; set; }

        [NameInMap("Approver")]
        [Validation(Required=false)]
        public string Approver { get; set; }

        [NameInMap("AppList")]
        [Validation(Required=false)]
        public string AppList { get; set; }

        [NameInMap("CtuUrl")]
        [Validation(Required=false)]
        public string CtuUrl { get; set; }

        [NameInMap("IterationId")]
        [Validation(Required=false)]
        public string IterationId { get; set; }

        [NameInMap("IterationUnitId")]
        [Validation(Required=false)]
        public string IterationUnitId { get; set; }

        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        [NameInMap("StcManager")]
        [Validation(Required=false)]
        public string StcManager { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
