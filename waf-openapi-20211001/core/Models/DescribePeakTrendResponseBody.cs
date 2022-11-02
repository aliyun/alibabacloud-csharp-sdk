// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePeakTrendResponseBody : TeaModel {
        [NameInMap("FlowChart")]
        [Validation(Required=false)]
        public List<DescribePeakTrendResponseBodyFlowChart> FlowChart { get; set; }
        public class DescribePeakTrendResponseBodyFlowChart : TeaModel {
            [NameInMap("AclSum")]
            [Validation(Required=false)]
            public long? AclSum { get; set; }

            [NameInMap("AntiScanSum")]
            [Validation(Required=false)]
            public long? AntiScanSum { get; set; }

            [NameInMap("CcSum")]
            [Validation(Required=false)]
            public long? CcSum { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("WafSum")]
            [Validation(Required=false)]
            public long? WafSum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
