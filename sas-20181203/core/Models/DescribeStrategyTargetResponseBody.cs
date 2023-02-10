// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyTargetResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StrategyTargets")]
        [Validation(Required=false)]
        public List<DescribeStrategyTargetResponseBodyStrategyTargets> StrategyTargets { get; set; }
        public class DescribeStrategyTargetResponseBodyStrategyTargets : TeaModel {
            [NameInMap("BindUuidCount")]
            [Validation(Required=false)]
            public int? BindUuidCount { get; set; }

            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
