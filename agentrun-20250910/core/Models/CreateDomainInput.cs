// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateDomainInput : TeaModel {
        [NameInMap("certIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
