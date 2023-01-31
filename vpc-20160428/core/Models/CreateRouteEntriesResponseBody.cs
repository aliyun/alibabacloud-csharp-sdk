// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteEntriesResponseBody : TeaModel {
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        [NameInMap("FailedRouteEntries")]
        [Validation(Required=false)]
        public List<CreateRouteEntriesResponseBodyFailedRouteEntries> FailedRouteEntries { get; set; }
        public class CreateRouteEntriesResponseBodyFailedRouteEntries : TeaModel {
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            [NameInMap("FailedCode")]
            [Validation(Required=false)]
            public string FailedCode { get; set; }

            [NameInMap("FailedMessage")]
            [Validation(Required=false)]
            public string FailedMessage { get; set; }

            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteEntryIds")]
        [Validation(Required=false)]
        public List<string> RouteEntryIds { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
