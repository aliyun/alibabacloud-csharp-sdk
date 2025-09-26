// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class DeleteCodeInterpreterOut : TeaModel {
        [NameInMap("codeInterpreterId")]
        [Validation(Required=false)]
        public string CodeInterpreterId { get; set; }

        [NameInMap("codeInterpreterName")]
        [Validation(Required=false)]
        public string CodeInterpreterName { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
