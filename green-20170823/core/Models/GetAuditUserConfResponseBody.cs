// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class GetAuditUserConfResponseBody : TeaModel {
        [NameInMap("CustomAudit")]
        [Validation(Required=false)]
        public bool? CustomAudit { get; set; }

        [NameInMap("RcpLabels")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> RcpLabels { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserLabels")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> UserLabels { get; set; }

    }

}
