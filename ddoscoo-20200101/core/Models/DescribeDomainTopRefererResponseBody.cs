// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainTopRefererResponseBody : TeaModel {
        [NameInMap("DomainTopReferer")]
        [Validation(Required=false)]
        public List<DescribeDomainTopRefererResponseBodyDomainTopReferer> DomainTopReferer { get; set; }
        public class DescribeDomainTopRefererResponseBodyDomainTopReferer : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

            [NameInMap("Referer")]
            [Validation(Required=false)]
            public string Referer { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
