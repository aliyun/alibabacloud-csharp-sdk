// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class Definition : TeaModel {
        [NameInMap("Cedar")]
        [Validation(Required=false)]
        public DefinitionCedar Cedar { get; set; }
        public class DefinitionCedar : TeaModel {
            [NameInMap("Statement")]
            [Validation(Required=false)]
            public string Statement { get; set; }

        }

    }

}
