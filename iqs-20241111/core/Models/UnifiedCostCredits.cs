// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedCostCredits : TeaModel {
        [NameInMap("search")]
        [Validation(Required=false)]
        public SearchCredits Search { get; set; }

        [NameInMap("valueAdded")]
        [Validation(Required=false)]
        public ValueAddedCredits ValueAdded { get; set; }

    }

}
