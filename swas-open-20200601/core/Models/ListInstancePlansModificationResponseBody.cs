// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancePlansModificationResponseBody : TeaModel {
        [NameInMap("Plans")]
        [Validation(Required=false)]
        public List<ListInstancePlansModificationResponseBodyPlans> Plans { get; set; }
        public class ListInstancePlansModificationResponseBodyPlans : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("Flow")]
            [Validation(Required=false)]
            public int? Flow { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            [NameInMap("OriginPrice")]
            [Validation(Required=false)]
            public double? OriginPrice { get; set; }

            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            [NameInMap("SupportPlatform")]
            [Validation(Required=false)]
            public string SupportPlatform { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
