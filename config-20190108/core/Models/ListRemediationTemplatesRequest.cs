// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class ListRemediationTemplatesRequest : TeaModel {
        [NameInMap("RemediationType")]
        [Validation(Required=false)]
        public string RemediationType { get; set; }

        [NameInMap("ManagedRuleIdentifier")]
        [Validation(Required=false)]
        public string ManagedRuleIdentifier { get; set; }

    }

}
