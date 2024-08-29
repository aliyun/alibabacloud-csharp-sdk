// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class GetResolveCountSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResolveSummary")]
        [Validation(Required=false)]
        public GetResolveCountSummaryResponseBodyResolveSummary ResolveSummary { get; set; }
        public class GetResolveCountSummaryResponseBodyResolveSummary : TeaModel {
            [NameInMap("Http")]
            [Validation(Required=false)]
            public long? Http { get; set; }

            [NameInMap("Http6")]
            [Validation(Required=false)]
            public long? Http6 { get; set; }

            [NameInMap("Https")]
            [Validation(Required=false)]
            public long? Https { get; set; }

            [NameInMap("Https6")]
            [Validation(Required=false)]
            public long? Https6 { get; set; }

        }

    }

}
