// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class FinishLinkelinkflowLinkflowTaskRequest : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("FormDefinitionId")]
        [Validation(Required=false)]
        public string FormDefinitionId { get; set; }

        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("Outcome")]
        [Validation(Required=false)]
        public string Outcome { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

    }

}
