// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLdpsNamespacedQuotaResponseBody : TeaModel {
        [NameInMap("NamespacedQuotas")]
        [Validation(Required=false)]
        public List<GetLdpsNamespacedQuotaResponseBodyNamespacedQuotas> NamespacedQuotas { get; set; }
        public class GetLdpsNamespacedQuotaResponseBodyNamespacedQuotas : TeaModel {
            [NameInMap("CpuAmount")]
            [Validation(Required=false)]
            public string CpuAmount { get; set; }

            [NameInMap("MemoryAmount")]
            [Validation(Required=false)]
            public string MemoryAmount { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("UsedCpu")]
            [Validation(Required=false)]
            public string UsedCpu { get; set; }

            [NameInMap("UsedMemory")]
            [Validation(Required=false)]
            public string UsedMemory { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
