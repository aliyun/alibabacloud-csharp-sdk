// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListIpSetsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("IpSets")]
        [Validation(Required=false)]
        public List<ListIpSetsResponseBodyIpSets> IpSets { get; set; }
        public class ListIpSetsResponseBodyIpSets : TeaModel {
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

            [NameInMap("IpAddressList")]
            [Validation(Required=false)]
            public List<string> IpAddressList { get; set; }

        }

    }

}
