// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SelfQuotaPreemptionConfig : TeaModel {
        [NameInMap("PreemptedPriorities")]
        [Validation(Required=false)]
        public List<int?> PreemptedPriorities { get; set; }

        [NameInMap("PreemptedProducts")]
        [Validation(Required=false)]
        public List<string> PreemptedProducts { get; set; }

        [NameInMap("PreemptorPriorities")]
        [Validation(Required=false)]
        public List<int?> PreemptorPriorities { get; set; }

    }

}
