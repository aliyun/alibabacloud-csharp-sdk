// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainTopUserAgentResponseBody : TeaModel {
        [NameInMap("DomainTopUa")]
        [Validation(Required=false)]
        public List<DescribeDomainTopUserAgentResponseBodyDomainTopUa> DomainTopUa { get; set; }
        public class DescribeDomainTopUserAgentResponseBodyDomainTopUa : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

            [NameInMap("UserAgent")]
            [Validation(Required=false)]
            public string UserAgent { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
