// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class CostOptimizedConfig : TeaModel {
        [NameInMap("OnDemandBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandBaseCapacity { get; set; }

        [NameInMap("OnDemandPercentageAboveBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandPercentageAboveBaseCapacity { get; set; }

        [NameInMap("SpotInstancePools")]
        [Validation(Required=false)]
        public int? SpotInstancePools { get; set; }

    }

}
