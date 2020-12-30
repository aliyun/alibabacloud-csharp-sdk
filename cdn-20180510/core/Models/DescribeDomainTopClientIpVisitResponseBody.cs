// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainTopClientIpVisitResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClientIpList")]
        [Validation(Required=false)]
        public List<DescribeDomainTopClientIpVisitResponseBodyClientIpList> ClientIpList { get; set; }
        public class DescribeDomainTopClientIpVisitResponseBodyClientIpList : TeaModel {
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public long? Acc { get; set; }

            [NameInMap("Traffic")]
            [Validation(Required=false)]
            public long? Traffic { get; set; }

            [NameInMap("Rank")]
            [Validation(Required=false)]
            public int? Rank { get; set; }

            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

        }

    }

}
