// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListDomainsByLogConfigIdResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public ListDomainsByLogConfigIdResponseBodyDomains Domains { get; set; }
        public class ListDomainsByLogConfigIdResponseBodyDomains : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<string> Domain { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
