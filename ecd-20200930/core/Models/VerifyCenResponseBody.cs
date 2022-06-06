// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class VerifyCenResponseBody : TeaModel {
        [NameInMap("CidrBlocks")]
        [Validation(Required=false)]
        public List<string> CidrBlocks { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<VerifyCenResponseBodyRouteEntries> RouteEntries { get; set; }
        public class VerifyCenResponseBodyRouteEntries : TeaModel {
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            [NameInMap("NextHopInstanceId")]
            [Validation(Required=false)]
            public string NextHopInstanceId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
