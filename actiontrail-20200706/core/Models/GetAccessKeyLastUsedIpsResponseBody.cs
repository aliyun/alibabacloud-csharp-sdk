// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetAccessKeyLastUsedIpsResponseBody : TeaModel {
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public List<GetAccessKeyLastUsedIpsResponseBodyIps> Ips { get; set; }
        public class GetAccessKeyLastUsedIpsResponseBodyIps : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("UsedTimestamp")]
            [Validation(Required=false)]
            public long? UsedTimestamp { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
