// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeDSTTraceResponseBody : TeaModel {
        [NameInMap("Trace")]
        [Validation(Required=false)]
        public DescribeDSTTraceResponseBodyTrace Trace { get; set; }
        public class DescribeDSTTraceResponseBodyTrace : TeaModel {
            [NameInMap("CollectedName")]
            [Validation(Required=false)]
            public string CollectedName { get; set; }
            [NameInMap("CollectedDescription")]
            [Validation(Required=false)]
            public string CollectedDescription { get; set; }
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("Collected")]
            [Validation(Required=false)]
            public bool? Collected { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
